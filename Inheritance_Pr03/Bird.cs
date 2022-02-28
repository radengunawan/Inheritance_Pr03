using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Pr03
{
    class Bird : Vertebrate
    {
        public double Wingspan;
        public virtual void Fly()
        {
            Console.WriteLine("Fly high with wings");
        }

        public void LayEggs()
        {
            Console.WriteLine("Bird lays eggs");
        }

        public void PreenFeathers()
        {
            Console.WriteLine("PreenFeathers");
        }

        public static Random Randomizer = new Random();
        public virtual Egg[] LayEggs(int numberOfEggs)
        {
            Console.Error.WriteLine("Bird.LayEggs should never get called");
            return new Egg[0];
        }
    }
}
