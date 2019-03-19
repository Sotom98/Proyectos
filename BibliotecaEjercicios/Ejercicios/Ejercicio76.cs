using System;

namespace Ejercicios
{
    class Ejercicio76
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

        public void SumaCol()
        {
            double sumc = 0;
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    if (f > sumc)
                    {
                        sumc += mat[c, c];
                    }
                }
            }

            Console.WriteLine("La suma es :" + sumc);
            Console.Write(" ");
        }
        public void llamar()
        {
            Ejercicio76 obj = new Ejercicio76();
            obj.Cargar();
            obj.SumaCol();
            Console.ReadKey();
        }
    }
}
