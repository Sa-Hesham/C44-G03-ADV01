using System.Collections;
using System.Threading.Channels;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //var intRange = new Range<int>(10, 20);

            //Console.WriteLine(intRange.ISRange(15)); 
            //Console.WriteLine(intRange.ISRange(25)); 
            //Console.WriteLine(intRange.GetLength());      

            //var doubleRange = new Range<double>(5.5, 9.5);
            //Console.WriteLine(doubleRange.ISRange(7.2)); // True
            //Console.WriteLine(doubleRange.GetLength());

            #endregion


            #region Q2

            //ArrayList list = new ArrayList() { 5, 4, 3, 2, 1 };
            //Helper.ReverseArray(list);
            //foreach (int i in list) { 

            //    Console.WriteLine(i);


            //} 
            #endregion

            #region Q3
            //List<int> Numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            //List<int> Evens = Helper.GetEvennumbers(Numbers);
            //foreach (int item in Evens)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion



            #region َQ4

            //FixedSizeList<int> list = new FixedSizeList<int>(3);

            //Console.WriteLine("Adding elements 10, 20, 30:");
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);

            //Console.WriteLine("Reading elements:");
            //Console.WriteLine($"Element at index 0: {list.GetIndex(0)}");
            //Console.WriteLine($"Element at index 1: {list.GetIndex(1)}");
            //Console.WriteLine($"Element at index 2: {list.GetIndex(2)}");

            //Console.WriteLine("\nTrying to add fourth element:");
            //try
            //{
            //    list.Add(40);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}


            //try
            //{
            //    int  item = list.GetIndex(5);
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}


            #endregion



            #region Q5
            Console.WriteLine(Helper.UniqueChar("AAbb") == -1 ? "un_unique" : "unique");


            #endregion
        }
    }
}
