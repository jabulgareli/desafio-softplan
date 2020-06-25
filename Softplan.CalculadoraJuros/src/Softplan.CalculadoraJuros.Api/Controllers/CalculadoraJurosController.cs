using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Softplan.CalculadoraJuros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraJurosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
