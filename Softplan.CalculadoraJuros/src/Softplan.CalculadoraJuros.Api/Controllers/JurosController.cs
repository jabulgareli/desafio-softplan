using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Softplan.CalculadoraJuros.Application.Commands;
using Softplan.CalculadoraJuros.Application.Interfaces;
using Softplan.CalculadoraJuros.Domain.Exceptions;
using Softplan.CalculadoraJuros.Domain.Interfaces.Services;

namespace Softplan.CalculadoraJuros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JurosController : ControllerBase
    {
        private IJurosAppService _jurosAppService;
        private ILogger<JurosController> _logger;

        public JurosController(IJurosAppService jurosAppService, ILogger<JurosController> logger)
        {
            _jurosAppService = jurosAppService;
            _logger = logger;
        }

        [HttpGet("calculaJuros")]
        [HttpGet("/calculaJuros")]
        public async Task<IActionResult> Get([FromQuery]decimal valorInicial, [FromQuery]int meses)
        {
            try
            {
                var command = new CalcularJurosCompostosCommand { ValorInicial = valorInicial, Meses = meses };
                return Ok(await _jurosAppService.CalcularJurosCompostosAsync(command));

            }
            catch(ParametrosDeCalculoInvalidosException ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
