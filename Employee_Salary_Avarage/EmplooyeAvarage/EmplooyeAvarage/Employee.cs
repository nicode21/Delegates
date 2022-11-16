using System;
using System.Collections.Generic;
using System.Text;

namespace EmplooyeAvarage
{
    public class Employee
    {
        public int Age { get; set; }
        public double Salary { get; set; }
        public static List<Employee> EList;


        public Employee(int age,double salary)
        {
            Age = age;
            Salary=salary;
        }

        public static void Checkemployee(List<Employee> list)
        {
            EList=list;

            double sum = 0 ;
            double avarage = 0;
            int count = 0;

            foreach (var item in EList)
            {
                if (item.Age>20&&item.Age<40)
                {
                    count++;
                    sum+=item.Salary;
                    avarage=sum/count;
                   
                }
            }
            Console.WriteLine(avarage);
        }


        public static void GetFilteredEmployee(Action<List<Employee>> func,List<Employee> list)
        {
            func(list);
        }

    }
}
