using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Burada databasedeki tablolarla projemdeki nesnelerilerimi bağlamak için kullanacağım kodları yazdım.
    public class WorkCenterContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=WorkCenter;Trusted_Connection=true");

        }

        public DbSet<Work> Works { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Plan> Plans { get; set; }
    }
}
