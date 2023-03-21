using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__9
{
    internal class LazyStudent : Student3
    {
        public override void Relax()
        {           

            Console.WriteLine("You cannot relax, only aafter you are" +
                " finished with the homework! do better!");
            Console.ResetColor();
        }

        public override void Study()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("I don't like studying");
        }
        public override void Read()
        {
            Console.WriteLine("I get bored while reading");
        }
        public override void Write()
        {
            Console.WriteLine("I write with 0 passion");
        }



    }
}
