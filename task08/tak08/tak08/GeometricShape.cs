using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tak08
{
    internal abstract class GeometricShape
    {
        public  double Dimension1 { get; set; }
        public double Dimension2 { get; set; }
        public abstract double Perimeter { get; }

        public abstract double CalculateArea();

    }

    class Triangle : GeometricShape
    {

        public override double CalculateArea()
        {
            return 0.5 * Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get
            {
                return Dimension1 + Dimension2 + Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2);
            }
        }
    }

    class Rrectangle : GeometricShape
    {
        public override double Perimeter {
            get { return 2 * (Dimension1 + Dimension2);
            }
        }


        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }
    }
   


}
