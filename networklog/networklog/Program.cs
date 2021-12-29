using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace networklog
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] Id = new int[12];
            string[] Source = new string[12];
            string[] Destination = new string[12];
            string[] Date = new string[12];
            string[] Status = new string[12];
            string[] Network = new string[12];
            for (i = 0; i <= 12; i++)
            {
                Console.Write("\t Enter Id:");
                Id[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("\t Enter Source");
                Source[i] = Console.ReadLine();
                Console.Write("\t Enter Destination");
                Destination[i] = Console.ReadLine();
                Console.Write("\t Enter Date");
                Date[i] = Console.ReadLine();
                Console.Write("\t Enter Status");
                Status[i] = Console.ReadLine();
                Console.WriteLine("\t Enter Network");
                Network[i] = Console.ReadLine();

            }
            Console.WriteLine("Id  " + "Source    " + "Destination" + "Date   " + "Status" + "Network");
            FileStream fs =new FileStream ("C:\\CAPG TRAINING\\csharp.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek()>0)
            {
                string readmyline = sr.ReadLine();
                string[] strings = readmyline.Split(':');
                if (strings.Length > 1)
                    Console.WriteLine(strings[1]);
                else
                    Console.WriteLine();
            }



            
                
            

        }
     
    }
}
