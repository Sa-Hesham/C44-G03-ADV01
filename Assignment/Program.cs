using System.Collections;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList() { 5, 4, 3, 2, 1 };
            //Helper.ReverseArray(list);
            //foreach (int i in list) { 
            
            //    Console.WriteLine(i);
            
             
            //}

            #region Q3
            List<int> Numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            List<int> Evens = Helper.GetEvennumbers(Numbers);
            foreach (int item in Evens)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
