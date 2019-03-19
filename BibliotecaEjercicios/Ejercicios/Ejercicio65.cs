using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio65
    {
        public int[] numeros;

        public void cargar()
        {
            numeros = new int[31];

            for (int i = 1; i < 31; i++)
            {
                Console.WriteLine("Ingrese los clientes totales del dia " + i + ": ");
                String nu;
                nu = Console.ReadLine();
                numeros[i] = int.Parse(nu);
            }
        }

        public void mostrar()
        {
            for (int i = 0; i < 31; i++)
            {
                Console.WriteLine("Clientes del dia " + i + ": ");
                Console.WriteLine(numeros[i]);

            }
        }

        public void llamar()
        {
            cargar();
            mostrar();
        }
    }
}
