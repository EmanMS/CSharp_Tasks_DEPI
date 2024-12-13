using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    public interface IShape
    {
        double Area { get; }

        void Draw();

        //void PrintDetails()
        //{
        //    Console.WriteLine("Default Print");
        //}

        void PrintDetails() { Console.WriteLine($"Area: {Area}"); }
    }

    internal class Rectangle : IShape
    {
        public double W { get; set; }
        public double H { get; set; }

        public Rectangle(double w , double h)
        {
           W = w;
            H = h;
        }
        public double Area     //
        {
            get { return W * H; }
        }
       


        public void Draw()
        {
            Console.WriteLine($"Draw the shape with dimentions width = {W} &  height = {H}");
        }
        /**********************************************/

       
        





    }

    internal class Circle : IShape
    {
        public double red { get; }
        public Circle(double r)
        {
            red = r;  
        }

        public double Area { 
            get
            {
                return 3.14 * red * red;
            }
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        //public void Draw()
        //{
        //   Console.WriteLine("Called form Circle Class" + " Area = {Area}");
        //}


     


    }

}
