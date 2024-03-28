using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Data
{
    internal class EmployeeDto
    {

        public string Name { get; set; }
        public Decimal Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Salary: {Salary}";
        }

    }
}
