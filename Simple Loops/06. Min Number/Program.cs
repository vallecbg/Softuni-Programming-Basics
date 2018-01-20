using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n - 1; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
