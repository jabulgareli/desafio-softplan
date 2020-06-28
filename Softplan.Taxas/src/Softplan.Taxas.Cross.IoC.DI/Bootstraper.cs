using Microsoft.Extensions.DependencyInjection;
using Softplan.Taxas.Application.Interfaces;
using Softplan.Taxas.Application.Services;
using System;

namespace Softplan.Taxas.Cross.IoC.DI
{
    public static class Bootstraper
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ITaxaAppService, TaxaAppService>();
        }
    }
}
