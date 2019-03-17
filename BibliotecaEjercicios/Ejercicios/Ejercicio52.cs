using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio52
    {
        public void Deaf()
        {
            int c_notas = 0;
            double notas = 0.0;
            double Prom = 0.0;
            double Acu = 0.0;

            Console.WriteLine("Ingrese la cantidad de notas que desea calificar");
            c_notas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese las notas a continuacion");

            for (int i = 0; i < c_notas; i++)
            {
                notas = double.Parse(Console.ReadLine());

                Acu = notas + notas;

            }

            Prom = (Acu / c_notas);
            Console.WriteLine("El promedio es: "+Prom);

            if (Prom>4)
            {
                Console.WriteLine("Usted ha aprobado");
            } else
            {
                if (Prom<4)
                {
                    Console.WriteLine("Usted ha reprobado");
                }
            }
            
        }
    }
}
