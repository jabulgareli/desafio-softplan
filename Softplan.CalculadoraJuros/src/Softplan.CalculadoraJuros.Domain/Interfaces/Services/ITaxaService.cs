using Softplan.CalculadoraJuros.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.CalculadoraJuros.Domain.Interfaces.Services
{
    public interface ITaxaService
    {
        Task<Percentual> ConsultarTaxaAtualAsync();
    }
}
