using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora_Win
{
    public class Reserva
    {
        private const decimal TasaItebis = 0.18m;
        private const decimal TasaServicio = 0.10m;
        private const decimal TasaDescuento = 0.10m; 
        private const decimal RecargoTemporadaAlta=0.25m;
        private const int NochesParaDescueto = 7;

        public string Huesped { get; set; } = "";

        public int Noches { get; set; } 
        public decimal TarifaPorNoche {  get; set; }
        public bool esTemporadaAlta { get; set; }

        public decimal Subtotal => esTemporadaAlta ? Noches * TarifaPorNoche *
            (1 + RecargoTemporadaAlta) : Noches * TarifaPorNoche;

        public decimal descuento => Noches >= NochesParaDescueto ? Subtotal * TasaDescuento : 0m;

        public decimal BaseImponible => Subtotal - descuento;
        public decimal Itbis => BaseImponible * TasaItebis;
        public decimal Servicio => BaseImponible * TasaServicio;

        public decimal Total => BaseImponible + Itbis + Servicio;
    }
}
