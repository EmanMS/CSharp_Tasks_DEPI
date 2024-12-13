﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    internal class Parent
    {
      

        public int X { get; set; }
        public int Y { get; set; }


        public Parent(int x, int y)
        {
            X = x;     // or using this
            Y = y;
        }

        public virtual int  Product()
        {
            return X * Y;
        }

        public override string ToString()
        {
            return $"({X} , {Y})";
        }
    }
}
