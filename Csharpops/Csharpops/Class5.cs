using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpops
{
    class Class5
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, 2, 1, 5, 4 };
            int largest = int.MinValue;
            int second = int.MinValue;
            foreach(var val in arr)
            {
                if(val>largest)
                {
                    second = largest;
                    largest = val;
                }
                else if(val>second)
                {
                    second = val;
                }
            }
            Console.WriteLine("3 2 1 5 4");
            Console.WriteLine(second);
        }
    }
}
