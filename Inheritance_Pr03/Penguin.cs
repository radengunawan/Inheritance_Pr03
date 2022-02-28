using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Pr03
{
    class Penguin : Bird
    {
        public void Swim()
        {
            Console.WriteLine("Penguin swim");
        }

        public override void Fly()
        {
            Console.Error.WriteLine("Penguin cannot fly at all.");
        }
    }
}
