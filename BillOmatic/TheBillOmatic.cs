using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillOmatic.Classes;

namespace BillOmatic
{
    public partial class Form_BillInput : Form
    {
        private ProgramManager _programManager;

        public Form_BillInput(ProgramManager programManager)
        {
            _programManager = programManager;
            _programManager.BillInputForm = this;
           // _programManager.currentForm = this;
            InitializeComponent();
            displayAvailableDueDates();
            
            List<string> types = new List<string>();  // TODO : Temporary! This list will be built by the Program Manager after reading the saved user preferences file.
            types.Add("Utilities");
            types.Add("Insurance");
            types.Add("Entertainment");
            types.Add("Business");
            displayBillTypes(types);

        }


        // TODO : Input validation
        private void Button_Submit_Click(object sender, EventArgs e)
        {            
            _programManager.createBill(TextBox_BillName.Text, float.Parse(TextBox_BillAmount.Text), (ComboBox_BillDueDate.SelectedIndex + 1), ComboBox_BillType.SelectedIndex, TextBox_BillNotes.Text);
            clearTextFields();
        }        

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            clearTextFields();
        }

        public void clearTextFields()  // All input fields need to be added to this method to be cleared. 
        {
            TextBox_BillName.Text = "";
            TextBox_BillAmount.Text = "";
            ComboBox_BillType.Text = "";
            TextBox_BillNotes.Text = "";
            ComboBox_BillDueDate.Text = "";
            TextBox_CreditorAddress.Text = "";
            TextBox_CreditorName.Text = "";
            TextBox_CreditorPhoneNumber.Text = "";
            TextBox_CreditorURL.Text = "";
            TextBox_CreditorURLPassword.Text = "";
            TextBox_CreditorURLUsername.Text = "";
        }

        public void displayNotificationBox(string message)
        {
            MessageBox.Show(message);
        }

        public void displayBillTypes(List<string> billType) // Add bill types to the combo box
        {
            foreach(string type in billType)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = type;
                ComboBox_BillType.Items.Add(item);
            }
        }

        public void displayAvailableDueDates() // Adds 1 - 31 to the date combo box.
        {
            for (int i = 0; i < 31; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = (i + 1).ToString();
                ComboBox_BillDueDate.Items.Add(item);
            }
        }

        private class ComboBoxItem
        {
            public string Text { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            _programManager.showCalendarView();
        }
    }
}
