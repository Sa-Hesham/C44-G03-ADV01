using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Range <T> where T: IComparable<T>,INumber<T>
    {
   

        public T Maximun { get; set; }
        public T Minimum { get; set; }


        public Range(T maximum  , T minimum)
        {
            if (minimum.CompareTo(minimum) > 0)
            {
                Console.WriteLine("min is greater than max");
            }

            Maximun = maximum;
            Minimum = minimum;

        }


        public bool ISRange(T value)
        {
           return   (value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximun) <= 0) ;
                
        }

        public T GetLength()
        {
            return Maximun - Minimum;
        }
    }
}
