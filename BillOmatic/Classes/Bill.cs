/*
 * Purpose: Store bill data.
 * Author: Virginia Dial
 * Date: 21-Apr-2017
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillOmatic.Classes
{
    [Serializable]
    public class Bill
    {
        private int _type;
        private string _name;
        private float _amount;
        private int _dueDate;
        private string _notes;

        // TODO : Add all parameters
        public Bill(string billName, float billAmount, int billDueDate, int type, string notes)
        {
            _name = billName;
            _amount = billAmount;
            _dueDate = billDueDate;
            _type = type;
            _notes = notes;
        }

        public int type
        {
            get { return _type; }
        }        

        public string name
        {
            get { return _name; }
        }

        public float amount
        {
            get { return _amount; }
        }

        public int dueDate
        {
            get { return _dueDate; }
        }

        public string notes
        {
            get { return _notes; }
        }

        public void printData()
        {
            Console.WriteLine("");
            Console.WriteLine("Bill type: " + _type.ToString());
            Console.WriteLine("Bill name: " + _name);
            Console.WriteLine("Due date: " + _dueDate.ToString());
            Console.WriteLine("Amount due: $" + _amount);
            Console.WriteLine("Notes: " + _notes);
            Console.WriteLine("");
        }
    }
}


