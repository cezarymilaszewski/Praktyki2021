using Liczniki.Logic;
using Liczniki.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Liczniki.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        private Model.ModelDto model;
        private Calculations liczba;

        public Controller()
        {

        }

        [HttpGet]
        [Route("readLiczniki")]
        public IActionResult GetModel()
        {
            model = new Model.ModelDto()
            {
                Id = 1,
                Liczba = 4.25f
            };
            return Ok(model);
        }
        [HttpPost]
        [Route("createLiczniki")]
        public IActionResult Licznik(Model.ModelDto model)
        {
            model = new Model.ModelDto()
            {
                Liczba = 4.25f
            };
            // add model to data
            return NoContent();
        }

        [HttpPut]
        [Route("updateLiczniki")]
        public IActionResult Zmiana(Model.ModelDto model)
        {
            model = new Model.ModelDto()
            {
                Id = 1,
                Liczba = 4.25f
            };
            // update model to data
            return NoContent();
        }

        [HttpDelete]
        [Route("deleteLiczniki")]
        public IActionResult Usuwanie(Model.ModelDto model)
        {
            model = new Model.ModelDto()
            {
                Id = 1,
                Liczba = 4.25f
            };
            //delete model from data
            return NoContent();
        }
    }
}
