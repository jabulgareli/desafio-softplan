using Softplan.CalculadoraJuros.Domain.Entities;
using Softplan.CalculadoraJuros.Domain.Exceptions;
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
            if (valorInicial <= 0 || meses <= 0)
                throw new ParametrosDeCalculoInvalidosException();

            return new SolicitacaoSimulacao(valorInicial, meses, 0.01m).Calcular();
        }
    }
}
