using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var formula = rad * 57.2957795;

            var deg = formula;

            Console.WriteLine(Math.Round(formula));
        }
    }
}
