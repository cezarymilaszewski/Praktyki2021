using ContosoUniversity.Data;
using ContosoUniversity.Dto;
using ContosoUniversity.Serwis;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicznikiController : ControllerBase
    {
        private readonly IServiceLicznik _iServiceLicznik;
        private LicznikiContext _licznikiContext;

        public LicznikiController(LicznikiContext licznikiContext)
        {
            _licznikiContext = licznikiContext;
            _iServiceLicznik = new ServiceLiczniki(licznikiContext);
        }


        [HttpGet("{id:int}", Name = "Get")]
        public ActionResult<LicznikiDto> Get(int id)
        {
            var licznik = _iServiceLicznik.Get(id);

            if (licznik == null) return NotFound();

            return Ok(licznik);
        }

        [HttpPost]
        public ActionResult<LicznikiDto> Create(LicznikiDto licznikiDto)
        {
            _iServiceLicznik.Add(licznikiDto.Nazwa, licznikiDto.Typ);

            return CreatedAtRoute("Get", new {id = licznikiDto.Id}, licznikiDto);
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, LicznikiDto dto)
        {
            var licznik = _iServiceLicznik.Get(id);

            if (licznik == null) return NotFound();

            _iServiceLicznik.Update(id, dto);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var licznik = _iServiceLicznik.Get(id);

            if (licznik == null) return NotFound();

            if (licznik.Id != null) _iServiceLicznik.Delete((int) licznik.Id);

            return NoContent();
        }
    }
}