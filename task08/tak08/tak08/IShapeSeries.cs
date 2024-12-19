using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tak08
{
    internal interface IShapeSeries
    {
        public int CurrentShapeArea { get; set; }
        void GetNextArea();
        void ResetSeries();
       
    }

    class SquareSeries : IShapeSeries
    {
        private int Length;
        public int CurrentShapeArea { get; set; }
        public SquareSeries()
        {
            ResetSeries();
        }

        public void GetNextArea() {
            CurrentShapeArea = Length * Length; 
            Length++; 
        }
        public void ResetSeries()
        {
            Length = 1;
            CurrentShapeArea = Length * Length;
        }


    }

    public class CircleSeries : IShapeSeries
    {
        private int Radius;

        public CircleSeries()
        {
            ResetSeries();
        }

        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            CurrentShapeArea = (int)(Math.PI * Radius * Radius);
            Radius++;
        }

        public void ResetSeries()
        {
            Radius = 1;
            CurrentShapeArea = (int)(Math.PI * Radius * Radius);
        }
    }

}
