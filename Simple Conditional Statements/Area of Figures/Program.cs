using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var vid = Console.ReadLine();
            double lice = 0.00;

            if (vid == "square")
            {
                double duljinastrana = double.Parse(Console.ReadLine());
                lice = Math.Pow(duljinastrana, 2);
                Console.WriteLine("{0:0.###}", lice);
            }
            else if (vid == "rectangle")
            {
                double duljinastrana1 = double.Parse(Console.ReadLine());
                double duljinastrana2 = double.Parse(Console.ReadLine());
                lice = duljinastrana1 * duljinastrana2;
                Console.WriteLine("{0:0.###}", lice);
            }
            else if (vid == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                lice = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine("{0:0.###}", lice);
            }
            else if (vid == "triangle")
            {
                double duljinastrana = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                lice = (duljinastrana * h) / 2.0;
                Console.WriteLine("{0:0.###}", lice);
            }
        }
    }
}
