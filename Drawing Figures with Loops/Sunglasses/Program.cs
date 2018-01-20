using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Left and Right parts
            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));

            for (int row = 0; row < n - 2; row++)
            {
                char bridge = ' ';

                if ((n - 1) / 2 - 1 == row)
                {
                    bridge = '|';
                }
                Console.WriteLine("*{0}*{1}*{0}*",
                    new string('/', n * 2 - 2),
                    new string(bridge, n));
            }

            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
        }
    }
}
