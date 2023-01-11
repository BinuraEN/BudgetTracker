using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetTracker.Models;
using BudgetTracker.BudgetTracker.DataStore;

namespace BudgetTracker.Views
{
    public partial class TransactionsForm : Form
    {
        static HttpClient httpClient;
        List<Transaction> transactionList;
        List<Category> categoryList;

        int transactionIdx;
        public TransactionsForm(SimpleInjector.Container container)
        {
            InitializeComponent();
            httpClient = container.GetInstance<HttpClient>();
        }

        // Load category data asynchronously via API
        private async Task<List<Category>> WCLoadCategoriesAsync()
        {
            var httpResponse = await httpClient.GetAsync("category-api/api/v1/Category");
            var ctgList = await httpResponse.Content.ReadAsAsync<List<Category>>();

            categoryList = ctgList;
            return categoryList;
        }

        // Load transactions data asynchronously via API
        private async Task<List<Transaction>> WCLoadTransactionsAsync()
        {
            var httpResponse = await httpClient.GetAsync("transaction-api/api/v1/Transaction");
            var trsnList = await httpResponse.Content.ReadAsAsync<List<Transaction>>();

            transactionList = trsnList;
            return transactionList;
        }

        // Load transaction data by ID asynchronously via API
        private async Task<Transaction> WCLoadTransactionAsync(int id)
        {
            var httpResponse = await httpClient.GetAsync("transaction-api/api/v1/Transaction/" + id);
            var trsn = await httpResponse.Content.ReadAsAsync<Transaction>();

            return trsn;
        }

        // Add transaction data asynchronously via API
        private async Task<Transaction> WCAddTransactionAsync(Transaction transaction)
        {
            var httpResponse = await httpClient.PostAsJsonAsync("transaction-api/api/v1/Transaction/", transaction);
            var trsn = await httpResponse.Content.ReadAsAsync<Transaction>();

            return trsn;

        }
        // Update transaction data by ID asynchronously via API
        private async Task<Transaction> WCUpdateTransactionAsync(int id, Transaction transaction)
        {
            var httpResponse = await httpClient.PutAsJsonAsync("transaction-api/api/v1/Transaction/" + id, transaction);
            var trsn = await httpResponse.Content.ReadAsAsync<Transaction>();

            return trsn;
        }

        // Delete transaction data by ID asynchronously via API
        private async Task WCDeleteTransactionAsync(int id)
        {
            var httpResponse = await httpClient.DeleteAsync("transaction-api/api/v1/Transaction/" + id);
        }

        // 1) Loads the transaction data into the grid view on form load
        // 2) clears all input fields and resets to their defaults
        private void WCTransactionsFormLoad(object sender, EventArgs e)
        {
            this.WCTransactionsDataGV.DataSource = transactionList.OrderBy(t => t.Date); //this._wcDataStore.Transaction.ToList()

            WCBtnClearClick(sender, e);            
        }

        // Adds the transaction data into the transaction table
        // If the user checks/ turns on the 'Recurr' option, the user will be provided with a data field to add the recurrence date
        // Once the user clicks on the create button two records will be created in the transactions table, one for the original transaction and the other for the recurring transaction
        // the data grid view will be reload with the new data and all fields will be cleared after the process

        private async void WCBtnSaveDraftClickAsync(object sender, EventArgs e)
        {
            Transaction tsnRow = new Transaction();

            tsnRow.Date = this.WCPickerDate.Value.Date;
            tsnRow.Note = this.WCTxtNote.Text;
            tsnRow.Type = this.WCCbType.Text.ToString();
            //tsnRow.Category = this.WCCbCategory.Text.ToString();
            tsnRow.Amount = Convert.ToDouble(this.WCTxtAmount.Text);
            tsnRow.Recurrence = this.WCChkRecurr.Checked;
            tsnRow.RecurrOn = this.WCRecurrDate.Value.Date;

            using (StreamWriter outputFile = new StreamWriter(Environment.CurrentDirectory + "\\transaction_draft.json"))
            {
                var serializedObject = JsonConvert.SerializeObject(tsnRow, Newtonsoft.Json.Formatting.Indented);
                await outputFile.WriteAsync(serializedObject);
            }
        }

        private void WCBtnLoadDraftClickAsync(object sender, EventArgs e)
        {
            Transaction tsnRow = new Transaction();

            using (var reader = File.OpenText(Environment.CurrentDirectory + "\\transaction_draft.json"))
            {
                var serializedObject = reader.ReadToEndAsync();
                //tsnRow = JsonConvert.DeserializeObject<Transaction>(serializedObject);
            }

            tsnRow.Date = this.WCPickerDate.Value.Date;
            tsnRow.Note = this.WCTxtNote.Text;
            tsnRow.Type = this.WCCbType.Text.ToString();
            //tsnRow.Category = this.WCCbCategory.Text.ToString();
            tsnRow.Amount = Convert.ToDouble(this.WCTxtAmount.Text.Trim());
            tsnRow.Recurrence = this.WCChkRecurr.Checked;
            tsnRow.RecurrOn = this.WCRecurrDate.Value.Date;
        }

