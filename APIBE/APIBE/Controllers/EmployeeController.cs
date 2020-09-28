using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIBE.Context;
using APIBE.Models;
using APIBE.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly DatabaseContext _context;
        public EmployeeController(DatabaseContext context)
        {
            _context = context;
        }

        [Route("GetAllEmployee")]
        [HttpGet]
        public ActionResult<List<Employee>> GetAllEmployee()
        {
            var employeeList = _context.Employee.ToList();
            return Ok(employeeList);
        }

        [Route("GetGroupByEmployee")]
        [HttpGet]
        public ActionResult<List<EmployeeViewModel>> GetGroupByEmployee()
        {
            List<EmployeeViewModel> dataList = new List<EmployeeViewModel>();
            var employeeGroupBy = _context.Employee.ToList();
            if (employeeGroupBy.Count > 0)
            {
                int i = 1;
                dataList = employeeGroupBy.GroupBy(g => g.Department).Select(a => new EmployeeViewModel()
                {
                    Id = i++,
                    Department = a.Key,
                    Total = a.Sum(s => s.Salary),
                    EmployeeList = a.Select(f => new EmployeeViewDetails()
                    {
                        Id = f.Id,
                        Name = f.Name,
                        Gender = f.Gender,
                        Salary = f.Salary
                    }).OrderBy(o => o.Name).ToList()
                }).OrderBy(o => o.Department).ToList();
            }
            return Ok(dataList);
        }
    }
}
