using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCCoreNewFeatues.Repositories;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFCCoreNewFeatues.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController1 : ControllerBase
    {
        private readonly AppDbContext _context;
        public ClassesController1(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<ClassesController1>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class>>> GetClasses()
        {
            return await _context.Class.ToListAsync();
        }

        // GET api/<ClassesController1>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Class>> GetClassByID(int id)
        {
            var cls = await _context.Class.FindAsync(id);
            if (cls == null)
            {
                return NotFound();
            }
            return cls;
        }

        // POST api/<ClassesController1>
        [HttpPost]
        public async Task<ActionResult<Class>> PostClass([FromBody] Class myClass)
        {
            _context.Class.Add(myClass);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClass", new { id = myClass.ClassID }, myClass);
        }

        // PUT api/<ClassesController1>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClassesController1>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
