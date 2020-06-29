using Softplan.CalculadoraJuros.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.CalculadoraJuros.Domain.Interfaces.Services
{
    public interface IJurosService
    {
        Task<ResultadoCalculoJuros> CorrigirValorAsync(decimal valorInicial, int meses);
    }
}
