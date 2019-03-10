using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio28 {
        public void Par() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese un número: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");

            double b = a % 2;

            if (b == 0) {
                Console.WriteLine(a + ", es par");
            }
            else {
                Console.WriteLine(a + ", es impar");
            }

        }
    }
}
