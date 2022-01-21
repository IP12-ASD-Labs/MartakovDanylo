using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdlab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            FindAllDosk(a, b);
            Console.ReadLine();
        }
        public static void FindAllDosk(int lowLimit, int upLimit)
        {
            for (int i = lowLimit; i < upLimit; i++)
            {
                int sum = 0;
                sum = FindDosk(i, sum, 1);
                if (sum == i)
                    Console.WriteLine(i);
            }
        }
        public static int FindDosk(int number, int sum, int current)
        {
            if (current < number)
            {
                if (number % current == 0)
                    sum += current;
                return FindDosk(number, sum, current + 1);
            }
            else
                return sum;
        }
    }
}
