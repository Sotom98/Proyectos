using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio24 {
        public void Opers() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese valor a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");

            if (a > b) {
                Console.WriteLine("Suma: " + (a + b));
                Console.WriteLine("Resta: " + (a - b));
            }
            else {
                Console.WriteLine("Multiplicación: " + (a * b));
                Console.WriteLine("División: " + (a / b));
            }
        }
    }
}
