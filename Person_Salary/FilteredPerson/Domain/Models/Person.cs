using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public double Salary { get; set; }


        public Person(string name,string surname,string adress,double salary)
        {
            Name=name;
            Surname=surname;
            Adress=adress;
            Salary=salary;
        }

    }
}
