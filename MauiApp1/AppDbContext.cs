using MauiApp1.Entities;
using MauiApp1.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class AppDbContext : DbContext
    {
        private const string DB_Name = "";

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = $"Filename={PathDb.GetPath("test.db")}";
            optionsBuilder.UseSqlite(connectionString);
        }


    }
}
