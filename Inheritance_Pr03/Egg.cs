using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Pr03
{
    class Egg
    {
        public double Size { get; private set; }
        public string Color { get; private set; }
        public Egg (double size, string color)
        {
            this.Size = size;

            this.Color = color;
        }

        public string Description
        {
            get { return $"A {this.Size:0.0}cm {this.Color} egg"; }
        }

    }
}
