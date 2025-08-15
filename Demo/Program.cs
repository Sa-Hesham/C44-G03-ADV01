namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Swap
            int a = 20, b = 30;
            Console.WriteLine($"a = {a} \t b ={b}");
            Console.WriteLine("a and b before swapping ");

            Helper<int>.SWap(ref a, ref b);
            Console.WriteLine($"a = {a} \t b ={b}");
            Console.WriteLine("a and b after swapping ");

            Console.WriteLine("##################################");

            decimal l1 = 20_000m, l2 = 30_000m;
            Console.WriteLine($"L1 = {l1} \t l2={l2}");
            Console.WriteLine("a and b before swapping ");
            Helper<decimal>.SWap(ref l1, ref l2);

            Console.WriteLine($"L1 = {l1} \t l2={l2}");
            Console.WriteLine("l1 and l2 after swapping ");

            Point p01 = new Point() { 
            
               X = 10,
               Y = 20
            
            };

            Point p02 = new Point() { X = 50, Y = 60 };

            
            Console.WriteLine("p1 and p2 after swapping ");

            Console.WriteLine($"p01 = {p01.ToString()} \t p02= {p02.ToString()}");

            Console.WriteLine("##########################");
            
            Helper<Point>.SWap(ref p01, ref p02);
            Console.WriteLine("p1 and p2 after swapping ");

            Console.WriteLine($"p01 = {p01.ToString()} \t p02= {p02.ToString()}");



            #endregion

        }
    }
}
