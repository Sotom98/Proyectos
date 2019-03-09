using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio10 {
        public void Fact() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Precio unitario: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Cantidad: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");

            Console.WriteLine("Subtotal: " + (a * b));
            Console.WriteLine("IVA: " + ((a * b) * 0.13));
            Console.WriteLine("Total: " + ((a * b) + ((a * b) * 0.13)));
        }
    }
}
