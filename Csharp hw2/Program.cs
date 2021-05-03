using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_hw2
{
    class Program
    {
        static int SumPassengers(ref Aircraft a1, ref Aircraft a2)
        {
            return a1.Passangers + a2.Passangers;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Aircraft[] aircrafts =
            {
                new Aircraft("DimOn", 100, 45, 6, 10000, "Wrum wrum..", 150),
                new Aircraft(),
                new Aircraft(),
                new Aircraft(),
                new Aircraft()
            };
            aircrafts[0].BoardingPassangers().Takeoff().Land();
            Aircraft.Destroy();
            Console.WriteLine($"Aircrafts: {Aircraft.aircrafts}" +
                $"\nDestroyed: {Aircraft.destroyedAircrafts}");
            
        }
    }
}
