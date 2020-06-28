using Softplan.CalculadoraJuros.Domain.Exceptions;
using Softplan.CalculadoraJuros.Domain.Services;
using System;
using Xunit;

namespace Softplan.CalculadoraJuros.Domain.UnitTests
{
    public class CalculadoraJurosTest
    {
        [Theory]
        [InlineData(100, 5)]
        [InlineData(500, 10)]
        [InlineData(1500, 24)]
        public void Ao_Calcular_Juros_Para_Valor_E_Mes_Validos_Entao_Retorna_Valor_Atualizado(decimal valorInicial, int quantidadeMeses)
        {
            var jurosService = new JurosService();

            var resultadoCalculo = jurosService.CorrigirValor(valorInicial, quantidadeMeses);

            Assert.NotNull(resultadoCalculo);
            Assert.True(resultadoCalculo.ValorFinal > 0);
            Assert.True(resultadoCalculo.Juros > 0);

        }

        [Theory]
        [InlineData(0, 5)]
        [InlineData(500, 0)]
        [InlineData(-1, 24)]
        [InlineData(1200, -1)]
        public void Ao_Calcular_Juros_Para_Valor_Valido_Gera_Excecao(decimal valorInicial, int quantidadeMeses)
        {
            var jurosService = new JurosService();

            Assert.Throws<ParametrosDeCalculoInvalidosException>(
                () => { 
                    jurosService.CorrigirValor(valorInicial, quantidadeMeses); 
                });
        }
    }
}
