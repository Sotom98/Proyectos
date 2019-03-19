using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio67
    {
        public int[] vector1;
        public int[] cuadrado;
        public int[] cubo;

        public int posc;

        public void captura1() {
            Console.WriteLine("¿Cuantas posiciones quiere en su vector?");
            posc = int.Parse(Console.ReadLine());

            vector1 =new int[posc];

            for (int i = 0; i < posc; i++)
            {
                Console.WriteLine("Ingrese valor para la posicion " + i + ": ");
                String nu;
                nu = Console.ReadLine();
                vector1[i] = int.Parse(nu);
            }
        }

        public void mostrarcuadrado() {
            cuadrado = new int[posc];
            Console.WriteLine("CUADRADO DE CADA POSICION DEL VECTOR 1");
            for (int i = 0; i < posc; i++)
            {
                cuadrado[i] = vector1[i]*vector1[i];
                Console.WriteLine(cuadrado[i]);
            }

        }

        public void mostrarcubo()
        {
            cubo = new int[posc];
            Console.WriteLine("CUBO DE CADA POSICION DEL VECTOR 1");
            for (int i = 0; i < posc; i++)
            {
                cubo[i] = vector1[i] * vector1[i] * vector1[i];
                Console.WriteLine(cubo[i]);
            }

        }

        public void llamar()
        {
            captura1();
            mostrarcuadrado();
            mostrarcubo();
        }


    }
}
