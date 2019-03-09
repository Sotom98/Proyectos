using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio26 {
        public void Cifras() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese un número entre 1 - 99: ");
            double a = double.Parse(Console.ReadLine());

            double x = a / 10;
            Console.WriteLine("-----------------------------------");

            if (x > 1) {
                Console.WriteLine(a + ", tiene dos cifras");
            }
            else {
                Console.WriteLine(a + ", tiene una cifra");
            }
             
        }
    }
}
