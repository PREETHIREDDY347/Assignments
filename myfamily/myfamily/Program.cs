using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfamily
{
     public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("total number of family members");
        }
    }
    public class my_mem : Program
    {
        public new void mem()
        {
            Console.WriteLine("name:rakesh,age:98 \n name:kaveri,"+"age:76 \n name:ravi,Age:98");
        }
    }
}
