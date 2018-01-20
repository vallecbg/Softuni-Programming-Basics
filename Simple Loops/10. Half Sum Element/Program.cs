using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0; // obshta suma
            var max = 0; // nai - golqmoto chislo

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num >= max)
                {
                    max = num;
                }
            }

            if ((sum - max) - max == 0)
            {
                Console.WriteLine("Yes Sum = " + max);
            }
            else
            {
                Console.WriteLine("No diff = " + (Math.Abs(Math.Abs(max - sum) - (max))));
            }
        }
    }
}
