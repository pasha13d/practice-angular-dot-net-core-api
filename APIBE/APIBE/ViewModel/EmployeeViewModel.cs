using APIBE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBE.ViewModel
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Department { get; set; }

        public List<EmployeeViewDetails> EmployeeList { get; set; }
    }

    public class EmployeeViewDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Salary { get; set; }
    }
        
}
