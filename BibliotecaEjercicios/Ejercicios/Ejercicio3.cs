using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio3 {
        double a, b;
        public void Divi() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese valor a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor b: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("La división es: " + (a / b));
        }
    }
}
