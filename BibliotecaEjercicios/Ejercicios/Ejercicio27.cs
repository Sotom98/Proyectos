using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio27 {
        public void Pagar() {
            int des;

            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese precio unitario: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");

            double total = a * b;

            if (total < 20000) {
                total = total - (total * 0.15);
                des = 15;
            }
            else {
                total = total - (total * 0.35);
                des = 35;
            }

            Console.WriteLine(total);
            Console.WriteLine("Descuento " + des + "%");
            Console.WriteLine("Total a pagar: " + total);
            Console.ReadKey();
        }
    }
}
