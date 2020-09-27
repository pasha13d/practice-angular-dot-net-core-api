using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIBE.Context;
using APIBE.Models;

namespace APIBE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly PaymentDetailContext _context;

        public LoginController(PaymentDetailContext context)
        {
            _context = context;
        }

        // GET: api/Login
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Login>>> GetLogin()
        {
            return await _context.Login.ToListAsync();
        }

        // GET: api/Login/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Login>> GetLogin(int id)
        {
            var login = await _context.Login.FindAsync(id);

            if (login == null)
            {
                return NotFound();
            }

            return login;
        }
        public IActionResult PostLoginCheck(Login login)
        {
            int loginCheck = _context.Login.Count(f=>f.Email==login.Email && f.Password == login.Password);

            return Ok(loginCheck);
        }

        //// PUT: api/Login/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutLogin(int id, Login login)
        //{
        //    if (id != login.LoginId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(login).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!LoginExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Login
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<Login>> PostLogin(Login login)
        //{
        //    _context.Login.Add(login);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetLogin", new { id = login.LoginId }, login);
        //}

        //// DELETE: api/Login/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Login>> DeleteLogin(int id)
        //{
        //    var login = await _context.Login.FindAsync(id);
        //    if (login == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Login.Remove(login);
        //    await _context.SaveChangesAsync();

        //    return login;
        //}

        //private bool LoginExists(int id)
        //{
        //    return _context.Login.Any(e => e.LoginId == id);
        //}
    }
}
