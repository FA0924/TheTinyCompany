using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTinyCompany.Models
{
    public class EmployeeRole
    {
        public int Id { get; set; }

        public string role { get; set; } // role : employee, manager, admin

        public ICollection<Employee> employees { get; set; } = new List<Employee>();

    }
}
