using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.CalculadoraJuros.Domain.Entities
{
    public class SolicitacaoSimulacao
    {
        public decimal ValorInicial { get; private set; }
        public int QuantidadeMeses { get; private set; }
        public decimal PercentualJuros { get; private set; }

        public SolicitacaoSimulacao(decimal valorInicial, int quantidadeMeses, decimal percentualJuros)
        {
            ValorInicial = valorInicial;
            QuantidadeMeses = quantidadeMeses;
            PercentualJuros = percentualJuros;
        }

        public ResultadoSimulacaoJuros Calcular()
        {
            return new ResultadoSimulacaoJuros(0, 0, this);
        }
    }
}
