using CompanyBusinessApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyBusinessApplication.Context
{
    public abstract class BaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("data source=DarshiL7\\SQLEXPRESS;initial catalog=CompanyBusinessDb;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework");
        }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<Leave> Leaves { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<BusinessUnit> BusinessUnits { get; set; }
    }
}
