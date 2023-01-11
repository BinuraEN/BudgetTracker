
namespace BudgetTracker
{
    partial class WCMainScreenForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WCMainPanel = new System.Windows.Forms.Panel();
            this.WCNavPanel1 = new System.Windows.Forms.Panel();
            this.WCBtnLogout = new System.Windows.Forms.Button();
            this.WCLogo1 = new System.Windows.Forms.PictureBox();
            this.WCNavUserProfile = new System.Windows.Forms.Button();
            this.WCNavForecast = new System.Windows.Forms.Button();
            this.WCNavStatements = new System.Windows.Forms.Button();
            this.WCNavTransactions = new System.Windows.Forms.Button();
            this.WCNavCategories = new System.Windows.Forms.Button();
            this.WCNavDashboard = new System.Windows.Forms.Button();
            this.WCLogoLbl1 = new System.Windows.Forms.Label();
            this.WCNavPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WCLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // WCMainPanel
            // 
            this.WCMainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WCMainPanel.Location = new System.Drawing.Point(371, -1);
            this.WCMainPanel.Name = "WCMainPanel";
            this.WCMainPanel.Size = new System.Drawing.Size(1106, 844);
            this.WCMainPanel.TabIndex = 1;
            // 
            // WCNavPanel1
            // 
            this.WCNavPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.WCNavPanel1.Controls.Add(this.WCLogoLbl1);
            this.WCNavPanel1.Controls.Add(this.WCBtnLogout);
            this.WCNavPanel1.Controls.Add(this.WCLogo1);
            this.WCNavPanel1.Controls.Add(this.WCNavUserProfile);
            this.WCNavPanel1.Controls.Add(this.WCNavForecast);
            this.WCNavPanel1.Controls.Add(this.WCNavStatements);
            this.WCNavPanel1.Controls.Add(this.WCNavTransactions);
            this.WCNavPanel1.Controls.Add(this.WCNavCategories);
            this.WCNavPanel1.Controls.Add(this.WCNavDashboard);
            this.WCNavPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.WCNavPanel1.Location = new System.Drawing.Point(0, 0);
            this.WCNavPanel1.Name = "WCNavPanel1";
            this.WCNavPanel1.Size = new System.Drawing.Size(371, 844);
            this.WCNavPanel1.TabIndex = 0;
            // 
            // WCBtnLogout
            // 
            this.WCBtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WCBtnLogout.FlatAppearance.BorderSize = 0;
            this.WCBtnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.WCBtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.WCBtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCBtnLogout.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCBtnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(119)))), ((int)(((byte)(2)))));
            this.WCBtnLogout.Image = global::BudgetTracker.Properties.Resources.BudgetTracker_Logout_Btn1;
            this.WCBtnLogout.Location = new System.Drawing.Point(78, 759);
            this.WCBtnLogout.Margin = new System.Windows.Forms.Padding(30);
            this.WCBtnLogout.Name = "WCBtnLogout";
            this.WCBtnLogout.Padding = new System.Windows.Forms.Padding(30, 10, 20, 0);
            this.WCBtnLogout.Size = new System.Drawing.Size(218, 77);
            this.WCBtnLogout.TabIndex = 1;
            this.WCBtnLogout.Text = "EXIT";
            this.WCBtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WCBtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WCBtnLogout.UseVisualStyleBackColor = true;
            this.WCBtnLogout.Click += new System.EventHandler(this.WCBtnEXitClick);
            // 
            // WCLogo1
            // 
            this.WCLogo1.ErrorImage = null;
            this.WCLogo1.Image = global::BudgetTracker.Properties.Resources.BudgetTracker1;
            this.WCLogo1.InitialImage = null;
            this.WCLogo1.Location = new System.Drawing.Point(21, 35);
            this.WCLogo1.Name = "WCLogo1";
            this.WCLogo1.Size = new System.Drawing.Size(99, 88);
            this.WCLogo1.TabIndex = 0;
            this.WCLogo1.TabStop = false;
            this.WCLogo1.Click += new System.EventHandler(this.WCLogo1Click);
            // 
            // WCNavUserProfile
            // 
            this.WCNavUserProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WCNavUserProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.WCNavUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WCNavUserProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WCNavUserProfile.FlatAppearance.BorderSize = 0;
            this.WCNavUserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCNavUserProfile.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCNavUserProfile.ForeColor = System.Drawing.Color.White;
            this.WCNavUserProfile.Image = global::BudgetTracker.Properties.Resources.BudgetTracker_Nav_Personal_Profile1;
            this.WCNavUserProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WCNavUserProfile.Location = new System.Drawing.Point(0, 645);
            this.WCNavUserProfile.Margin = new System.Windows.Forms.Padding(20);
            this.WCNavUserProfile.Name = "WCNavUserProfile";
            this.WCNavUserProfile.Padding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.WCNavUserProfile.Size = new System.Drawing.Size(366, 63);
            this.WCNavUserProfile.TabIndex = 0;
            this.WCNavUserProfile.Text = "USER PROFILE";
            this.WCNavUserProfile.UseVisualStyleBackColor = false;
            this.WCNavUserProfile.Click += new System.EventHandler(this.WCNavUserProfileClick);
            // 
            // WCNavForecast
            // 
            this.WCNavForecast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WCNavForecast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.WCNavForecast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WCNavForecast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WCNavForecast.FlatAppearance.BorderSize = 0;
            this.WCNavForecast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCNavForecast.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCNavForecast.ForeColor = System.Drawing.Color.White;
            this.WCNavForecast.Image = global::BudgetTracker.Properties.Resources.BudgetTracker_Nav_Forecast2;
            this.WCNavForecast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WCNavForecast.Location = new System.Drawing.Point(1, 545);
            this.WCNavForecast.Margin = new System.Windows.Forms.Padding(20);
            this.WCNavForecast.Name = "WCNavForecast";
            this.WCNavForecast.Padding = new System.Windows.Forms.Padding(63, 0, 35, 0);
            this.WCNavForecast.Size = new System.Drawing.Size(370, 62);
            this.WCNavForecast.TabIndex = 0;
            this.WCNavForecast.Text = "FORECAST";
            this.WCNavForecast.UseVisualStyleBackColor = false;
            this.WCNavForecast.Click += new System.EventHandler(this.WCNavForecastClick);
            // 
            // WCNavStatements
            // 
            this.WCNavStatements.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WCNavStatements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.WCNavStatements.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WCNavStatements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WCNavStatements.FlatAppearance.BorderSize = 0;
            this.WCNavStatements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCNavStatements.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCNavStatements.ForeColor = System.Drawing.Color.White;
            this.WCNavStatements.Image = global::BudgetTracker.Properties.Resources.BudgetTracker_Nav_Finance_Statements__2_;
            this.WCNavStatements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WCNavStatements.Location = new System.Drawing.Point(3, 458);
            this.WCNavStatements.Margin = new System.Windows.Forms.Padding(20);
            this.WCNavStatements.Name = "WCNavStatements";
            this.WCNavStatements.Padding = new System.Windows.Forms.Padding(63, 0, 14, 10);
            this.WCNavStatements.Size = new System.Drawing.Size(368, 58);
            this.WCNavStatements.TabIndex = 0;
            this.WCNavStatements.Text = "STATEMENTS";
            this.WCNavStatements.UseVisualStyleBackColor = false;
            this.WCNavStatements.Click += new System.EventHandler(this.WCNavStatementsClick);
            // 
            // WCNavTransactions
            // 
            this.WCNavTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WCNavTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.WCNavTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WCNavTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WCNavTransactions.FlatAppearance.BorderSize = 0;
            this.WCNavTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCNavTransactions.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCNavTransactions.ForeColor = System.Drawing.Color.White;
            this.WCNavTransactions.Image = global::BudgetTracker.Properties.Resources.BudgetTracker_Nav_Transaction_Manager__4_;
            this.WCNavTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WCNavTransactions.Location = new System.Drawing.Point(3, 360);
            this.WCNavTransactions.Margin = new System.Windows.Forms.Padding(20);
            this.WCNavTransactions.Name = "WCNavTransactions";
            this.WCNavTransactions.Padding = new System.Windows.Forms.Padding(63, 0, 0, 0);
            this.WCNavTransactions.Size = new System.Drawing.Size(368, 62);
            this.WCNavTransactions.TabIndex = 0;
            this.WCNavTransactions.Text = "    TRANSACTIONS";
            this.WCNavTransactions.UseVisualStyleBackColor = false;
            this.WCNavTransactions.Click += new System.EventHandler(this.WCNavTransactionsClick);
            // 
            // WCNavCategories
            // 
            this.WCNavCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WCNavCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.WCNavCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WCNavCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WCNavCategories.FlatAppearance.BorderSize = 0;
            this.WCNavCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCNavCategories.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCNavCategories.ForeColor = System.Drawing.Color.White;
            this.WCNavCategories.Image = global::BudgetTracker.Properties.Resources.BudgetTracker_Nav_Category_Manager22;
            this.WCNavCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WCNavCategories.Location = new System.Drawing.Point(3, 272);
            this.WCNavCategories.Margin = new System.Windows.Forms.Padding(20);
            this.WCNavCategories.Name = "WCNavCategories";
            this.WCNavCategories.Padding = new System.Windows.Forms.Padding(63, 11, 11, 11);
            this.WCNavCategories.Size = new System.Drawing.Size(368, 61);
            this.WCNavCategories.TabIndex = 0;
            this.WCNavCategories.Text = "CATEGORIES";
            this.WCNavCategories.UseVisualStyleBackColor = false;
            this.WCNavCategories.Click += new System.EventHandler(this.WCNavCategoriesClick);
            // 
            // WCNavDashboard
            // 
            this.WCNavDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WCNavDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.WCNavDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WCNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WCNavDashboard.FlatAppearance.BorderSize = 0;
            this.WCNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCNavDashboard.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCNavDashboard.ForeColor = System.Drawing.Color.White;
            this.WCNavDashboard.Image = global::BudgetTracker.Properties.Resources.BudgetTracker_Nav_Dashboard1;
            this.WCNavDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WCNavDashboard.Location = new System.Drawing.Point(3, 176);
            this.WCNavDashboard.Margin = new System.Windows.Forms.Padding(20);
            this.WCNavDashboard.Name = "WCNavDashboard";
            this.WCNavDashboard.Padding = new System.Windows.Forms.Padding(63, 11, 11, 11);
            this.WCNavDashboard.Size = new System.Drawing.Size(368, 60);
            this.WCNavDashboard.TabIndex = 0;
            this.WCNavDashboard.Text = "DASHBOARD";
            this.WCNavDashboard.UseVisualStyleBackColor = false;
            this.WCNavDashboard.Click += new System.EventHandler(this.WCNavDashboardClick);
            // 
            // WCLogoLbl1
            // 
            this.WCLogoLbl1.AutoSize = true;
            this.WCLogoLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCLogoLbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.WCLogoLbl1.Location = new System.Drawing.Point(114, 56);
            this.WCLogoLbl1.Name = "WCLogoLbl1";
            this.WCLogoLbl1.Size = new System.Drawing.Size(245, 46);
            this.WCLogoLbl1.TabIndex = 2;
            this.WCLogoLbl1.Text = "BudgetTracker";
            // 
            // WCMainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1478, 844);
            this.Controls.Add(this.WCMainPanel);
            this.Controls.Add(this.WCNavPanel1);
            this.Name = "WCMainScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudgetTracker - Dashboard";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.WCMainScreenLoad);
            this.WCNavPanel1.ResumeLayout(false);
            this.WCNavPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WCLogo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel WCMainPanel;
        private System.Windows.Forms.Button WCNavDashboard;
        private System.Windows.Forms.Button WCNavCategories;
        private System.Windows.Forms.Button WCNavTransactions;
        private System.Windows.Forms.Button WCNavStatements;
        private System.Windows.Forms.Button WCNavForecast;
        private System.Windows.Forms.Button WCNavUserProfile;
        private System.Windows.Forms.PictureBox WCLogo1;
        private System.Windows.Forms.Panel WCNavPanel1;
        private System.Windows.Forms.Button WCBtnLogout;
        private System.Windows.Forms.Label WCLogoLbl1;
    }
}

