﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalCrossingQR.AC
{
    public struct Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

        public Color(byte red, byte green, byte blue)
            : this()
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public static double DistanceSquared(Color a, Color b)
        {
            return (a.Red - b.Red) * (a.Red - b.Red) +
                (a.Green - b.Green) * (a.Green - b.Green) +
                (a.Blue - b.Blue) * (a.Blue - b.Blue);
        }

        public static double Distance(Color a, Color b)
        {
            return Math.Sqrt(DistanceSquared(a, b));
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Color))
                return false;

            Color b = (Color)obj;
            return this.Red == b.Red &&
                this.Blue == b.Blue &&
                this.Green == b.Green;
        }

        public override int GetHashCode()
        {
            return Red + (Green << 8) + (Blue << 16);
        }
    }
}
