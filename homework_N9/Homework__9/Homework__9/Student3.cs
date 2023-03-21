using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__9
{
    internal class Student3
    {
       public string stName;
       public virtual void Study()
        {
           Console.WriteLine("go study!");
        }
         public virtual void Read()
        {
            Console.WriteLine("go read!");
        }
        public virtual void Write()
        {
            Console.WriteLine("go write!");

        }
        public virtual void Relax()
        {
            Console.WriteLine("it is  relax time");

        }


    }
}
