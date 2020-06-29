using Microsoft.Extensions.DependencyInjection;
using Softplan.CalculadoraJuros.Application.Interfaces;
using Softplan.CalculadoraJuros.Application.Services;
using Softplan.CalculadoraJuros.Domain.Interfaces.Services;
using Softplan.CalculadoraJuros.Domain.Services;
using Softplan.CalculadoraJuros.Infrastrucutre.TaxaApi.Services;
using System;

namespace Softplan.CalculadoraJuros.Cross.IoC.DI
{
    public static class Bootstraper
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IJurosService, JurosService>();
            serviceCollection.AddScoped<ITaxaService, TaxaService>();
            serviceCollection.AddScoped<IJurosAppService, JurosAppService>();
        }
    }
}
