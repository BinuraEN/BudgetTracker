
using System.Windows.Forms;

namespace BudgetTracker.Views
{
    partial class StatementsForm
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
            this.WCFromDate = new System.Windows.Forms.DateTimePicker();
            this.WCLblFromDate = new System.Windows.Forms.Label();
            this.WCToDate = new System.Windows.Forms.DateTimePicker();
            this.WCLblToDate = new System.Windows.Forms.Label();
            this.WCBtnGenerate = new System.Windows.Forms.Button();
            this.WCPanel2 = new System.Windows.Forms.Panel();
            this.WCTransactionsDataGV = new System.Windows.Forms.DataGridView();
            this.WCPanel1 = new System.Windows.Forms.Panel();
            this.WCLblCategories = new System.Windows.Forms.Label();
            this.WCPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WCTransactionsDataGV)).BeginInit();
            this.WCPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WCFromDate
            // 
            this.WCFromDate.CustomFormat = "MM/dd/yyyy";
            this.WCFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.WCFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.WCFromDate.Location = new System.Drawing.Point(176, 49);
            this.WCFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCFromDate.Name = "WCFromDate";
            this.WCFromDate.Size = new System.Drawing.Size(272, 32);
            this.WCFromDate.TabIndex = 11;
            this.WCFromDate.Value = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            this.WCFromDate.ValueChanged += new System.EventHandler(this.WCFromDateValueChanged);
            // 
            // WCLblFromDate
            // 
            this.WCLblFromDate.AutoSize = true;
            this.WCLblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.WCLblFromDate.Location = new System.Drawing.Point(101, 51);
            this.WCLblFromDate.Name = "WCLblFromDate";
            this.WCLblFromDate.Size = new System.Drawing.Size(75, 26);
            this.WCLblFromDate.TabIndex = 10;
            this.WCLblFromDate.Text = "From: ";
            // 
            // WCToDate
            // 
            this.WCToDate.CustomFormat = "MM/dd/yyyy";
            this.WCToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.WCToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.WCToDate.Location = new System.Drawing.Point(523, 49);
            this.WCToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCToDate.Name = "WCToDate";
            this.WCToDate.Size = new System.Drawing.Size(272, 32);
            this.WCToDate.TabIndex = 13;
            this.WCToDate.Value = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            // 
            // WCLblToDate
            // 
            this.WCLblToDate.AutoSize = true;
            this.WCLblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.WCLblToDate.Location = new System.Drawing.Point(476, 52);
            this.WCLblToDate.Name = "WCLblToDate";
            this.WCLblToDate.Size = new System.Drawing.Size(42, 26);
            this.WCLblToDate.TabIndex = 12;
            this.WCLblToDate.Text = "To:";
            // 
            // WCBtnGenerate
            // 
            this.WCBtnGenerate.BackColor = System.Drawing.Color.SkyBlue;
            this.WCBtnGenerate.FlatAppearance.BorderSize = 0;
            this.WCBtnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCBtnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.WCBtnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WCBtnGenerate.Location = new System.Drawing.Point(854, 40);
            this.WCBtnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCBtnGenerate.Name = "WCBtnGenerate";
            this.WCBtnGenerate.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.WCBtnGenerate.Size = new System.Drawing.Size(163, 49);
            this.WCBtnGenerate.TabIndex = 16;
            this.WCBtnGenerate.Text = " GENERATE";
            this.WCBtnGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WCBtnGenerate.UseVisualStyleBackColor = false;
            this.WCBtnGenerate.Click += new System.EventHandler(this.WCBtnGenerateClickAsync);
            // 
            // WCPanel2
            // 
            this.WCPanel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.WCPanel2.Controls.Add(this.WCTransactionsDataGV);
            this.WCPanel2.Location = new System.Drawing.Point(4, 1);
            this.WCPanel2.Name = "WCPanel2";
            this.WCPanel2.Size = new System.Drawing.Size(1052, 673);
            this.WCPanel2.TabIndex = 19;
            // 
            // WCTransactionsDataGV
            // 
            this.WCTransactionsDataGV.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.WCTransactionsDataGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.WCTransactionsDataGV.Location = new System.Drawing.Point(18, 18);
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
            this.WCTransactionsDataGV.Size = new System.Drawing.Size(1014, 643);
            this.WCTransactionsDataGV.TabIndex = 17;
            // 
            // WCPanel1
            // 
            this.WCPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(119)))), ((int)(((byte)(2)))));
            this.WCPanel1.Controls.Add(this.WCPanel2);
            this.WCPanel1.Location = new System.Drawing.Point(22, 136);
            this.WCPanel1.Name = "WCPanel1";
            this.WCPanel1.Size = new System.Drawing.Size(1061, 679);
            this.WCPanel1.TabIndex = 18;
            // 
            // WCLblCategories
            // 
            this.WCLblCategories.AutoSize = true;
            this.WCLblCategories.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.WCLblCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.WCLblCategories.Location = new System.Drawing.Point(45, 108);
            this.WCLblCategories.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.WCLblCategories.Name = "WCLblCategories";
            this.WCLblCategories.Padding = new System.Windows.Forms.Padding(4);
            this.WCLblCategories.Size = new System.Drawing.Size(150, 38);
            this.WCLblCategories.TabIndex = 18;
            this.WCLblCategories.Text = "Statement";
            this.WCLblCategories.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StatementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1106, 844);
            this.Controls.Add(this.WCLblCategories);
            this.Controls.Add(this.WCBtnGenerate);
            this.Controls.Add(this.WCToDate);
            this.Controls.Add(this.WCLblToDate);
            this.Controls.Add(this.WCFromDate);
            this.Controls.Add(this.WCLblFromDate);
            this.Controls.Add(this.WCPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StatementsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatementForm";
            this.Load += new System.EventHandler(this.WCStatementsFormLoadAsync);
            this.WCPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WCTransactionsDataGV)).EndInit();
            this.WCPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker WCFromDate;
        private Label WCLblFromDate;
        private DateTimePicker WCToDate;
        private Label WCLblToDate;
        private Button WCBtnGenerate;
        private Panel WCPanel2;
        private DataGridView WCTransactionsDataGV;
        private Panel WCPanel1;
        private Label WCLblCategories;
    }
}