using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsium = double.Parse(Console.ReadLine());
            var formula = celsium * 1.80 + 32.00;

            var farenheit = formula;
            Console.WriteLine("{0:F2}", farenheit);
        }
    }
}
