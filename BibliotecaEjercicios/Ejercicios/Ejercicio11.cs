using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio11 {
        public void Salario() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese salario por dia: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese dias trabajados: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");

            Console.WriteLine("Salario bruto: " + (a * b));
            Console.WriteLine("AFP: " + ((a * b) * 0.10));
            Console.WriteLine("ISSS: " + ((a * b) * 0.15));
            Console.WriteLine("Salario neto: " + ((a * b) - (((a * b) * 0.10) + ((a * b) * 0.15))));
            

        }
    }
}
