using System;
using System.Collections.Generic;
using System.Text;

namespace RemindMe.EF.Models
{
    /// <summary>
    /// Template to determine the next scheduled reminder.
    /// </summary>
    public class ScheduleTemplate
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Event/activity that the reminder for specific person/user will be created for.
        /// </summary>
        public ToDo ToDo { get; set; }

        /// <summary>
        /// Date and time to calculate the reminder from.
        /// </summary>
        public DateTime StartFrom { get; set; }

        /// <summary>
        /// Number of minutes after the start time that the reminder should be triggered.
        /// </summary>
        public int Minutes { get; set; }

        /// <summary>
        /// How many times to repeat the reminder.
        /// Will repeat indefinitely, if <c>null</c>.
        /// Will not be triggered at all, if <c>zero</c>.
        /// </summary>
        public int? RepeatTimes { get; set; }
    }
}
