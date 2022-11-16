using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class PersonService : Person
    {
        public PersonService(string name,string surname,string adress,double salary) : base (name,surname,adress,salary) 
        {

        }
    }
}
