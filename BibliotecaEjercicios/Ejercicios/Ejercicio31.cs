using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio31
    {
        public void Voca()
        {

            Console.Clear();
            Console.WriteLine("****Realizar un programa que permita determinar si una letra es o no vocal****");
            Console.WriteLine("Ingrese una letra");
            string Nombre1 = Console.ReadLine();

            switch (Nombre1)
            {
                case "a":
                    Console.WriteLine("Ha ingresado una vocal");
                    break;

                case "e":
                    Console.WriteLine("Ha ingresado una vocal");
                    break;

                case "i":
                    Console.WriteLine("Ha ingresado una vocal");
                    break;

                case "o":
                    Console.WriteLine("Ha ingresado una vocal");
                    break;

                case "u":
                    Console.WriteLine("Ha ingresado una vocal");
                    break;

                default:
                    Console.WriteLine("Ha ingresado una consonante");
                    break;
            }
        }
    }
}
