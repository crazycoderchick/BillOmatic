using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calendar.NET;

namespace BillOmatic.Classes
{
    class CalendarEvent : IEvent
    {


        public CustomRecurringFrequenciesHandler CustomRecurringFunction { get; set; }

        public DateTime Date { get; set; }

        public bool Enabled { get; set; }

        public Color EventColor { get; set; }

        public Font EventFont { get; set; }

        public float EventLengthInHours { get; set; }

        public string EventText { get; set; }

        public Color EventTextColor { get; set; }

        public bool IgnoreTimeComponent { get; set; }

        public int Rank { get; set; }

        public bool ReadOnlyEvent { get; set; }

        public RecurringFrequencies RecurringFrequency { get; set; }

        public bool ThisDayForwardOnly { get; set; }

        public bool TooltipEnabled { get; set; }

        public IEvent Clone()
        {
            throw new NotImplementedException();
        }
    }
}
