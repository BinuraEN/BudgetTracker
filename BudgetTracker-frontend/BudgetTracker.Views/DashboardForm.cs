using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetTracker.BudgetTracker.DataStore;
using FluentDateTime;
using BudgetTracker.Models;
using System.Net.Http;

namespace BudgetTracker.Views
{
    public partial class DashboardForm : Form
    {
        static HttpClient httpClient;
        List<Transaction> transactionList;

        public DashboardForm(SimpleInjector.Container container)
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

        // Loads the monthly transaction summary view and the weekly transaction summary view for the user
        private async void WCDashboardFormLoadAsync(object sender, EventArgs e)
        {
            transactionList = await Task.Run(() => WCLoadTransactionsAsync());

            DateTime today = DateTime.Now.Date;
            WCLoadMonthlySummary(today);
            WCLoadWeeklySummary(today);
        }

        // The monthly transaction summary view will take a summation of all incomes in the month and substract a summation of all the expenses incurred within the month
        // to identify the net income value of the current month as at today.
        public void WCLoadMonthlySummary(DateTime date)
        {
            DateTime fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime toDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, (DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)));

            // Income analysis for the month
            var filteredIncList = from t in transactionList
                                  where t.Date <= toDate && t.Date >= fromDate && t.Type == "Income"
                                  select t;

            double totalIncThisMonth = filteredIncList.Sum(trsn => trsn.Amount);

            // Expense analysis for the month
            var filteredExpList = from t in transactionList
                                  where t.Date <= toDate && t.Date >= fromDate && t.Type == "Expense"
                                  select t;

            double totalExpThisMonth = filteredExpList.Sum(trsn => trsn.Amount);
            
            // Net Income for the month
            double NetIncomeThisMonth = totalIncThisMonth - totalExpThisMonth;

            this.WCLblIncomeAmt.Text = totalIncThisMonth.ToString("0.00");
            this.WCLblExpenseAmt.Text = totalExpThisMonth.ToString("0.00");
            this.WCLblNetIncomeAmt.Text = NetIncomeThisMonth.ToString("0.00");
        }

        // This method will load all the transaction data for the week to the dashboard showing the incomes and expenses incurred for each day starting from the last monday to the following sunday.
        public void WCLoadWeeklySummary(DateTime date)
        {
            var monday = date.Previous(DayOfWeek.Monday);
            var sunday = date.AddDays(7 - (int)date.DayOfWeek); 
            
            
            // retrieve the daily incomes and expenses form the data store
            double[] dailyIncomeList = transactionList.Where(f => f.Date >= monday && f.Date <= sunday && f.Type == "Income")
                                                                 .Select(f => f.Amount).ToArray();

            double[] dailyExpenseList = transactionList.Where(f => f.Date >= monday && f.Date <= sunday && f.Type == "Expense")
                                                                 .Select(f => f.Amount).ToArray();
            
            // Display all the user's incomes for each day on the dashboard
            DateTime dayCounter = monday;
            foreach (double dailyInc in dailyIncomeList)
            {   
                string dayOftheWeek = dayCounter.ToString("ddd");

                switch (dayOftheWeek)
                {
                    case "Mon":
                        WCListMonday.Items.Add("\n");
                        WCListMonday.Items.Add("(+inc): " + dailyInc.ToString("0.00"));
                        break;

                    case "Tue":
                        WCListTuesday.Items.Add("\n");
                        WCListTuesday.Items.Add("(+inc): " + dailyInc.ToString("0.00"));
                        break;

                    case "Wed":
                        WCListWednesday.Items.Add("\n");
                        WCListWednesday.Items.Add("(+inc): " + dailyInc.ToString("0.00"));
                        break;

                    case "Thu":
                        WCListThursday.Items.Add("\n");
                        WCListThursday.Items.Add("(+inc): " + dailyInc.ToString("0.00"));
                        break;

                    case "Fri":
                        WCListFriday.Items.Add("\n");
                        WCListFriday.Items.Add("(+inc): " + dailyInc.ToString("0.00"));
                        break;

                    case "Sat":
                        WCListSaturday.Items.Add("\n");
                        WCListSaturday.Items.Add("(+inc): " + dailyInc.ToString("0.00"));
                        break;

                    case "Sun":
                        WCListSunday.Items.Add("\n");
                        WCListSunday.Items.Add("(+inc): " + dailyInc.ToString("0.00"));
                        break;
                }
                dayCounter = dayCounter.AddDays(1);
            }

            // Display all the user's expenses for each day on the dashboard
            dayCounter = monday;
            foreach (double dailyExp in dailyExpenseList)
            {
                string dayOftheWeek = dayCounter.ToString("ddd");

                switch (dayOftheWeek)
                {
                    case "Mon":
                        WCListMonday.Items.Add("\n");
                        WCListMonday.Items.Add("(-exp): " + dailyExp.ToString("0.00"));
                        break;

                    case "Tue":
                        WCListTuesday.Items.Add("\n");
                        WCListTuesday.Items.Add("(-exp): " + dailyExp.ToString("0.00"));
                        break;

                    case "Wed":
                        WCListWednesday.Items.Add("\n");
                        WCListWednesday.Items.Add("(-exp): " + dailyExp.ToString("0.00"));
                        break;

                    case "Thu":
                        WCListThursday.Items.Add("\n");
                        WCListThursday.Items.Add("(-exp): " + dailyExp.ToString("0.00"));
                        break;

                    case "Fri":
                        WCListFriday.Items.Add("\n");
                        WCListFriday.Items.Add("(-exp): " + dailyExp.ToString("0.00"));
                        break;

                    case "Sat":
                        WCListSaturday.Items.Add("\n");
                        WCListSaturday.Items.Add("(-exp): " + dailyExp.ToString("0.00"));
                        break;
                }
                dayCounter = dayCounter.AddDays(1);
            }
        }    
    }
}
