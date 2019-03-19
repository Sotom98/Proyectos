using System;

namespace Ejercicios
{
    public class Ejercicio78
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

        public void SumaEncima()
        {
            int suma= 0;
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    if (c>f)
                    {
                        suma += mat[f, c];
                    }
                }
            }
            Console.WriteLine("La suma de la Diagonal Encima :" + suma);

        }

        public void SumaDebajo()
        {
            int suma = 0;
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    if (f>c)
                    {
                        suma += mat[f, c];
                    }
                }
            }
            Console.WriteLine("La suma de la Diagonal Debajo :" + suma);

        }
        public void llamar()
        {
            
            Cargar();
            SumaEncima();
            SumaDebajo();
            Console.ReadKey();
        }
    }
}
