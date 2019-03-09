using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio14 {
        public void Opers() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese valor a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor d: ");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("------------------------");
            Console.WriteLine("Suma: " + (a + b + c + d));
            Console.WriteLine("Promedio: " + ((a + b + c + d) / 4));
        }
    }
}
