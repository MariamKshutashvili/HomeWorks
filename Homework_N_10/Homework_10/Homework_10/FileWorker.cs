using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public abstract  class FileWorker
    {
        public int fileMaxSize;
        public abstract int FileExpansion { get; set; }

        public virtual void Read()
        {
            Console.WriteLine("Reading the file of worker ");
        }

        public virtual void Write()
        {
            Console.WriteLine("Writing in the file of worker");
        }

        public virtual void Edit()
        {
            Console.WriteLine("Editing the file of worker ");
        }


        public virtual void Delete()
        {
            Console.WriteLine("Deleting the file of worker");
        }


    }
}
