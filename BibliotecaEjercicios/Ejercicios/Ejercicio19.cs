using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio19 {
        public void Refri() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese grado: ");
            int a = int.Parse(Console.ReadLine());

            if (a < 6) {
                Console.WriteLine("----------------------");
                Console.WriteLine("Recibe refrigerio");
            }
            else {
                Console.WriteLine("----------------------");
                Console.WriteLine("No recibe refrigerio");
            }
        }
    }
}
