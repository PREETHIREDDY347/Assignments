using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Project
{
     public class Program
    {
        public static void Main(string[] args)
        {
            Queue myList = new Queue();
            int People = 3;
            int i;
            for (i = 0; i < People; i++)
            {
                string Name = Console.ReadLine();
                int age =int.Parse(Console.ReadLine());
                myList.Enqueue(new Person()
                {
                    Name1 = Name,
                    Age = age

                });
            }
            foreach(Person p in myList)
            {
                Console.WriteLine(p.ToString());
            }
            Console.ReadLine();
        }
    }
}
