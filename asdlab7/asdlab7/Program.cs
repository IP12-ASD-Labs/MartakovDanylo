using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdlab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[] b = new int[10];
            int[] c = new int[10];
            InitArrays(a, b);
            InitThirdArray(a, b, c);
            ArrayOutput(a);
            ArrayOutput(b);
            ArrayOutput(c);
            Console.WriteLine(FindMinSum(c));
            Console.ReadLine();
        }
        public static void InitArrays(int[] a, int[] b)
        {
            for (int i = 0; i < 10; i++)
            {
                a[i] = 74 - i;
                b[i] = 64 + 2 * i;
            }
        }
        public static void InitThirdArray(int[] a, int[] b, int[] c)
        {
            for (int i = 0; i < 10; i++)
            {
                int j = 0;
                while (j < 10 && c[i] == 0) 
                {
                    if (a[i] == b[j])
                        c[i] = b[j];
                    j++;
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
        public static int FindMinSum(int[] array)
        {
            int firstMin = array[0];
            int secondMin = -1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    if (firstMin > array[i])
                    {
                        secondMin = firstMin;
                        firstMin = array[i];
                    }
                    if (secondMin != -1 && secondMin > array[i] && array[i] != firstMin)
                        secondMin = array[i];
                }
            }
            return firstMin + secondMin;
        }
    }
}
