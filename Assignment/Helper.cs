using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal static class Helper
    {
        
        



        public static void ReverseArray(ArrayList list) {

            if (list is not null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        object temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }

            }
            return;
               




            }


                
        public static List<int> GetEvennumbers (List<int> numbers)
        {


            List<int> evens = new List<int>();

            foreach (int num in numbers)
            {
                if (num % 2 == 0) 
                {
                    evens.Add(num);
                }
            }

            return evens;
        }





    }
}
