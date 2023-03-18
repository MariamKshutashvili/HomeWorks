using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__9
{
    internal class Student
    {
        public int ageofstudent { get; set; }
        public string Name { get; set; }
        public string lName { get; set; }
        public int yearOfAcceptance;
        
        public int YearOfAcceptance(int yearOfAcceptance)
        {
            
            return 4-(2023 - yearOfAcceptance); 
            
        }

        public string RandomSubject(string a) 
        {
        
        if (a == "1")
            {
              return "math";
            }
        if (a == "2")
            {
              return "English";
            }
        if (a == "3")
            {
              return "chemistry";
            }
            else
            {
                return "error. only 1, 2, 3";
            }

        }



    }
}
