using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson
{
    class Courses
    {
        public string name;
        public int duration;
        public int fee;
        public Courses(string name,int duration,int fee)
        {
            this.name = name;
            this.duration = duration;
            this.fee = fee;
        }
        public void Print()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Duration:"+duration);
            Console.WriteLine("fee:" + fee);
        }
        public  virtual double GetTotalFee()
        {
            return fee * duration;
        }
    }
    class PartTimeCourse : Courses
    {
        public int Discount;
        public PartTimeCourse(string name,int duration,int fee):base(name,duration,fee)
        {
            Discount = fee-10;
        }
        public override double  GetTotalFee()
        {
            var total = fee * duration;
            return total - (total * Discount / 100);
        }
    }
    class OnsiteCourse:Courses
    {
        public double charge;
        public OnsiteCourse(string name, int duration, int fee) : base(name, duration, fee)
        {
            charge = 10;
        }
        public override double GetTotalFee()
        {
            var total = fee * duration;
            return total - (total * charge/ 100);
        }
    }
}
