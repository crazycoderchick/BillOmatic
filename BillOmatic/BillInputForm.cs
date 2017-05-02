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
            _programManager.createBill(TextBox_BillName.Text, float.Parse(TextBox_BillAmount.Text), DateTimePicker_DueDate.Value, ComboBox_BillType.SelectedIndex, TextBox_BillNotes.Text, SetBillAppearancePreferences());
            clearTextFields();
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
