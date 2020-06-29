using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.CalculadoraJuros.Infrastrucutre.TaxaApi.Exceptions
{
    public class RespostaTaxaInvalidaException : Exception
    {
        public RespostaTaxaInvalidaException() : base("A resposta da api de taxas foi inválida")
        {

        }
    }
}
