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
    public partial class Form_CalendarView : Form
    {
        private ProgramManager _programManager;
        
        public Form_CalendarView(ProgramManager programManager, List<Bill> bills)
        {
            _programManager = programManager;
            _programManager.CalendarForm = this;
           // _programManager.currentForm = this;
            InitializeComponent();
            plotBillsOnCalendar(bills);
        }

        private void Button_AddNewBill_Click(object sender, EventArgs e)
        {
            _programManager.showAddBillView();
        }

        private void Button_PrintList_Click(object sender, EventArgs e)
        {
            _programManager.printBillList();
        }

        private void plotBillsOnCalendar(List<Bill> bills)
        {
            

            foreach(Bill bill in bills)
            {
                var exerciseEvent = new CustomEvent
                {
                    Date = DateTime.Now,
                    RecurringFrequency = RecurringFrequencies.EveryMonWedFri,
                    EventText = "Time for Exercise!"
                };

                Calendar.AddEvent(billData);
            }

            
        }
    }
}
