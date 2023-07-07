using System;

namespace MetodoSarrus
{
    internal class Program
    {
        static void Main()
        {
            double[,] matriz = new double[3, 3] ;
            double[,] matriz2 = new double[3, 5];
            Console.WriteLine("Ingresa una matriz de orden 3");
            Cargar(matriz);
            Mostrar(matriz);
            RellenarMatriz(matriz, matriz2);
            Mostrar(matriz2);
            Console.WriteLine("El determinante de tu matriz es: " + SacarDeterminante(matriz2));
            Console.ReadKey();
        }
        static void Cargar(double[,] mat) 
        {
            for(int i = 0;  i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.WriteLine("Ingresa la posicion " + (i + 1) + ", " + (j + 1));
                    mat[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
        static void Mostrar(double[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("\t" + mat[i, j] + "\t");
                }
            }
            Console.WriteLine("\n");
        }
        static void RellenarMatriz(double[,] mat, double[,] mat2)
        {
            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    if (j < 3)
                    {
                        mat2[i, j] = mat[i, j];
                    }
                    if (j >= 3)
                    {
                        mat2[i, j] = mat2[i, j - 3];
                    }
                }
            }
        }
        static double SacarDeterminante(double[,] mat)
        {
            double diagonalP = 0;
            double diagonalS = 0;
            double determinante = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i == 0 &&  j <= 2)
                    {
                        diagonalP += mat[i, j] * mat[i + 1, j + 1] * mat[i + 2, j + 2];
                    }
                    if (i == 0 && j >= 2)
                    {
                        diagonalS += mat[i, j] * mat[i + 1, j - 1] * mat[i + 2, j - 2];
                    }
                    determinante = diagonalP - diagonalS;
                }
            }
            return determinante;
        }
    }
}
