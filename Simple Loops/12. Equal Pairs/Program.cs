using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstPair = 0;
            int secondPair = 0;
            int maxDiff = 0;
            for (int i = 0; i < n; i++)
            {
                secondPair = firstPair;
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                firstPair = firstNumber + secondNumber;

                if (i > 0)
                {
                    int currentDiff = Math.Abs(firstPair - secondPair);

                    if (currentDiff > maxDiff)
                    {
                        maxDiff = currentDiff;
                    }
                }
            }
            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value {0}", firstPair);
            }
            else
            {
                Console.WriteLine("No, maxdiff {0}", maxDiff);
            }
        }
    }
}
