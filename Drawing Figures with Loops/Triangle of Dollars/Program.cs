using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string dollar = "$";
            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine(dollar);
                dollar += " $";
            }
        }
    }
}
