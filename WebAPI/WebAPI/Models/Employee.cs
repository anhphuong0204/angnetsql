using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public Department Department { get; set; }'
        public DateTime JoinDate { get; set; }
        public string PhotoFileDir { get; set; }
    }
}