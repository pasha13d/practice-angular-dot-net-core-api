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
    public class CascadingController : ControllerBase
    {
        private readonly DatabaseContext _context;
        public CascadingController(DatabaseContext databaseContext)
        {
            _context = databaseContext;
        }

        [Route("GetAllCountry")]
        [HttpGet]
        public ActionResult<List<Country>> GetAllCountry()
        {
            var countryList = _context.Country.ToList();
            return Ok(countryList);
        }

        [Route("GetStateById/{CountryId}")]
        [HttpGet]
        public ActionResult<List<Country>> GetStateById(int CountryId)
        {
            var stateList = _context.State.Where(s => s.CountryId == CountryId)
                .Select(a => new { a.Id, a.stateName});
            return Ok(stateList);
        }

        [Route("GetCityById/{StateId}")]
        [HttpGet]
        public ActionResult<List<Country>> GetCityById(int StateId)
        {
            var cityList = _context.City.Where(c => c.StateId == StateId)
                .Select(a => new { a.Id, a.cityName });
            return Ok(cityList);
        }
    }
}
