using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddSum += currentNumber;
                }
                else
                {
                    evenSum += currentNumber;
                }
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes sum  {0}", oddSum);
            }
            else
            {
                Console.WriteLine("No diff  {0}", Math.Abs(oddSum - evenSum));
            }
        }
    }
}
