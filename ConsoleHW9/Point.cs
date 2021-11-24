using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHW9
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine($"X:{X};Y:{Y}");
        }
    }
}
