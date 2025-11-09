using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TheTinyCompany.Models;

namespace TheTinyCompany.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // connection string

            string con = "server = . ; database = theTinyCompanyDb ; " +
                "Integrated Security = True ; Encrypt = True ; Trust Server Certificate = True ;";
            optionsBuilder.UseSqlServer(con);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }


        public DbSet<EmployeeRole> employeeRoles { get; set; }
        public DbSet<Employee> employees { get; set; }



    }
}