using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio13 {
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
            Console.Write("Ingrese valor e: ");
            double e = double.Parse(Console.ReadLine());

            double resul1 = a + b;
            double resul2 = c * d;

            Console.WriteLine("--------------------");
            Console.WriteLine("a + b: " + resul1);
            Console.WriteLine("c * d: " + resul2);
            Console.WriteLine("(a + b) / e: " + (resul1 / e));
            Console.WriteLine("(c * d) / e: " + (resul2 / e));

        }
    }
}
