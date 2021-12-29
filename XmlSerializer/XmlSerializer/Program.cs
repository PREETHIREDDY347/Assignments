using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
                           
  //Serialization:Process of converting an object into stream of bytes.
  //Xml-extensible markup language.
 //Xml Serialization converts public fields and properties of an object into Xml stream.

namespace Xml
{
    class Program
    {
        static void Main(string[] args)
        {
            // STEP1:create object for class
            // STEP2:create object for XmlSerializer to perform serialization.
            // STEP3:use XmlSerializer object to serialize data into file.
            Employee obj = new Employee();
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            //typeof() is a keyword which is used to get at compiletime.
            TextWriter tw = new StreamWriter(@"C:\CAPG TRAINING\XmlSerializer.xml");
            xs.Serialize(tw, obj);
            tw.Close();

        }
    }
}
