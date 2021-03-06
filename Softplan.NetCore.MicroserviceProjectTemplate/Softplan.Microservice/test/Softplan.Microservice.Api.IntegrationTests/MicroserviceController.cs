using Softplan.Microservice.Api.IntegrationTests.Fixtures;
using System;
using System.Net.Http;
using Xunit;

namespace Softplan.Microservice.Api.IntegrationTests
{
    public class MicroserviceController : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly CustomWebApplicationFactory _factory;
        private readonly HttpClient _client;

        public MicroserviceController(CustomWebApplicationFactory factory)
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
