using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Student
    {
        private int Rollno;
        private string Name;
        private string Course;
        private int feepaid;
        private static double servicetax = 12.3;

        public Student(int Rollno, string Name, string Course)
        { 
            this.Rollno = Rollno;
            this.Name = Name;
            this.Course = Course;

        }
        public void Payment(int Amount)
        {
            feepaid += Amount;
        }
        public void Print()
        {
            Console.WriteLine("Rollno of Student:{0}", Rollno);
            Console.WriteLine("Name of Student:{0}", Name);
            Console.WriteLine("Course:{0}", Course);
            Console.WriteLine("feepaid:{0}", feepaid);
        }
        public int DueAmountproperty
        {
            get
            {
                return totalfeeproperty - feepaid;
            }
        }
        public int totalfeeproperty
        {
            get
            {
                double total = Course == "c#" ? 2000 : 3000;
                // service tax
                total = total + total * servicetax / 100;
                return (int)total;
            }

        }
        public static double ServiceTax
        {
            get
            {
                return servicetax;
            }
            set
            {
                servicetax = value;
            }
        }
        //public class Tax
        //{
        //    public double ServiceTax { get; set; }


        //    public int DueAmountproperty { get; set; }


        //    public double TotalFee
        //    {
        //        get
        //        {
        //            return DueAmountproperty + DueAmountproperty * ServiceTax;
        //        }
        //    }


        //    public Tax()
        //    {
        //        ServiceTax = 0.123;

        //    }
        //}
    }
}
