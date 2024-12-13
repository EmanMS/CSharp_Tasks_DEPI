using System;

namespace Task07
{
    class Program
    {
        static void Main()
        {
            #region Problem1
            //Car c1 = new Car();
            //Console.WriteLine(c1.ToString());

            //Car c2 = new Car(12);
            //Console.WriteLine(c2.ToString());

            //Car c3 = new Car(13 , "BMW");
            //Console.WriteLine(c3.ToString()); 
            #endregion

            #region Problem2
            //Calculator calc1 = new Calculator();
            //Console.WriteLine(calc1.Sum(2,3));
            //Calculator calc2 = new Calculator();
            //Console.WriteLine(calc2.Sum(2, 3 , 5));
            //Calculator calc3 = new Calculator();
            //Console.WriteLine(calc3.Sum(2.5, 3.5)); 
            #endregion

            #region Problem3
            //Parent parent = new Parent(2 ,5);
            //Console.WriteLine("Parent elements: " + parent.X + " " + parent.Y );

            //Child child = new Child(1 ,2 ,3);
            //Console.WriteLine( "Child elements: " +child.X + " " + child.Y + " " + child.Z); 
            #endregion

            #region Problem4
            //Parent parent = new Parent(3 , 4);
            //Child child = new Child(2 , 5, 7);  
            //Console.WriteLine(child.Product());  // by new
            //Console.WriteLine(parent.Product()); 


            //Console.WriteLine(child.Product());    // by override
            //Console.WriteLine(parent.Product()); 
            #endregion

            #region Problem5
            //Parent parent = new Parent(2, 4);
            //Child child = new Child(3,5 , 7);

            //Console.WriteLine(child.ToString());
            //Console.WriteLine(parent.ToString()); 
            #endregion

            #region Problem6
            //Rectangle rect = new Rectangle(3.5 , 4.5);
            //rect.Draw();

            //Console.WriteLine("with Area equals : " + rect.Area ); // 15.75  
            #endregion




            #region Problem7
            // Circle circle = new Circle(2.3);
            // circle.Draw(); 
            ////Console.WriteLine($"Area of the circle: {circle.Area}");
            // circle.PrintDetails(); //   
            #endregion


            #region Problem8
            //CarForIMove MyCar = new CarForIMove("BMW");
            //MyCar.Move();
            //IMovable mov = MyCar;
            //mov.Move();
            #endregion

            #region Problem9
            //File f1 = new File();
            //f1.Read();
            //f1.Write();

            //IReadable read = f1;
            //read.Read();
            //IWritable write = f1;
            //write.Write(); 
            #endregion


            #region Problem10
            //RectangleOfShap rect = new RectangleOfShap(5 ,6);
            //Console.WriteLine(rect.CalculateArea());
            //rect.Draw(); 
            #endregion













        }
    }
}
