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
    public class ShowTheCodeController : ControllerBase
    {
        [HttpGet("showmethecode")]
        [HttpGet("/showmethecode")]
        public IActionResult Get()
        {
            return Ok(new
            {
                Url = "https://github.com/jabulgareli/desafio-softplan"
            });
        }
    }
}
