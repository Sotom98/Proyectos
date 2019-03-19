using System;

namespace Ejercicios
{
    public class Ejercicio74
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

        public void Buscar()
        {
            int filabus = 0;
            int columbus = 0;
            int bus;
           
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.WriteLine("Ingrese Numero de Busqueda");
                    bus = int.Parse(Console.ReadLine());
                    bus = mat[f, c];
                    filabus = f;
                    columbus = c;
                }
            }
            Console.WriteLine("Fla en la que se encuentra " + filabus + "y en la columna " + columbus);
        }

        public void llamar()
        {
           
            Cargar();
            Buscar();
            Console.ReadKey();
        }
    }
}
