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
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<StudentsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Student.ToListAsync();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentByID(int id)
        {
            var stud = await _context.Student.FindAsync(id);
            if (stud == null)
            {
                return NotFound();
            }
            return stud;
        }

        // POST api/<StudentsController>
        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent([FromBody]Student student)
        {
            _context.Student.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudent", new { id = student.StudentID }, student);
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutStudent(int id, [FromBody] Student student)
        {
            if (id != student.StudentID)
            {
                return BadRequest();
            }

            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                //todo: Write this method
                if (!StudentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        private bool StudentExists(int id)
        {
            throw new NotImplementedException();
        }

        //DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteStudent(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var foundStudent = _context.Student.FirstOrDefault(e => e.StudentID == id);
            if (foundStudent != null)
            {
                _context.Student.Remove(foundStudent);
                await _context.SaveChangesAsync();
            }
            return BadRequest();
        }

        [HttpDelete("sproc/{id}")]
        public async Task<ActionResult<string>> DeleteStudentForSP(int id)
        {
            var rowsAffected = await _context.Database.ExecuteSqlInterpolatedAsync($"EXEC DeleteStudentForSP {id}");
            return $"{rowsAffected} Student deleted";
        }

    }
}

