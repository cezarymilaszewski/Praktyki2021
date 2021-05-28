using ContosoUniversity.Data;
using ContosoUniversity.Dto;
using ContosoUniversity.Serwis;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudynekController : ControllerBase
    {
        private readonly IServiceBudynek _iServiceBudynek;
        private LicznikiContext _budynekContext;

        public BudynekController(LicznikiContext budynekContext)
        {
            _budynekContext = budynekContext;
            _iServiceBudynek = new ServiceBudynek(budynekContext);
        }


        [HttpGet("{id:int}", Name = "budynki")]
        public ActionResult<BudynekDto> Get(int id)
        {
            var budynekDto = _iServiceBudynek.Get(id);

            if (budynekDto == null) return NotFound();

            return budynekDto;
        }

        [HttpPost]
        public ActionResult<BudynekDto> Create(BudynekDto budynekDto)
        {
            _iServiceBudynek.Add(budynekDto);
            return CreatedAtRoute("Get", new { id = budynekDto.Id }, budynekDto);
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, BudynekDto dto)
        {
            var budynek = _iServiceBudynek.Get(id);

            if (budynek == null) return NotFound();

            _iServiceBudynek.Update(id, dto);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var budynek = _iServiceBudynek.Get(id);

            if (budynek == null) return NotFound();

            if (budynek.Id != null) _iServiceBudynek.Delete((int)budynek.Id);

            return NoContent();
        }
    }
}