using System;
using System.Collections.Generic;
using System.Text;

namespace RemindMe.EF.Models
{
    /// <summary>
    /// Person who is to be reminded.
    /// </summary>
    public class Remindee
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Collection of schedule templates created by the person/user.
        /// </summary>
        public virtual IEnumerable<ScheduleTemplate> ScheduleTemplates { get; set; }
    }
}
