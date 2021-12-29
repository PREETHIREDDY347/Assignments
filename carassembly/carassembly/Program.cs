using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carassembly
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            Console.WriteLine(c.SuccessRate(10));
            Console.WriteLine(c.ProductionRatePerHour(6));
            Console.WriteLine(c.WorkingItemsPerMinute(6));
            Console.ReadLine();
        }
    }
}
