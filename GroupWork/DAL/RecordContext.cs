using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupWork.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GroupWork.DAL
{
    public class RecordContext : DbContext
    {

        public RecordContext() : base("RecordContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Record> Records { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}