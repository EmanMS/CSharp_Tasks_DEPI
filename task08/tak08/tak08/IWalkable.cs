using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tak08
{
    internal interface IWalkable
    {
        void Walk();
    }
    class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Through Robot method.");
        }

        void IWalkable.Walk()
        {
            Console.WriteLine("Through IWalkable interface method.");
        }


    }
}
