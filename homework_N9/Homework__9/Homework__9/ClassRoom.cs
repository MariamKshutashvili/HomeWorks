using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework__9
{
    internal class ClassRoom
    {   
        public ClassRoom(params Student3[] Students) { }

        public void AllMethods(params Student3[] Students)
        {
            foreach (var student in Students)
            {
                student.Study();
                student.Write();
                student.Read();
                student.Relax();
                
            }
        }

        


    }
}
