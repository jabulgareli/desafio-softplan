using Flurl.Http;
using Microsoft.Extensions.Configuration;
using Softplan.CalculadoraJuros.Domain.Interfaces.Services;
using Softplan.CalculadoraJuros.Domain.ValueObjects;
using Softplan.CalculadoraJuros.Infrastrucutre.TaxaApi.Contratos;
using Softplan.CalculadoraJuros.Infrastrucutre.TaxaApi.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.CalculadoraJuros.Infrastrucutre.TaxaApi.Services
{
    public class TaxaService : ITaxaService
    {
        private readonly IConfiguration _configuration;

        public TaxaService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<Percentual> ConsultarTaxaAtualAsync()
        {
            var endpoint = _configuration.GetSection("TaxaApi:Url")?.Value;

            if (string.IsNullOrEmpty(endpoint))
                throw new UrlApiNaoConfiguradaException();

            endpoint += "/api/taxas/taxaJuros";

            var result = await endpoint.AllowHttpStatus("2xx")
                                       .GetJsonAsync<RespostaTaxa>();

            if (result == null || result.Multiplicador <= 0)
                throw new RespostaTaxaInvalidaException();

            return Percentual.WithMultiplicador(result.Multiplicador);
        }
    }
}
