﻿using Contratos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contratos.Services
{
    class ParcelaService
    {
        public int QuantidadeParcelas  { get; set; }
        
        public Contrato Contrato { get; set; }

        
        public double ValorParcela { get { return Contrato.ValorContrato/ QuantidadeParcelas; } }

        public ParcelaService(int quantidadeParcelas, Contrato contrato, double montante)
        {
            QuantidadeParcelas = quantidadeParcelas;
            Contrato = contrato;
         
        }
        

        
    }
}
