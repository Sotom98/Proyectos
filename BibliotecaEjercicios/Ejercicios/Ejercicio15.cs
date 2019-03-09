using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio15 {
        public void Cred() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese precio unitario: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------");
            Console.WriteLine("Saldo: " + (a * b));

        }
    }
}
