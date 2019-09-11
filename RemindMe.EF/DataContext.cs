using Microsoft.EntityFrameworkCore;
using RemindMe.EF.Models;
using System;

namespace RemindMe.EF
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        public DbSet<ToDo> ToDos { get; set; }

        public DbSet<Remindee> Remindees { get; set; }

        public DbSet<ScheduleTemplate> ScheduleTemplates { get; set; }

        public DbSet<NotificationStatus> NotificationStatuses { get; set; }

        public DbSet<Notification> Notifications { get; set; }
    }
}
