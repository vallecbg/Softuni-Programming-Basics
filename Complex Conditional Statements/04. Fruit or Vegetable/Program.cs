using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var thing = Console.ReadLine();

            if (thing == "banana" || thing == "apple" || thing == "kiwi" ||
                thing == "cherry" || thing == "lemon" || thing == "grapes")
            {
                Console.WriteLine("Fruit");
            }

            else if (thing == "tomato" || thing == "cucumber" || thing == "pepper" ||
                    thing == "carrot")
            {
                Console.WriteLine("Vegetable");
            }

            else
            {
                Console.WriteLine("Unknown");
            }
        }
    }
}
