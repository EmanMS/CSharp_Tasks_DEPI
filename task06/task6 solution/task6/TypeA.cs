using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    public class TypeA
    {
        private int f;
        internal int g;
        public int h;

        public int Getf() { return f; }


    }


    class TypeB : TypeA
    {
        public int x;
    }
    class TypeC 
    {
        public int y;
    }
}
