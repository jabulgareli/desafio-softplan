using Softplan.CalculadoraJuros.Application.Commands;
using Softplan.CalculadoraJuros.Application.Interfaces;
using Softplan.CalculadoraJuros.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.CalculadoraJuros.Application.Services
{
    public class JurosAppService : IJurosAppService
    {
        private readonly IJurosService _jurosService;

        public JurosAppService(IJurosService jurosService)
        {
            _jurosService = jurosService;
        }

        public async Task<CalcularJurosCompostosResult> CalcularJurosCompostosAsync(CalcularJurosCompostosCommand command)
        {
            if (command == null)
                throw new ArgumentNullException(nameof(command));

            var result = await _jurosService.CorrigirValorAsync(command.ValorInicial, command.Meses);

            return new CalcularJurosCompostosResult { ValorCorrigido = result.ValorFinal };
        }
    }
}
