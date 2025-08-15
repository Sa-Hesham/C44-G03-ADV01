using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x , int y)
        {
          
        }
        public override string ToString()
        {
            return $"X = {X} \t y= {Y}";
        }
    }
}
