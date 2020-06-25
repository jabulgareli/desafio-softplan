using Softplan.CalculadoraJuros.Api.IntegrationTests.Fixtures;
using System;
using System.Net.Http;
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

        [Fact]
        public void Test1()
        {

        }
    }
}
