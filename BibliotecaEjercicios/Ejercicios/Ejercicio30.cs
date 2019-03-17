using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio30 {
        public void Total() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese total compra: ");
            double a = double.Parse(Console.ReadLine());

            if ((a >= 10000) && (a <= 20000)) {
                double desc = a * 0.10;
                Console.WriteLine("---------------------------");
                Console.WriteLine("Descuento: " + desc);
                Console.WriteLine("Total a pagar: " + (a - desc));
            }
            else if ((a >= 20001) && (a <= 50000)) {
                double desc = a * 0.20;
                Console.WriteLine("---------------------------");
                Console.WriteLine("Descuento: " + desc);
                Console.WriteLine("Total a pagar: " + (a - desc));
            }
            else if (a > 50000) {
                double desc = a * 0.50;
                Console.WriteLine("---------------------------");
                Console.WriteLine("Descuento: " + desc);
                Console.WriteLine("Total a pagar: " + (a - desc));
            }
        }
    }
}
