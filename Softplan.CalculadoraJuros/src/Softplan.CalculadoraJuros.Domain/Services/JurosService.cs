using Softplan.CalculadoraJuros.Domain.Entities;
using Softplan.CalculadoraJuros.Domain.Exceptions;
using Softplan.CalculadoraJuros.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.CalculadoraJuros.Domain.Services
{
    public class JurosService : IJurosService
    {
        private readonly ITaxaService _taxaService;

        public JurosService(ITaxaService taxaService)
        {
            if (taxaService == null)
                throw new ArgumentNullException(nameof(taxaService));

            _taxaService = taxaService;
        }

        public async Task<ResultadoCalculoJuros> CorrigirValorAsync(decimal valorInicial, int meses)
        {
            var taxa = await _taxaService.ConsultarTaxaAtualAsync();

            if (valorInicial <= 0 || meses <= 0 || taxa == null || taxa.Multiplicador <= 0)
                throw new ParametrosDeCalculoInvalidosException();

            return new SolicitacaoCalculoJuros(valorInicial, meses, taxa).Calcular();
        }
    }
}
