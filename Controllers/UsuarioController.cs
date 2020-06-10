using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bsiteTest.Data;
using bsiteTest.Models;

namespace bsiteTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UsuarioController : ControllerBase
    {
        private readonly bsiteCtx _ctx;
        public UsuarioController(bsiteCtx context)
        {
            _ctx = context;
        }

        [HttpGet("[action]/{usr}/{pwd}")]
        public async Task<IActionResult> Login(string usr, string pwd)
        {
            Costumer cs = await _ctx.Costumers.FirstOrDefaultAsync(c => c.EmailAddress == usr && c.PasswordHash == pwd);
            if (cs == null)
            {
                return NotFound("usuario no encontrado");
            }
            return Ok(cs);
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<Product>> GetProducts()
        {
            List<Product> ls = await _ctx.Products.ToListAsync();
            return ls;
        }
    }

}