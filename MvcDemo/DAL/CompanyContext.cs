using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcDemo.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MvcDemo.DAL
{
    public class CompanyContext : DbContext
    {
        public CompanyContext() : base("CompanyContext")
        {
        }

        public DbSet<Worker> Workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}