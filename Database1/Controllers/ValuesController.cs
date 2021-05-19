using Database1.Tables;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Database1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var ctx = new SchoolContext();

            var stufets = ctx.Students.Select(s => s).DefaultIfEmpty().ToList();
            var stufetsi = ctx.Students.Select(s => s).Where(s => s.StudentID == 89).SingleOrDefault();
            ctx.Students.Add();
            stufetsi.Photo = "lo";

            ctx.SaveChanges();


            return Ok(st);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var ctx = new SchoolContext();
            ctx.Students.Add(7,1);

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
