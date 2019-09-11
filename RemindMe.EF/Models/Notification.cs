using System;
using System.Collections.Generic;
using System.Text;

namespace RemindMe.EF.Models
{
    /// <summary>
    /// Instance of a notification reminder template scheduled to run a specific point in time.
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// A schedule ToDo template that is used to generate a notification.
        /// </summary>
        public ScheduleTemplate ScheduleTemplate { get; set; }

        /// <summary>
        /// Date and time a notification is scheduled to be sent.
        /// </summary>
        public DateTime ScheduledTime { get; set; }

        /// <summary>
        /// Date and time the notification was sent.
        /// </summary>
        public DateTime? SentTime { get; set; }

        /// <summary>
        /// Status of the notification.
        /// </summary>
        public NotificationStatus NotificationStatus { get; set; }
    }
}
