using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio7 {
        public void Porcen() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese un número: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Su 30% es: " + (a * 0.3));
            Console.WriteLine("Su 60% es: " + (a * 0.6));
            Console.WriteLine("Su 90% es: " + (a * 0.9));
        }
    }
}
