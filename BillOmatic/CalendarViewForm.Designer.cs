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
            this.TextBox_CalendarArea = new System.Windows.Forms.TextBox();
            this.Label_Welcome = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Button_AddNewBill
            // 
            this.Button_AddNewBill.Location = new System.Drawing.Point(52, 459);
            this.Button_AddNewBill.Name = "Button_AddNewBill";
            this.Button_AddNewBill.Size = new System.Drawing.Size(132, 49);
            this.Button_AddNewBill.TabIndex = 0;
            this.Button_AddNewBill.Text = "Add bill";
            this.Button_AddNewBill.UseVisualStyleBackColor = true;
            this.Button_AddNewBill.Click += new System.EventHandler(this.Button_AddNewBill_Click);
            // 
            // Button_PrintList
            // 
            this.Button_PrintList.Location = new System.Drawing.Point(669, 459);
            this.Button_PrintList.Name = "Button_PrintList";
            this.Button_PrintList.Size = new System.Drawing.Size(136, 49);
            this.Button_PrintList.TabIndex = 9;
            this.Button_PrintList.Text = "Print My Bills";
            this.Button_PrintList.UseVisualStyleBackColor = true;
            this.Button_PrintList.Click += new System.EventHandler(this.Button_PrintList_Click);
            // 
            // TextBox_CalendarArea
            // 
            this.TextBox_CalendarArea.Location = new System.Drawing.Point(43, 104);
            this.TextBox_CalendarArea.Multiline = true;
            this.TextBox_CalendarArea.Name = "TextBox_CalendarArea";
            this.TextBox_CalendarArea.Size = new System.Drawing.Size(746, 310);
            this.TextBox_CalendarArea.TabIndex = 10;
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
            // Form_CalendarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 522);
            this.Controls.Add(this.Label_Welcome);
            this.Controls.Add(this.TextBox_CalendarArea);
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
        private System.Windows.Forms.TextBox TextBox_CalendarArea;
        private System.Windows.Forms.Label Label_Welcome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}