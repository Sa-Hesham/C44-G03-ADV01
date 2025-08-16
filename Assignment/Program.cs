using System.Collections;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { 5, 4, 3, 2, 1 };
            Helper.ReverseArray(list);
            foreach (int i in list) { 
            
                Console.WriteLine(i);
            
            
            }
        }
    }
}
