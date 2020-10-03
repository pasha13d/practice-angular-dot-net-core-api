using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIBE.Context;
using APIBE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public CompanyController(DatabaseContext context)
        {
            _context = context;
        }

        [Route("GetAllCompany")]
        [HttpGet]
        public ActionResult<List<Company>> GetAllCompany()
        {
            var companyList = _context.Company.ToList();
            return Ok(companyList);
        }

        [Route("GetFloorById/{CompanyId}")]
        [HttpGet]
        public ActionResult<List<Floors>> GetFloorById(int CompanyId)
        {
            var floorList = _context.Floors.ToList();
            return Ok(floorList);
        }

        [HttpPost]
        public async Task<ActionResult<Company>> PostCompany(Company Company)
        {
            _context.Company.Add(Company);
            await _context.SaveChangesAsync();
            return Ok(Company);
        }


        [HttpPost]
        public async Task<ActionResult<Floors>> PostFloor(Floors Floors)
        {
            _context.Floors.Add(Floors);
            await _context.SaveChangesAsync();
            return Ok(Floors);
        }

    }
}
