using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EXAMPLE_FILESTREAM
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string file = @"C:\CAPG TRAINING\EXAMPLE_FILESTREAM\test.txt";
                FileStream fs = new FileStream(file, FileMode.Create);
                byte[] bdata = Encoding.Default.GetBytes(DateTime.Now.ToString());
                fs.Write(bdata, 0, bdata.Length);
                Console.WriteLine("data added");
                fs.Close();
                string data;
                FileStream fsread = new FileStream(file, FileMode.Open, FileAccess.Read);
                using (StreamReader sr = new StreamReader(fsread))
                {
                    data = sr.ReadToEnd();
                }
                Console.WriteLine(data);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            Console.ReadKey();
        } 
    }
}
