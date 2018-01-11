using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            var inches = double.Parse(Console.ReadLine());
            Console.Write("Centimeters = ");
            var centimeters = inches * 2.54;
            Console.WriteLine(centimeters);
        }
    }
}
