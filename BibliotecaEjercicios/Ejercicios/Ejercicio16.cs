using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio16 {
        public void Edad() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese año actual: ");
            int yra = int.Parse(Console.ReadLine());
            Console.Write("Ingrese año de nacimiento: ");
            int yrn = int.Parse(Console.ReadLine());

            int edad = yra - yrn;

            if (edad >= 18) {
                Console.WriteLine("--------------------");
                Console.WriteLine("Edad: " + edad);
                Console.WriteLine("Mayor de edad");
            }
            else {
                Console.WriteLine("--------------------");
                Console.WriteLine("Edad: " + edad);
                Console.WriteLine("Menor de edad");
            }
        }
    }
}
