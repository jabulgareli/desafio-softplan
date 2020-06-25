using Softplan.Taxas.Api.IntegrationTests.Fixtures;
using System;
using System.Net.Http;
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

        [Fact]
        public void Test1()
        {

        }
    }
}
