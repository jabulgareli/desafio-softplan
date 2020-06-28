using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Taxas.Domain.ValueObjects
{
    public class Taxa
    {
        private const decimal MULTIPLICADOR_ATUAL = 0.01m; //REQUISITO NO DESAFIO (fixo no código)
        public decimal Multiplicador =>
                MULTIPLICADOR_ATUAL;
    }
}
