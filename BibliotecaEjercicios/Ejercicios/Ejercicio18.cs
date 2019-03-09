using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio18 {
        public void MayMen() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese valor a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese valor b: ");
            double b = double.Parse(Console.ReadLine());

            if (a > b) {
                Console.WriteLine("------------------------");
                Console.WriteLine("a es mayor que b");
            }
            else {
                Console.WriteLine("------------------------");
                Console.WriteLine("b es mayor que a");
            }
        }
    }
}
