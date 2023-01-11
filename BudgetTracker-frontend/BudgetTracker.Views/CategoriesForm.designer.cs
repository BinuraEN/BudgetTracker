
namespace BudgetTracker.Views
{
    partial class CategoriesForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.WCLblCategories = new System.Windows.Forms.Label();
            this.WCCategories = new System.Windows.Forms.Panel();
            this.WCCategories2 = new System.Windows.Forms.Panel();
            this.WCCategoriessDataGV = new System.Windows.Forms.DataGridView();
            this.WCImageList = new System.Windows.Forms.ImageList(this.components);
            this.WCLblCategoryActions = new System.Windows.Forms.Label();
            this.WCCategoryActions = new System.Windows.Forms.Panel();
            this.WCCategoryActions2 = new System.Windows.Forms.Panel();
            this.WCCbType = new System.Windows.Forms.ComboBox();
            this.WCLblType = new System.Windows.Forms.Label();
            this.WCTxtName = new System.Windows.Forms.TextBox();
            this.WCLblName = new System.Windows.Forms.Label();
            this.WCFilterByType = new System.Windows.Forms.ComboBox();
            this.WCBtnFilter = new System.Windows.Forms.Button();
            this.WCBtnClear = new System.Windows.Forms.Button();
            this.WCBtnDelete = new System.Windows.Forms.Button();
            this.WCBtnAdd = new System.Windows.Forms.Button();
            this.WCBtnUpdate = new System.Windows.Forms.Button();
            this.WCLblFilterCategories = new System.Windows.Forms.Label();
            this.WCBtnSaveDraft = new System.Windows.Forms.Button();
            this.WCBtnLoadDraft = new System.Windows.Forms.Button();
            this.WCCategories.SuspendLayout();
            this.WCCategories2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WCCategoriessDataGV)).BeginInit();
            this.WCCategoryActions.SuspendLayout();
            this.WCCategoryActions2.SuspendLayout();
            this.SuspendLayout();
            // 
            // WCLblCategories
            // 
            this.WCLblCategories.AutoSize = true;
            this.WCLblCategories.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.WCLblCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.WCLblCategories.Location = new System.Drawing.Point(304, 309);
            this.WCLblCategories.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.WCLblCategories.Name = "WCLblCategories";
            this.WCLblCategories.Padding = new System.Windows.Forms.Padding(4);
            this.WCLblCategories.Size = new System.Drawing.Size(159, 38);
            this.WCLblCategories.TabIndex = 3;
            this.WCLblCategories.Text = "Categories";
            this.WCLblCategories.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WCCategories
            // 
            this.WCCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(119)))), ((int)(((byte)(2)))));
            this.WCCategories.Controls.Add(this.WCCategories2);
            this.WCCategories.Location = new System.Drawing.Point(273, 338);
            this.WCCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCCategories.Name = "WCCategories";
            this.WCCategories.Padding = new System.Windows.Forms.Padding(4);
            this.WCCategories.Size = new System.Drawing.Size(558, 463);
            this.WCCategories.TabIndex = 4;
            // 
            // WCCategories2
            // 
            this.WCCategories2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.WCCategories2.Controls.Add(this.WCCategoriessDataGV);
            this.WCCategories2.Location = new System.Drawing.Point(3, 2);
            this.WCCategories2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCCategories2.Name = "WCCategories2";
            this.WCCategories2.Size = new System.Drawing.Size(550, 456);
            this.WCCategories2.TabIndex = 0;
            // 
            // WCCategoriessDataGV
            // 
            this.WCCategoriessDataGV.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.WCCategoriessDataGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WCCategoriessDataGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.WCCategoriessDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WCCategoriessDataGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.WCCategoriessDataGV.Location = new System.Drawing.Point(11, 18);
            this.WCCategoriessDataGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCCategoriessDataGV.Name = "WCCategoriessDataGV";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WCCategoriessDataGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.WCCategoriessDataGV.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.WCCategoriessDataGV.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.WCCategoriessDataGV.RowTemplate.Height = 60;
            this.WCCategoriessDataGV.Size = new System.Drawing.Size(528, 427);
            this.WCCategoriessDataGV.TabIndex = 1;
            this.WCCategoriessDataGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WCCategoriessDataGVCellClickAsync);
            // 
            // WCImageList
            // 
            this.WCImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.WCImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.WCImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // WCLblCategoryActions
            // 
            this.WCLblCategoryActions.AutoSize = true;
            this.WCLblCategoryActions.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.WCLblCategoryActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.WCLblCategoryActions.Location = new System.Drawing.Point(90, 28);
            this.WCLblCategoryActions.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.WCLblCategoryActions.Name = "WCLblCategoryActions";
            this.WCLblCategoryActions.Padding = new System.Windows.Forms.Padding(4);
            this.WCLblCategoryActions.Size = new System.Drawing.Size(115, 38);
            this.WCLblCategoryActions.TabIndex = 5;
            this.WCLblCategoryActions.Text = "Actions";
            this.WCLblCategoryActions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WCCategoryActions
            // 
            this.WCCategoryActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(119)))), ((int)(((byte)(2)))));
            this.WCCategoryActions.Controls.Add(this.WCCategoryActions2);
            this.WCCategoryActions.Location = new System.Drawing.Point(58, 49);
            this.WCCategoryActions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCCategoryActions.Name = "WCCategoryActions";
            this.WCCategoryActions.Padding = new System.Windows.Forms.Padding(4);
            this.WCCategoryActions.Size = new System.Drawing.Size(996, 222);
            this.WCCategoryActions.TabIndex = 6;
            // 
            // WCCategoryActions2
            // 
            this.WCCategoryActions2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.WCCategoryActions2.Controls.Add(this.WCBtnLoadDraft);
            this.WCCategoryActions2.Controls.Add(this.WCBtnSaveDraft);
            this.WCCategoryActions2.Controls.Add(this.WCCbType);
            this.WCCategoryActions2.Controls.Add(this.WCLblType);
            this.WCCategoryActions2.Controls.Add(this.WCTxtName);
            this.WCCategoryActions2.Controls.Add(this.WCLblName);
            this.WCCategoryActions2.Controls.Add(this.WCFilterByType);
            this.WCCategoryActions2.Controls.Add(this.WCBtnFilter);
            this.WCCategoryActions2.Controls.Add(this.WCBtnClear);
            this.WCCategoryActions2.Controls.Add(this.WCBtnDelete);
            this.WCCategoryActions2.Controls.Add(this.WCBtnAdd);
            this.WCCategoryActions2.Controls.Add(this.WCBtnUpdate);
            this.WCCategoryActions2.Controls.Add(this.WCLblFilterCategories);
            this.WCCategoryActions2.Location = new System.Drawing.Point(2, 2);
            this.WCCategoryActions2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCCategoryActions2.Name = "WCCategoryActions2";
            this.WCCategoryActions2.Size = new System.Drawing.Size(990, 215);
            this.WCCategoryActions2.TabIndex = 0;
            // 
            // WCCbType
            // 
            this.WCCbType.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.WCCbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WCCbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.WCCbType.FormattingEnabled = true;
            this.WCCbType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.WCCbType.Location = new System.Drawing.Point(574, 97);
            this.WCCbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCCbType.Name = "WCCbType";
            this.WCCbType.Size = new System.Drawing.Size(231, 34);
            this.WCCbType.TabIndex = 71;
            // 
            // WCLblType
            // 
            this.WCLblType.AutoSize = true;
            this.WCLblType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.WCLblType.Location = new System.Drawing.Point(502, 98);
            this.WCLblType.Name = "WCLblType";
            this.WCLblType.Size = new System.Drawing.Size(65, 30);
            this.WCLblType.TabIndex = 72;
            this.WCLblType.Text = "Type:";
            // 
            // WCTxtName
            // 
            this.WCTxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.WCTxtName.Location = new System.Drawing.Point(254, 97);
            this.WCTxtName.Name = "WCTxtName";
            this.WCTxtName.Size = new System.Drawing.Size(231, 32);
            this.WCTxtName.TabIndex = 70;
            // 
            // WCLblName
            // 
            this.WCLblName.AutoSize = true;
            this.WCLblName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.WCLblName.Location = new System.Drawing.Point(178, 97);
            this.WCLblName.Name = "WCLblName";
            this.WCLblName.Size = new System.Drawing.Size(76, 30);
            this.WCLblName.TabIndex = 69;
            this.WCLblName.Text = "Name:";
            // 
            // WCFilterByType
            // 
            this.WCFilterByType.BackColor = System.Drawing.SystemColors.Window;
            this.WCFilterByType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.WCFilterByType.FormattingEnabled = true;
            this.WCFilterByType.Items.AddRange(new object[] {
            "Transaction Type",
            "Income",
            "Expense"});
            this.WCFilterByType.Location = new System.Drawing.Point(341, 19);
            this.WCFilterByType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCFilterByType.Name = "WCFilterByType";
            this.WCFilterByType.Size = new System.Drawing.Size(213, 36);
            this.WCFilterByType.TabIndex = 9;
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
            this.WCBtnFilter.Location = new System.Drawing.Point(589, 15);
            this.WCBtnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCBtnFilter.Name = "WCBtnFilter";
            this.WCBtnFilter.Size = new System.Drawing.Size(110, 42);
            this.WCBtnFilter.TabIndex = 68;
            this.WCBtnFilter.Text = "FILTER";
            this.WCBtnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WCBtnFilter.UseVisualStyleBackColor = false;
            this.WCBtnFilter.Click += new System.EventHandler(this.WCBtnFilterClick);
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
            this.WCBtnClear.Location = new System.Drawing.Point(790, 156);
            this.WCBtnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCBtnClear.Name = "WCBtnClear";
            this.WCBtnClear.Size = new System.Drawing.Size(110, 42);
            this.WCBtnClear.TabIndex = 67;
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
            this.WCBtnDelete.Location = new System.Drawing.Point(668, 156);
            this.WCBtnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCBtnDelete.Name = "WCBtnDelete";
            this.WCBtnDelete.Size = new System.Drawing.Size(110, 42);
            this.WCBtnDelete.TabIndex = 66;
            this.WCBtnDelete.Text = "REMOVE";
            this.WCBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WCBtnDelete.UseVisualStyleBackColor = false;
            this.WCBtnDelete.Click += new System.EventHandler(this.WCBtnDeleteClickAsync);
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
            this.WCBtnAdd.Location = new System.Drawing.Point(421, 156);
            this.WCBtnAdd.Margin = new System.Windows.Forms.Padding(3, 6, 3, 10);
            this.WCBtnAdd.Name = "WCBtnAdd";
            this.WCBtnAdd.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.WCBtnAdd.Size = new System.Drawing.Size(110, 42);
            this.WCBtnAdd.TabIndex = 11;
            this.WCBtnAdd.Text = "CREATE";
            this.WCBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WCBtnAdd.UseVisualStyleBackColor = false;
            this.WCBtnAdd.Click += new System.EventHandler(this.WCBtnAddClickAsync);
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
            this.WCBtnUpdate.Location = new System.Drawing.Point(544, 156);
            this.WCBtnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCBtnUpdate.Name = "WCBtnUpdate";
            this.WCBtnUpdate.Size = new System.Drawing.Size(110, 42);
            this.WCBtnUpdate.TabIndex = 65;
            this.WCBtnUpdate.Text = "MODIFY";
            this.WCBtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WCBtnUpdate.UseVisualStyleBackColor = false;
            this.WCBtnUpdate.Click += new System.EventHandler(this.WCBtnUpdateClickAsync);
            // 
            // WCLblFilterCategories
            // 
            this.WCLblFilterCategories.AutoSize = true;
            this.WCLblFilterCategories.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.WCLblFilterCategories.Location = new System.Drawing.Point(243, 21);
            this.WCLblFilterCategories.Name = "WCLblFilterCategories";
            this.WCLblFilterCategories.Size = new System.Drawing.Size(102, 30);
            this.WCLblFilterCategories.TabIndex = 8;
            this.WCLblFilterCategories.Text = "Filter By: ";
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
            this.WCBtnSaveDraft.Location = new System.Drawing.Point(85, 156);
            this.WCBtnSaveDraft.Margin = new System.Windows.Forms.Padding(3, 6, 3, 10);
            this.WCBtnSaveDraft.Name = "WCBtnSaveDraft";
            this.WCBtnSaveDraft.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.WCBtnSaveDraft.Size = new System.Drawing.Size(149, 42);
            this.WCBtnSaveDraft.TabIndex = 73;
            this.WCBtnSaveDraft.Text = "SAVE DRAFT";
            this.WCBtnSaveDraft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WCBtnSaveDraft.UseVisualStyleBackColor = false;
            this.WCBtnSaveDraft.Click += new System.EventHandler(this.WCBtnSaveDraftClick);
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
            this.WCBtnLoadDraft.Location = new System.Drawing.Point(251, 156);
            this.WCBtnLoadDraft.Margin = new System.Windows.Forms.Padding(3, 6, 3, 10);
            this.WCBtnLoadDraft.Name = "WCBtnLoadDraft";
            this.WCBtnLoadDraft.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.WCBtnLoadDraft.Size = new System.Drawing.Size(155, 42);
            this.WCBtnLoadDraft.TabIndex = 74;
            this.WCBtnLoadDraft.Text = "LOAD DRAFT";
            this.WCBtnLoadDraft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WCBtnLoadDraft.UseVisualStyleBackColor = false;
            this.WCBtnLoadDraft.Click += new System.EventHandler(this.WCBtnLoadDraftClick);
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1110, 851);
            this.Controls.Add(this.WCLblCategoryActions);
            this.Controls.Add(this.WCCategoryActions);
            this.Controls.Add(this.WCLblCategories);
            this.Controls.Add(this.WCCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CategoriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudgetTracker - Categories";
            this.Load += new System.EventHandler(this.WCCategoriesFormLoadAsync);
            this.WCCategories.ResumeLayout(false);
            this.WCCategories2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WCCategoriessDataGV)).EndInit();
            this.WCCategoryActions.ResumeLayout(false);
            this.WCCategoryActions2.ResumeLayout(false);
            this.WCCategoryActions2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WCLblCategories;
        private System.Windows.Forms.Panel WCCategories;
        private System.Windows.Forms.Panel WCCategories2;
        private System.Windows.Forms.Label WCLblCategoryActions;
        private System.Windows.Forms.Panel WCCategoryActions;
        private System.Windows.Forms.Panel WCCategoryActions2;
        private System.Windows.Forms.ComboBox WCFilterByType;
        private System.Windows.Forms.Label WCLblFilterCategories;
        private System.Windows.Forms.ImageList WCImageList;
        private System.Windows.Forms.Button WCBtnAdd;
        private System.Windows.Forms.Button WCBtnClear;
        private System.Windows.Forms.Button WCBtnDelete;
        private System.Windows.Forms.Button WCBtnUpdate;
        private System.Windows.Forms.Button WCBtnFilter;
        private System.Windows.Forms.TextBox WCTxtName;
        private System.Windows.Forms.Label WCLblName;
        private System.Windows.Forms.ComboBox WCCbType;
        private System.Windows.Forms.Label WCLblType;
        private System.Windows.Forms.DataGridView WCCategoriessDataGV;
        private System.Windows.Forms.Button WCBtnSaveDraft;
        private System.Windows.Forms.Button WCBtnLoadDraft;
    }
}