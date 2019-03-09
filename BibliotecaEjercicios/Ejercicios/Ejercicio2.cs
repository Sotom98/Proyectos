using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio2 {
        double a, b, c;
        public void Multi() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese valor a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor c: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("La multiplicación es: " + (a * b * c));
        }
    }
}
