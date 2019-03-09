using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio8 {
        public void Area() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese lado de cuadrado: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Area igual a: " + Math.Pow(a, 2) + " unidades cuadradas");
        }
    }
}
