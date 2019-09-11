using System;
using System.Collections.Generic;
using System.Text;

namespace RemindMe.EF.Models
{
    /// <summary>
    /// Item/activity to be reminded to do.
    /// </summary>
    public class ToDo
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Item/Activity description.
        /// </summary>
        public string Description { get; set; }
    }
}
