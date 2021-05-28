using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using ContosoUniversity.Dto;
using ContosoUniversity.Serwis;
using Microsoft.AspNetCore.Routing;


namespace ContosoUniversity.Controllers


{
    [Route("api/[controller]")]
    [ApiController]
    public class LicznikiDaneController : ControllerBase
    {
        private readonly IServiceLicznikDane _iServiceLicznikDane;
        private LicznikiContext _licznikiContext;


        public LicznikiDaneController(LicznikiContext licznikiContext)
        {
            _licznikiContext = licznikiContext;
            _iServiceLicznikDane = new ServiceLicznikiDane(licznikiContext);
        }


        [HttpGet("{id:int}", Name = "dane")]
        public ActionResult<LicznikiDaneDto> Get(int id)
        {
            var licznikDaneDto = _iServiceLicznikDane.Get(id);

            if (licznikDaneDto == null) return NotFound();

            return licznikDaneDto;
        }


        [HttpPost]
        public ActionResult<LicznikiDaneDto> Create(LicznikiDaneDto licznikiDaneDto)
        {
            _iServiceLicznikDane.Add(licznikiDaneDto);
            return CreatedAtRoute("Get", new { id = licznikiDaneDto.Id }, licznikiDaneDto);
        }

        [HttpPut]
        public IActionResult Update(int id, LicznikiDaneDto dane)
        {
            var licznik = _iServiceLicznikDane.Get(id);

            if (licznik == null) return NotFound();

            _iServiceLicznikDane.Update(id, dane);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var licznikDane = _iServiceLicznikDane.Get(id);

            if (licznikDane == null) return NotFound();

            if (licznikDane.Id != null) _iServiceLicznikDane.Delete((int)licznikDane.Id);

            return NoContent();
        }

    }
}    