using Contratos.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contratos.Entities
{
    class Contrato
    {
        public int NumeroContrato { get; set; }
        public DateTime DataContrato { get; set; }

        public double ValorContrato { get; set; }

        private ITaxa _taxaPaPal;

        public List<Parcelas> parcela = new List<Parcelas>();

        public Contrato(int numeroContrato, DateTime dataContrato, double valorContrato, ITaxa meioDePagamento = null)
        {
            NumeroContrato = numeroContrato;
            DataContrato = dataContrato;
            ValorContrato = valorContrato;
            _taxaPaPal = meioDePagamento;
           
        }

        public void GerarParcelas( int qtParcelas )
        {
            
            double vparcela = ValorContrato / qtParcelas;
            for (int i = 0; i < qtParcelas; i++)
            {    
                Parcelas parc = new Parcelas(DataContrato.AddMonths(i+1),_taxaPaPal.CobrancaTaxa(vparcela, i+1) + vparcela);
                parcela.Add(parc);
                
            }
        }  
        
      
        
    }
}
