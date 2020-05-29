using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Laba_14EntityASP.Models;

namespace Laba_14EntityASP.EF
{
    public class QRContext:DbContext
    {
        public QRContext() : base("QRContext")
        {
            //Database.SetInitializer<QRContext>(new QRInitializer());
            //Database.Initialize(true);
        }
        public DbSet<QuestRoom> QuestRooms { get; set; }
        public DbSet<Phone> Phones { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new QRInitializer());
        }


    }
}