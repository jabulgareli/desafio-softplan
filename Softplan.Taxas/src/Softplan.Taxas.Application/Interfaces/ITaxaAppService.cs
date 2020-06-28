using Softplan.Taxas.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.Taxas.Application.Interfaces
{
    public interface ITaxaAppService
    {
        Taxa ObterTaxa();
    }
}
