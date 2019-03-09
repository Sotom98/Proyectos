using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio23 {
        public void Pagar() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese precio unitario: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad: ");
            int b = int.Parse(Console.ReadLine());

            double stotal = a * b;
            Console.WriteLine("--------------------------");
            Console.WriteLine("Subtotal: " + stotal);

            if (stotal > 100000) {
                Console.WriteLine("Descuento 20%: " + (stotal * 0.2));
                Console.WriteLine("Total a pagar: " + (stotal - (stotal * 0.2)));
            }
            else {
                Console.WriteLine("Sin descuento\nTotal a paga: " + stotal);
            }
        }
    }
}
