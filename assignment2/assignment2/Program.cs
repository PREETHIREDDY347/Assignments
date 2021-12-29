using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Student P = new Student(417, "Preethi", "ASP.NET");
            P.Payment(1500);
            P.Print();
            Console.WriteLine("Amountdue:{0}", P.DueAmountproperty);
            Console.WriteLine("Totalfee:{0}", P.totalfeeproperty);
            Console.ReadKey();
        
            
        }
    }
}
