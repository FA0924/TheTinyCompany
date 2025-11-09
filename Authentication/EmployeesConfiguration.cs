using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheTinyCompany.Models;

namespace TheTinyCompany.Authentication
{
    public class EmployeesConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(u => u.Email)
            .HasDefaultValue("employee@tinycompany.com")
            .IsRequired(false);

            builder.HasOne<EmployeeRole>(ur => ur.employeeRole)
            .WithMany();
        }
    }
}
