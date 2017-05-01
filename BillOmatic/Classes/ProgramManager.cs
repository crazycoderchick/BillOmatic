using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BillOmatic.Classes
{
    public class ProgramManager
    {
        List<Bill> billList = new List<Bill>();
        public Form_BillInput BillInputForm;  // TODO : Temporary until Event Aggragater
        public Form_CalendarView CalendarForm;
        public Form currentForm;

        public void start()
        {
            Form f = (new Form_CalendarView(this, billList));
            currentForm = f;
            Application.Run(f);
        }

        public void createBill(string billName, float billAmount, DateTime billDueDate, int billType, string billNotes)
        {
            Bill newBill = new Bill(billName, billAmount, billDueDate, billType, billNotes);
            addBillToList(newBill);
            saveBillList();
            BillInputForm.clearTextFields();
            BillInputForm.displayNotificationBox("Bill saved successfully!");
        }

        private void addBillToList(Bill b)
        {
            billList.Add(b);
        }

        public void printBillList()
        {
            Console.WriteLine("Number of bills contained in the bill list: " + billList.Count);

            foreach(Bill bill in billList)
            {
                bill.printData();
            }

        }

        private void saveBillList() 
        {
            DataIOManager.saveBills(billList);
        }

        public void loadSavedData()  // Add all load data methods that need to be called at start up.
        {
            loadBillList();
        }

        private void loadBillList()  // Load data method.
        {
            billList = DataIOManager.loadBillList();
        }

        public void showCalendarView()
        {
            showNewForm(new Form_CalendarView(this, billList)); 
        }

        public void showAddBillView()
        {            
            showNewForm(new Form_BillInput(this));           
        }

        public void showNewForm(Form form)
        {
            var frm = form;
            frm.Location = currentForm.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { currentForm.Show(); };
            frm.Show();
            currentForm.Hide();
            currentForm = frm;
        }

    }
}
