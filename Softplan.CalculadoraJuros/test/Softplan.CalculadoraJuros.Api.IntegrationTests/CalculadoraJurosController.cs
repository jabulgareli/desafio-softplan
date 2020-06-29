using Microsoft.AspNetCore.Http;
using Softplan.CalculadoraJuros.Api.IntegrationTests.Fixtures;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Softplan.CalculadoraJuros.Api.IntegrationTests
{
    public class CalculadoraJurosController : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly CustomWebApplicationFactory _factory;
        private readonly HttpClient _client;

        public CalculadoraJurosController(CustomWebApplicationFactory factory)
        {
            _factory = factory;
            _client = _factory.CreateClient();
        }

        [Fact(DisplayName = "Ao calcular juros com valores válidos, deve-se retornar status OK e conteúdo na resposta")]
        public async Task Ao_Calcular_Juros_Com_Valores_Validos_Deve_Retornar_Status_Ok_E_Conteudo_Na_Resposta()
        {
            var response = await _client.GetAsync("/api/juros/calculaJuros?valorInicial=100&meses=5");

            response.EnsureSuccessStatusCode();
            Assert.NotNull(await response.Content.ReadAsStringAsync());
            Assert.True((await response.Content.ReadAsStringAsync())?.Length > 0);
        }

        [Fact(DisplayName = "Ao calcular a taxa de juros com valores inválidos, deve-se retornar status Bad Request")]
        public async Task Ao_Calcular_Juros_Com_Valores_Invalidos_Deve_Retornar_Status_Bad_Request()
        {
            var response = await _client.GetAsync("/api/juros/calculaJuros?valorInicial=100&meses=0");

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}
