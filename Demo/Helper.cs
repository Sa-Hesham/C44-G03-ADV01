using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static class Helper<T>
    {
        public static void SWap(ref T a, ref T b)
        {
            T temb = a;
            a = b;
            b = temb;
        }

        public static int LinearSearch(T[] arr, T value)
        {
            if (arr is not null && arr.Length > 0 && value is not null)
            {

                for (int i = 0; i < arr.Length; i++)


                {
                    //if (arr[i]?.Equals(value)??false)
                    if (value.Equals(arr[i]))

                       return i+1;

                }


              
            }
            return -1;

        }





    }
}


