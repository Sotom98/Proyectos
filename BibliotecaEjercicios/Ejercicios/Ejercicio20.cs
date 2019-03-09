using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio20 {
        public void Midtad() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese un número: ");
            double a = double.Parse(Console.ReadLine());

            double mid = a / 2;

            if (mid > 100) {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Mitad: " + mid);
                Console.WriteLine("Mayor que 100");
            }
            else {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Mitad: " + mid);
                Console.WriteLine("Menor que 100");
            }
        }
    }
}
