using System;
using System.Collections.Generic;

namespace EmplooyeAvarage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Employee emp1 = new Employee(23,200);
            Employee emp2 = new Employee(18,2000);
            Employee emp3 = new Employee(25,2000);
            Employee emp4 = new Employee(27,2000);

            list.Add(emp1);
            list.Add(emp2);
            list.Add(emp3);
            list.Add(emp4);

            Action<List<Employee>> func = Employee.Checkemployee;

            Employee.GetFilteredEmployee(func,list);

        }
    }
}
