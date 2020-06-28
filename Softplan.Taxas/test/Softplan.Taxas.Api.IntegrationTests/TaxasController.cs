using Softplan.Taxas.Api.IntegrationTests.Fixtures;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Softplan.Taxas.Api.IntegrationTests
{
    public class TaxasController : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly CustomWebApplicationFactory _factory;
        private readonly HttpClient _client;

        public TaxasController(CustomWebApplicationFactory factory)
        {
            _factory = factory;
            _client = _factory.CreateClient();
        }

        [Fact(DisplayName = "Ao consultar a taxa de juros, deve-se retornar status OK e conteúdo na resposta")]
        public async Task Ao_Consultar_Taxa_Deve_Retornar_Http200_E_Conteudo()
        {
            var response = await _client.GetAsync("/api/taxas/taxajuros");

            response.EnsureSuccessStatusCode();
            Assert.NotNull(await response.Content.ReadAsStringAsync());
            Assert.True((await response.Content.ReadAsStringAsync())?.Length > 0);
        }
    }
}
