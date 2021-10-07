using Contratos.Entities;
using Contratos.Services;
using System;
using System.Globalization;

namespace Contratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informações de contrato: ");
            Console.Write("Número do contrato: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Data de início (dd/mm/yy): ");
            DateTime dataInicial = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Valor do contrato: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Número de Parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            Contrato a = new Contrato(numero, dataInicial, valor, new TaxaPaypalService());

            a.GerarParcelas(parcelas);

            Console.WriteLine(a.ImprimirParcelas());
            
            
            


        }
    }
}
