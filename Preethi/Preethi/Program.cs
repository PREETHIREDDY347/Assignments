using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Preethi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringlist = new List<string>();
            stringlist.Add("abc");
            stringlist.Add("cdaef");
            stringlist.Add("js");
            stringlist.Add("php");         
        
            foreach(var i in stringlist)
            {
                
                Console.WriteLine(i.Replace("a",""));
                Console.ReadLine();

            }
        }
    }
}
