namespace BillOmatic
{
    partial class SyncfusionTest
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
            this.scheduleControl1 = new Syncfusion.Windows.Forms.Schedule.ScheduleControl();
            this.SuspendLayout();
            // 
            // scheduleControl1
            // 
            this.scheduleControl1.Appearance.MonthCalendarStartDayOfWeek = System.DayOfWeek.Sunday;
            this.scheduleControl1.Appearance.MonthShowFullWeek = true;
            this.scheduleControl1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.scheduleControl1.Culture = new System.Globalization.CultureInfo("");
            this.scheduleControl1.DataSource = null;
            this.scheduleControl1.EnableAlerts = true;
            this.scheduleControl1.ISO8601CalenderFormat = false;
            this.scheduleControl1.Location = new System.Drawing.Point(34, 27);
            this.scheduleControl1.Name = "scheduleControl1";
            this.scheduleControl1.ShowRoundedCorners = true;
            this.scheduleControl1.Size = new System.Drawing.Size(640, 448);
            this.scheduleControl1.TabIndex = 0;
            this.scheduleControl1.Load += new System.EventHandler(this.scheduleControl1_Load);
            // 
            // SyncfusionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 573);
            this.Controls.Add(this.scheduleControl1);
            this.Name = "SyncfusionTest";
            this.Text = "SyncfusionTest";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Schedule.ScheduleControl scheduleControl1;
    }
}