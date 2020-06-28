using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.CalculadoraJuros.Domain.Entities
{
    public class ResultadoSimulacaoJuros
    {
        public decimal ValorFinal { get; private set; }
        public decimal Juros { get; private set; }
        public SolicitacaoSimulacao DadosSolicitacao { get; private set; }

        public ResultadoSimulacaoJuros(decimal valorFinal, decimal juros, SolicitacaoSimulacao dadosSolicitacao)
        {
            ValorFinal = valorFinal;
            Juros = juros;
            DadosSolicitacao = dadosSolicitacao;
        }
    }
}
