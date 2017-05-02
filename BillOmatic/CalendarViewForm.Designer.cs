using Calendar.NET;

namespace BillOmatic
{
    partial class Form_CalendarView
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
            this.Button_AddNewBill = new System.Windows.Forms.Button();
            this.Button_PrintList = new System.Windows.Forms.Button();
            this.Label_Welcome = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Calendar = new Calendar.NET.Calendar();
            this.SuspendLayout();
            // 
            // Button_AddNewBill
            // 
            this.Button_AddNewBill.Location = new System.Drawing.Point(51, 512);
            this.Button_AddNewBill.Name = "Button_AddNewBill";
            this.Button_AddNewBill.Size = new System.Drawing.Size(132, 49);
            this.Button_AddNewBill.TabIndex = 0;
            this.Button_AddNewBill.Text = "Add bill";
            this.Button_AddNewBill.UseVisualStyleBackColor = true;
            this.Button_AddNewBill.Click += new System.EventHandler(this.Button_AddNewBill_Click);
            // 
            // Button_PrintList
            // 
            this.Button_PrintList.Location = new System.Drawing.Point(666, 512);
            this.Button_PrintList.Name = "Button_PrintList";
            this.Button_PrintList.Size = new System.Drawing.Size(136, 49);
            this.Button_PrintList.TabIndex = 9;
            this.Button_PrintList.Text = "Print My Bills";
            this.Button_PrintList.UseVisualStyleBackColor = true;
            this.Button_PrintList.Click += new System.EventHandler(this.Button_PrintList_Click);
            // 
            // Label_Welcome
            // 
            this.Label_Welcome.AutoSize = true;
            this.Label_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Welcome.Location = new System.Drawing.Point(246, 26);
            this.Label_Welcome.Name = "Label_Welcome";
            this.Label_Welcome.Size = new System.Drawing.Size(365, 39);
            this.Label_Welcome.TabIndex = 11;
            this.Label_Welcome.Text = "Welcome Dial Family!!!";
            // 
            // Calendar
            // 
            this.Calendar.AllowEditingEvents = true;
            this.Calendar.CalendarDate = new System.DateTime(2017, 4, 29, 22, 14, 35, 347);
            this.Calendar.CalendarView = CalendarViews.Month;
            this.Calendar.DateHeaderFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Calendar.DayOfWeekFont = new System.Drawing.Font("Arial", 10F);
            this.Calendar.DaysFont = new System.Drawing.Font("Arial", 10F);
            this.Calendar.DayViewTimeFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Calendar.DimDisabledEvents = true;
            this.Calendar.HighlightCurrentDay = true;
            this.Calendar.LoadPresetHolidays = true;
            this.Calendar.Location = new System.Drawing.Point(31, 80);
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowArrowControls = true;
            this.Calendar.ShowDashedBorderOnDisabledEvents = true;
            this.Calendar.ShowDateInHeader = true;
            this.Calendar.ShowDisabledEvents = false;
            this.Calendar.ShowEventTooltips = true;
            this.Calendar.ShowTodayButton = true;
            this.Calendar.Size = new System.Drawing.Size(775, 415);
            this.Calendar.TabIndex = 12;
            this.Calendar.TodayFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            // 
            // Form_CalendarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 598);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.Label_Welcome);
            this.Controls.Add(this.Button_PrintList);
            this.Controls.Add(this.Button_AddNewBill);
            this.Name = "Form_CalendarView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_AddNewBill;
        private System.Windows.Forms.Button Button_PrintList;
        private System.Windows.Forms.Label Label_Welcome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Calendar.NET.Calendar Calendar;
    }
}