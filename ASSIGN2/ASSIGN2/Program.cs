using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGN2
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter firstname");
            string firstname = Console.ReadLine();
            Console.WriteLine("enter lastname");
            string lastname = Console.ReadLine();
            Console.Write("enter Id");
            int Id=Convert.ToInt32(Console.ReadLine());
            Console.Write("enter number of times:");
            int Scores = Convert.ToInt32(Console.ReadLine());
            int[] times = new int[Scores];
            for(int i=0;i<Scores;i++)
            {
                Console.Write("enter test marks{0}:", (i + 1));
                times[i] = Convert.ToInt32(Console.ReadLine());
            }
            Student s = new Student(firstname, lastname, Id, times);
            s.printPerson();
            Console.WriteLine("Grade:" + s.calculate());
            Console.ReadLine();
           
        }
    }
}
