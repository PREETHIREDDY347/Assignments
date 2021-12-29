using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\CAPG TRAINING\\Assign1.txt", FileMode.Create, FileAccess.Write);
            Console.WriteLine("ID     Source       Destination      Date      Status       Network");
            int i;
            string Source = "86876786";
            string Destination = "878979723";
            string Date = "09/12/2021";
            string Status1 = "Failed";
            string Status2 = "Dialed";
            string Status3 = "Missed";
            string Status4 = " Success";
            string Network1 = "Jio";
            string Network2 = "Airtel";
            string Network3 = "Idea";

            StreamWriter sw = new StreamWriter(fs);
            for (i = 1; i <= 12; i++)
            {
                sw.WriteLine("ID:" + i);
                sw.WriteLine("Source:" + Source);
                sw.WriteLine("Destination:" + Destination);
                sw.WriteLine("Date:" + Date);
                if (i == 1)
                {
                    sw.WriteLine("Status:" + Status1);
                    sw.WriteLine("Network:" + Network1);
                }
                else if (i == 2 || i == 3 || i == 10)
                {
                    sw.WriteLine("Status:" + Status4);
                    sw.WriteLine("Network:" + Network2);
                }
                else if (i == 4)
                {
                    sw.WriteLine("Status:" + Status1);
                    sw.WriteLine("Network:" + Network3);
                }
                else if (i == 5 || i == 6 || i == 7)
                {
                    sw.WriteLine("Status:" + Status1);
                    sw.WriteLine("Network:" + Network2);
                }
                else if (i == 8)
                {
                    sw.WriteLine("Status:" + Status2);
                    sw.WriteLine("Network:" + Network2);
                }
                else if (i == 9)
                {
                    sw.WriteLine("Status:" + Status3);
                    sw.WriteLine("Network:" + Network2);
                }
                else if (i == 11)
                {
                    sw.WriteLine("Status:" + Status3);
                    sw.WriteLine("Network:" + Network3);
                }
                else
                {
                    sw.WriteLine("Status:" + Status4);
                    sw.WriteLine("Network:" + Network1);
                }

            }
            sw.Close();
            FileStream fsObj = new FileStream("C:\\CAPG TRAINING\\Assign1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fsObj);
            
            while (sr.Peek() > 0)
            {
                string readmyline = sr.ReadLine();
                string[] strings = readmyline.Split(':');
            }
            for (i = 1; i <= 12; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("\n" +"    "+i+ "     "+Source+"  "+Destination+"  "+Date+"    "+Status1+"  "+Network1+"");
                }
                else if (i == 2 || i == 3 || i == 10)
                {
                    Console.WriteLine("\n" +"     "+i+"       "+Source+"  "+Destination+"   "+Date+"    "+Status4+"    "+Network2+"");
                }
                else if (i == 4)
                {
                    Console.WriteLine("\n  "+"     "+i+"       "+Source+"  "+Destination+"  "+Date+"     "+Status1+"  "+Network3+"");
                }
                else if (i == 5 || i == 6 || i == 7)
                {
                    Console.WriteLine("\n "+"      "+i+"        "+Source+"  "+Destination+"  "+Date+"     "+Status1+"    "+Network2+"");
                }
                else if (i == 8)
                {
                    Console.WriteLine( "\n"+"      "+ i +"      " +Source+"  "+Destination+"  "+Date+"     "+Status2+"  "+Network2+"");
                }
                else if (i == 9)
                {
                    Console.WriteLine("\n "+"       "+i+"       "+Source+"  "+Destination+"    "+Date+"  "+Status3+"  "+Network2+"");
                }
                else if (i == 11)
                {
                    Console.WriteLine("\n   "+"     "+i+"       "+Source+"   "+Destination+"   "+Date+"   "+Status4+"  "+Network3+"");
                }
                else
                {
                    Console.WriteLine("\n  "+"      "+i+"       "+Source+"    "+Destination+"   "+Date+"   "+Status4+"  "+Network1+"");
                }
            }
            sr.Close();
            fsObj.Close();
            Console.ReadKey();


        }
    }
}
