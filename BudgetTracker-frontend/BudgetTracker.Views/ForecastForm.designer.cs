
using System.Windows.Forms;

namespace BudgetTracker.Views
{
    partial class ForecastForm
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
            this.WCLblDatePicker = new System.Windows.Forms.Label();
            this.WCCalendar = new System.Windows.Forms.MonthCalendar();
            this.WCLblForecast = new System.Windows.Forms.Label();
            this.WCForecastPanel = new System.Windows.Forms.Panel();
            this.WCForecastPanel2 = new System.Windows.Forms.Panel();
            this.WCLblForecastDate = new System.Windows.Forms.Label();
            this.WCForecastPanel3 = new System.Windows.Forms.Panel();
            this.WCForecastPanel4 = new System.Windows.Forms.Panel();
            this.WCForecastPanel7 = new System.Windows.Forms.Panel();
            this.WCLblRecurringExpenseAmt = new System.Windows.Forms.Label();
            this.WCLblRecurringExpenseDate = new System.Windows.Forms.Label();
            this.WCLblRecurringExpenses = new System.Windows.Forms.Label();
            this.WCForecastPanel6 = new System.Windows.Forms.Panel();
            this.WCLblRecurringIncomeAmt = new System.Windows.Forms.Label();
            this.WCLblRecurringIncomeDate = new System.Windows.Forms.Label();
            this.WCLblRecurringIncome = new System.Windows.Forms.Label();
            this.WCLblNetIncomeAmt = new System.Windows.Forms.Label();
            this.WCForecastPanel5 = new System.Windows.Forms.Panel();
            this.WCLblNetIncome = new System.Windows.Forms.Label();
            this.WCForecastPanel.SuspendLayout();
            this.WCForecastPanel2.SuspendLayout();
            this.WCForecastPanel3.SuspendLayout();
            this.WCForecastPanel4.SuspendLayout();
            this.WCForecastPanel7.SuspendLayout();
            this.WCForecastPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // WCLblDatePicker
            // 
            this.WCLblDatePicker.AutoSize = true;
            this.WCLblDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCLblDatePicker.Location = new System.Drawing.Point(642, 211);
            this.WCLblDatePicker.Name = "WCLblDatePicker";
            this.WCLblDatePicker.Size = new System.Drawing.Size(364, 32);
            this.WCLblDatePicker.TabIndex = 11;
            this.WCLblDatePicker.Text = "Pick a future date to forecast for:";
            // 
            // WCCalendar
            // 
            this.WCCalendar.Location = new System.Drawing.Point(662, 326);
            this.WCCalendar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.WCCalendar.Name = "WCCalendar";
            this.WCCalendar.TabIndex = 12;
            this.WCCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.WCCalendarDateChanged);
            // 
            // WCLblForecast
            // 
            this.WCLblForecast.AutoSize = true;
            this.WCLblForecast.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.WCLblForecast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.WCLblForecast.Location = new System.Drawing.Point(138, 68);
            this.WCLblForecast.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.WCLblForecast.Name = "WCLblForecast";
            this.WCLblForecast.Padding = new System.Windows.Forms.Padding(4);
            this.WCLblForecast.Size = new System.Drawing.Size(128, 38);
            this.WCLblForecast.TabIndex = 13;
            this.WCLblForecast.Text = "Forecast";
            this.WCLblForecast.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WCForecastPanel
            // 
            this.WCForecastPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(119)))), ((int)(((byte)(2)))));
            this.WCForecastPanel.Controls.Add(this.WCForecastPanel2);
            this.WCForecastPanel.Location = new System.Drawing.Point(105, 96);
            this.WCForecastPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCForecastPanel.Name = "WCForecastPanel";
            this.WCForecastPanel.Padding = new System.Windows.Forms.Padding(4);
            this.WCForecastPanel.Size = new System.Drawing.Size(449, 644);
            this.WCForecastPanel.TabIndex = 14;
            // 
            // WCForecastPanel2
            // 
            this.WCForecastPanel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.WCForecastPanel2.Controls.Add(this.WCLblForecastDate);
            this.WCForecastPanel2.Controls.Add(this.WCForecastPanel3);
            this.WCForecastPanel2.Controls.Add(this.WCLblNetIncomeAmt);
            this.WCForecastPanel2.Controls.Add(this.WCForecastPanel5);
            this.WCForecastPanel2.Controls.Add(this.WCLblNetIncome);
            this.WCForecastPanel2.Location = new System.Drawing.Point(2, 2);
            this.WCForecastPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCForecastPanel2.Name = "WCForecastPanel2";
            this.WCForecastPanel2.Size = new System.Drawing.Size(441, 637);
            this.WCForecastPanel2.TabIndex = 0;
            // 
            // WCLblForecastDate
            // 
            this.WCLblForecastDate.AutoSize = true;
            this.WCLblForecastDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.WCLblForecastDate.Location = new System.Drawing.Point(250, 56);
            this.WCLblForecastDate.Name = "WCLblForecastDate";
            this.WCLblForecastDate.Size = new System.Drawing.Size(127, 30);
            this.WCLblForecastDate.TabIndex = 13;
            this.WCLblForecastDate.Text = "01/09/2022";
            // 
            // WCForecastPanel3
            // 
            this.WCForecastPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(119)))), ((int)(((byte)(2)))));
            this.WCForecastPanel3.Controls.Add(this.WCForecastPanel4);
            this.WCForecastPanel3.Location = new System.Drawing.Point(34, 241);
            this.WCForecastPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCForecastPanel3.Name = "WCForecastPanel3";
            this.WCForecastPanel3.Padding = new System.Windows.Forms.Padding(4);
            this.WCForecastPanel3.Size = new System.Drawing.Size(388, 376);
            this.WCForecastPanel3.TabIndex = 16;
            // 
            // WCForecastPanel4
            // 
            this.WCForecastPanel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.WCForecastPanel4.Controls.Add(this.WCForecastPanel7);
            this.WCForecastPanel4.Controls.Add(this.WCLblRecurringExpenseDate);
            this.WCForecastPanel4.Controls.Add(this.WCLblRecurringExpenses);
            this.WCForecastPanel4.Controls.Add(this.WCForecastPanel6);
            this.WCForecastPanel4.Controls.Add(this.WCLblRecurringIncomeDate);
            this.WCForecastPanel4.Controls.Add(this.WCLblRecurringIncome);
            this.WCForecastPanel4.Location = new System.Drawing.Point(2, 2);
            this.WCForecastPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCForecastPanel4.Name = "WCForecastPanel4";
            this.WCForecastPanel4.Size = new System.Drawing.Size(380, 369);
            this.WCForecastPanel4.TabIndex = 0;
            // 
            // WCForecastPanel7
            // 
            this.WCForecastPanel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WCForecastPanel7.Controls.Add(this.WCLblRecurringExpenseAmt);
            this.WCForecastPanel7.Location = new System.Drawing.Point(61, 247);
            this.WCForecastPanel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCForecastPanel7.Name = "WCForecastPanel7";
            this.WCForecastPanel7.Size = new System.Drawing.Size(270, 62);
            this.WCForecastPanel7.TabIndex = 11;
            // 
            // WCLblRecurringExpenseAmt
            // 
            this.WCLblRecurringExpenseAmt.AutoSize = true;
            this.WCLblRecurringExpenseAmt.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.WCLblRecurringExpenseAmt.Location = new System.Drawing.Point(51, 11);
            this.WCLblRecurringExpenseAmt.Margin = new System.Windows.Forms.Padding(0);
            this.WCLblRecurringExpenseAmt.Name = "WCLblRecurringExpenseAmt";
            this.WCLblRecurringExpenseAmt.Size = new System.Drawing.Size(159, 36);
            this.WCLblRecurringExpenseAmt.TabIndex = 18;
            this.WCLblRecurringExpenseAmt.Text = "Rs. 13500.00";
            this.WCLblRecurringExpenseAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WCLblRecurringExpenseDate
            // 
            this.WCLblRecurringExpenseDate.AutoSize = true;
            this.WCLblRecurringExpenseDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.WCLblRecurringExpenseDate.Location = new System.Drawing.Point(239, 196);
            this.WCLblRecurringExpenseDate.Name = "WCLblRecurringExpenseDate";
            this.WCLblRecurringExpenseDate.Size = new System.Drawing.Size(127, 30);
            this.WCLblRecurringExpenseDate.TabIndex = 12;
            this.WCLblRecurringExpenseDate.Text = "01/09/2022";
            // 
            // WCLblRecurringExpenses
            // 
            this.WCLblRecurringExpenses.AutoSize = true;
            this.WCLblRecurringExpenses.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.WCLblRecurringExpenses.Location = new System.Drawing.Point(19, 195);
            this.WCLblRecurringExpenses.Name = "WCLblRecurringExpenses";
            this.WCLblRecurringExpenses.Size = new System.Drawing.Size(249, 30);
            this.WCLblRecurringExpenses.TabIndex = 11;
            this.WCLblRecurringExpenses.Text = "Recurring Expenses as at";
            // 
            // WCForecastPanel6
            // 
            this.WCForecastPanel6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.WCForecastPanel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WCForecastPanel6.Controls.Add(this.WCLblRecurringIncomeAmt);
            this.WCForecastPanel6.Location = new System.Drawing.Point(61, 86);
            this.WCForecastPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCForecastPanel6.Name = "WCForecastPanel6";
            this.WCForecastPanel6.Size = new System.Drawing.Size(270, 62);
            this.WCForecastPanel6.TabIndex = 10;
            // 
            // WCLblRecurringIncomeAmt
            // 
            this.WCLblRecurringIncomeAmt.AutoSize = true;
            this.WCLblRecurringIncomeAmt.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.WCLblRecurringIncomeAmt.Location = new System.Drawing.Point(53, 10);
            this.WCLblRecurringIncomeAmt.Margin = new System.Windows.Forms.Padding(0);
            this.WCLblRecurringIncomeAmt.Name = "WCLblRecurringIncomeAmt";
            this.WCLblRecurringIncomeAmt.Size = new System.Drawing.Size(159, 36);
            this.WCLblRecurringIncomeAmt.TabIndex = 17;
            this.WCLblRecurringIncomeAmt.Text = "Rs. 12600.00";
            this.WCLblRecurringIncomeAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WCLblRecurringIncomeDate
            // 
            this.WCLblRecurringIncomeDate.AutoSize = true;
            this.WCLblRecurringIncomeDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.WCLblRecurringIncomeDate.Location = new System.Drawing.Point(235, 41);
            this.WCLblRecurringIncomeDate.Name = "WCLblRecurringIncomeDate";
            this.WCLblRecurringIncomeDate.Size = new System.Drawing.Size(127, 30);
            this.WCLblRecurringIncomeDate.TabIndex = 9;
            this.WCLblRecurringIncomeDate.Text = "01/09/2022";
            // 
            // WCLblRecurringIncome
            // 
            this.WCLblRecurringIncome.AutoSize = true;
            this.WCLblRecurringIncome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.WCLblRecurringIncome.Location = new System.Drawing.Point(23, 40);
            this.WCLblRecurringIncome.Name = "WCLblRecurringIncome";
            this.WCLblRecurringIncome.Size = new System.Drawing.Size(242, 30);
            this.WCLblRecurringIncome.TabIndex = 8;
            this.WCLblRecurringIncome.Text = "Recurring Incomes as at";
            // 
            // WCLblNetIncomeAmt
            // 
            this.WCLblNetIncomeAmt.AutoSize = true;
            this.WCLblNetIncomeAmt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCLblNetIncomeAmt.Location = new System.Drawing.Point(136, 111);
            this.WCLblNetIncomeAmt.Name = "WCLblNetIncomeAmt";
            this.WCLblNetIncomeAmt.Size = new System.Drawing.Size(183, 38);
            this.WCLblNetIncomeAmt.TabIndex = 10;
            this.WCLblNetIncomeAmt.Text = "Rs. 23000.00";
            this.WCLblNetIncomeAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WCForecastPanel5
            // 
            this.WCForecastPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(41)))));
            this.WCForecastPanel5.Location = new System.Drawing.Point(77, 168);
            this.WCForecastPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WCForecastPanel5.Name = "WCForecastPanel5";
            this.WCForecastPanel5.Size = new System.Drawing.Size(300, 2);
            this.WCForecastPanel5.TabIndex = 9;
            // 
            // WCLblNetIncome
            // 
            this.WCLblNetIncome.AutoSize = true;
            this.WCLblNetIncome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.WCLblNetIncome.Location = new System.Drawing.Point(75, 56);
            this.WCLblNetIncome.Name = "WCLblNetIncome";
            this.WCLblNetIncome.Size = new System.Drawing.Size(182, 30);
            this.WCLblNetIncome.TabIndex = 8;
            this.WCLblNetIncome.Text = "Net Income as at ";
            // 
            // ForecastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1096, 855);
            this.Controls.Add(this.WCLblForecast);
            this.Controls.Add(this.WCForecastPanel);
            this.Controls.Add(this.WCCalendar);
            this.Controls.Add(this.WCLblDatePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ForecastForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForecastForm";
            this.Load += new System.EventHandler(this.WCForecastFormLoadAsync);
            this.WCForecastPanel.ResumeLayout(false);
            this.WCForecastPanel2.ResumeLayout(false);
            this.WCForecastPanel2.PerformLayout();
            this.WCForecastPanel3.ResumeLayout(false);
            this.WCForecastPanel4.ResumeLayout(false);
            this.WCForecastPanel4.PerformLayout();
            this.WCForecastPanel7.ResumeLayout(false);
            this.WCForecastPanel7.PerformLayout();
            this.WCForecastPanel6.ResumeLayout(false);
            this.WCForecastPanel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label WCLblDatePicker;
        private MonthCalendar WCCalendar;
        private Label WCLblForecast;
        private Panel WCForecastPanel;
        private Panel WCForecastPanel2;
        private Label WCLblNetIncome;
        private Panel WCForecastPanel5;
        private Label WCLblNetIncomeAmt;
        private Panel WCForecastPanel3;
        private Panel WCForecastPanel4;
        private Label WCLblRecurringIncome;
        private Label WCLblRecurringIncomeDate;
        private Panel WCForecastPanel7;
        private Label WCLblRecurringExpenseDate;
        private Label WCLblRecurringExpenses;
        private Panel WCForecastPanel6;
        private Label WCLblForecastDate;
        private Label WCLblRecurringExpenseAmt;
        private Label WCLblRecurringIncomeAmt;
    }
}