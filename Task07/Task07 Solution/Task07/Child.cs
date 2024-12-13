﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    internal class Child:Parent
    {
        public int Z { get; set; }


        public Child(int x , int y,int z)  : base(x ,y)     // chaining 
        {
            Z = z;
        }

        public new int Product()
        {
            return base.Product() * Z;
        }


        //public override int Product()
        //{
        //    return X * Y * Z;
        //}


        public override string ToString()
        {
            return $"({X} , {Y} , {Z})";
        }

    }
}
