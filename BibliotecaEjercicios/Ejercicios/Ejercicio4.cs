using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio4 {
        double v, t;
        public void Distan() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese la velocidad: ");
            v = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el tiempo: ");
            t = double.Parse(Console.ReadLine());

            Console.WriteLine("La distancia es: " + (v * t) + " metros");
        }
    }
}