        private async void WCBtnCreateClickAsync(object sender, EventArgs e)
        {
            Transaction tsnRow = new Transaction();

            string tsnName = this.WCTxtNote.Text.ToString();

            tsnRow.Date = this.WCPickerDate.Value.Date;   
            tsnRow.Note = this.WCTxtNote.Text;
            tsnRow.Type = this.WCCbType.Text.ToString(); 
            //tsnRow.Category = this.WCCbCategory.Text.ToString();
            tsnRow.Amount = Convert.ToDouble(this.WCTxtAmount.Text);
            tsnRow.Recurrence = this.WCChkRecurr.Checked;  
            tsnRow.RecurrOn = this.WCRecurrDate.Value.Date;

            await Task.Run(() => WCAddTransactionAsync(tsnRow));

            if (this.WCChkRecurr.Checked)
            {
                tsnRow.Date = tsnRow.RecurrOn;
                tsnRow.Recurrence = false;
                tsnRow.RecurrOn = DateTime.Parse("01/01/1753", null);

                await Task.Run(() => WCAddTransactionAsync(tsnRow));
            }

            WCTransactionsFormLoad(sender, e);

            MessageBox.Show("Transaction " + tsnName + " created successfully!");

            WCBtnClearClick(sender, e);
        }

        // Updates an existing transaction. The user will only be able to update the Transaction Date, Transaction Note, Transaction Type, Category and Transaction Amount
        // the recurring options will not be available for updating.
        // If the transaction that the user is updating has a recurring transaction, the data for the 'Recurr' checkbox and the 'RecurrOn' fields will be displayed but disabled for editing
        // User selects a data row from the categories table, it will load the row data into the input fields enabling the user to update the data with new data of their choice
        // Once done the user will click the MODIFY Btn and this will update the existing data with the edited information
        // The data grid will be loaded once again to include the update event and all fields will be reset
        private async void WCBtnUpdateClickAsync(object sender, EventArgs e)
        {
            Transaction tsnRow = new Transaction();

            string tsnName = tsnRow.Note.ToString();

            tsnRow.Date = this.WCPickerDate.Value.Date;
            tsnRow.Note = this.WCTxtNote.Text;
            tsnRow.Type = this.WCCbType.Text.ToString(); 
            //tsnRow.Category = this.WCCbCategory.Text.ToString();
            tsnRow.Amount = Convert.ToDouble(this.WCTxtAmount.Text.Trim());

            await Task.Run(() => WCUpdateTransactionAsync(transactionIdx, tsnRow));

            WCTransactionsFormLoad(sender, e);

            MessageBox.Show("Transaction " + tsnName + " modified successfully!");

            WCBtnClearClick(sender, e);
        }

        // Deletes an existing transaction entry from the data store.
        // USer selects a data row on the transactions data grid view and clicks on the REMOVE Btn
        // This action will delete this data from the user's memory and will reload the data grid view which now doesn't show the removed transaction
        // And the fields will be cleared right after
        private async void WCBtnDeleteClickAsync(object sender, EventArgs e)
        {
            Transaction tsnRow = new Transaction();

            string tsnName = tsnRow.Note.ToString();

            await Task.Run(() => WCDeleteTransactionAsync(transactionIdx));

            WCTransactionsFormLoad(sender, e);

            MessageBox.Show("Transaction " + tsnName + " modified successfully!");

            WCBtnClearClick(sender, e);
        }

        // Filters the transactions data by transaction type or by category
        // once a choice of filteration is selected from the first dropdown , this list of options for the chose category will be populated in the second dropdown
        // once a user selects an option and clicks on filter, the user will be able to view the filtered data on the data grid view.
        private void WCBtnFilterClick(object sender, EventArgs e)
        {
            string tsnColFilter = WCFilterByColCombo.Text.ToString();
            string tsnColValFilter = WCFilterByColValCombo.Text.ToString();

            //Monthly transaction filter

            //Transaction Type
            if (WCFilterByColCombo.SelectedIndex == 1)
            {
                if (WCFilterByColValCombo.SelectedIndex != 0)
                {
                    //this.WCTransactionsDataGV.DataSource = transactionList.Where(f => f.Type == tsnColValFilter).OrderBy(t => t.Date).CopyToDataTable();
                }
            }
            //Categories
            else if (WCFilterByColCombo.SelectedIndex == 2)
            {
                if (WCFilterByColValCombo.SelectedIndex != 0)
                {
                    //this.WCTransactionsDataGV.DataSource = transactionList.Where(f => f.Category == tsnColValFilter).OrderBy(t => t.Date).CopyToDataTable();
                }
            }
            //run all transactions query
            else
            {
                //this.WCTransactionsDataGV.DataSource = transactionList.OrderBy(t => t.Date).CopyToDataTable();
            }

            WCFilterByColCombo.SelectedIndex = 0;
            WCFilterByColValCombo.Items.Clear();
            WCFilterByColValCombo.Items.Add("--Select Value--");
            WCFilterByColValCombo.SelectedIndex = 0;
        }

