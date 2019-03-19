using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio69
    {
        private int[,] mat;

        public void Cargar()
        {
            Console.WriteLine("Cuantas Filas Tiene la Matriz:  ");
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);
            Console.WriteLine("Cuantas Columnas Tiene la Matriz :");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);
            mat = new int[filas, columnas];

            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.WriteLine("Ingrese Miembro de la Matriz");
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);

                }
            }
        }

        public void Sumar()
        {
            double suma = 0;
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    suma = suma + mat[f, c];
                }
            }
            Console.WriteLine("La suma de la Matriz es: " + suma);
        }

        public void Promedio()
        {
            double Prom = 0;
            int suma = 0;
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    suma = suma + mat[f, c];
                    Prom = suma / 12;
                }
            }
            Console.WriteLine("El promedio de la Matriz es: " + Prom);
        }
        public void llamar()
        {

            Cargar();
            Sumar();
            Promedio();
            Console.ReadKey();
        }
    }
}
