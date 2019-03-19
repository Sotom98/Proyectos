using System;

namespace Ejercicios
{
    public class Ejercicio73
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

        public void Positivos()
        {
            int pos = mat[0, 0];
            int neg = mat[0, 0];
            int cero= mat[0, 0];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    if (mat[f, c]>0)
                    {
                        pos = mat[f, c];
                    }
                    else if (mat[f, c] < 0)
                    {
                        neg = mat[f, c];
                    }

                    else
                    {
                        cero= mat[f, c];
                    }
                }
                Console.WriteLine("Numero Positivo" + pos);
                Console.WriteLine("Numero Negativo" + neg);
                Console.WriteLine("Numero Ceros" + cero);
            }
        }
        public void llamar()
        {
            
            Cargar();
            Positivos();
            Console.ReadKey();
        }
    }
}
