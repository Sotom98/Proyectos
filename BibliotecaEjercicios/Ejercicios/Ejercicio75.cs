using System;

namespace Ejercicios
{
    public class Ejercicio75
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

         public void SumaFila()
        {
            double sumf = 0;
            for(int f=0; f<mat.GetLength(0);f++)
            {
                for (int c=0;c<mat.GetLength(1);c++)
                {
                    if (f>sumf)
                    {
                        sumf += mat[f, f];
                    }
                }
            }

            Console.WriteLine("La suma es :"+sumf);
            Console.Write(" ");
        }
         public void llamar()
        {
 
            Cargar();
            SumaFila();
            Console.ReadKey();
        }
    }
}
