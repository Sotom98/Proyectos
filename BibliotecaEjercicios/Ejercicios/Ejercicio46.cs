using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio46
    {
        public void ejer46() {
            int I;
            double notas, prom = 0, contador = 0;


            for (I = 1; I < 16; I++)
            {
                Console.WriteLine("ingrese las notas: ");
                notas = double.Parse(Console.ReadLine());
                contador = contador + notas;
                prom = contador / I;

            }
            if (prom >= 4)
            {
                Console.WriteLine("SE gano la materia de Programación De Software : ");
            }
            else
            {
                Console.WriteLine("NO gano la materia de Programación De Software : ");
            }

        }
    }
}
