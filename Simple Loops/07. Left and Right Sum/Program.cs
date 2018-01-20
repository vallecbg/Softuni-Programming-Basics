using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int left = int.Parse(Console.ReadLine());
                leftSum += left;
            }
            for (int i = 1; i <= n; i++)
            {
                int right = int.Parse(Console.ReadLine());
                rightSum += right;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum {0}", leftSum);
            }
            else
            {
                Console.WriteLine("No, diff {0}", Math.Abs(leftSum - rightSum));
            }
        }
    }
}
