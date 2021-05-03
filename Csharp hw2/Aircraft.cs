using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp_hw2
{
    partial class Aircraft
    {
        #region Properties

        public string Name { get; set; }
        public int BodyLength { get; set; }
        public int WingLength { get; set; }
        public int Wheels { get; set; }
        public int Power { get; set; }
        public string Sound { get; set; }
        public int Passangers { get; set; }

        #endregion

        public static int aircrafts;
        public static int destroyedAircrafts;

        #region Constructors

        static Aircraft()
        {
            aircrafts = 0;
            destroyedAircrafts = 0;
        }
        public Aircraft()
        {
            Name = "Noname";
            BodyLength = 0;
            WingLength = 0;
            Wheels = 0;
            Power = 0;
            Sound = "Wwwwwwww..";
            Passangers = 0;
            aircrafts++;
        }
        public Aircraft(string name, int bodyLength, int wingLength, int wheels, int power, string sound, int passangers)
        {
            Name = name;
            BodyLength = bodyLength;
            WingLength = wingLength;
            Wheels = wheels;
            Power = power;
            Sound = sound;
            Passangers = passangers;
            aircrafts++;
        }

        #endregion

        #region Metods

        public Aircraft Takeoff()
        {
            Console.Clear();
            Console.WriteLine($"Aircraft \"{Name}\" is taking off {Sound}");
            Thread.Sleep(10000);
            Console.WriteLine($"Aircraft \"{Name}\" taked off");
            return this;
        }
        public Aircraft Land()
        {
            Console.Clear();
            Console.WriteLine($"Aircraft \"{Name}\" is landing {Sound}");
            Thread.Sleep(10000);
            Console.WriteLine($"Aircraft \"{Name}\" landed");
            return this;
        }
        public Aircraft BoardingPassangers()
        {
            Console.Clear();
            Console.WriteLine("Boarding Passengers..");
            Console.Write("Passenger number:");
            for (int i = 1; i <= Passangers; i++)
            {
                Console.SetCursorPosition(18, 2);
                Console.WriteLine("                                ");
                Console.SetCursorPosition(18, 2);
                Console.WriteLine($"{i} / {Passangers}");
                Thread.Sleep(100);
            }
            Console.WriteLine();
            return this;
        }

        #endregion
    }
}
