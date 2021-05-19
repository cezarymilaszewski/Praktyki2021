using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database1.Tables;
using Database1.Tables.Info;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Database1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET: api/<ValuesController1>
        [HttpGet]
        public IActionResult Get()
        {
            var ctx = new SchoolContext();
            var students = ctx.Students.Select(s => s).DefaultIfEmpty().ToList();

            ctx.SaveChanges();
            
            return Ok(students);
        }

        // GET api/<ValuesController1>/5
        [HttpGet("{id}")]
        public IActionResult Get()
        {
            var ctx = new SchoolContext();

            var student = ctx.Students.Select(s => s).Where(s => s.StudentID == 13).SingleOrDefault();

            ctx.SaveChanges();

            return Ok(student);

        }

        // POST api/<ValuesController1>
        [HttpPost]
        public IActionResult Get()
        {

        }

        // PUT api/<ValuesController1>/5
        [HttpPut("{id}")]
        public IActionResult Get()
        {
            var ctx = new SchoolContext();
            ctx.Students.Add();
            return Student;
        }

        // DELETE api/<ValuesController1>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
