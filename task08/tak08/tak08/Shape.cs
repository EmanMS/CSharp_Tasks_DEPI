using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tak08
{
    internal abstract class Shape
    {
       public abstract double GetArea();
        public void Display()
       {
            Console.WriteLine($"The area of the shape is: {GetArea()}");
        }
       
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Circle : Shape
    {
        public double Redius { get; set; }
        public override double GetArea()
        {
            return Redius * Redius * 3.14;
        }
    }
}
