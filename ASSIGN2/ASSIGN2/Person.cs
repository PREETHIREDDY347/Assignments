using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGN2
{
     public class Person
    {
        protected string firstname;
       protected  string lastname;
        protected int Id;
        public Person(string firstname,string lastname,int Id)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.Id = Id;
        }
        public void printPerson()
        {
            Console.WriteLine("name:" + firstname + lastname);
            Console.WriteLine("Id" + Id);
        }
    }
}
