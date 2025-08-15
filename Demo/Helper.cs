using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static  class Helper <T>
    {
        public static void SWap (ref T a , ref T b)
        {
            T temb = a;
            a = b;
            b=temb;
        }
    }
}
