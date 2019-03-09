using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio6 {
        public void Porcen() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese un número: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Su 20% es: " + (a * 0.2));
        }
    }
}
