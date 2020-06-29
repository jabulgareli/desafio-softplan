using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.CalculadoraJuros.Domain.Entities
{
    public class ResultadoCalculoJuros
    {
        public decimal ValorFinal { get; private set; }
        public decimal JurosAPagar { get; private set; }
        public SolicitacaoCalculoJuros DadosSolicitacao { get; private set; }

        public ResultadoCalculoJuros(decimal valorFinal, decimal jurosAPagar, SolicitacaoCalculoJuros dadosSolicitacao)
        {
            ValorFinal = valorFinal;
            JurosAPagar = jurosAPagar;
            DadosSolicitacao = dadosSolicitacao;
        }
    }
}
