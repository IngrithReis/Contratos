using Contratos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contratos.Services
{
    interface ITaxa
    {
        public double CobrancaTaxa(double valorParcela, int numeroParcela);

    }
}
