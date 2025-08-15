using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Employee
    {

        public int Id { get; set; }
        public string ?Name { get; set; }
        public decimal Salary { get; set; }
        //public Employee()
        //{
            
        //}

        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
           Salary = salary;
        }


        public override bool Equals(object? obj)
        {
            #region UnSafeCasting
            //Employee? employee = (Employee?)obj;
            //if (employee == null) return false;


            //return this.Id == employee.Id && this.Name == employee.Name && this.Salary == employee.Salary;

            #endregion

            #region Is Operator
            //if (obj is null) return false;
            //else if (obj is Employee employee) // make cheack and casting cheak id obj is Employee the casting take the (obj=employee)
            //    // obj must be employee or the othe types that inherit from Employee
            //    return this.Id == employee.Id && this.Name == employee.Name && this.Salary == employee.Salary;
            //return false;
            #endregion

            #region As operator
            Employee? employee = obj as Employee;
            if (employee == null) return false;
            return this.Id == employee.Id && this.Name == employee.Name && this.Salary == employee.Salary;
            #endregion


        }

        public override int GetHashCode()
        {
           // return this.Id.GetHashCode()+this.Name.GetHashCode()+this.Salary.GetHashCode(); //deprecated
           return HashCode.Combine(Id, Name, Salary);
        }


    }
}
