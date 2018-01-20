using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonusScore = 0;

            if (number <= 100)
            {
                bonusScore += 5;
            }
            else if ((number > 100) && (number <= 1000))
            {
                bonusScore += 0.2 * number;
            }
            else
            {
                bonusScore += 0.1 * number;
            }

            if (number % 2 == 0)
            {
                bonusScore += 1;
            }

            if (number % 10 == 5)
            {
                bonusScore += 2;
            }

            double totalScore = bonusScore + number;
            Console.WriteLine(bonusScore);
            Console.WriteLine(totalScore);
        }
    }
}
