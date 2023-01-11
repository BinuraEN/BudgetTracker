using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetTracker.BudgetTracker.DataStore;
using BudgetTracker.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace BudgetTracker.Views
{
    public partial class UserProfileForm : Form
    {
        static HttpClient httpClient;
        int LoginID;
        WCMainScreenForm msf;

        public UserProfileForm(WCMainScreenForm mainScreenForm, SimpleInjector.Container container)
        {
            InitializeComponent();
            msf = mainScreenForm;
            httpClient = container.GetInstance<HttpClient>();
            //_wcDataStore = wcDataStore;
        }

        // Load user data asynchronously via API
        private async Task<User> WCLoadUserAsync()
        {
            var httpResponse = await httpClient.GetAsync("user-api/api/v1/User/1");
            var user = await httpResponse.Content.ReadAsAsync<User>();
            
            return user;
        }

        // Update User data asynchronously via API
        private async Task<User> WCUpdateUserAsync(User usr)
        {
            var httpResponse = await httpClient.PutAsJsonAsync("user-api/api/v1/User/1", usr);
            var user = await httpResponse.Content.ReadAsAsync<User>();

            return user;
        }

        // Loads user profile data from the data store once the GUI fires up
        private async void WCUserProfileFormLoad(object sender, EventArgs e)
        {
            User usr = new User();
            usr = await Task.Run(() => WCLoadUserAsync());

            WCTxtLoginId.Text = usr.LoginID;
            WCTxtName.Text = usr.Name;  
            WCTxtEmail.Text = usr.EmailAddress; 
            WCTxtContact.Text = usr.ContactNumber;             
        }

        // If the user decided to update his profile by editing 1 or more fields he will be able to
        // Upon Saving any changes made, his/her user profile will be usdated with the latest details and the user will be redirected to the BudgetTracker Dashboard
        private async void WCBtnSaveChangesClickAsync(object sender, EventArgs e)
        {
            //updating user info from before
            User usr = new User();

            usr.LoginID = WCTxtLoginId.Text;
            usr.Name = WCTxtName.Text;
            usr.EmailAddress = WCTxtEmail.Text;
            usr.ContactNumber = WCTxtContact.Text;

            await Task.Run(() => WCUpdateUserAsync(usr));

            this.Close();
            msf.Show();
        }

        // User's view of the user profile will end and will be directed to the BudgetTracker Dashboard
        private void WCBtnCloseClick(object sender, EventArgs e)
        {
            this.Close();
            msf.Show();
        }        
    }
}
