using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    internal interface IWritable
    {
       
        void Write();
    }


    class File : IWritable, IReadable
    {
        public void Read()
        {
            Console.WriteLine("read from here!");
        }

        public void Write()
        {
            Console.WriteLine("Write here!");
        }
    }
}
