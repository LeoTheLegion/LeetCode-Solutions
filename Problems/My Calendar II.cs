using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class MyCalendarTwo
    {
        private SortedDictionary<int, int> timeline;

        public MyCalendarTwo()
        {
            // Initialize the timeline
            timeline = new SortedDictionary<int, int>();
        }

        public bool Book(int start, int end)
        {
            // If the timeline is empty, add the event
            if (!timeline.ContainsKey(start))
            {
                timeline[start] = 0;
            }
            // If the timeline is empty, add the event
            if (!timeline.ContainsKey(end))
            {
                timeline[end] = 0;
            }

            // Increment the start and end times
            timeline[start]++;
            timeline[end]--;

            int activeBookings = 0;
            // Check if the event overlaps with any existing events
            foreach (var kvp in timeline)
            {
                // Increment the active bookings
                activeBookings += kvp.Value;
                // If there are more than 2 active bookings, revert the changes
                if (activeBookings >= 3)
                {
                    // Revert the changes
                    timeline[start]--;
                    timeline[end]++;

                    // Remove the start and end times if they are 0
                    if (timeline[start] == 0)
                    {
                        timeline.Remove(start);
                    }
                    if (timeline[end] == 0)
                    {
                        timeline.Remove(end);
                    }

                    return false;
                }
            }

            return true;
        }
    }
}
