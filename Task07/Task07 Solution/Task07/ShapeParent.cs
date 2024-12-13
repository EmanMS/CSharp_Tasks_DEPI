using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    internal abstract class ShapeParent
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }
        public abstract double CalculateArea();

      

    }

    class RectangleOfShap : ShapeParent
    {
        public double W { get; set; }
        public double H { get; set; }

        public RectangleOfShap(double W ,double H)
        {
            this.W = W;
            this.H = H;
        }
       
        public override double CalculateArea()
        {
            return W * H;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle! ");
        }


    }
}
