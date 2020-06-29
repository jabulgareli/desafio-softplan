using Softplan.CalculadoraJuros.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.CalculadoraJuros.Domain.Entities
{
    public class SolicitacaoCalculoJuros
    {
        public decimal ValorInicial { get; private set; }
        public int QuantidadeMeses { get; private set; }
        public Percentual PercentualDeJuros { get; private set; }

        public SolicitacaoCalculoJuros(decimal valorInicial, int quantidadeMeses, Percentual percentual)
        {
            ValorInicial = valorInicial;
            QuantidadeMeses = quantidadeMeses;
            PercentualDeJuros = percentual;
        }

        public ResultadoCalculoJuros Calcular()
        {
            var valorFinal = ValorInicial * Convert.ToDecimal(Math.Pow(Convert.ToDouble((1 + PercentualDeJuros.Multiplicador)), QuantidadeMeses));
            var valorFinalTruncado = Math.Truncate(valorFinal * 100) / 100;
            var valorJuros = valorFinalTruncado - ValorInicial;

            return new ResultadoCalculoJuros(valorFinalTruncado, valorJuros, this);
        }
    }
}
