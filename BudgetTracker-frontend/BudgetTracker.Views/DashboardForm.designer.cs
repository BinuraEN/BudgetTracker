
using System.Windows.Forms;

namespace BudgetTracker.Views
{
    partial class DashboardForm
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
            this.WCLblMonthlySummary = new System.Windows.Forms.Label();
            this.WCLblWeeklySummary = new System.Windows.Forms.Label();
            this.WCWeeklySummary = new System.Windows.Forms.Panel();
            this.WCWeeklySummary2 = new System.Windows.Forms.Panel();
            this.WCListSaturday = new System.Windows.Forms.ListBox();
            this.WCListFriday = new System.Windows.Forms.ListBox();
            this.WCListThursday = new System.Windows.Forms.ListBox();
            this.WCListWednesday = new System.Windows.Forms.ListBox();
            this.WCLblSunday = new System.Windows.Forms.Label();
            this.WCLblSaturday = new System.Windows.Forms.Label();
            this.WCLblFriday = new System.Windows.Forms.Label();
            this.WCLblThursday = new System.Windows.Forms.Label();
            this.WCLblWednesday = new System.Windows.Forms.Label();
            this.WCLblTuesday = new System.Windows.Forms.Label();
            this.WCLblMonday = new System.Windows.Forms.Label();
            this.WCListTuesday = new System.Windows.Forms.ListBox();
            this.WCListMonday = new System.Windows.Forms.ListBox();
            this.WCLblIncomes = new System.Windows.Forms.Label();
            this.WCPanel1 = new System.Windows.Forms.Panel();
            this.WCPanel2 = new System.Windows.Forms.Panel();
            this.WCPanel5 = new System.Windows.Forms.Panel();
            this.WCPanel4 = new System.Windows.Forms.Panel();
            this.WCPanel3 = new System.Windows.Forms.Panel();
            this.WCLblNetIncomeAmt = new System.Windows.Forms.Label();
            this.WCLblExpenseAmt = new System.Windows.Forms.Label();
            this.WCLblIncomeAmt = new System.Windows.Forms.Label();
            this.WCLblNetIncome = new System.Windows.Forms.Label();
            this.WCLblExpenses = new System.Windows.Forms.Label();
            this.WCListSunday = new System.Windows.Forms.ListBox();
            this.WCWeeklySummary.SuspendLayout();
            this.WCWeeklySummary2.SuspendLayout();
            this.WCPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // WCLblMonthlySummary
            // 
            this.WCLblMonthlySummary.AutoSize = true;
            this.WCLblMonthlySummary.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.WCLblMonthlySummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.WCLblMonthlySummary.Location = new System.Drawing.Point(371, 55);
            this.WCLblMonthlySummary.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.WCLblMonthlySummary.Name = "WCLblMonthlySummary";
            this.WCLblMonthlySummary.Padding = new System.Windows.Forms.Padding(4);
            this.WCLblMonthlySummary.Size = new System.Drawing.Size(152, 38);
            this.WCLblMonthlySummary.TabIndex = 0;
            this.WCLblMonthlySummary.Text = "This Month";
            this.WCLblMonthlySummary.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WCLblWeeklySummary
            // 
            this.WCLblWeeklySummary.AutoSize = true;
            this.WCLblWeeklySummary.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.WCLblWeeklySummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.WCLblWeeklySummary.Location = new System.Drawing.Point(60, 316);
            this.WCLblWeeklySummary.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.WCLblWeeklySummary.Name = "WCLblWeeklySummary";
            this.WCLblWeeklySummary.Padding = new System.Windows.Forms.Padding(4);
            this.WCLblWeeklySummary.Size = new System.Drawing.Size(144, 38);
            this.WCLblWeeklySummary.TabIndex = 3;
            this.WCLblWeeklySummary.Text = "This Week";
            this.WCLblWeeklySummary.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WCWeeklySummary
            // 
            this.WCWeeklySummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(119)))), ((int)(((byte)(2)))));
            this.WCWeeklySummary.Controls.Add(this.WCWeeklySummary2);
            this.WCWeeklySummary.Location = new System.Drawing.Point(27, 337);
            this.WCWeeklySummary.Name = "WCWeeklySummary";
            this.WCWeeklySummary.Padding = new System.Windows.Forms.Padding(4);
            this.WCWeeklySummary.Size = new System.Drawing.Size(1047, 433);
            this.WCWeeklySummary.TabIndex = 4;
            // 
            // WCWeeklySummary2
            // 
            this.WCWeeklySummary2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.WCWeeklySummary2.Controls.Add(this.WCListSunday);
            this.WCWeeklySummary2.Controls.Add(this.WCListSaturday);
            this.WCWeeklySummary2.Controls.Add(this.WCListFriday);
            this.WCWeeklySummary2.Controls.Add(this.WCListThursday);
            this.WCWeeklySummary2.Controls.Add(this.WCListWednesday);
            this.WCWeeklySummary2.Controls.Add(this.WCLblSunday);
            this.WCWeeklySummary2.Controls.Add(this.WCLblSaturday);
            this.WCWeeklySummary2.Controls.Add(this.WCLblFriday);
            this.WCWeeklySummary2.Controls.Add(this.WCLblThursday);
            this.WCWeeklySummary2.Controls.Add(this.WCLblWednesday);
            this.WCWeeklySummary2.Controls.Add(this.WCLblTuesday);
            this.WCWeeklySummary2.Controls.Add(this.WCLblMonday);
            this.WCWeeklySummary2.Controls.Add(this.WCListTuesday);
            this.WCWeeklySummary2.Controls.Add(this.WCListMonday);
            this.WCWeeklySummary2.Location = new System.Drawing.Point(3, 3);
            this.WCWeeklySummary2.Name = "WCWeeklySummary2";
            this.WCWeeklySummary2.Size = new System.Drawing.Size(1039, 425);
            this.WCWeeklySummary2.TabIndex = 0;
            // 
            // WCListSaturday
            // 
            this.WCListSaturday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.WCListSaturday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WCListSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.WCListSaturday.FormattingEnabled = true;
            this.WCListSaturday.ItemHeight = 22;
            this.WCListSaturday.Location = new System.Drawing.Point(732, 60);
            this.WCListSaturday.Name = "WCListSaturday";
            this.WCListSaturday.Size = new System.Drawing.Size(135, 352);
            this.WCListSaturday.TabIndex = 17;
            // 
            // WCListFriday
            // 
            this.WCListFriday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.WCListFriday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WCListFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCListFriday.FormattingEnabled = true;
            this.WCListFriday.ItemHeight = 22;
            this.WCListFriday.Location = new System.Drawing.Point(591, 60);
            this.WCListFriday.Name = "WCListFriday";
            this.WCListFriday.Size = new System.Drawing.Size(135, 352);
            this.WCListFriday.TabIndex = 16;
            // 
            // WCListThursday
            // 
            this.WCListThursday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.WCListThursday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WCListThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.WCListThursday.FormattingEnabled = true;
            this.WCListThursday.ItemHeight = 22;
            this.WCListThursday.Location = new System.Drawing.Point(450, 61);
            this.WCListThursday.Name = "WCListThursday";
            this.WCListThursday.Size = new System.Drawing.Size(135, 352);
            this.WCListThursday.TabIndex = 15;
            // 
            // WCListWednesday
            // 
            this.WCListWednesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.WCListWednesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WCListWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCListWednesday.FormattingEnabled = true;
            this.WCListWednesday.ItemHeight = 22;
            this.WCListWednesday.Location = new System.Drawing.Point(309, 60);
            this.WCListWednesday.Name = "WCListWednesday";
            this.WCListWednesday.Size = new System.Drawing.Size(135, 352);
            this.WCListWednesday.TabIndex = 14;
            // 
            // WCLblSunday
            // 
            this.WCLblSunday.AutoSize = true;
            this.WCLblSunday.BackColor = System.Drawing.Color.Transparent;
            this.WCLblSunday.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.WCLblSunday.Location = new System.Drawing.Point(900, 24);
            this.WCLblSunday.Name = "WCLblSunday";
            this.WCLblSunday.Size = new System.Drawing.Size(89, 30);
            this.WCLblSunday.TabIndex = 13;
            this.WCLblSunday.Text = "Sunday";
            // 
            // WCLblSaturday
            // 
            this.WCLblSaturday.AutoSize = true;
            this.WCLblSaturday.BackColor = System.Drawing.Color.Transparent;
            this.WCLblSaturday.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.WCLblSaturday.Location = new System.Drawing.Point(749, 25);
            this.WCLblSaturday.Name = "WCLblSaturday";
            this.WCLblSaturday.Size = new System.Drawing.Size(106, 30);
            this.WCLblSaturday.TabIndex = 12;
            this.WCLblSaturday.Text = "Saturday";
            // 
            // WCLblFriday
            // 
            this.WCLblFriday.AutoSize = true;
            this.WCLblFriday.BackColor = System.Drawing.Color.Transparent;
            this.WCLblFriday.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.WCLblFriday.Location = new System.Drawing.Point(624, 25);
            this.WCLblFriday.Name = "WCLblFriday";
            this.WCLblFriday.Size = new System.Drawing.Size(77, 30);
            this.WCLblFriday.TabIndex = 11;
            this.WCLblFriday.Text = "Friday";
            // 
            // WCLblThursday
            // 
            this.WCLblThursday.AutoSize = true;
            this.WCLblThursday.BackColor = System.Drawing.Color.Transparent;
            this.WCLblThursday.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.WCLblThursday.Location = new System.Drawing.Point(465, 27);
            this.WCLblThursday.Name = "WCLblThursday";
            this.WCLblThursday.Size = new System.Drawing.Size(109, 30);
            this.WCLblThursday.TabIndex = 10;
            this.WCLblThursday.Text = "Thursday";
            // 
            // WCLblWednesday
            // 
            this.WCLblWednesday.AutoSize = true;
            this.WCLblWednesday.BackColor = System.Drawing.Color.Transparent;
            this.WCLblWednesday.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.WCLblWednesday.Location = new System.Drawing.Point(313, 27);
            this.WCLblWednesday.Name = "WCLblWednesday";
            this.WCLblWednesday.Size = new System.Drawing.Size(133, 30);
            this.WCLblWednesday.TabIndex = 9;
            this.WCLblWednesday.Text = "Wednesday";
            // 
            // WCLblTuesday
            // 
            this.WCLblTuesday.AutoSize = true;
            this.WCLblTuesday.BackColor = System.Drawing.Color.Transparent;
            this.WCLblTuesday.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.WCLblTuesday.Location = new System.Drawing.Point(189, 26);
            this.WCLblTuesday.Name = "WCLblTuesday";
            this.WCLblTuesday.Size = new System.Drawing.Size(97, 30);
            this.WCLblTuesday.TabIndex = 8;
            this.WCLblTuesday.Text = "Tuesday";
            // 
            // WCLblMonday
            // 
            this.WCLblMonday.AutoSize = true;
            this.WCLblMonday.BackColor = System.Drawing.Color.Transparent;
            this.WCLblMonday.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.WCLblMonday.Location = new System.Drawing.Point(46, 25);
            this.WCLblMonday.Name = "WCLblMonday";
            this.WCLblMonday.Size = new System.Drawing.Size(98, 30);
            this.WCLblMonday.TabIndex = 7;
            this.WCLblMonday.Text = "Monday";
            // 
            // WCListTuesday
            // 
            this.WCListTuesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.WCListTuesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WCListTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.WCListTuesday.FormattingEnabled = true;
            this.WCListTuesday.ItemHeight = 22;
            this.WCListTuesday.Location = new System.Drawing.Point(168, 59);
            this.WCListTuesday.Name = "WCListTuesday";
            this.WCListTuesday.Size = new System.Drawing.Size(135, 352);
            this.WCListTuesday.TabIndex = 1;
            // 
            // WCListMonday
            // 
            this.WCListMonday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.WCListMonday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WCListMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCListMonday.FormattingEnabled = true;
            this.WCListMonday.ItemHeight = 22;
            this.WCListMonday.Location = new System.Drawing.Point(27, 58);
            this.WCListMonday.Name = "WCListMonday";
            this.WCListMonday.Size = new System.Drawing.Size(135, 352);
            this.WCListMonday.TabIndex = 0;
            // 
            // WCLblIncomes
            // 
            this.WCLblIncomes.AutoSize = true;
            this.WCLblIncomes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WCLblIncomes.Location = new System.Drawing.Point(50, 29);
            this.WCLblIncomes.Name = "WCLblIncomes";
            this.WCLblIncomes.Size = new System.Drawing.Size(104, 32);
            this.WCLblIncomes.TabIndex = 0;
            this.WCLblIncomes.Text = "Incomes";
            // 
            // WCPanel1
            // 
            this.WCPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(119)))), ((int)(((byte)(2)))));
            this.WCPanel1.Location = new System.Drawing.Point(353, 83);
            this.WCPanel1.Name = "WCPanel1";
            this.WCPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.WCPanel1.Size = new System.Drawing.Size(414, 197);
            this.WCPanel1.TabIndex = 2;
            // 
            // WCPanel2
            // 
            this.WCPanel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.WCPanel2.Controls.Add(this.WCPanel5);
            this.WCPanel2.Controls.Add(this.WCPanel4);
            this.WCPanel2.Controls.Add(this.WCPanel3);
            this.WCPanel2.Controls.Add(this.WCLblNetIncomeAmt);
            this.WCPanel2.Controls.Add(this.WCLblExpenseAmt);
            this.WCPanel2.Controls.Add(this.WCLblIncomeAmt);
            this.WCPanel2.Controls.Add(this.WCLblNetIncome);
            this.WCPanel2.Controls.Add(this.WCLblExpenses);
            this.WCPanel2.Controls.Add(this.WCLblIncomes);
            this.WCPanel2.Location = new System.Drawing.Point(356, 85);
            this.WCPanel2.Name = "WCPanel2";
            this.WCPanel2.Size = new System.Drawing.Size(406, 189);
            this.WCPanel2.TabIndex = 0;
            // 
            // WCPanel5
            // 
            this.WCPanel5.BackColor = System.Drawing.Color.Black;
            this.WCPanel5.Location = new System.Drawing.Point(210, 147);
            this.WCPanel5.Name = "WCPanel5";
            this.WCPanel5.Size = new System.Drawing.Size(135, 3);
            this.WCPanel5.TabIndex = 6;
            // 
            // WCPanel4
            // 
            this.WCPanel4.BackColor = System.Drawing.Color.Black;
            this.WCPanel4.Location = new System.Drawing.Point(210, 142);
            this.WCPanel4.Name = "WCPanel4";
            this.WCPanel4.Size = new System.Drawing.Size(135, 3);
            this.WCPanel4.TabIndex = 6;
            // 
            // WCPanel3
            // 
            this.WCPanel3.BackColor = System.Drawing.Color.Black;
            this.WCPanel3.Location = new System.Drawing.Point(210, 108);
            this.WCPanel3.Name = "WCPanel3";
            this.WCPanel3.Size = new System.Drawing.Size(135, 3);
            this.WCPanel3.TabIndex = 5;
            // 
            // WCLblNetIncomeAmt
            // 
            this.WCLblNetIncomeAmt.AutoSize = true;
            this.WCLblNetIncomeAmt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WCLblNetIncomeAmt.Location = new System.Drawing.Point(215, 112);
            this.WCLblNetIncomeAmt.Name = "WCLblNetIncomeAmt";
            this.WCLblNetIncomeAmt.Size = new System.Drawing.Size(140, 32);
            this.WCLblNetIncomeAmt.TabIndex = 3;
            this.WCLblNetIncomeAmt.Text = "Rs.30000.00";
            this.WCLblNetIncomeAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WCLblExpenseAmt
            // 
            this.WCLblExpenseAmt.AutoSize = true;
            this.WCLblExpenseAmt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WCLblExpenseAmt.ForeColor = System.Drawing.Color.Red;
            this.WCLblExpenseAmt.Location = new System.Drawing.Point(215, 66);
            this.WCLblExpenseAmt.Name = "WCLblExpenseAmt";
            this.WCLblExpenseAmt.Size = new System.Drawing.Size(140, 32);
            this.WCLblExpenseAmt.TabIndex = 3;
            this.WCLblExpenseAmt.Text = "Rs.20000.00";
            this.WCLblExpenseAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WCLblIncomeAmt
            // 
            this.WCLblIncomeAmt.AutoSize = true;
            this.WCLblIncomeAmt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WCLblIncomeAmt.Location = new System.Drawing.Point(215, 31);
            this.WCLblIncomeAmt.Name = "WCLblIncomeAmt";
            this.WCLblIncomeAmt.Size = new System.Drawing.Size(140, 32);
            this.WCLblIncomeAmt.TabIndex = 3;
            this.WCLblIncomeAmt.Text = "Rs.50000.00";
            this.WCLblIncomeAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WCLblNetIncome
            // 
            this.WCLblNetIncome.AutoSize = true;
            this.WCLblNetIncome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WCLblNetIncome.Location = new System.Drawing.Point(48, 109);
            this.WCLblNetIncome.Name = "WCLblNetIncome";
            this.WCLblNetIncome.Size = new System.Drawing.Size(140, 32);
            this.WCLblNetIncome.TabIndex = 2;
            this.WCLblNetIncome.Text = "Net Income";
            // 
            // WCLblExpenses
            // 
            this.WCLblExpenses.AutoSize = true;
            this.WCLblExpenses.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WCLblExpenses.ForeColor = System.Drawing.Color.Red;
            this.WCLblExpenses.Location = new System.Drawing.Point(50, 66);
            this.WCLblExpenses.Name = "WCLblExpenses";
            this.WCLblExpenses.Size = new System.Drawing.Size(112, 32);
            this.WCLblExpenses.TabIndex = 1;
            this.WCLblExpenses.Text = "Expenses";
            // 
            // WCListSunday
            // 
            this.WCListSunday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.WCListSunday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WCListSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.WCListSunday.FormattingEnabled = true;
            this.WCListSunday.ItemHeight = 22;
            this.WCListSunday.Location = new System.Drawing.Point(873, 59);
            this.WCListSunday.Name = "WCListSunday";
            this.WCListSunday.Size = new System.Drawing.Size(135, 352);
            this.WCListSunday.TabIndex = 18;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1107, 851);
            this.Controls.Add(this.WCLblMonthlySummary);
            this.Controls.Add(this.WCPanel2);
            this.Controls.Add(this.WCLblWeeklySummary);
            this.Controls.Add(this.WCWeeklySummary);
            this.Controls.Add(this.WCPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.WCDashboardFormLoadAsync);
            this.WCWeeklySummary.ResumeLayout(false);
            this.WCWeeklySummary2.ResumeLayout(false);
            this.WCWeeklySummary2.PerformLayout();
            this.WCPanel2.ResumeLayout(false);
            this.WCPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label WCLblMonthlySummary;
        private Label WCLblWeeklySummary;
        private Panel WCWeeklySummary;
        private Panel WCWeeklySummary2;
        private ListBox WCListMonday;
        private ListBox WCListTuesday;
        private Label WCLblSunday;
        private Label WCLblSaturday;
        private Label WCLblFriday;
        private Label WCLblThursday;
        private Label WCLblWednesday;
        private Label WCLblTuesday;
        private Label WCLblMonday;
        private Label WCLblIncomes;
        private Panel WCPanel1;
        private Panel WCPanel2;
        private Panel WCPanel5;
        private Panel WCPanel4;
        private Panel WCPanel3;
        private Label WCLblNetIncomeAmt;
        private Label WCLblExpenseAmt;
        private Label WCLblIncomeAmt;
        private Label WCLblNetIncome;
        private Label WCLblExpenses;
        private ListBox WCListSaturday;
        private ListBox WCListFriday;
        private ListBox WCListThursday;
        private ListBox WCListWednesday;
        private ListBox WCListSunday;
    }
}