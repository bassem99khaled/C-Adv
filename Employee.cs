using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv
{

    class EmployeeComaprer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
           return x?.Name?.CompareTo(y?.Name) ?? (y is null 0 : -1);
        }
    }

    internal class Employee
 
    {
    public int ID { get; set; }
        public string? Name { get; set; }
    
        public decimal Salary { get; set; }

        public Employee(int ID , string? Name, decimal Salary)
        {

        }

        public override string ToString()
        {
            return $"ID = {ID} , Name = {Name} , Salary = {Salary}";
        }

        public int CompareTo(Employee? other)
        {
            if (other is null) return 1;

            return this.Salary.CompareTo(other.Salary);
        }
    }
}
