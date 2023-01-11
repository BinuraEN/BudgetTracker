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
    public partial class ForecastForm : Form
    {
        static HttpClient httpClient;
        List<Transaction> transactionList;

        public ForecastForm(SimpleInjector.Container container)
        {
            InitializeComponent();
            httpClient = container.GetInstance<HttpClient>();
        }

        // Load transactions data asynchronously via API
        private async Task<List<Transaction>> WCLoadTransactionsAsync()
        {
            var httpResponse = await httpClient.GetAsync("transaction-api/api/v1/Transaction");
            var trsnList = await httpResponse.Content.ReadAsAsync<List<Transaction>>();

            transactionList = trsnList;
            return transactionList;
        }

        // 1) Generates a forecast for the user for the current date, taking into consideration the spending habits of the user
        // 2) Once the forecast is geneartes the results will be loaded as in the following areas respectively; Net Income, Recurring Incomes, Recurring Expenses.
        // 2) clears all input fields and resets to their defaults
        private async void WCForecastFormLoadAsync(object sender, EventArgs e)
        {
            transactionList = await Task.Run(() => WCLoadTransactionsAsync());

            WCCalendar.MinDate = DateTime.Today;
            DateTime todayDateTime = DateTime.Now.Date;
            string todayString = DateTime.Now.Date.ToShortDateString();

            this.WCLblForecastDate.Text = todayString;
            this.WCLblRecurringIncomeDate.Text = todayString;
            this.WCLblRecurringExpenseDate.Text = todayString;

            WCForecastDataLoad(todayDateTime);
        }

        // This will trigger a forecast generation for the user picked date
        private void WCCalendarDateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime calendarSelection = WCCalendar.SelectionRange.Start.Date;

            this.WCLblForecastDate.Text = calendarSelection.ToShortDateString();
            this.WCLblRecurringIncomeDate.Text = calendarSelection.ToShortDateString();
            this.WCLblRecurringExpenseDate.Text = calendarSelection.ToShortDateString();

            WCForecastDataLoad(calendarSelection);
        }

        // This method acts as a pipeline between the Form UI and the backend generation
        // Takes in the date and passes it to the forecast generator and returns the results back to the Forecast Form
        public void WCForecastDataLoad(DateTime date)
        {
            double totalNetIncome = WCNetIncomeCalculator(date);
            double totalRecurringIncome = WCRecurringIncomesCalculator(date);
            double totalRecurringExpenses = WCRecurringExpensesCalculator(date);

            this.WCLblNetIncomeAmt.Text = "Rs. " + totalNetIncome.ToString("0.00");
            this.WCLblRecurringIncomeAmt.Text = "Rs. " + totalRecurringIncome.ToString("0.00");
            this.WCLblRecurringExpenseAmt.Text = "Rs. " + totalRecurringExpenses.ToString("0.00");
        }

        // NetIncome Forecast Calculation based on the past three months
        // requires income and expenditure type transaction data from the transactions table
        public double WCNetIncomeCalculator(DateTime date)
        {
            DateTime threeMonthsAgo = date.AddMonths(-3);

            var filteredIncomeList = from t in transactionList
                                   where t.Date <= date && t.Date >= threeMonthsAgo && t.Type == "Income"
                                   select t;

            var filteredExpenseList = from t in transactionList
                                   where t.Date <= date && t.Date >= threeMonthsAgo && t.Type == "Expense"
                                   select t;

            // calculate total
            double totalInc = filteredIncomeList.Sum(trsn => trsn.Amount);
            double totalExp = filteredExpenseList.Sum(trsn => trsn.Amount);

            // average recurring expenses from the past 3 months
            return (totalInc - totalExp)/3.00;
        }


        // Recurring Incomes Forecast Calculation based on the past three months
        // Requires income type transaction data from the transactions table
        public double WCRecurringIncomesCalculator(DateTime date)
        {
            DateTime threeMonthsAgo = date.AddMonths(-3);

            var filteredRecIncList = from t in transactionList
                                   where t.Date <= date && t.Date >= threeMonthsAgo && t.Recurrence == true && t.Type == "Income"
                                   select t;

            // calculate total
            double total = filteredRecIncList.Sum(trsn => trsn.Amount);

            // average recurring expenses from the past 3 months
            return total /3.00;
        }

        // Recurring Expenses Forecast Calculation based on the past three months
        // Requires expense type transaction data from the transactions table
        public double WCRecurringExpensesCalculator(DateTime date)
        {
            DateTime threeMonthsAgo = date.AddMonths(-3);

            var filteredRecExpList = from t in transactionList
                                   where t.Date <= date && t.Date >= threeMonthsAgo && t.Recurrence == true && t.Type == "Expense"
                                   select t;

            // calculate total
            double total = filteredRecExpList.Sum(trsn => trsn.Amount);           

            // average recurring expenses from the past 3 months
            return total/3.00;
        }
    }
}
