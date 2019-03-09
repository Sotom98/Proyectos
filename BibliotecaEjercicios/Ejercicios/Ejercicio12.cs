using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio12 {
        public void Perim() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese lado de cuadrado: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Perímetro: " + (a * 4));
        }
    }
}
