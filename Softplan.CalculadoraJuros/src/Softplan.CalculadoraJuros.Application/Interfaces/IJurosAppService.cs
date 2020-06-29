using Softplan.CalculadoraJuros.Application.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.CalculadoraJuros.Application.Interfaces
{
    public interface IJurosAppService
    {
        Task<CalcularJurosCompostosResult> CalcularJurosCompostosAsync(CalcularJurosCompostosCommand command);
    }
}
