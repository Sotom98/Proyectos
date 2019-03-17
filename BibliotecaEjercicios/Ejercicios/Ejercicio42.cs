using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio42
    {
        public void ejer42() {
            int I;
            double estatura, acumulador = 0, prom = 0;

            for (I = 1; I < 19; I++)
            {
                Console.WriteLine("ingrese la estatura de los estudiantes ");
                estatura = double.Parse(Console.ReadLine());

                acumulador = (acumulador + estatura);
                prom = acumulador / I;


            }

            if (prom < 140)
            {
                Console.WriteLine("el promedio de la edad es: " + (prom));
                Console.WriteLine("Estudiantes muy bajos");
            }
            else if ((prom >= 140 & prom <= 170))
            {
                Console.WriteLine("el promedio de la edad es: " + (prom));
                Console.WriteLine("Estudiantes de estaturanormal");
            }
            else if (prom > 170)
            {
                Console.WriteLine("el promedio de la edad es: " + (prom));
                Console.WriteLine("Estudiant es muy bajos");
            }

        }
    }
}
