using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora_Win
{
    public class ConsumidorMiniBar
    {
        public int cantidad { get; set; } = 9;
        public decimal precioUnitario { get; set; } =3.5m;

        public decimal subtotal => cantidad * precioUnitario;
        public decimal itbis => subtotal * 0.18m;

        public decimal total=>subtotal+ itbis;

    }
}
