using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Top Row (Gorna chast)
            Console.Write("+");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            //Middle Part (Sredna chast)
            Console.WriteLine();
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("|");
                for (int j = 1; j <= n - 2; j++)
                {
                    Console.Write(" -");
                }
                Console.Write(" |");
                Console.WriteLine();
            }
            // Bottom Row (Dolna chast)
            Console.Write("+");
            for (int k = 1; k <= n - 2; k++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();
        }
    }
}
