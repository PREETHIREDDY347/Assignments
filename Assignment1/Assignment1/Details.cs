using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment1
{
    class Details
    {
        public void createdetails()
        {
            FileStream filestreamobj = new FileStream("C:\\CAPG TRAINING\\Assignment1\\file.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(filestreamobj);
            sw.Write("Call log details");
            Console.Write("enter Id:");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter Source");
            int Source = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter Destination");
            int Destination = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter time");
            int time = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter status");
            string status = Console.ReadLine();
            Console.Write("enter network");
            string network = Console.ReadLine();
            sw.WriteLine(Id);
            sw.WriteLine(Source);
            sw.WriteLine(Destination);
            sw.WriteLine(time);
            sw.WriteLine(status);
            sw.WriteLine(network);
            sw.Close();
            filestreamobj.Close();
        }
        public void ReadHouseDetails()
        {
            FileStream fileStreamObj = new FileStream("C:\\Test\\MyFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fileStreamObj);
            while (sr.Peek() > 0)
            {
                string readmyline = sr.ReadLine();
                string[] strings = readmyline.Split(':');
                if (strings.Length > 1)
                    Console.WriteLine(strings[1]);



            }
        }
    }
}
