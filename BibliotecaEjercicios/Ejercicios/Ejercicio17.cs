using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio17 {
        public void Num() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese un número: ");
            double a = double.Parse(Console.ReadLine());

            if (a > 0) {
                Console.WriteLine("------------------------");
                Console.WriteLine(a + ", es positivo");
            }
            else if (a == 0) {
                Console.WriteLine("------------------------");
                Console.WriteLine(a + ", es neutro");
            }
            else if (a < 0) {
                Console.WriteLine("------------------------");
                Console.WriteLine(a + ", es negativo");
            }
        }
    }
}
