using Contratos.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Contratos.Entities
{
    class Contrato
    {
        public int NumeroContrato { get; set; }
        public DateTime DataContrato { get; set; }

        public double ValorContrato { get; set; }

        private ITaxa _taxaPaPal;

        public List<Parcelas> Parcelas { get; set; } = new List<Parcelas>();

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
                Parcelas.Add(parc);
                
            }
        }

        public string ImprimirParcelas()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine("Dados das parcelas: ");
            foreach (var parcela in Parcelas)
            {
                sb.Append(parcela.DataParcela.ToString("d") + "-");
                sb.AppendLine(parcela.ValorParcela.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));

                // sb.AppendLine(FormattableString.Invariant( $"{parcela.DataParcela:d} - {parcela.ValorParcela:f2} ")); no caso de interpolação, a data passa a ser no formato dd/MM/yyyy

            }

            return sb.ToString();
                        
        }



    }
}
