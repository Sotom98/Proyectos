using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio64
    {
        public int[] numeros;

        public void cargar()
        {

            numeros = new int[18];

            for (int i = 0; i < 18; i++)
            {
                Console.WriteLine("Ingrese los numeros: ");
                String nu;
                nu = Console.ReadLine();
                numeros[i] = int.Parse(nu);
            }
        }

        public void mostrar()
        {
            for (int i=18; i>0; i--) {

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
