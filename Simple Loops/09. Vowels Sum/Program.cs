using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int points = 0;
            for (int i = 1; i <= s.Length - 1; i++)
            {
                switch (s[i])
                {
                    case 'a':
                        points += 1;
                        break;
                    case 'e':
                        points += 2;
                        break;
                    case 'i':
                        points += 3;
                        break;
                    case 'o':
                        points += 4;
                        break;
                    case 'u':
                        points += 5;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(points);
        }
    }
}
