using Moq;
using Softplan.CalculadoraJuros.Domain.Exceptions;
using Softplan.CalculadoraJuros.Domain.Interfaces.Services;
using Softplan.CalculadoraJuros.Domain.Services;
using Softplan.CalculadoraJuros.Domain.ValueObjects;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xunit;

namespace Softplan.CalculadoraJuros.Domain.UnitTests
{
    public class CalculadoraJurosTest
    {
        private readonly ITaxaService _taxaService;

        public CalculadoraJurosTest()
        {
            var taxaServiceMock = new Mock<ITaxaService>();
            taxaServiceMock.Setup(ts => ts.ConsultarTaxaAtualAsync()).Returns(Task.FromResult(Percentual.WithValor(1)));
            _taxaService = taxaServiceMock.Object;
        }

        [Fact(DisplayName = "Ao calcular juros pra R$ 100 em 5 meses então o resultado é R$ 105.10 ")]
        public async Task Ao_Calcular_Juros_Para_100_E_5_Meses_Entao_Retorna_Valor_Atualizado_De_105e10()
        {
            var jurosService = new JurosService(_taxaService);

            var resultadoCalculo = await jurosService.CorrigirValorAsync(100, 5);

            Assert.NotNull(resultadoCalculo);
            Assert.NotNull(resultadoCalculo.DadosSolicitacao);
            Assert.NotNull(resultadoCalculo.DadosSolicitacao.PercentualDeJuros);

            Assert.Equal(1, resultadoCalculo.DadosSolicitacao.PercentualDeJuros.Valor);
            Assert.Equal(105.1m, resultadoCalculo.ValorFinal);
            Assert.Equal(5.1m, resultadoCalculo.JurosAPagar);

        }

        [Theory(DisplayName = "Ao calcular juros para valor inválido uma exceção deve ser gerada")]
        [InlineData(0, 5)]
        [InlineData(500, 0)]
        [InlineData(-1, 24)]
        [InlineData(1200, -1)]
        public async Task Ao_Calcular_Juros_Para_Valor_Invalido_Gera_Excecao(decimal valorInicial, int quantidadeMeses)
        {
            var jurosService = new JurosService(_taxaService);

            await Assert.ThrowsAsync<ParametrosDeCalculoInvalidosException>(
                async () => { 
                    await jurosService.CorrigirValorAsync(valorInicial, quantidadeMeses); 
                });
        }
    }
}
