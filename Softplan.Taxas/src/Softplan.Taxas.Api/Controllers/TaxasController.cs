using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Logging;
using Softplan.Taxas.Application.Interfaces;
using Softplan.Taxas.Domain.ValueObjects;

namespace Softplan.Taxas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxasController : ControllerBase
    {
        private readonly ITaxaAppService _taxaAppService;
        private ILogger<TaxasController> _logger;

        public TaxasController(ITaxaAppService taxaAppService, 
            ILogger<TaxasController> logger)
        {
            _taxaAppService = taxaAppService;
            _logger = logger;
        }

        [HttpGet("taxaJuros")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_taxaAppService.ObterTaxa());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
