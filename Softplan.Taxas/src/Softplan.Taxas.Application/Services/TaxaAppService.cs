using Softplan.Taxas.Application.Interfaces;
using Softplan.Taxas.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Softplan.Taxas.Application.Services
{
    public class TaxaAppService : ITaxaAppService
    {
        public Taxa ObterTaxa()
        {
            return new Taxa();
        }
    }
}
