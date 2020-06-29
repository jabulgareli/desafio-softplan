using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.CalculadoraJuros.Domain.ValueObjects
{
    public sealed class Percentual
    {
        public decimal Valor { get; set; }
        public decimal Multiplicador { get; set; }

        public Percentual(decimal valor, decimal multiplicador)
        {
            Valor = valor;
            Multiplicador = multiplicador;
        }

        public static Percentual WithValor(decimal valor)
        {
            return new Percentual(valor, valor / 100);
        }

        public static Percentual WithMultiplicador(decimal multiplicador)
        {
            return new Percentual(multiplicador*100, multiplicador);
        }
    }
}
