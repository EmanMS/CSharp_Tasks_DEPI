using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tak08
{
    internal class Shape9 : IComparable
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public Shape9(string name, double area)
        {
            Name = name;
            Area = area;
        }
        public Shape9()
        {

        }
        public int CompareTo(object obj)
        {
            Shape9 PasssShape = (Shape9) obj;
            if (this.Area > PasssShape.Area)
            {
                return 1;
            }
            else if (this.Area < PasssShape.Area)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
