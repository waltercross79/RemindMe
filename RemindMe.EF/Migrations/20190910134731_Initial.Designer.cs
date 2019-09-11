﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RemindMe.EF;

namespace RemindMe.EF.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190910134731_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RemindMe.EF.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("NotificationStatusId");

                    b.Property<int?>("ScheduleTemplateId");

                    b.Property<DateTime>("ScheduledTime");

                    b.Property<DateTime?>("SentTime");

                    b.HasKey("Id");

                    b.HasIndex("NotificationStatusId");

                    b.HasIndex("ScheduleTemplateId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("RemindMe.EF.Models.NotificationStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("NotificationStatuses");
                });

            modelBuilder.Entity("RemindMe.EF.Models.Remindee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Remindees");
                });

            modelBuilder.Entity("RemindMe.EF.Models.ScheduleTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Minutes");

                    b.Property<int?>("RemindeeId");

                    b.Property<int?>("RepeatTimes");

                    b.Property<DateTime>("StartFrom");

                    b.Property<int?>("ToDoId");

                    b.HasKey("Id");

                    b.HasIndex("RemindeeId");

                    b.HasIndex("ToDoId");

                    b.ToTable("ScheduleTemplates");
                });

            modelBuilder.Entity("RemindMe.EF.Models.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("ToDos");
                });

            modelBuilder.Entity("RemindMe.EF.Models.Notification", b =>
                {
                    b.HasOne("RemindMe.EF.Models.NotificationStatus", "NotificationStatus")
                        .WithMany()
                        .HasForeignKey("NotificationStatusId");

                    b.HasOne("RemindMe.EF.Models.ScheduleTemplate", "ScheduleTemplate")
                        .WithMany()
                        .HasForeignKey("ScheduleTemplateId");
                });

            modelBuilder.Entity("RemindMe.EF.Models.ScheduleTemplate", b =>
                {
                    b.HasOne("RemindMe.EF.Models.Remindee")
                        .WithMany("ScheduleTemplates")
                        .HasForeignKey("RemindeeId");

                    b.HasOne("RemindMe.EF.Models.ToDo", "ToDo")
                        .WithMany()
                        .HasForeignKey("ToDoId");
                });
#pragma warning restore 612, 618
        }
    }
}
