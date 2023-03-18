using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__9
{
    internal class Teacher
    {
        public string teachName { get; set; }
        public bool IsCertified;

        public string Test(string n)
        {   
            if (IsCertified == false)
            {   if (n == "math"){
                   var g= "3+5=8";
                    return g;
                }
                if(n == "English")
                {
                   var g= "I never saw a purple cow,\r\nI never hope to see one," +
                        "\r\nBut I can tell you, anyhow,\r\nI’d rather see than be one!";
                    return g;
                }
                if(n == "chemistry")
                {
                    var g= "NH3 (Ammonia), CO2 (Carbon dioxide), " +
                        "CH4 (Methane), SO2 (Sulfur dioxide)";
                    return g;
                } else
                {
                   return "The eacher is not competent";
                }

                 
            } else
            {
               return "The teacher is  competent";
            }

        }
    }
}
