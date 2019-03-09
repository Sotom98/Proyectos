using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio1 {
        double a, b;
        public void Suma() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese valor a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor b: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("La suma es: " + (a + b));
        }
    }
}
