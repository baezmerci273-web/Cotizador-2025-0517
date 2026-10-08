using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora_Win
{
    public class Excursion
    {
        public int persona { get; set; } = 5;
        public decimal precioPorPersona { get; set; } = 80m;

        public decimal subtotal => persona * precioPorPersona;
        public decimal descuento => persona >= 4 ? subtotal * 0.10m : 0;
        public decimal total => subtotal - descuento;
    }
}
