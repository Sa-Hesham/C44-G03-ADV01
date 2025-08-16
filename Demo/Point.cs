using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public struct Point : IEquatable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x , int y)
        {
          X = x;    
          Y = y;
        }
        public override string ToString()
        {
            return $"({X} , {Y})";
        }

        public bool Equals(Point other)
        {
         return this.X==other.X && this.Y==other.Y;   
        }
    }
}
