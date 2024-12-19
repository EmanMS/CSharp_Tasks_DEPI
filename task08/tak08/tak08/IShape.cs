using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tak08
{
    public interface IShape
    {
        public double GetArea();
        void Display();


    }

    public class Rectangle2 : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double GetArea()
        {
            return Width * Height;
        }
        
        public void Display()
        {
            Console.WriteLine($"The area of the shape is: {GetArea()}");
        }

    }

    public class Circle2 : IShape
    {
        public double Radius { get; set; }
       
        public double GetArea()
        {
            return 3.14 * Radius * Radius;
        }

        public void Display()
        {
            Console.WriteLine($"The area of the shape is: {GetArea()}");
        }

    }



}
