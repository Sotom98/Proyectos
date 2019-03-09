using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio21 {
        public void Opers() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese valor a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor b: ");
            double b = double.Parse(Console.ReadLine());

            if (a == b) {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Resta: " + (a - b));
            }
            else {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Suma: " + (a + b));
            }
        }
    }
}
