using Softplan.CalculadoraJuros.Domain.Entities;
using Softplan.CalculadoraJuros.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.CalculadoraJuros.Domain.Services
{
    public class JurosService : IJurosService
    {
        public ResultadoSimulacaoJuros CorrigirValor(decimal valorInicial, int meses)
        {
            return new SolicitacaoSimulacao(valorInicial, meses, 0).Calcular();
        }
    }
}
