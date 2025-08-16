using System.Collections.Specialized;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Swap
            //int a = 20, b = 30;
            //Console.WriteLine($"a = {a} \t b ={b}");
            //Console.WriteLine("a and b before swapping ");

            //Helper<int>.SWap(ref a, ref b);
            //Console.WriteLine($"a = {a} \t b ={b}");
            //Console.WriteLine("a and b after swapping ");

            //Console.WriteLine("##################################");

            //decimal l1 = 20_000m, l2 = 30_000m;
            //Console.WriteLine($"L1 = {l1} \t l2={l2}");
            //Console.WriteLine("a and b before swapping ");
            //Helper<decimal>.SWap(ref l1, ref l2);

            //Console.WriteLine($"L1 = {l1} \t l2={l2}");
            //Console.WriteLine("l1 and l2 after swapping ");

            //Point p01 = new Point() { 

            //   X = 10,
            //   Y = 20

            //};

            //Point p02 = new Point() { X = 50, Y = 60 };


            //Console.WriteLine("p1 and p2 after swapping ");

            //Console.WriteLine($"p01 = {p01.ToString()} \t p02= {p02.ToString()}");

            //Console.WriteLine("##########################");

            //Helper<Point>.SWap(ref p01, ref p02);
            //Console.WriteLine("p1 and p2 after swapping ");

            //Console.WriteLine($"p01 = {p01.ToString()} \t p02= {p02.ToString()}");



            #endregion

            #region Example02 [linear search]

            //   int[] arr = new int[] { 10, 20, 30, 49, 50, 60 };
            //   int value = 20;
            //int index=   Helper<int>.LinearSearch(arr, value);
            //   Console.WriteLine($"  value {value} , at index {index}" );


            //   Point[] points = new Point[]
            //   {
            //       new Point(1,2),
            //       new Point(3,4),
            //       new Point(4,5),
            //   };

            //   Point p3 = new Point(3, 4);
            //  int index2= Helper<Point>.LinearSearch(points, p3);
            //   Console.WriteLine($"  Value = {p3} , at index {index2}");


            //  Employee[] employees =
            //  {
            //      new Employee(1,"sayed",5000),
            //      new Employee(2,"hesham",4000),
            //      new Employee(3,"ahmed",7000)

            //  };

            //  Employee emp = new Employee(1, "sayed", 5000);

            //int index3=  Helper<Employee>.LinearSearch(employees, emp);
            //  Console.WriteLine(index3);
            #endregion


            #region relations between equals-hashcode
            //Employee emoloyee01 = new Employee(6, "sayed", 1000);
            //Employee emoloyee02 = new Employee(1, "sayed", 1000);

            //Console.WriteLine(emoloyee01.GetHashCode());
            //Console.WriteLine(emoloyee02.GetHashCode());
            #endregion



            #region Is As Operator
            //Employee emoloyee01 = new Employee(6, "sayed", 1000);
            //Employee emoloyee02 = new Employee(1, "sayed", 1000);

            //Console.WriteLine(emoloyee01.GetHashCode());
            //Console.WriteLine(emoloyee02.GetHashCode());

            #endregion


            #region IEquatble

            //int[] arr = new int[] { 10, 20, 30, 49, 50, 60 };
            //int value = 20;
            //int index = Helper<int>.LinearSearch(arr, value);
            //Console.WriteLine($"  value {value} , at index {index}");


            //Point[] points = new Point[]
            //{
            //       new Point(1,2),
            //       new Point(3,4),
            //       new Point(4,5),
            //};

            //Point p3 = new Point(3, 4);
            //int index2 = Helper<Point>.LinearSearch(points, p3);
            //Console.WriteLine($"  Value = {p3} , at index {index2}");


            //Employee[] employees =
            //{
            //      new Employee(1,"sayed",5000),
            //      new Employee(2,"hesham",4000),
            //      new Employee(3,"ahmed",7000)

            //  };

            //Employee emp = new Employee(1, "sayed", 5000);

            //int index3 = Helper<Employee>.LinearSearch(employees, emp);
            //Console.WriteLine(index3);


            #endregion

            #region IEuality comaproer

            //Employee[] employees =
            //{
            //	new Employee(10,"Samy" , 5000),
            //	new Employee(20,"Omar" , 6000),
            //	new Employee(30,"Amr" , 9000),
            //	new Employee(40,"Samar" , 10000)
            //};

            //Employee employee = new Employee() { Id = 30 };

            //int Result = Helper<Employee>.LinearSearch(employees, employee);
            //Console.WriteLine($"Index Of {employee} Is {Result}"); //  -1 


            //Result = Helper<Employee>.LinearSearch(employees, employee, new EmployeeNameEqualityComparer());
            //Console.WriteLine($"Index Of {employee} Is {Result}"); //  -1 


            //Result = Helper<Employee>.LinearSearch(employees, employee, new EmployeIdEqualityComparer());
            //Console.WriteLine($"Index Of {employee} Is {Result}"); //  2 

            #endregion
        }
    }
}
