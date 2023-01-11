using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetTracker.Views;
using BudgetTracker.BudgetTracker.DataStore;

namespace BudgetTracker
{
    public partial class WCMainScreenForm : Form
    {
        SimpleInjector.Container _WCContainer;

        public WCMainScreenForm(SimpleInjector.Container container)
        {
            _WCContainer = container;
            InitializeComponent();
        }

        // Loads the MainForm with the Navigation Panel to all other Application operations and and the Dashboard Form
        private void WCMainScreenLoad(object Form, EventArgs e)
        {
            WCLoadNavForm(new DashboardForm(_WCContainer));
        }

        // Method used to load all the forms from the Navigation Panel without the need for repetitive code.
        public void WCLoadNavForm(object form)
        {
            WCMainPanel.Controls.Clear();
            Form navForm = form as Form;
            navForm.TopLevel = false;
            WCMainPanel.Controls.Add(navForm);
            WCMainPanel.Tag = navForm;
            navForm.Show();
        }

        // Dashboard Navigation and Form title initialization
        private void WCNavDashboardClick(object sender, EventArgs e)
        {
            WCLoadNavForm(new DashboardForm(_WCContainer));
            this.Text = "BudgetTracker - Dashboard";
        }

        // Categories Manager Navigation and Form title initialization
        private void WCNavCategoriesClick(object sender, EventArgs e)
        {
            WCLoadNavForm(new CategoriesForm(_WCContainer));
            this.Text = "BudgetTracker - Category Manager";
        }

        // Transaction Manager Navigation and Form title initialization
        private void WCNavTransactionsClick(object sender, EventArgs e)
        {
            WCLoadNavForm(new TransactionsForm(_WCContainer));
            this.Text = "BudgetTracker - Transaction Manager";
        }

        // Financial Statement Navigation and Form title initialization
        private void WCNavStatementsClick(object sender, EventArgs e)
        {
            WCLoadNavForm(new StatementsForm(_WCContainer));
            this.Text = "BudgetTracker - Financial Statement";
        }

        // Financial Forecast Navigation and Form title initialization
        private void WCNavForecastClick(object sender, EventArgs e)
        {
            WCLoadNavForm(new ForecastForm(_WCContainer));
            this.Text = "BudgetTracker - Financial Forecast";
        }

        // Dashboard Navigation and Form title initialization
        private void WCLogo1Click(object sender, EventArgs e)
        {
            WCLoadNavForm(new DashboardForm(_WCContainer));
            this.Text = "BudgetTracker - Dashboard";
        }

        // User Profile Navigation
        private void WCNavUserProfileClick(object sender, EventArgs e)
        {
            this.Hide();
            UserProfileForm upf = new UserProfileForm(this, _WCContainer);
            upf.Show();
        }

        //  Logout Btn to exit the application 
        private void WCBtnEXitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
