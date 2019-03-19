using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio34
    {
        public void Edi_Eda_Edo_Edito()
        {
            int val11, val12;
            double val2, val3, val4, val5;

            Console.Clear();
            Console.WriteLine("****Realizar un Programa que determine las siguientes opciones****");
            Console.WriteLine("Paso o no??? Presione 1 para saber");
            Console.WriteLine("Soy mayor de edad o no???");
            val11 = int.Parse(Console.ReadLine());

            switch (val11)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("La opcion: **" + val11 + "** ha sido ingresada");
                    Console.WriteLine("Ingrese su primer nota");
                    val2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese su segunda nota");
                    val3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese su tercera nota");
                    val4 = double.Parse(Console.ReadLine());
                    val5 = (val2 + val3 + val4) / 3;
                    if (val5 <= 2.9)
                    {
                        Console.WriteLine("Ha dejado la materia");
                    }
                    else
                    {
                        Console.WriteLine("Ha pasado la materia");
                    }
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Ha seleccionada la opcion: **" + val11 + "**");
                    Console.WriteLine("Ingrese su edad");
                    val12 = int.Parse(Console.ReadLine());
                    if (val12 >= 18)
                    {
                        Console.WriteLine("Usted es mayor de edad");
                    }
                    else
                    {
                        Console.WriteLine("Usted es menor de edad");
                    }
                    break;

                default:
                    Console.WriteLine("Ha ingresado una opcion incorrecta");
                    break;
            }
        }
    }
}
