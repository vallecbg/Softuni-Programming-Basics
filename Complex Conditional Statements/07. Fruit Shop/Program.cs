using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana") Console.WriteLine(quantity * 2.50);
                if (fruit == "apple") Console.WriteLine(quantity * 1.20);
                if (fruit == "orange") Console.WriteLine(quantity * 0.85);
                if (fruit == "grapefruit") Console.WriteLine(quantity * 1.45);
                if (fruit == "kiwi") Console.WriteLine(quantity * 2.70);
                if (fruit == "pineapple") Console.WriteLine(quantity * 5.50);
                if (fruit == "grapes") Console.WriteLine(quantity * 3.85);
                else Console.WriteLine("error");
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana") Console.WriteLine(quantity * 2.70);
                if (fruit == "apple") Console.WriteLine(quantity * 1.25);
                if (fruit == "orange") Console.WriteLine(quantity * 0.90);
                if (fruit == "grapefruit") Console.WriteLine(quantity * 1.60);
                if (fruit == "kiwi") Console.WriteLine(quantity * 3.00);
                if (fruit == "pineapple") Console.WriteLine(quantity * 5.60);
                if (fruit == "grapes") Console.WriteLine(quantity * 4.20);
                else Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
