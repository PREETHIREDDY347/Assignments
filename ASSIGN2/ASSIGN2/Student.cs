using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGN2
{
    class Student:Person
    {
        private int [] marks;
        public Student(string firstname,string lastname,int Id,int[]marks) :base(firstname,lastname,Id)
        {
            this.marks = marks;
            this.firstname = firstname;
            this.lastname = lastname;
            this.Id = Id;
        }
        public char calculate()
        {
            float avg = 0;
            float sum = 0;
            char grade =' ';
            for (int i = 0,Length = this.marks.Length; i < Length;i++)
                {
                sum = sum + this.marks[i];
            }
            avg = sum / this.marks.Length;
            if(90<=avg&&avg<=100)
            {
                grade = 'O';
            }
            else if (80<=avg&&avg<90)
            {
                grade = 'E';
            }
            else if(70<=avg&&avg<80)
            {
                grade = 'A';
            }
            else if(55<=avg&&avg<70)
            {
                grade = 'P';
            }
            else if(40<=avg&&avg<55)
            {
                grade = 'D';
            }
            else
            {
                grade = 'I';
            }
            return grade;
        }
    }
}
