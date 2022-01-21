using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdlab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter m");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[m, n];
            FillMatrix(A, m, n);
            MatrixOutput(A, m, n);
            FindAndSwap(A, m, n);
            MatrixOutput(A, m, n);
            Console.ReadLine();
        }
        public static void FillMatrix(int[,] matrix, int row, int colum)
        {
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    matrix[i, j] = rnd.Next(-50, 50);
                }
            }
        }
        public static void MatrixOutput(int[,] matrix, int row, int colum)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void FindAndSwap(int[,] matrix, int row, int colum)
        {
            for (int i = 0; i < row; i++)
            {
                int localMax = -51;
                int localMaxY = 0;
                int localMaxX = 0;
                for (int j = 0; j < colum; j++)
                {
                    if (matrix[i, j] > localMax)
                    {
                        localMax = matrix[i, j];
                        localMaxY = i;
                        localMaxX = j;
                    }
                }
                Console.WriteLine("Max Element in row" + (i+1) + " = " + matrix[localMaxY, localMaxX]);
                int temp = localMax;
                matrix[localMaxY, localMaxX] = matrix[i, 0];
                matrix[i, 0] = temp;
            }
        }
    }
}
