using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios {
    public class Ejercicio22 {
        public void Nota() {
            Console.WriteLine("----------------------------------------");
            Console.Write("Ingrese nombre de estudiante: ");
            string a = Console.ReadLine();
            Console.Write("Ingrese código de estudiante: ");
            string b = Console.ReadLine();
            Console.WriteLine("--------------------------");
            Console.Write("Ingrese materia: ");
            string c = Console.ReadLine();
            Console.WriteLine("--------------------------\nNotas (entre 1.0 - 5.0)");
            Console.Write("Ingrese nota 1: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese nota 2: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese nota 3: ");
            double n3 = double.Parse(Console.ReadLine());

            double prom = (n1 + n2 + n3) / 3;

            Console.WriteLine("--------------------------");
            Console.WriteLine("Estudiante: " + a);
            Console.WriteLine("Código: " + b);
            Console.WriteLine("Materia: " + c);

            if (prom > 4) {
                Console.WriteLine("Aprobada");
            }
            else {
                Console.WriteLine("Reprobada");
            }

        }
    }
}