        // This will allow the data to be pulled into input fields once the user clicks on a data row on the data grid view
        private async void WCTransactionsDataGVCellClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            transactionIdx = e.RowIndex;
            Transaction tsnRow = await Task.Run(() => WCLoadTransactionAsync(transactionIdx));

            WCPickerDate.Value = DateTime.Parse(tsnRow.Date.ToString());
            WCTxtNote.Text = tsnRow.Note.ToString();
            WCCbType.SelectedIndex = WCCbType.FindStringExact(tsnRow.Type.ToString());
            WCCbCategory.SelectedIndex = WCCbCategory.FindStringExact(tsnRow.Category.ToString());
            WCTxtAmount.Text = tsnRow.Amount.ToString();
            WCChkRecurr.Checked = Convert.ToBoolean(tsnRow.Recurrence);
            WCChkRecurr.AutoCheck = false;
            WCRecurrDate.Value = DateTime.Parse(tsnRow.RecurrOn.ToString() ?? DateTime.Parse("01/01/1753", null).ToString());
            WCRecurrDate.Enabled = false;

            if (WCRecurrDate.Value == DateTime.Parse("01/01/1753", null))
                WCRecurrDate.Visible = false; 
        }

        // Clears all values in the input fields on the transaction form if any of them are fields and resets them.
        private void WCBtnClearClick(object sender, EventArgs e)
        {
            WCTxtNote.Text = String.Empty;
            WCPickerDate.Value = DateTime.Parse(DateTime.Now.ToString());
            WCCbType.SelectedIndex = 0;
            WCCbCategory.SelectedIndex = 0;
            WCTxtAmount.Text = "0.00";
            WCChkRecurr.Checked = false;
            WCChkRecurr.Enabled = true;
            WCChkRecurr.AutoCheck = true;

            WCRecurrDate.Value = DateTime.Parse(DateTime.Now.ToShortDateString(), null);
            
            WCRecurrDate.Visible = false;
            WCLblRecurrOn.Visible = false;

            WCFilterByColCombo.SelectedIndex = 0;
            WCFilterByColValCombo.SelectedIndex = 0;
        }


        // Checks whether the 'Recurr' checkbutton is turned on or not
        // If it is checked, the RecurrDate field will be set to visible
        // Else it will remaain hidden
        private void WCChkRecurrCheckedChanged(object sender, EventArgs e)
        {
            if (WCChkRecurr.Checked == true)
            {
                this.WCLblRecurrOn.Visible = true;
                this.WCRecurrDate.Enabled = true;
                this.WCRecurrDate.Value = DateTime.Now;
                this.WCRecurrDate.Visible = true;
            }
            else
            {
                this.WCLblRecurrOn.Visible = false;
                WCRecurrDate.Value = DateTime.Parse("1/1/1753", null);
                this.WCRecurrDate.Visible = false;
            }
        }

        private void WCFilterByColComboSelectedIndexChanged(object sender, EventArgs e)
        {
            WCFilterByColValCombo.Items.Clear();
            WCFilterByColValCombo.Items.Add("--Select Value--");

            if (WCFilterByColCombo.SelectedIndex == 1)
            {
                // Initialize transaction types array 
                string[] trsnTypes = { "Income", "Expense" };

                foreach (string trsnType in trsnTypes)
                {
                    WCFilterByColValCombo.Items.Add(trsnType);
                }
            }
            //Categories
            else if (WCFilterByColCombo.SelectedIndex == 2)
            {
                //load categories
                string[] transactionCategories = categoryList.Select(r => r.Name).ToArray();

                foreach (string tCategory in transactionCategories)
                {
                    WCFilterByColValCombo.Items.Add(tCategory);
                }
            }
        }

        private void WCCbTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            WCCbCategory.Items.Clear();
            WCCbCategory.Items.Add(" ");
            WCCbCategory.SelectedIndex = 0;

            if (WCCbType.SelectedIndex == 1)
            {
                string[] transactionCategories = categoryList.Where(r => r.Type == "Income").Select(r => r.Name).ToArray();

                foreach (string tCategory in transactionCategories)
                {
                    WCCbCategory.Items.Add(tCategory);
                }
            }
            else if (WCCbType.SelectedIndex == 2)
            {
                string[] transactionCategories = categoryList.Where(r => r.Type == "Expense").Select(r => r.Name).ToArray();

                foreach (string tCategory in transactionCategories)
                {
                    WCCbCategory.Items.Add(tCategory);
                }
            }
        }
    }
}
