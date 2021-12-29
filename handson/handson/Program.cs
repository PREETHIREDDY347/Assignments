using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Courses("courses", 10, 100);
            var PartCourse = new PartTimeCourse("PartCourse",10,90);
            var onsite = new OnsiteCourse("onsite", 10, 100);
            courses.Print();
            PartCourse.Print();
            onsite.Print();
        }
    }
}
