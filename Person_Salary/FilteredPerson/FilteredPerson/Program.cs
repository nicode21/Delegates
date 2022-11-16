using System;
using System.Collections.Generic;

namespace FilteredPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            Person person1 = new Person("Nicat","Novruzzade","Ehmedli",1800);
            Person person2 = new Person("Resul","Hesenov","Razin",2500);
            Person person3 = new Person("Hesen","Qarayev","Qara-Qarayev",800);
            Person person4 = new Person("Fatime","Bayramova","Elmler Akademiyasi",1900);


            list.Add(person1);
            list.Add(person2);
            list.Add(person3);
            list.Add(person4);



            Predicate<List<Person>> func = Person.CheckPersons;

            Person.GetFilteredPerson(func,list);

            //func(list);
        }
    }
}
