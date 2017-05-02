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
using Calendar.NET;

namespace BillOmatic
{
    public partial class Form_CalendarView : Form
    {
        private ProgramManager _programManager;
        private List<Bill> _bills = new List<Bill>();
        public Form_CalendarView(ProgramManager programManager, List<Bill> bills)
        {
            _programManager = programManager;
            _programManager.CalendarForm = this;
            _bills = bills;
           // _programManager.currentForm = this;
            InitializeComponent();
            plotBillsOnCalendar(_bills);
        }

        private void Button_AddNewBill_Click(object sender, EventArgs e)
        {
            _programManager.showAddBillView();
        }

        private void Button_PrintList_Click(object sender, EventArgs e)
        {
            _programManager.printBillList();
            plotBillsOnCalendar(_bills);
        }

        public void plotBillsOnCalendar(List<Bill> bills)
        {
            Console.WriteLine("----------------------------- Called Plot Bills");
            Console.WriteLine("Printing Bill called, Printing: " + _bills.Count + " bills");
            foreach (Bill bill in bills)
            {
                bill.printData();
                CalendarEvent billData = new CalendarEvent();

                billData.Date = bill.dueDate;
                billData.RecurringFrequency = RecurringFrequencies.Monthly;
                billData.EventText = bill.name;
                billData.Enabled = true;
                billData.TooltipEnabled = true;

                //Event Styling
                billData.EventFont = new Font("Arial", 9.0f, FontStyle.Regular);
                billData.EventColor = bill.apperanceContainer.backgroundColor;
                billData.EventTextColor = bill.apperanceContainer.fontColor;

                Console.WriteLine("************************************" + billData.Date.ToString() + billData.EventText);

                Calendar.AddEvent(billData);
            }

        }
    }
}
