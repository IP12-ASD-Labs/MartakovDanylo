using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdlab8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 5];
            FillMatrix(matrix, 8, 3);
            MatrixOutput(matrix, 8, 3);
            int[] dobArray = new int[8];
            FillDobArray(dobArray, matrix, 8, 3);
            ArrayOutput(dobArray);
            SortArray(dobArray);
            ArrayOutput(dobArray);
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
        public static void FillDobArray(int[] array, int[,] matrix, int row, int colum)
        {
            for (int i = 0; i < row; i++)
            {
                int dob = 1;
                for (int j = 0; j < colum; j++)
                {
                    if (matrix[i, j] > 0)
                        dob *= matrix[i, j];
                }
                array[i] = dob;
            }
        }
        public static void SortArray(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public static void ArrayOutput(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
