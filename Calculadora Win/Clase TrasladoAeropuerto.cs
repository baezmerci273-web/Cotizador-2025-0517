using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora_Win
{
    public class Clase_TrasladoAeropuerto
    {
        public int pasajeros { get; set; } = 3;
        public bool nocturno { get; set; }
        public decimal subtotal => pasajeros*25m; 
        public decimal recargo=> nocturno==true ?  subtotal* 0.20m: 0m;
         public decimal total => subtotal + recargo;
        
        

    }
}
