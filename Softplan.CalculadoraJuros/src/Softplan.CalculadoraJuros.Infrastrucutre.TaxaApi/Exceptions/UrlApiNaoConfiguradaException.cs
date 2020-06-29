using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.CalculadoraJuros.Infrastrucutre.TaxaApi.Exceptions
{
    public class UrlApiNaoConfiguradaException : Exception
    {
        public UrlApiNaoConfiguradaException() : base("Url da api não foi configurada")
        {

        }
    }
}
