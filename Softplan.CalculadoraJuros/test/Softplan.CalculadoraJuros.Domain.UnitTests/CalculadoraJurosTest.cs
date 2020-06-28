using Softplan.CalculadoraJuros.Domain.Exceptions;
using Softplan.CalculadoraJuros.Domain.Services;
using System;
using Xunit;

namespace Softplan.CalculadoraJuros.Domain.UnitTests
{
    public class CalculadoraJurosTest
    {
        [Fact(DisplayName = "Ao calcular juros pra R$ 100 em 5 meses então o resultado é R$ 105.10 ")]
        public void Ao_Calcular_Juros_Para_100_E_5_Meses_Entao_Retorna_Valor_Atualizado_De_105e10()
        {
            var jurosService = new JurosService();

            var resultadoCalculo = jurosService.CorrigirValor(100, 5);

            Assert.NotNull(resultadoCalculo);
            Assert.NotNull(resultadoCalculo.DadosSolicitacao);

            Assert.Equal(1, resultadoCalculo.DadosSolicitacao.PercentualJuros);
            Assert.Equal(105.1m, resultadoCalculo.ValorFinal);
            Assert.Equal(5.1m, resultadoCalculo.Juros);

        }

        [Theory(DisplayName = "Ao calcular juros para valor inválido uma exceção deve ser gerada")]
        [InlineData(0, 5)]
        [InlineData(500, 0)]
        [InlineData(-1, 24)]
        [InlineData(1200, -1)]
        public void Ao_Calcular_Juros_Para_Valor_Invalido_Gera_Excecao(decimal valorInicial, int quantidadeMeses)
        {
            var jurosService = new JurosService();

            Assert.Throws<ParametrosDeCalculoInvalidosException>(
                () => { 
                    jurosService.CorrigirValor(valorInicial, quantidadeMeses); 
                });
        }
    }
}
