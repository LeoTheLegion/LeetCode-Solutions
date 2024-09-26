using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class MyCalendar
    {
        private SortedList<int, int> calendar;

        public MyCalendar()
        {
            calendar = new SortedList<int, int>();
        }

        public bool Book(int start, int end)
        {
            // If the calendar is empty, add the event
            if (calendar.Count == 0)
            {
                calendar.Add(start, end);
                return true;
            }

            // Check if the event overlaps with any existing events
            foreach (var entry in calendar)
            {
                if (start < entry.Value && end > entry.Key)
                {
                    return false;
                }
            }

            // Add the event to the calendar
            calendar.Add(start, end);
            return true;
        }
    }
}
