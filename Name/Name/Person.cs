using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Project
{
     public class Person
    {
        public string Name1
        {
            get;
            set;
        }
        
        public int Age
        { 
        
            get;
            set;
        }
            
        public override string ToString()
        {
            return Name1 + "-" + Age;
        }
      
    }
    



}