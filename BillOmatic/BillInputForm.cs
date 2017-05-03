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
            
            List<string> types = new List<string>();  // TODO : Temporary! This list will be built by the Program Manager after reading the saved user preferences file.
            types.Add("Utilities");
            types.Add("Insurance");
            types.Add("Entertainment");
            types.Add("Business");
            displayBillTypes(types);

            List<string> colors = new List<string>();  // TODO : Temporary! This list will be built by the Program Manager after reading the saved user preferences file.
            colors.Add("Blue");
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Purple");
            colors.Add("Yellow");
            displayBillCalendarEventColor(colors);            
        }


        // TODO : Input validation
        private void Button_Submit_Click(object sender, EventArgs e)
        {
            string billName = null;
            float billAmount = -1;
            int billType = -1;
            bool allInputsValid = true;

            if(TextBox_BillName.Text.Length > 1)
            {
                billName = TextBox_BillName.Text;
                Label_Warning_BillName.Text = "";
            }
            else
            {
                Label_Warning_BillName.Text = "Bill name required!!";
                allInputsValid = false;
            }


            if (TextBox_BillAmount.Text.Length > 1)
            {
                
                float.TryParse(TextBox_BillAmount.Text, out billAmount);
                
                if (billAmount == 0)
                {
                   Label_Warning_BillAmount.Text = "Amount must be numeric!!";
                    allInputsValid = false;
                }
                else  // This is the only successfull parsing of the BillAmount TextBox
                {
                    Label_Warning_BillAmount.Text = "";
                }
            }
            else
            {
                Label_Warning_BillAmount.Text = "Bill amount required in the following format ex: 0.00";
                allInputsValid = false;
            }


            if (ComboBox_BillType.SelectedIndex > 0)
            {
                billType = ComboBox_BillType.SelectedIndex;
                Label_Warning_BillType.Text = "";
            }
            else
            {
                Label_Warning_BillType.Text = "Bill type is required!!";
                allInputsValid = false;
            }


            if (allInputsValid)
            {
                _programManager.createBill(billName, billAmount, DateTimePicker_DueDate.Value, billType, TextBox_BillNotes.Text, SetBillAppearancePreferences());
                clearTextFields(); 
            }
        }        

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            clearTextFields();
        }

        private BillAppearance SetBillAppearancePreferences()
        {
            BillAppearance billAppearence = new BillAppearance();

            int i = ComboBox_EventColor.SelectedIndex;

            switch (i)
            {
                case 0:
                    billAppearence.backgroundColor = Color.Blue;
                    billAppearence.fontColor = Color.White;
                    break;
                case 1:
                    billAppearence.backgroundColor = Color.Red;
                    billAppearence.fontColor = Color.White;
                    break;
                case 2:
                    billAppearence.backgroundColor = Color.Green;
                    billAppearence.fontColor = Color.White;
                    break;
                case 3:
                    billAppearence.backgroundColor = Color.Purple;
                    billAppearence.fontColor = Color.White;
                    break;
                case 4:
                    billAppearence.backgroundColor = Color.Yellow;
                    billAppearence.fontColor = Color.Black;
                    break;
                default:
                    billAppearence.backgroundColor = Color.White;
                    billAppearence.fontColor = Color.Black;
                    break;
            }


            return billAppearence;
        }

        public void clearTextFields()  // All input fields need to be added to this method to be cleared. 
        {
            TextBox_BillName.Text = "";
            TextBox_BillAmount.Text = "";
            ComboBox_BillType.Text = "";
            ComboBox_EventColor.Text = "";
            TextBox_BillNotes.Text = "";
            TextBox_CreditorAddress.Text = "";
            TextBox_CreditorName.Text = "";
            TextBox_CreditorPhoneNumber.Text = "";
            TextBox_CreditorURL.Text = "";
            TextBox_CreditorURLPassword.Text = "";
            TextBox_CreditorURLUsername.Text = "";
            DateTimePicker_DueDate.Value = DateTime.Now;
            Label_Warning_BillAmount.Text = "";
            Label_Warning_BillName.Text = "";
            Label_Warning_BillType.Text = "";
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

        public void displayBillCalendarEventColor(List<string> billEventDisplayColor) // Add event color options to the combo box
        {
            foreach (string color in billEventDisplayColor)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = color;
                ComboBox_EventColor.Items.Add(item);
            }
        }
        
    }
}
