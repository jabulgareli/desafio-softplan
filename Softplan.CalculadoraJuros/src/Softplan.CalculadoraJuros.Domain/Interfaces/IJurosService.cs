using Softplan.CalculadoraJuros.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.CalculadoraJuros.Domain.Interfaces
{
    public interface IJurosService
    {
        ResultadoSimulacaoJuros CorrigirValor(decimal valorInicial, int meses);
    }
}
