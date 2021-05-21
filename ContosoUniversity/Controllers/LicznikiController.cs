using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using ContosoUniversity.Dto;
using ContosoUniversity.Serwis;

namespace ContosoUniversity.Controllers
{

    


    [Route("api/[controller]")]
    [ApiController]
    public class LicznikiController : ControllerBase
    {
        private LicznikiContext _licznikiContext;
        private IServiceLicznik _iServiceLicznik;

        public LicznikiController(LicznikiContext licznikiContext )
        {
            _licznikiContext = licznikiContext;
            _iServiceLicznik = new ServiceLiczniki(licznikiContext);
        }

        [Route("{licznikId:int}")]
        [HttpGet]
        [ProducesResponseType(typeof(LicznikiDto), (int) HttpStatusCode.OK)]
        [ProducesResponseType((int) HttpStatusCode.NotFound)]
        [ProducesResponseType((int) HttpStatusCode.BadRequest)]
        public async Task<ActionResult> GetLicznikAsync(int licznikId)
        {
            try
            {
                var licznikDto =  _iServiceLicznik.Get(licznikId);
                if (licznikDto == null)
                    return NotFound();

                return Ok(licznikDto);
            }
            catch
            {
                return BadRequest();
            }
        }



        [HttpGet("{id:int}", Name = "Get")]
        public ActionResult<LicznikiDto> Get(int id)
        {
            var licznik = _iServiceLicznik.Get(id);

            if (licznik == null)
            {
                return NotFound();
            }

            return licznik;
        }

        [HttpPost]
        public ActionResult<LicznikiDto> Create(LicznikiDto licznikiDto)
        {
            _iServiceLicznik.Add(licznikiDto.Nazwa,licznikiDto.Typ);

            return CreatedAtRoute("Get", new { id = licznikiDto.Id }, licznikiDto);
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, LicznikiDto dto)
        {
            var licznik = _iServiceLicznik.Get(id);

            if (licznik == null)
            {
                return NotFound();
            }

            _iServiceLicznik.Update(id, dto);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var licznik = _iServiceLicznik.Get(id);

            if (licznik == null)
            {
                return NotFound();
            }

            if (licznik.Id != null) _iServiceLicznik.Delete((int) licznik.Id);

            return NoContent();
        }
    }
}
