using Contratos.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Contratos.Entities;

namespace Contratos.Services
{
    class TaxaPaypalService : ITaxa
    {
       
        public double CobrancaTaxa( double valorParcela, int numeroParcela)
        {
                double valor = valorParcela * 0.01 * (double)numeroParcela; 
                return valor +((valorParcela + valor)  * 0.02);   
        }
    }
}
