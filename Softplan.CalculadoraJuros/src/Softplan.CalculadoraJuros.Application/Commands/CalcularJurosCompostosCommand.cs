using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.CalculadoraJuros.Application.Commands
{
    public class CalcularJurosCompostosCommand
    {
        public decimal ValorInicial { get; set; }
        public int Meses { get; set; }
    }
}
