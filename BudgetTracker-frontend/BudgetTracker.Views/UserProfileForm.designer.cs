
namespace BudgetTracker.Views
{
    partial class UserProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WCBtnSave = new System.Windows.Forms.Button();
            this.WCPanel6 = new System.Windows.Forms.Panel();
            this.WCTxtContact = new System.Windows.Forms.TextBox();
            this.WCLblContact = new System.Windows.Forms.Label();
            this.WCTxtEmail = new System.Windows.Forms.TextBox();
            this.WCLblEmail = new System.Windows.Forms.Label();
            this.WCTxtName = new System.Windows.Forms.TextBox();
            this.WCLblName = new System.Windows.Forms.Label();
            this.WCTxtLoginId = new System.Windows.Forms.TextBox();
            this.WCLblLoginId = new System.Windows.Forms.Label();
            this.WCUserImg = new System.Windows.Forms.PictureBox();
            this.WCBtnClose = new System.Windows.Forms.Button();
            this.WCPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WCUserImg)).BeginInit();
            this.SuspendLayout();
            // 
            // WCBtnSave
            // 
            this.WCBtnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.WCBtnSave.FlatAppearance.BorderSize = 0;
            this.WCBtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCBtnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCBtnSave.ForeColor = System.Drawing.Color.Black;
            this.WCBtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WCBtnSave.Location = new System.Drawing.Point(125, 716);
            this.WCBtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCBtnSave.Name = "WCBtnSave";
            this.WCBtnSave.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.WCBtnSave.Size = new System.Drawing.Size(275, 64);
            this.WCBtnSave.TabIndex = 16;
            this.WCBtnSave.Text = "SAVE CHANGES";
            this.WCBtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WCBtnSave.UseVisualStyleBackColor = false;
            this.WCBtnSave.Click += new System.EventHandler(this.WCBtnSaveChangesClickAsync);
            // 
            // WCPanel6
            // 
            this.WCPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WCPanel6.Controls.Add(this.WCTxtContact);
            this.WCPanel6.Controls.Add(this.WCLblContact);
            this.WCPanel6.Controls.Add(this.WCTxtEmail);
            this.WCPanel6.Controls.Add(this.WCLblEmail);
            this.WCPanel6.Controls.Add(this.WCTxtName);
            this.WCPanel6.Controls.Add(this.WCLblName);
            this.WCPanel6.Controls.Add(this.WCTxtLoginId);
            this.WCPanel6.Controls.Add(this.WCLblLoginId);
            this.WCPanel6.Controls.Add(this.WCUserImg);
            this.WCPanel6.Controls.Add(this.WCBtnSave);
            this.WCPanel6.Controls.Add(this.WCBtnClose);
            this.WCPanel6.Location = new System.Drawing.Point(2, -1);
            this.WCPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCPanel6.Name = "WCPanel6";
            this.WCPanel6.Size = new System.Drawing.Size(524, 849);
            this.WCPanel6.TabIndex = 21;
            // 
            // WCTxtContact
            // 
            this.WCTxtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCTxtContact.Location = new System.Drawing.Point(68, 638);
            this.WCTxtContact.Name = "WCTxtContact";
            this.WCTxtContact.Size = new System.Drawing.Size(394, 35);
            this.WCTxtContact.TabIndex = 65;
            // 
            // WCLblContact
            // 
            this.WCLblContact.AutoSize = true;
            this.WCLblContact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCLblContact.ForeColor = System.Drawing.SystemColors.GrayText;
            this.WCLblContact.Location = new System.Drawing.Point(62, 603);
            this.WCLblContact.Name = "WCLblContact";
            this.WCLblContact.Size = new System.Drawing.Size(197, 32);
            this.WCLblContact.TabIndex = 64;
            this.WCLblContact.Text = "Contact Number:";
            // 
            // WCTxtEmail
            // 
            this.WCTxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCTxtEmail.Location = new System.Drawing.Point(67, 539);
            this.WCTxtEmail.Name = "WCTxtEmail";
            this.WCTxtEmail.Size = new System.Drawing.Size(394, 35);
            this.WCTxtEmail.TabIndex = 63;
            // 
            // WCLblEmail
            // 
            this.WCLblEmail.AutoSize = true;
            this.WCLblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCLblEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.WCLblEmail.Location = new System.Drawing.Point(63, 504);
            this.WCLblEmail.Name = "WCLblEmail";
            this.WCLblEmail.Size = new System.Drawing.Size(168, 32);
            this.WCLblEmail.TabIndex = 62;
            this.WCLblEmail.Text = "Email Address:";
            // 
            // WCTxtName
            // 
            this.WCTxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCTxtName.Location = new System.Drawing.Point(67, 442);
            this.WCTxtName.Name = "WCTxtName";
            this.WCTxtName.Size = new System.Drawing.Size(392, 35);
            this.WCTxtName.TabIndex = 61;
            // 
            // WCLblName
            // 
            this.WCLblName.AutoSize = true;
            this.WCLblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCLblName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.WCLblName.Location = new System.Drawing.Point(64, 407);
            this.WCLblName.Name = "WCLblName";
            this.WCLblName.Size = new System.Drawing.Size(84, 32);
            this.WCLblName.TabIndex = 60;
            this.WCLblName.Text = "Name:";
            // 
            // WCTxtLoginId
            // 
            this.WCTxtLoginId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCTxtLoginId.Location = new System.Drawing.Point(67, 341);
            this.WCTxtLoginId.Name = "WCTxtLoginId";
            this.WCTxtLoginId.Size = new System.Drawing.Size(394, 35);
            this.WCTxtLoginId.TabIndex = 59;
            // 
            // WCLblLoginId
            // 
            this.WCLblLoginId.AutoSize = true;
            this.WCLblLoginId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCLblLoginId.ForeColor = System.Drawing.SystemColors.GrayText;
            this.WCLblLoginId.Location = new System.Drawing.Point(66, 308);
            this.WCLblLoginId.Name = "WCLblLoginId";
            this.WCLblLoginId.Size = new System.Drawing.Size(109, 32);
            this.WCLblLoginId.TabIndex = 58;
            this.WCLblLoginId.Text = "Login ID:";
            // 
            // WCUserImg
            // 
            this.WCUserImg.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.WCUserImg.Image = global::BudgetTracker.Properties.Resources.BudgetTracker_User_Profile2;
            this.WCUserImg.Location = new System.Drawing.Point(137, 8);
            this.WCUserImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCUserImg.Name = "WCUserImg";
            this.WCUserImg.Size = new System.Drawing.Size(263, 266);
            this.WCUserImg.TabIndex = 0;
            this.WCUserImg.TabStop = false;
            // 
            // WCBtnClose
            // 
            this.WCBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.WCBtnClose.FlatAppearance.BorderSize = 0;
            this.WCBtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCBtnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.WCBtnClose.ForeColor = System.Drawing.Color.Black;
            this.WCBtnClose.Image = global::BudgetTracker.Properties.Resources.BudgetTracker_CloseBtn1;
            this.WCBtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WCBtnClose.Location = new System.Drawing.Point(455, 6);
            this.WCBtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.WCBtnClose.Name = "WCBtnClose";
            this.WCBtnClose.Size = new System.Drawing.Size(62, 45);
            this.WCBtnClose.TabIndex = 22;
            this.WCBtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WCBtnClose.UseVisualStyleBackColor = false;
            this.WCBtnClose.Click += new System.EventHandler(this.WCBtnCloseClick);
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(524, 849);
            this.Controls.Add(this.WCPanel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudgetTracker - User Profile";
            this.Load += new System.EventHandler(this.WCUserProfileFormLoad);
            this.WCPanel6.ResumeLayout(false);
            this.WCPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WCUserImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox WCUserImg;
        private System.Windows.Forms.Button WCBtnSave;
        private System.Windows.Forms.Panel WCPanel6;
        private System.Windows.Forms.Button WCBtnClose;
        private System.Windows.Forms.TextBox WCTxtLoginId;
        private System.Windows.Forms.Label WCLblLoginId;
        private System.Windows.Forms.TextBox WCTxtName;
        private System.Windows.Forms.Label WCLblName;
        private System.Windows.Forms.TextBox WCTxtEmail;
        private System.Windows.Forms.Label WCLblEmail;
        private System.Windows.Forms.TextBox WCTxtContact;
        private System.Windows.Forms.Label WCLblContact;
    }
}