using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1.Models
{
    public struct SeatLocation
    {
        public char Row { get; }
        public int Number { get; }

        public SeatLocation(char row, int number)
        {
            Row = row;
            Number = number;
        }

        //// to print "A1", "B5", etc.
        public override string ToString() => $"{Row}{Number}";
    }
}
