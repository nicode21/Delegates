using System;
using System.Collections.Generic;
using System.Text;

namespace FilteredPerson
{
    public class Person
    {
        public static List<Person> PList ;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public double Salary { get; set; }


        public Person(string name, string surname, string adress, double salary)
        {
            Name = name;
            Surname = surname;
            Adress = adress;
            Salary = salary;
        }

        public static bool CheckPersons(List<Person>list)
        {
            PList=list;

            string res = "";

            foreach (var item in list)
            {
                if (item.Salary>1000)
                {
                    Console.WriteLine($"{item.Name} -- {item.Surname} -- {item.Adress}"); 
                }
            }
            return true;
           
        }


        public static void GetFilteredPerson(Predicate<List<Person>> func ,List<Person> list)
        {
            func(list);
        }


    }
}
