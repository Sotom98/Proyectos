using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio9 {
        public void Prom() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese valor a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor d: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor e: ");
            double e = double.Parse(Console.ReadLine());

            Console.WriteLine("El promedio es: " + ((a + b + c + d + e) / 5));
        }
    }
}
