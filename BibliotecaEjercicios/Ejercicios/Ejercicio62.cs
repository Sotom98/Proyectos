using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio62
    {
        int po = 0, ne = 0, ce = 0;
        public int[] numeros;

        public void cargar()
        {
            numeros = new int[20];

            for (int i = 1; i < 20; i++)
            {

                Console.WriteLine("numero: ");
                String nu;
                nu = Console.ReadLine();
                numeros[i] = int.Parse(nu);

                if (numeros[i] == 0)
                {
                    ce = ce + 1;
                }

                if (numeros[i] > 0)
                {
                    po = po + 1;
                }

                if (numeros[i] < 0)
                {
                    ne = ne + 1;
                }
            }
        }

        public void imprimir() {
            //for (int i = 1; i < 20; i++) {
            //Console.WriteLine(numeros[i]);
            //}
            Console.WriteLine("numeros negarivos: " + ne);
            Console.WriteLine("numeros positivos: " + po);
            Console.WriteLine("numeros cero: " + ne);
            Console.ReadKey();
        }

        public void llamar()
        {
            cargar();
            imprimir();
        }
    }
}

