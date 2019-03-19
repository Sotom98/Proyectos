using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio38
    {
        public void Dab()
        {
            int val11;
            Console.Clear();
            Console.WriteLine("****Realizar un Programa que determine cuantos estudiantes son mayores de edad en un grupo de 20 estudiantes.****");

            for (int x = 1; x <= 20; x++)
            {
                Console.WriteLine("Ingrese la edad del estudiante " + x);
                val11 = int.Parse(Console.ReadLine());
                if (val11 <= 18)
                {
                    Console.WriteLine("El estudiante es MENOR de EDAD");
                }
                else
                {
                    Console.WriteLine("El estudiante es MAYOR de EDAD");
                }
            }
        }
    }
}
