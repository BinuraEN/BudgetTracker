using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetTracker.Models;
using BudgetTracker.BudgetTracker.DataStore;

namespace BudgetTracker.Views
{
    public partial class StatementsForm : Form
    {
        static HttpClient httpClient;
        List<Transaction> transactionList;

        public StatementsForm(SimpleInjector.Container container)
        {
            InitializeComponent();
            httpClient = container.GetInstance<HttpClient>();
        }

        // Load all transaction data asynchronously via API
        private async Task<List<Transaction>> WCLoadTransactionsAsync()
        {
            var httpResponse = await httpClient.GetAsync("transaction-api/api/v1/Transaction");
            //var trsnList = await httpResponse.Content.ReadAsStringAsync();
            var trsnList = await httpResponse.Content.ReadAsAsync<List<Transaction>>();

            transactionList = trsnList;
            return transactionList;
        }

        // Loads the transaction data for the current month into the grid view on form load
        // Creates a financial statement for the current month
        private async void WCStatementsFormLoadAsync(object sender, EventArgs e)
        {
            transactionList = await Task.Run(() => WCLoadTransactionsAsync());

            DateTime fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime toDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month,(DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)));

            WCFromDate.Value = fromDate;
            WCToDate.Value = toDate;

            //load transactions for this month
            WCGenerateStatement(fromDate, toDate);            
        }

        // Generates the financial statement for user entered date range
        public void WCGenerateStatement(DateTime fromDate, DateTime toDate)
        {
            var filteredTrsnList = from t in transactionList
                                   where t.Date >= fromDate && t.Date <= toDate
                                   select t;

            this.WCTransactionsDataGV.DataSource = filteredTrsnList;
        }

        // Generate Btn Click that calls on the WCGenerateStatement to perform a custom date range generation
        private void WCBtnGenerateClickAsync(object sender, EventArgs e)
        {
            //load transactions for the selection

            WCGenerateStatement(WCFromDate.Value.Date, WCToDate.Value.Date);
        }

        private void WCFromDateValueChanged(object sender, EventArgs e)
        {
            WCToDate.MinDate = WCFromDate.Value;
        }
    }
}
