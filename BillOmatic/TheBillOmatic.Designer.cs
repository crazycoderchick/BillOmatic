namespace BillOmatic
{
    partial class Form_BillInput
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
            this.Label_BillName = new System.Windows.Forms.Label();
            this.Label_BillDueDate = new System.Windows.Forms.Label();
            this.Label_BillAmountDue = new System.Windows.Forms.Label();
            this.TextBox_BillName = new System.Windows.Forms.TextBox();
            this.TextBox_BillAmount = new System.Windows.Forms.TextBox();
            this.Button_Submit = new System.Windows.Forms.Button();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Label_BillType = new System.Windows.Forms.Label();
            this.ComboBox_BillType = new System.Windows.Forms.ComboBox();
            this.Label_BillNotes = new System.Windows.Forms.Label();
            this.TextBox_BillNotes = new System.Windows.Forms.TextBox();
            this.ComboBox_BillDueDate = new System.Windows.Forms.ComboBox();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Label_OptionalInformation = new System.Windows.Forms.Label();
            this.Label_CreditorName = new System.Windows.Forms.Label();
            this.Label_CreditorAddress = new System.Windows.Forms.Label();
            this.Label_CreditorPhoneNumber = new System.Windows.Forms.Label();
            this.Label_CreditorURL = new System.Windows.Forms.Label();
            this.Label_CreditorURLUsername = new System.Windows.Forms.Label();
            this.Label_CreditorURLPassword = new System.Windows.Forms.Label();
            this.TextBox_CreditorName = new System.Windows.Forms.TextBox();
            this.TextBox_CreditorAddress = new System.Windows.Forms.TextBox();
            this.TextBox_CreditorPhoneNumber = new System.Windows.Forms.TextBox();
            this.TextBox_CreditorURL = new System.Windows.Forms.TextBox();
            this.TextBox_CreditorURLUsername = new System.Windows.Forms.TextBox();
            this.TextBox_CreditorURLPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label_BillName
            // 
            this.Label_BillName.AutoSize = true;
            this.Label_BillName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BillName.Location = new System.Drawing.Point(26, 37);
            this.Label_BillName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_BillName.Name = "Label_BillName";
            this.Label_BillName.Size = new System.Drawing.Size(34, 16);
            this.Label_BillName.TabIndex = 0;
            this.Label_BillName.Text = "Bill:";
            // 
            // Label_BillDueDate
            // 
            this.Label_BillDueDate.AutoSize = true;
            this.Label_BillDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BillDueDate.Location = new System.Drawing.Point(26, 112);
            this.Label_BillDueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_BillDueDate.Name = "Label_BillDueDate";
            this.Label_BillDueDate.Size = new System.Drawing.Size(77, 16);
            this.Label_BillDueDate.TabIndex = 1;
            this.Label_BillDueDate.Text = "Due Date:";
            // 
            // Label_BillAmountDue
            // 
            this.Label_BillAmountDue.AutoSize = true;
            this.Label_BillAmountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BillAmountDue.Location = new System.Drawing.Point(26, 71);
            this.Label_BillAmountDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_BillAmountDue.Name = "Label_BillAmountDue";
            this.Label_BillAmountDue.Size = new System.Drawing.Size(95, 16);
            this.Label_BillAmountDue.TabIndex = 2;
            this.Label_BillAmountDue.Text = "Amount Due:";
            // 
            // TextBox_BillName
            // 
            this.TextBox_BillName.Location = new System.Drawing.Point(198, 28);
            this.TextBox_BillName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_BillName.Name = "TextBox_BillName";
            this.TextBox_BillName.Size = new System.Drawing.Size(429, 22);
            this.TextBox_BillName.TabIndex = 3;
            // 
            // TextBox_BillAmount
            // 
            this.TextBox_BillAmount.Location = new System.Drawing.Point(199, 65);
            this.TextBox_BillAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_BillAmount.Name = "TextBox_BillAmount";
            this.TextBox_BillAmount.Size = new System.Drawing.Size(157, 22);
            this.TextBox_BillAmount.TabIndex = 4;
            this.TextBox_BillAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Button_Submit
            // 
            this.Button_Submit.Location = new System.Drawing.Point(13, 737);
            this.Button_Submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Submit.Name = "Button_Submit";
            this.Button_Submit.Size = new System.Drawing.Size(204, 27);
            this.Button_Submit.TabIndex = 6;
            this.Button_Submit.Text = "SUBMIT";
            this.Button_Submit.UseVisualStyleBackColor = true;
            this.Button_Submit.Click += new System.EventHandler(this.Button_Submit_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(289, 737);
            this.Button_Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(204, 27);
            this.Button_Clear.TabIndex = 7;
            this.Button_Clear.Text = "CLEAR";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Label_BillType
            // 
            this.Label_BillType.AutoSize = true;
            this.Label_BillType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BillType.Location = new System.Drawing.Point(26, 150);
            this.Label_BillType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_BillType.Name = "Label_BillType";
            this.Label_BillType.Size = new System.Drawing.Size(78, 16);
            this.Label_BillType.TabIndex = 9;
            this.Label_BillType.Text = "Bill Type: ";
            // 
            // ComboBox_BillType
            // 
            this.ComboBox_BillType.FormattingEnabled = true;
            this.ComboBox_BillType.Location = new System.Drawing.Point(198, 140);
            this.ComboBox_BillType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox_BillType.Name = "ComboBox_BillType";
            this.ComboBox_BillType.Size = new System.Drawing.Size(226, 24);
            this.ComboBox_BillType.TabIndex = 10;
            // 
            // Label_BillNotes
            // 
            this.Label_BillNotes.AutoSize = true;
            this.Label_BillNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BillNotes.Location = new System.Drawing.Point(26, 181);
            this.Label_BillNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_BillNotes.Name = "Label_BillNotes";
            this.Label_BillNotes.Size = new System.Drawing.Size(57, 16);
            this.Label_BillNotes.TabIndex = 11;
            this.Label_BillNotes.Text = "Notes: ";
            // 
            // TextBox_BillNotes
            // 
            this.TextBox_BillNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_BillNotes.Location = new System.Drawing.Point(198, 181);
            this.TextBox_BillNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_BillNotes.Multiline = true;
            this.TextBox_BillNotes.Name = "TextBox_BillNotes";
            this.TextBox_BillNotes.Size = new System.Drawing.Size(428, 180);
            this.TextBox_BillNotes.TabIndex = 12;
            // 
            // ComboBox_BillDueDate
            // 
            this.ComboBox_BillDueDate.FormattingEnabled = true;
            this.ComboBox_BillDueDate.Location = new System.Drawing.Point(199, 102);
            this.ComboBox_BillDueDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox_BillDueDate.Name = "ComboBox_BillDueDate";
            this.ComboBox_BillDueDate.Size = new System.Drawing.Size(100, 24);
            this.ComboBox_BillDueDate.TabIndex = 15;
            // 
            // Button_Close
            // 
            this.Button_Close.Location = new System.Drawing.Point(562, 738);
            this.Button_Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(177, 26);
            this.Button_Close.TabIndex = 16;
            this.Button_Close.Text = "CLOSE";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Label_OptionalInformation
            // 
            this.Label_OptionalInformation.AutoSize = true;
            this.Label_OptionalInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_OptionalInformation.Location = new System.Drawing.Point(13, 421);
            this.Label_OptionalInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_OptionalInformation.Name = "Label_OptionalInformation";
            this.Label_OptionalInformation.Size = new System.Drawing.Size(356, 20);
            this.Label_OptionalInformation.TabIndex = 17;
            this.Label_OptionalInformation.Text = "Optional Information (Creditor Information):";
            // 
            // Label_CreditorName
            // 
            this.Label_CreditorName.AutoSize = true;
            this.Label_CreditorName.Location = new System.Drawing.Point(26, 467);
            this.Label_CreditorName.Name = "Label_CreditorName";
            this.Label_CreditorName.Size = new System.Drawing.Size(57, 16);
            this.Label_CreditorName.TabIndex = 18;
            this.Label_CreditorName.Text = "Name: ";
            // 
            // Label_CreditorAddress
            // 
            this.Label_CreditorAddress.AutoSize = true;
            this.Label_CreditorAddress.Location = new System.Drawing.Point(26, 497);
            this.Label_CreditorAddress.Name = "Label_CreditorAddress";
            this.Label_CreditorAddress.Size = new System.Drawing.Size(70, 16);
            this.Label_CreditorAddress.TabIndex = 19;
            this.Label_CreditorAddress.Text = "Address:";
            // 
            // Label_CreditorPhoneNumber
            // 
            this.Label_CreditorPhoneNumber.AutoSize = true;
            this.Label_CreditorPhoneNumber.Location = new System.Drawing.Point(26, 584);
            this.Label_CreditorPhoneNumber.Name = "Label_CreditorPhoneNumber";
            this.Label_CreditorPhoneNumber.Size = new System.Drawing.Size(114, 16);
            this.Label_CreditorPhoneNumber.TabIndex = 20;
            this.Label_CreditorPhoneNumber.Text = "Phone Number:";
            // 
            // Label_CreditorURL
            // 
            this.Label_CreditorURL.AutoSize = true;
            this.Label_CreditorURL.Location = new System.Drawing.Point(27, 622);
            this.Label_CreditorURL.Name = "Label_CreditorURL";
            this.Label_CreditorURL.Size = new System.Drawing.Size(42, 16);
            this.Label_CreditorURL.TabIndex = 21;
            this.Label_CreditorURL.Text = "URL:";
            // 
            // Label_CreditorURLUsername
            // 
            this.Label_CreditorURLUsername.AutoSize = true;
            this.Label_CreditorURLUsername.Location = new System.Drawing.Point(41, 650);
            this.Label_CreditorURLUsername.Name = "Label_CreditorURLUsername";
            this.Label_CreditorURLUsername.Size = new System.Drawing.Size(83, 16);
            this.Label_CreditorURLUsername.TabIndex = 22;
            this.Label_CreditorURLUsername.Text = "Username:";
            // 
            // Label_CreditorURLPassword
            // 
            this.Label_CreditorURLPassword.AutoSize = true;
            this.Label_CreditorURLPassword.Location = new System.Drawing.Point(41, 675);
            this.Label_CreditorURLPassword.Name = "Label_CreditorURLPassword";
            this.Label_CreditorURLPassword.Size = new System.Drawing.Size(80, 16);
            this.Label_CreditorURLPassword.TabIndex = 23;
            this.Label_CreditorURLPassword.Text = "Password:";
            // 
            // TextBox_CreditorName
            // 
            this.TextBox_CreditorName.Location = new System.Drawing.Point(199, 461);
            this.TextBox_CreditorName.Name = "TextBox_CreditorName";
            this.TextBox_CreditorName.Size = new System.Drawing.Size(428, 22);
            this.TextBox_CreditorName.TabIndex = 24;
            // 
            // TextBox_CreditorAddress
            // 
            this.TextBox_CreditorAddress.Location = new System.Drawing.Point(199, 491);
            this.TextBox_CreditorAddress.Multiline = true;
            this.TextBox_CreditorAddress.Name = "TextBox_CreditorAddress";
            this.TextBox_CreditorAddress.Size = new System.Drawing.Size(428, 81);
            this.TextBox_CreditorAddress.TabIndex = 25;
            // 
            // TextBox_CreditorPhoneNumber
            // 
            this.TextBox_CreditorPhoneNumber.Location = new System.Drawing.Point(198, 584);
            this.TextBox_CreditorPhoneNumber.Name = "TextBox_CreditorPhoneNumber";
            this.TextBox_CreditorPhoneNumber.Size = new System.Drawing.Size(428, 22);
            this.TextBox_CreditorPhoneNumber.TabIndex = 26;
            // 
            // TextBox_CreditorURL
            // 
            this.TextBox_CreditorURL.Location = new System.Drawing.Point(199, 622);
            this.TextBox_CreditorURL.Name = "TextBox_CreditorURL";
            this.TextBox_CreditorURL.Size = new System.Drawing.Size(428, 22);
            this.TextBox_CreditorURL.TabIndex = 27;
            // 
            // TextBox_CreditorURLUsername
            // 
            this.TextBox_CreditorURLUsername.Location = new System.Drawing.Point(199, 650);
            this.TextBox_CreditorURLUsername.Name = "TextBox_CreditorURLUsername";
            this.TextBox_CreditorURLUsername.Size = new System.Drawing.Size(428, 22);
            this.TextBox_CreditorURLUsername.TabIndex = 28;
            // 
            // TextBox_CreditorURLPassword
            // 
            this.TextBox_CreditorURLPassword.Location = new System.Drawing.Point(199, 675);
            this.TextBox_CreditorURLPassword.Name = "TextBox_CreditorURLPassword";
            this.TextBox_CreditorURLPassword.Size = new System.Drawing.Size(428, 22);
            this.TextBox_CreditorURLPassword.TabIndex = 29;
            // 
            // Form_BillInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 772);
            this.Controls.Add(this.TextBox_CreditorURLPassword);
            this.Controls.Add(this.TextBox_CreditorURLUsername);
            this.Controls.Add(this.TextBox_CreditorURL);
            this.Controls.Add(this.TextBox_CreditorPhoneNumber);
            this.Controls.Add(this.TextBox_CreditorAddress);
            this.Controls.Add(this.TextBox_CreditorName);
            this.Controls.Add(this.Label_CreditorURLPassword);
            this.Controls.Add(this.Label_CreditorURLUsername);
            this.Controls.Add(this.Label_CreditorURL);
            this.Controls.Add(this.Label_CreditorPhoneNumber);
            this.Controls.Add(this.Label_CreditorAddress);
            this.Controls.Add(this.Label_CreditorName);
            this.Controls.Add(this.Label_OptionalInformation);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.ComboBox_BillDueDate);
            this.Controls.Add(this.TextBox_BillNotes);
            this.Controls.Add(this.Label_BillNotes);
            this.Controls.Add(this.ComboBox_BillType);
            this.Controls.Add(this.Label_BillType);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Button_Submit);
            this.Controls.Add(this.TextBox_BillAmount);
            this.Controls.Add(this.TextBox_BillName);
            this.Controls.Add(this.Label_BillAmountDue);
            this.Controls.Add(this.Label_BillDueDate);
            this.Controls.Add(this.Label_BillName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_BillInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Bill Omatic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_BillName;
        private System.Windows.Forms.Label Label_BillDueDate;
        private System.Windows.Forms.Label Label_BillAmountDue;
        private System.Windows.Forms.TextBox TextBox_BillName;
        private System.Windows.Forms.TextBox TextBox_BillAmount;
        private System.Windows.Forms.Button Button_Submit;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Label Label_BillType;
        private System.Windows.Forms.ComboBox ComboBox_BillType;
        private System.Windows.Forms.Label Label_BillNotes;
        private System.Windows.Forms.TextBox TextBox_BillNotes;
        private System.Windows.Forms.ComboBox ComboBox_BillDueDate;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Label Label_OptionalInformation;
        private System.Windows.Forms.Label Label_CreditorName;
        private System.Windows.Forms.Label Label_CreditorAddress;
        private System.Windows.Forms.Label Label_CreditorPhoneNumber;
        private System.Windows.Forms.Label Label_CreditorURL;
        private System.Windows.Forms.Label Label_CreditorURLUsername;
        private System.Windows.Forms.Label Label_CreditorURLPassword;
        private System.Windows.Forms.TextBox TextBox_CreditorName;
        private System.Windows.Forms.TextBox TextBox_CreditorAddress;
        private System.Windows.Forms.TextBox TextBox_CreditorPhoneNumber;
        private System.Windows.Forms.TextBox TextBox_CreditorURL;
        private System.Windows.Forms.TextBox TextBox_CreditorURLUsername;
        private System.Windows.Forms.TextBox TextBox_CreditorURLPassword;
    }
}

