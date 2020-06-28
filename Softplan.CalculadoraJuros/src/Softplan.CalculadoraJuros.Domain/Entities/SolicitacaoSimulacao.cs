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
        public decimal MultiplicadorJuros { get; private set; }

        public SolicitacaoSimulacao(decimal valorInicial, int quantidadeMeses, decimal multiplicadorJuros)
        {
            ValorInicial = valorInicial;
            QuantidadeMeses = quantidadeMeses;
            MultiplicadorJuros = multiplicadorJuros;
            PercentualJuros = multiplicadorJuros * 100;
        }

        public ResultadoSimulacaoJuros Calcular()
        {
            var valorFinal = ValorInicial * Convert.ToDecimal(Math.Pow(Convert.ToDouble((1 + MultiplicadorJuros)), QuantidadeMeses));
            var valorFinalTruncado = Math.Truncate(valorFinal * 100) / 100;
            var valorJuros = valorFinalTruncado - ValorInicial;

            return new ResultadoSimulacaoJuros(valorFinalTruncado, valorJuros, this);
        }
    }
}
