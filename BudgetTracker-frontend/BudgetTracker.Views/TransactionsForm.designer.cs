
using System.Windows.Forms;

namespace BudgetTracker.Views
{
    partial class TransactionsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.WCLblTransactionActions = new System.Windows.Forms.Label();
            this.WCCategoryActions = new System.Windows.Forms.Panel();
            this.WCCategoryActions2 = new System.Windows.Forms.Panel();
            this.WCBtnSaveDraft = new System.Windows.Forms.Button();
            this.WCBtnLoadDraft = new System.Windows.Forms.Button();
            this.WCBtnClear = new System.Windows.Forms.Button();
            this.WCBtnDelete = new System.Windows.Forms.Button();
            this.WCBtnUpdate = new System.Windows.Forms.Button();
            this.WCRecurrDate = new System.Windows.Forms.DateTimePicker();
            this.WCLblRecurrOn = new System.Windows.Forms.Label();
            this.WCChkRecurr = new System.Windows.Forms.CheckBox();
            this.WCTxtAmount = new System.Windows.Forms.TextBox();
            this.WCTxtNote = new System.Windows.Forms.TextBox();
            this.WCLblAmount = new System.Windows.Forms.Label();
            this.WCCbCategory = new System.Windows.Forms.ComboBox();
            this.WCLblCategory = new System.Windows.Forms.Label();
            this.WCCbType = new System.Windows.Forms.ComboBox();
            this.WCLblType = new System.Windows.Forms.Label();
            this.WCPickerDate = new System.Windows.Forms.DateTimePicker();
            this.WCLblDate = new System.Windows.Forms.Label();
            this.WCLblNote = new System.Windows.Forms.Label();
            this.WCBtnFilter = new System.Windows.Forms.Button();
            this.WCFilterByColValCombo = new System.Windows.Forms.ComboBox();
            this.WCFilterByColCombo = new System.Windows.Forms.ComboBox();
            this.WCBtnAdd = new System.Windows.Forms.Button();
            this.WCLblFilterTransactions = new System.Windows.Forms.Label();
            this.WCTransactions = new System.Windows.Forms.Panel();
            this.WCTransactionsDataGV = new System.Windows.Forms.DataGridView();
            this.WCTransactions2 = new System.Windows.Forms.Panel();
            this.WCLblTransactions = new System.Windows.Forms.Label();
            this.WCCategoryActions.SuspendLayout();
            this.WCCategoryActions2.SuspendLayout();
            this.WCTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WCTransactionsDataGV)).BeginInit();
            this.WCTransactions2.SuspendLayout();
            this.SuspendLayout();
            // 
            // WCLblTransactionActions
            // 
            this.WCLblTransactionActions.AutoSize = true;
            this.WCLblTransactionActions.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.WCLblTransactionActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.WCLblTransactionActions.Location = new System.Drawing.Point(49, 12);
            this.WCLblTransactionActions.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.WCLblTransactionActions.Name = "WCLblTransactionActions";
            this.WCLblTransactionActions.Padding = new System.Windows.Forms.Padding(4);
            this.WCLblTransactionActions.Size = new System.Drawing.Size(115, 38);
            this.WCLblTransactionActions.TabIndex = 7;
            this.WCLblTransactionActions.Text = "Actions";
            this.WCLblTransactionActions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WCCategoryActions
            // 
            this.WCCategoryActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(119)))), ((int)(((byte)(2)))));
            this.WCCategoryActions.Controls.Add(this.WCCategoryActions2);
            this.WCCategoryActions.Location = new System.Drawing.Point(17, 39);
            this.WCCategoryActions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCCategoryActions.Name = "WCCategoryActions";
            this.WCCategoryActions.Padding = new System.Windows.Forms.Padding(4);
            this.WCCategoryActions.Size = new System.Drawing.Size(1070, 288);
            this.WCCategoryActions.TabIndex = 8;
            // 
            // WCCategoryActions2
            // 
            this.WCCategoryActions2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.WCCategoryActions2.Controls.Add(this.WCBtnSaveDraft);
            this.WCCategoryActions2.Controls.Add(this.WCBtnLoadDraft);
            this.WCCategoryActions2.Controls.Add(this.WCBtnClear);
            this.WCCategoryActions2.Controls.Add(this.WCBtnDelete);
            this.WCCategoryActions2.Controls.Add(this.WCBtnUpdate);
            this.WCCategoryActions2.Controls.Add(this.WCRecurrDate);
            this.WCCategoryActions2.Controls.Add(this.WCLblRecurrOn);
            this.WCCategoryActions2.Controls.Add(this.WCChkRecurr);
            this.WCCategoryActions2.Controls.Add(this.WCTxtAmount);
            this.WCCategoryActions2.Controls.Add(this.WCTxtNote);
            this.WCCategoryActions2.Controls.Add(this.WCLblAmount);
            this.WCCategoryActions2.Controls.Add(this.WCCbCategory);
            this.WCCategoryActions2.Controls.Add(this.WCLblCategory);
            this.WCCategoryActions2.Controls.Add(this.WCCbType);
            this.WCCategoryActions2.Controls.Add(this.WCLblType);
            this.WCCategoryActions2.Controls.Add(this.WCPickerDate);
            this.WCCategoryActions2.Controls.Add(this.WCLblDate);
            this.WCCategoryActions2.Controls.Add(this.WCLblNote);
            this.WCCategoryActions2.Controls.Add(this.WCBtnFilter);
            this.WCCategoryActions2.Controls.Add(this.WCFilterByColValCombo);
            this.WCCategoryActions2.Controls.Add(this.WCFilterByColCombo);
            this.WCCategoryActions2.Controls.Add(this.WCBtnAdd);
            this.WCCategoryActions2.Controls.Add(this.WCLblFilterTransactions);
            this.WCCategoryActions2.Location = new System.Drawing.Point(3, 2);
            this.WCCategoryActions2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCCategoryActions2.Name = "WCCategoryActions2";
            this.WCCategoryActions2.Size = new System.Drawing.Size(1063, 281);
            this.WCCategoryActions2.TabIndex = 0;
            // 
            // WCBtnSaveDraft
            // 
            this.WCBtnSaveDraft.BackColor = System.Drawing.Color.SkyBlue;
            this.WCBtnSaveDraft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WCBtnSaveDraft.FlatAppearance.BorderSize = 0;
            this.WCBtnSaveDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCBtnSaveDraft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.WCBtnSaveDraft.ForeColor = System.Drawing.Color.Black;
            this.WCBtnSaveDraft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WCBtnSaveDraft.Location = new System.Drawing.Point(134, 130);
            this.WCBtnSaveDraft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCBtnSaveDraft.Name = "WCBtnSaveDraft";
            this.WCBtnSaveDraft.Size = new System.Drawing.Size(139, 48);
            this.WCBtnSaveDraft.TabIndex = 66;
            this.WCBtnSaveDraft.Text = "SAVE DRAFT";
            this.WCBtnSaveDraft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WCBtnSaveDraft.UseVisualStyleBackColor = false;
            this.WCBtnSaveDraft.Click += new System.EventHandler(this.WCBtnSaveDraftClickAsync);
            // 
            // WCBtnLoadDraft
            // 
            this.WCBtnLoadDraft.BackColor = System.Drawing.Color.SkyBlue;
            this.WCBtnLoadDraft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WCBtnLoadDraft.FlatAppearance.BorderSize = 0;
            this.WCBtnLoadDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCBtnLoadDraft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.WCBtnLoadDraft.ForeColor = System.Drawing.Color.Black;
            this.WCBtnLoadDraft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WCBtnLoadDraft.Location = new System.Drawing.Point(294, 130);
            this.WCBtnLoadDraft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCBtnLoadDraft.Name = "WCBtnLoadDraft";
            this.WCBtnLoadDraft.Size = new System.Drawing.Size(141, 48);
            this.WCBtnLoadDraft.TabIndex = 65;
            this.WCBtnLoadDraft.Text = "LOAD DRAFT";
            this.WCBtnLoadDraft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WCBtnLoadDraft.UseVisualStyleBackColor = false;
            this.WCBtnLoadDraft.Click += new System.EventHandler(this.WCBtnLoadDraftClickAsync);
            // 
            // WCBtnClear
            // 
            this.WCBtnClear.BackColor = System.Drawing.Color.SkyBlue;
            this.WCBtnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WCBtnClear.FlatAppearance.BorderSize = 0;
            this.WCBtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCBtnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.WCBtnClear.ForeColor = System.Drawing.Color.Black;
            this.WCBtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WCBtnClear.Location = new System.Drawing.Point(838, 130);
            this.WCBtnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCBtnClear.Name = "WCBtnClear";
            this.WCBtnClear.Size = new System.Drawing.Size(110, 48);
            this.WCBtnClear.TabIndex = 64;
            this.WCBtnClear.Text = "CLEAR";
            this.WCBtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WCBtnClear.UseVisualStyleBackColor = false;
            this.WCBtnClear.Click += new System.EventHandler(this.WCBtnClearClick);
            // 
            // WCBtnDelete
            // 
            this.WCBtnDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.WCBtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WCBtnDelete.FlatAppearance.BorderSize = 0;
            this.WCBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCBtnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.WCBtnDelete.ForeColor = System.Drawing.Color.Black;
            this.WCBtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WCBtnDelete.Location = new System.Drawing.Point(711, 130);
            this.WCBtnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCBtnDelete.Name = "WCBtnDelete";
            this.WCBtnDelete.Size = new System.Drawing.Size(110, 48);
            this.WCBtnDelete.TabIndex = 63;
            this.WCBtnDelete.Text = "REMOVE";
            this.WCBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WCBtnDelete.UseVisualStyleBackColor = false;
            this.WCBtnDelete.Click += new System.EventHandler(this.WCBtnDeleteClickAsync);
            // 
            // WCBtnUpdate
            // 
            this.WCBtnUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.WCBtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WCBtnUpdate.FlatAppearance.BorderSize = 0;
            this.WCBtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCBtnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.WCBtnUpdate.ForeColor = System.Drawing.Color.Black;
            this.WCBtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WCBtnUpdate.Location = new System.Drawing.Point(583, 130);
            this.WCBtnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCBtnUpdate.Name = "WCBtnUpdate";
            this.WCBtnUpdate.Size = new System.Drawing.Size(110, 48);
            this.WCBtnUpdate.TabIndex = 62;
            this.WCBtnUpdate.Text = "MODIFY";
            this.WCBtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WCBtnUpdate.UseVisualStyleBackColor = false;
            this.WCBtnUpdate.Click += new System.EventHandler(this.WCBtnUpdateClickAsync);
            // 
            // WCRecurrDate
            // 
            this.WCRecurrDate.CustomFormat = "MM/dd/yyyy";
            this.WCRecurrDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.WCRecurrDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.WCRecurrDate.Location = new System.Drawing.Point(874, 71);
            this.WCRecurrDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCRecurrDate.Name = "WCRecurrDate";
            this.WCRecurrDate.Size = new System.Drawing.Size(169, 32);
            this.WCRecurrDate.TabIndex = 61;
            this.WCRecurrDate.Value = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            // 
            // WCLblRecurrOn
            // 
            this.WCLblRecurrOn.AutoSize = true;
            this.WCLblRecurrOn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.WCLblRecurrOn.Location = new System.Drawing.Point(824, 71);
            this.WCLblRecurrOn.Name = "WCLblRecurrOn";
            this.WCLblRecurrOn.Size = new System.Drawing.Size(47, 30);
            this.WCLblRecurrOn.TabIndex = 60;
            this.WCLblRecurrOn.Text = "On:";
            // 
            // WCChkRecurr
            // 
            this.WCChkRecurr.AutoSize = true;
            this.WCChkRecurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.WCChkRecurr.ForeColor = System.Drawing.Color.Blue;
            this.WCChkRecurr.Location = new System.Drawing.Point(709, 71);
            this.WCChkRecurr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCChkRecurr.Name = "WCChkRecurr";
            this.WCChkRecurr.Size = new System.Drawing.Size(103, 30);
            this.WCChkRecurr.TabIndex = 59;
            this.WCChkRecurr.Text = "Recurr";
            this.WCChkRecurr.UseVisualStyleBackColor = true;
            this.WCChkRecurr.CheckedChanged += new System.EventHandler(this.WCChkRecurrCheckedChanged);
            // 
            // WCTxtAmount
            // 
            this.WCTxtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.WCTxtAmount.Location = new System.Drawing.Point(454, 72);
            this.WCTxtAmount.Name = "WCTxtAmount";
            this.WCTxtAmount.Size = new System.Drawing.Size(216, 32);
            this.WCTxtAmount.TabIndex = 58;
            // 
            // WCTxtNote
            // 
            this.WCTxtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.WCTxtNote.Location = new System.Drawing.Point(118, 22);
            this.WCTxtNote.Name = "WCTxtNote";
            this.WCTxtNote.Size = new System.Drawing.Size(218, 32);
            this.WCTxtNote.TabIndex = 57;
            // 
            // WCLblAmount
            // 
            this.WCLblAmount.AutoSize = true;
            this.WCLblAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.WCLblAmount.Location = new System.Drawing.Point(356, 71);
            this.WCLblAmount.Name = "WCLblAmount";
            this.WCLblAmount.Size = new System.Drawing.Size(95, 30);
            this.WCLblAmount.TabIndex = 56;
            this.WCLblAmount.Text = "Amount:";
            // 
            // WCCbCategory
            // 
            this.WCCbCategory.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.WCCbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WCCbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.WCCbCategory.FormattingEnabled = true;
            this.WCCbCategory.Location = new System.Drawing.Point(817, 19);
            this.WCCbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCCbCategory.Name = "WCCbCategory";
            this.WCCbCategory.Size = new System.Drawing.Size(226, 34);
            this.WCCbCategory.TabIndex = 54;
            // 
            // WCLblCategory
            // 
            this.WCLblCategory.AutoSize = true;
            this.WCLblCategory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.WCLblCategory.Location = new System.Drawing.Point(704, 19);
            this.WCLblCategory.Name = "WCLblCategory";
            this.WCLblCategory.Size = new System.Drawing.Size(107, 30);
            this.WCLblCategory.TabIndex = 55;
            this.WCLblCategory.Text = "Category:";
            // 
            // WCCbType
            // 
            this.WCCbType.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.WCCbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WCCbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.WCCbType.FormattingEnabled = true;
            this.WCCbType.Items.AddRange(new object[] {
            " ",
            "Income",
            "Expense"});
            this.WCCbType.Location = new System.Drawing.Point(118, 71);
            this.WCCbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCCbType.Name = "WCCbType";
            this.WCCbType.Size = new System.Drawing.Size(218, 34);
            this.WCCbType.TabIndex = 48;
            this.WCCbType.SelectedIndexChanged += new System.EventHandler(this.WCCbTypeSelectedIndexChanged);
            // 
            // WCLblType
            // 
            this.WCLblType.AutoSize = true;
            this.WCLblType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.WCLblType.Location = new System.Drawing.Point(52, 69);
            this.WCLblType.Name = "WCLblType";
            this.WCLblType.Size = new System.Drawing.Size(65, 30);
            this.WCLblType.TabIndex = 53;
            this.WCLblType.Text = "Type:";
            // 
            // WCPickerDate
            // 
            this.WCPickerDate.CustomFormat = "MM/dd/yyyy";
            this.WCPickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.WCPickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.WCPickerDate.Location = new System.Drawing.Point(455, 19);
            this.WCPickerDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCPickerDate.Name = "WCPickerDate";
            this.WCPickerDate.Size = new System.Drawing.Size(213, 32);
            this.WCPickerDate.TabIndex = 32;
            this.WCPickerDate.Value = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            // 
            // WCLblDate
            // 
            this.WCLblDate.AutoSize = true;
            this.WCLblDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.WCLblDate.Location = new System.Drawing.Point(389, 17);
            this.WCLblDate.Name = "WCLblDate";
            this.WCLblDate.Size = new System.Drawing.Size(63, 30);
            this.WCLblDate.TabIndex = 52;
            this.WCLblDate.Text = "Date:";
            // 
            // WCLblNote
            // 
            this.WCLblNote.AutoSize = true;
            this.WCLblNote.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.WCLblNote.Location = new System.Drawing.Point(50, 22);
            this.WCLblNote.Name = "WCLblNote";
            this.WCLblNote.Size = new System.Drawing.Size(66, 30);
            this.WCLblNote.TabIndex = 51;
            this.WCLblNote.Text = "Note:";
            // 
            // WCBtnFilter
            // 
            this.WCBtnFilter.BackColor = System.Drawing.Color.SandyBrown;
            this.WCBtnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WCBtnFilter.FlatAppearance.BorderSize = 0;
            this.WCBtnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCBtnFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.WCBtnFilter.ForeColor = System.Drawing.Color.Black;
            this.WCBtnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WCBtnFilter.Location = new System.Drawing.Point(783, 214);
            this.WCBtnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCBtnFilter.Name = "WCBtnFilter";
            this.WCBtnFilter.Size = new System.Drawing.Size(110, 48);
            this.WCBtnFilter.TabIndex = 15;
            this.WCBtnFilter.Text = "FILTER";
            this.WCBtnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WCBtnFilter.UseVisualStyleBackColor = false;
            this.WCBtnFilter.Click += new System.EventHandler(this.WCBtnFilterClick);
            // 
            // WCFilterByColValCombo
            // 
            this.WCFilterByColValCombo.BackColor = System.Drawing.SystemColors.Window;
            this.WCFilterByColValCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.WCFilterByColValCombo.FormattingEnabled = true;
            this.WCFilterByColValCombo.Items.AddRange(new object[] {
            "--Select Value--"});
            this.WCFilterByColValCombo.Location = new System.Drawing.Point(552, 220);
            this.WCFilterByColValCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCFilterByColValCombo.Name = "WCFilterByColValCombo";
            this.WCFilterByColValCombo.Size = new System.Drawing.Size(207, 36);
            this.WCFilterByColValCombo.TabIndex = 14;
            // 
            // WCFilterByColCombo
            // 
            this.WCFilterByColCombo.BackColor = System.Drawing.SystemColors.Window;
            this.WCFilterByColCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.WCFilterByColCombo.FormattingEnabled = true;
            this.WCFilterByColCombo.Items.AddRange(new object[] {
            "--Column--",
            "Transaction Type",
            "Category"});
            this.WCFilterByColCombo.Location = new System.Drawing.Point(324, 220);
            this.WCFilterByColCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCFilterByColCombo.Name = "WCFilterByColCombo";
            this.WCFilterByColCombo.Size = new System.Drawing.Size(212, 36);
            this.WCFilterByColCombo.TabIndex = 13;
            this.WCFilterByColCombo.SelectedIndexChanged += new System.EventHandler(this.WCFilterByColComboSelectedIndexChanged);
            // 
            // WCBtnAdd
            // 
            this.WCBtnAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.WCBtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WCBtnAdd.FlatAppearance.BorderSize = 0;
            this.WCBtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCBtnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.WCBtnAdd.ForeColor = System.Drawing.Color.Black;
            this.WCBtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WCBtnAdd.Location = new System.Drawing.Point(455, 130);
            this.WCBtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCBtnAdd.Name = "WCBtnAdd";
            this.WCBtnAdd.Size = new System.Drawing.Size(110, 48);
            this.WCBtnAdd.TabIndex = 11;
            this.WCBtnAdd.Text = "CREATE";
            this.WCBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WCBtnAdd.UseVisualStyleBackColor = false;
            this.WCBtnAdd.Click += new System.EventHandler(this.WCBtnCreateClickAsync);
            // 
            // WCLblFilterTransactions
            // 
            this.WCLblFilterTransactions.AutoSize = true;
            this.WCLblFilterTransactions.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.WCLblFilterTransactions.Location = new System.Drawing.Point(213, 222);
            this.WCLblFilterTransactions.Name = "WCLblFilterTransactions";
            this.WCLblFilterTransactions.Size = new System.Drawing.Size(102, 30);
            this.WCLblFilterTransactions.TabIndex = 8;
            this.WCLblFilterTransactions.Text = "Filter By: ";
            // 
            // WCTransactions
            // 
            this.WCTransactions.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.WCTransactions.Controls.Add(this.WCTransactionsDataGV);
            this.WCTransactions.Location = new System.Drawing.Point(3, 3);
            this.WCTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCTransactions.Name = "WCTransactions";
            this.WCTransactions.Size = new System.Drawing.Size(1058, 400);
            this.WCTransactions.TabIndex = 0;
            // 
            // WCTransactionsDataGV
            // 
            this.WCTransactionsDataGV.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.WCTransactionsDataGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WCTransactionsDataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.WCTransactionsDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WCTransactionsDataGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.WCTransactionsDataGV.Location = new System.Drawing.Point(9, 23);
            this.WCTransactionsDataGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCTransactionsDataGV.Name = "WCTransactionsDataGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WCTransactionsDataGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.WCTransactionsDataGV.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.WCTransactionsDataGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.WCTransactionsDataGV.RowTemplate.Height = 60;
            this.WCTransactionsDataGV.Size = new System.Drawing.Size(1045, 368);
            this.WCTransactionsDataGV.TabIndex = 0;
            this.WCTransactionsDataGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WCTransactionsDataGVCellClickAsync);
            // 
            // WCTransactions2
            // 
            this.WCTransactions2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(119)))), ((int)(((byte)(2)))));
            this.WCTransactions2.Controls.Add(this.WCTransactions);
            this.WCTransactions2.Location = new System.Drawing.Point(19, 384);
            this.WCTransactions2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCTransactions2.Name = "WCTransactions2";
            this.WCTransactions2.Padding = new System.Windows.Forms.Padding(4);
            this.WCTransactions2.Size = new System.Drawing.Size(1067, 408);
            this.WCTransactions2.TabIndex = 11;
            // 
            // WCLblTransactions
            // 
            this.WCLblTransactions.AutoSize = true;
            this.WCLblTransactions.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.WCLblTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.WCLblTransactions.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.WCLblTransactions.Location = new System.Drawing.Point(48, 359);
            this.WCLblTransactions.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.WCLblTransactions.Name = "WCLblTransactions";
            this.WCLblTransactions.Padding = new System.Windows.Forms.Padding(4);
            this.WCLblTransactions.Size = new System.Drawing.Size(176, 38);
            this.WCLblTransactions.TabIndex = 10;
            this.WCLblTransactions.Text = "Transactions";
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1110, 852);
            this.Controls.Add(this.WCLblTransactions);
            this.Controls.Add(this.WCTransactions2);
            this.Controls.Add(this.WCLblTransactionActions);
            this.Controls.Add(this.WCCategoryActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionsForm";
            this.Load += new System.EventHandler(this.WCTransactionsFormLoad);
            this.WCCategoryActions.ResumeLayout(false);
            this.WCCategoryActions2.ResumeLayout(false);
            this.WCCategoryActions2.PerformLayout();
            this.WCTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WCTransactionsDataGV)).EndInit();
            this.WCTransactions2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label WCLblTransactionActions;
        private Panel WCCategoryActions;
        private Panel WCCategoryActions2;
        private Button WCBtnAdd;
        private Label WCLblFilterTransactions;
        private ComboBox WCFilterByColValCombo;
        private ComboBox WCFilterByColCombo;
        private Button WCBtnFilter;
        private Label WCLblNote;
        private DateTimePicker WCPickerDate;
        private Label WCLblDate;
        private ComboBox WCCbType;
        private Label WCLblType;
        private ComboBox WCCbCategory;
        private Label WCLblCategory;
        private TextBox WCTxtNote;
        private Label WCLblAmount;
        private TextBox WCTxtAmount;
        private CheckBox WCChkRecurr;
        private DateTimePicker WCRecurrDate;
        private Label WCLblRecurrOn;
        private Button WCBtnDelete;
        private Button WCBtnUpdate;
        private Button WCBtnClear;
        private Panel WCTransactions;
        private DataGridView WCTransactionsDataGV;
        private Panel WCTransactions2;
        private Label WCLblTransactions;
        private Button WCBtnSaveDraft;
        private Button WCBtnLoadDraft;
    }
}