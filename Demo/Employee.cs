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
            if (obj == null) return false;
            if(obj is Employee employee)
            {
                return this.Id==employee.Id && this.Name== employee.Name &&  this.Salary==employee.Salary; 
                  
            }
            return false;
        }

        public override int GetHashCode()
        {
           // return this.Id.GetHashCode()+this.Name.GetHashCode()+this.Salary.GetHashCode(); //deprecated
           return HashCode.Combine(Id.GetHashCode(), Name.GetHashCode(), Salary.GetHashCode());
        }


    }
}
