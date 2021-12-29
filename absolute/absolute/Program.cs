using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absolute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(32));
            Console.WriteLine(test(54));
            Console.WriteLine(test(43));
            Console.ReadLine();

        }
        public static int test(int n)
        {
            const int x = 52;
            if (n > x)
            {
                return n - x * 3;

            }
            return x - n;

        }

    }
}
