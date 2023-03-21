using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public class FileEmployee : FileWorker
    {
        int fileExpansion = 0;
        public override int FileExpansion 
        { get => fileExpansion; 
        set => fileExpansion = value; }

        public override void Read()
        {
            Console.WriteLine("Reading the file of employee ");
        }

        public override void Write()
        {
            Console.WriteLine("Writing in the file of employee ");
        }

        public override void Edit()
        {
            Console.WriteLine("Editing the file of employee  ");
        }


        public override void Delete()
        {
            Console.WriteLine("Deleting the file of employee ");
        }





    }
}
