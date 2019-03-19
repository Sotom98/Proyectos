using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio32
    {
        public void Duca()
        {
            int val11;
            double val1, val2, val3;

            Console.Clear();
            Console.WriteLine("****Realizar un programa que permita calcular la velocidad, tiempo y distancia recorridos****");
            Console.WriteLine("Si desea calcular la distancia presione 1");
            Console.WriteLine("Si desea calcular la velocidad que posee un cuerpo presione 2");
            Console.WriteLine("Si desea calcular el tiempo del recorrido presione 3");
            val11 = int.Parse(Console.ReadLine());

            switch (val11)
            {
                case 1:
                    Console.WriteLine("Formula: X= v.t/2");
                    Console.WriteLine("ingrese el valor de la velocidad");
                    val1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del tiempo");
                    val2 = double.Parse(Console.ReadLine());
                    val3 = (val1 * val2) / 2;
                    Console.WriteLine("El resultado es: " + val3);
                    break;

                case 2:
                    Console.WriteLine("Formula: X= d/t");
                    Console.WriteLine("ingrese el valor de la distancia");
                    val1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del tiempo");
                    val2 = double.Parse(Console.ReadLine());
                    val3 = (val1 / val2);
                    Console.WriteLine("El resultado es: " + val3);
                    break;

                case 3:
                    Console.WriteLine("Formula: X= d/t");
                    Console.WriteLine("ingrese el valor de la distancia");
                    val1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del tiempo");
                    val2 = double.Parse(Console.ReadLine());
                    val3 = (val1 / val2);
                    Console.WriteLine("El resultado es: " + val3);
                    break;

                default:
                    Console.WriteLine("Ha ingresado una opcion incorrecta");
                    break;
            }
        }
    }
}
