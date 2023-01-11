using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using BudgetTracker.Models;
using BudgetTracker.BudgetTracker.DataStore;

namespace BudgetTracker.Views
{
    public partial class CategoriesForm : Form
    {
        static HttpClient httpClient;
        int categoryIdx;
        List<Category> categoryList;
        
        public CategoriesForm(SimpleInjector.Container container)
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

        // Load category data by ID asynchronously via API
        private async Task<Category> WCLoadCategoryAsync(int id)
        {
            var httpResponse = await httpClient.GetAsync("category-api/api/v1/Category/"+id);
            var ctg = await httpResponse.Content.ReadAsAsync<Category>();

            return ctg;
        }

        // Add category data asynchronously via API
        private async Task<Category> WCAddCategoryAsync(Category category)
        {
            var httpResponse = await httpClient.PostAsJsonAsync("category-api/api/v1/Category/", category);
            var ctg = await httpResponse.Content.ReadAsAsync<Category>();

            return ctg;

        }
        // Update category data by ID asynchronously via API
        private async Task<Category> WCUpdateCategoryAsync(int id, Category category)
        {
            var httpResponse = await httpClient.PutAsJsonAsync("category-api/api/v1/Category/" + id, category);
            var ctg = await httpResponse.Content.ReadAsAsync<Category>();

            return ctg;
        }

        // Delete category data by ID asynchronously via API
        private async Task WCDeleteCategoryAsync(int id)
        {
            var httpResponse = await httpClient.DeleteAsync("category-api/api/v1/Category/" + id);
        }

        // 1) Loads the Category data into the grid view on form load
        // 2) clears all input fields and resets to their defaults
        private async void WCCategoriesFormLoadAsync(object sender, EventArgs e)
        {
            this.WCCategoriessDataGV.DataSource = await Task.Run (() => WCLoadCategoriesAsync());
            
            WCBtnClearClick(sender, e);
        }

        // Adds a new category for the user. Can be of type income or expense
        // When user clicks on CREATE Btn; 1) a new Category will be added 2) Categories data view will be reloaded 3) All input fields will be cleared & resetted to defaults
        private async void WCBtnAddClickAsync(object sender, EventArgs e)
        {
            Category ctgRow = new Category();

            string categoryName = WCTxtName.Text.ToString();

            ctgRow.Name = WCTxtName.Text;
            ctgRow.Type = WCCbType.Text.ToString();

            await Task.Run(() => WCAddCategoryAsync(ctgRow));

            WCCategoriesFormLoadAsync(sender, e);

            MessageBox.Show("Category " + categoryName + " created successfully!");

            WCBtnClearClick(sender, e);
        }      

        // Update an existing category for the user.
        // User selects a data row from the categories table, it will load the row data into the input fields enabling the user to update the data with new data of their choice
        // Once done the user will click the MODIFY Btn and this will update the existing data with the edited information
        // The data grid will be loaded once again to include the update event and all input fields will be rest
        private async void WCBtnUpdateClickAsync(object sender, EventArgs e)
        {
            Category ctgRow = new Category();

            string categoryName = ctgRow.Name.ToString();

            ctgRow.Name = WCTxtName.Text;
            ctgRow.Type = WCCbType.Text.ToString();

            await Task.Run(() => WCUpdateCategoryAsync(categoryIdx, ctgRow));

            WCCategoriesFormLoadAsync(sender, e);

            MessageBox.Show("Category " + categoryName + " modified successfully!");

            WCBtnClearClick(sender, e);
        }

        // Deletes an existing category for the user.
        // USer selects a data row on the categories table and clicks on the REMOVE Btn
        // This action will delete this data from the user's memory and reload the data grid view which now doesn't show the removed item
        // And the fields will be cleared
        private async void WCBtnDeleteClickAsync(object sender, EventArgs e)
        {
            Category ctgRow = new Category();

            string categoryName = ctgRow.Name.ToString();

            await Task.Run(() => WCDeleteCategoryAsync(categoryIdx));

            WCCategoriesFormLoadAsync(sender, e);

            MessageBox.Show("Category " + categoryName + " removed successfully!");

            WCBtnClearClick(sender, e);
        }

        // Clears all values in the input fields on the category form if any of them are fields and resets them.
        private void WCBtnClearClick(object sender, EventArgs e)
        {
            WCTxtName.Text = String.Empty;
            WCCbType.SelectedIndex = 0;
            WCFilterByType.SelectedIndex = 0;
        }

        // Filters the categories to provide a narrower data list
        // Filtering is done by transaction type
        // once the filteration is done, clear() will be called to reset the filter.
        private void WCBtnFilterClick(object sender, EventArgs e)
        {
            string ctgTypeFilter = WCFilterByType.Text.ToString();

            //List<Category> categories = new List<Category>(categoryList);

            if ((WCFilterByType.SelectedIndex != 0) && 
                (!string.IsNullOrEmpty(WCFilterByType.Text.ToString())))
            {
                var filteredCtgList = from c in categoryList
                                      where c.Type == ctgTypeFilter
                                      select c;

                this.WCCategoriessDataGV.DataSource = filteredCtgList;
            }
            else
            {
                var filteredCtgList2 = from c in categoryList
                                       select c;

                this.WCCategoriessDataGV.DataSource = filteredCtgList2;
            }

            WCBtnClearClick(sender, e);
        }

        // This will allow the data to be pulled into input fields once the user clicks on a data row on the data grid view
        public async void WCCategoriessDataGVCellClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            categoryIdx = e.RowIndex;
            Category ctgRow = await Task.Run(() => WCLoadCategoryAsync(categoryIdx));

            WCTxtName.Text = ctgRow.Name;
            WCCbType.SelectedIndex = WCCbType.FindStringExact(ctgRow.Type.ToString());
        }

        private async void WCBtnSaveDraftClick(object sender, EventArgs e)
        {
            using (XmlWriter WCXml = XmlWriter.Create(Environment.CurrentDirectory + "\\Category.xml", 
                new XmlWriterSettings { Async = true, CloseOutput = true, Indent = true }))
            {
                await WCXml.WriteStartDocumentAsync();
                await WCXml.WriteStartElementAsync("", "Category", "");
                await WCXml.WriteElementStringAsync("", "Name", "", WCTxtName.Text);
                await WCXml.WriteElementStringAsync("", "Type", "", WCCbType.Text.ToString());
                await WCXml.WriteEndElementAsync();
                await WCXml.WriteEndDocumentAsync();
            }
        }

        private async void WCBtnLoadDraftClick(object sender, EventArgs e)
        {
            Category ctg = new Category();
            XmlSerializer WCXsl = new XmlSerializer(typeof(Category));

            using (FileStream WCfs = new FileStream(Environment.CurrentDirectory + "\\Category.xml", FileMode.Open, FileAccess.Read))
            {
                if (WCfs.CanRead == true && WCfs.Length > 0)
                {
                    WCfs.Position = 0;
                    ctg = WCXsl.Deserialize(WCfs) as Category;
                }
            }

            if (ctg != null)
            {
                this.WCTxtName.Text = ctg.Name;
                this.WCCbType.Text = ctg.Type;
            }
        }
    }
}
