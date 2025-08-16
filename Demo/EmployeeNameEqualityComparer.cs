using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class EmployeeNameEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (x is null || y is null) return false;
            
            return string.Equals(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Name is null ? 0 : StringComparer.OrdinalIgnoreCase.GetHashCode(obj.Name);
        }
    }
}
