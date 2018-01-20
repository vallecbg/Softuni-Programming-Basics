using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            var sells = double.Parse(Console.ReadLine());

            if (town == "sofia")
            {
                if (sells >= 0 && sells <= 500) Console.WriteLine("{0:F2}", 5 * sells / 100);
                if (sells > 500 && sells <= 1000) Console.WriteLine("{0:F2}", 7 * sells / 100);
                if (sells > 1000 && sells <= 10000) Console.WriteLine("{0:F2}", 8 * sells / 100);
                if (sells > 10000) Console.WriteLine("{0:F2}", 12 * sells / 100);
                else Console.WriteLine("error");
            }
            else if (town == "varna")
            {
                if (sells >= 0 && sells <= 500) Console.WriteLine("{0:F2}", 4.5 * sells / 100);
                if (sells > 500 && sells <= 1000) Console.WriteLine("{0:F2}", 7.5 * sells / 100);
                if (sells > 1000 && sells <= 10000) Console.WriteLine("{0:F2}", 10 * sells / 100);
                if (sells > 10000) Console.WriteLine("{0:F2}", 13 * sells / 100);
                else Console.WriteLine("error");
            }
            else if (town == "plovdiv")
            {
                if (sells >= 0 && sells <= 500) Console.WriteLine("{0:F2}", 5.5 * sells / 100);
                if (sells > 500 && sells <= 1000) Console.WriteLine("{0:F2}", 8 * sells / 100);
                if (sells > 1000 && sells <= 10000) Console.WriteLine("{0:F2}", 12 * sells / 100);
                if (sells > 10000) Console.WriteLine("{0:F2}", 14.5 * sells / 100);
                else Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
