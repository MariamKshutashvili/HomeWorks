using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__9
{
    internal class GoodStudent : Student3
    {
        public override void Relax()
        {
            Console.WriteLine("it is  relax time, you deserve it <3 <3");
            Console.ResetColor();

        }
        public override void Study()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Studying is good");
        }
        public override void Read()
        {
            Console.WriteLine("I love reading");
        }
        public override void Write()
        {
            Console.WriteLine("I write with passion");
        }

    }
}
