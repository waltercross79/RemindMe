using System;
using System.Collections.Generic;
using System.Text;

namespace RemindMe.EF.Models
{
    /// <summary>
    /// Enumeration of notification statuses.
    /// </summary>
    public class NotificationStatus
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Notification status description.
        /// </summary>
        public string Description { get; set; }
    }
}
