using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio39
    {
        public void Esss()
        {
            string Nombre1;
            int i = 0;
            int J = 0;
            Console.Clear();
            Console.WriteLine("****Realizar un Programa que determine cuantos estudiantes son mayores de edad en un grupo de 20 estudiantes.****");

            for (int x = 1; x <= 25; x++)
            {
                Console.WriteLine("Ingrese M si usted es muejer o H si usted es hombre");
                Nombre1 = Console.ReadLine();
                switch (Nombre1)
                {
                    case "H":
                        i = i + 1;
                        break;

                    case "Hombre":
                        i = i + 1;
                        break;

                    case "hombre":
                        i = i + 1;
                        break;

                    case "M":
                        J = J + 1;
                        break;

                    case "Mujer":
                        J = J + 1;
                        break;

                    case "mujer":
                        J = J + 1;
                        break;

                    default:
                        Console.WriteLine();
                        break;
                }
                Console.WriteLine("Hay " + i + " de hombres");
                Console.WriteLine("Hay " + J + " de mujeres");
            }
        }
    }
}
