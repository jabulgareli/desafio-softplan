using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.CalculadoraJuros.Api.IntegrationTests.Fixtures
{
    public class CustomWebApplicationFactory : WebApplicationFactory<Api.Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.UseEnvironment("Test");
            builder.UseStartup(typeof(Api.Startup));
        }
    }
}
