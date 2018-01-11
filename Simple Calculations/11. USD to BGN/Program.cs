using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = double.Parse(Console.ReadLine());
            var usdinbgn = usd * 1.79549;

            var bgn = usdinbgn;

            Console.WriteLine("{0:F2} BGN", bgn);
        }
    }
}
