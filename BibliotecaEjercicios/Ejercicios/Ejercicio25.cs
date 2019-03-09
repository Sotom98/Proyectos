using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio25 {
        public void Promo() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese nota 1: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese nota 2: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese nota 3: ");
            double n3 = double.Parse(Console.ReadLine());

            double prom = (n1 + n2 + n3) / 3;
            Console.WriteLine("-------------------------");
            Console.WriteLine("Promedio: " + prom);

            if (prom >= 7) {
                Console.WriteLine("Promocionado");
            }
            else {
                Console.WriteLine("No promocionado");
            }
        }

    }
}