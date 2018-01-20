using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine().ToLower();
            var redove = int.Parse(Console.ReadLine());
            var koloni = int.Parse(Console.ReadLine());
            double price = 0.00;

            switch (projection)
            {
                case "premiere":
                    price = 12.00;
                    break;
                case "normal":
                    price = 7.5;
                    break;
                case "discount":
                    price = 5.00;
                    break;
                default:
                    break;
            }
            var result = redove * koloni * price;
            Console.WriteLine("{0:f2}", result);
        }
    }
}
