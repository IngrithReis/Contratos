
using System;


namespace Contratos.Entities
{
    class Parcelas
    {
        public DateTime DataParcela { get; set; }

        public double ValorParcela { get; private set; }


        public Parcelas(DateTime dataParcela, double valorParcela)
        {
            DataParcela = dataParcela;
            ValorParcela = valorParcela;
        }

        

    }
}
