using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio5 {
        public void Edad() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese año actual: ");
            int yra = int.Parse(Console.ReadLine());
            Console.Write("Ingrese año de nacimiento: ");
            int yrn = int.Parse(Console.ReadLine());

            Console.WriteLine("Su edad es: " + (yra - yrn) + " años");
        }
    }
}
