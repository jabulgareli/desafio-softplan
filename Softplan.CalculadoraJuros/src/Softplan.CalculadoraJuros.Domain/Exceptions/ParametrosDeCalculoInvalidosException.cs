using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.CalculadoraJuros.Domain.Exceptions
{
    public class ParametrosDeCalculoInvalidosException : Exception
    {
        public ParametrosDeCalculoInvalidosException() : base("Parâmetros de cálculo inválidos")
        {

        }
    }
}
