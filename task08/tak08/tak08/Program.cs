using System;
using System.Collections.Generic;

namespace tak08
{
    internal class Program
    {

        #region Prob9
        //public static void PrintTenShapes(IShapeSeries series)
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        series.GetNextArea();
        //        Console.WriteLine($"Shape {i} area: {series.CurrentShapeArea}");
        //    }
        //} 
        #endregion

        public static void SelectionSort(int[] nums)
        {
            int n = nums.Length;

            for (int i = 0; i < n - 1; i++)
            {
               
                int MinIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[j] < nums[MinIdx])
                    {
                        MinIdx = j;
                    }
                }

                int temp = nums[MinIdx];
                nums[MinIdx] = nums[i];
                nums[i] = temp;
            }
        }

        static void Main()
        {
            #region Problem1
            //Car car = new Car();
            //car.StartEngine();
            //car.StopEngine();

            //Bike bike = new Bike();
            //bike.StartEngine();
            //bike.StopEngine(); 
            #endregion

            #region Prob2
            ////abstract class
            //Rectangle rect = new Rectangle();
            //rect.Width = 3;
            //rect.Height = 3;
            //rect.Display();

            //Circle circ = new Circle();  
            //circ.Redius = 2.6;
            //circ.Display();

            //// interface
            //Rectangle2 rect2 = new Rectangle2();
            //rect2.Width = 4;
            //rect2.Height = 4;
            //rect2.Display();
            //Circle2 circ2 = new Circle2();
            //circ2.Radius = 5;
            //circ2.Display(); 
            #endregion

            #region Prob3
            //Product[] products = new Product[]
            //{
            //     new Product ( 1, "Laptop", 999.99),
            //     new Product (2,"phone",  699.99),
            //     new Product ( 3, "Tablet", 399.99),
            //     new Product ( 4, "Phone", 199.99)
            //};

            //Array.Sort(products);

            //foreach (Product p in products)
            //{
            //    Console.WriteLine($"id: {p.Id}, name: {p.Name}, price: {p.Price}");
            //} 
            #endregion


            #region Prob4
            //Student stud1 = new Student(1, "Ahmed", 97.5);

            //// Shallow 
            //Student stud2 = stud1;
            //// deep 
            //Student stud3 = new Student(stud1);

            //Console.WriteLine("Student 1 " +stud1.ToString()); //84
            //Console.WriteLine("Student 2 " + stud2.ToString());//84
            //Console.WriteLine("Student 3 " + stud3.ToString());//84

            //Console.WriteLine("After");
            //stud1.Grade = 84;
            //Console.WriteLine("Student 1 " + stud1.ToString()); // 84
            //Console.WriteLine("Student 2 " + stud2.ToString()); // 84
            //Console.WriteLine("Student 3 " + stud3.ToString()); // 97 
            #endregion

            #region Prob5
            //Robot robot = new Robot();
            //robot.Walk();

            //IWalkable WRobot = robot; 
            //WRobot.Walk(); 
            #endregion



            #region Prob6
            //Account account = new Account(1, "Omar", 18000);

            //Console.WriteLine(account); 
            #endregion

            #region Prob7
            //ILogger consoleLogger = new ConsoleLogger();
            //consoleLogger.Log("-----------Console message--------");

            //ILogger defaultLogger = new DefaultLog();
            //  defaultLogger.Log("-----------default message--------"); 
            #endregion

            #region Prob8
            //Book bk1 = new Book();
            //Book bk2 = new Book("Grokking Algorithms");
            //Book bk3 = new Book("MyBook" , "Eman Salem");

            //Console.WriteLine("Book 1 Info :" + bk1.ToString());
            //Console.WriteLine("Book 1 Info :" + bk2.ToString());
            //Console.WriteLine("Book 1 Info :" + bk3.ToString());

            #endregion

            #region Prob9
            //IShapeSeries CircSeries = new CircleSeries();
            //IShapeSeries SqSeries = new SquareSeries();
            //PrintTenShapes(CircSeries);
            //PrintTenShapes(SqSeries); 
            #endregion


            #region Problem10

            //Shape9[] MyShapes = new Shape9[]
            //{
            //     new Shape9 ("Squqre", 25),
            //     new Shape9 ("Circle",  21.56),
            //     new Shape9 ( "Rectangle", 37.5),
            //     new Shape9 ( "Circle", 19.33)
            //};

            //Array.Sort (MyShapes);

            //foreach (Shape9 s in MyShapes)
            //{
            //    Console.WriteLine($"Shape name: {s.Name}, Area: {s.Area}");
            //} 
            #endregion



            #region Prob11
            //GeometricShape trig = new Triangle { Dimension1 = 3, Dimension2 = 4 };
            //GeometricShape rect = new Rrectangle { Dimension1 = 8, Dimension2 = 9};


            //Console.WriteLine($"Rectangle Area: {trig.CalculateArea()}");
            //Console.WriteLine($"its Perimeter: {trig.Perimeter}");

            //Console.WriteLine($"Triangle Area: {rect.CalculateArea()}");
            //Console.WriteLine($"its Perimeter: {rect.Perimeter}"); 
            #endregion

            #region Prob12
            //Shape9[] myshapes = new Shape9[]
            //{
            //     new Shape9 ("squqre", 25),
            //     new Shape9 ("circle",  21.56),
            //     new Shape9 ( "rectangle", 37.5),
            //     new Shape9 ( "circle", 19.33)
            //};

            //int[] shapeAreas = new int[myshapes.Length];
            //for (int i = 0; i < myshapes.Length; i++)
            //{
            //    shapeAreas[i] = (int)Math.Round(myshapes[i].Area);
            //}

            //SelectionSort(shapeAreas);

            //foreach (Shape9 s in myshapes)
            //{
            //    Console.WriteLine($"shape name: {s.Name}, area: {s.Area}");
            //} 
            #endregion


            #region Problem13
            //ShapeFactory Shapefact = new ShapeFactory();

            //GeometricShape rect = Shapefact.CreateShape("rectangle", 5, 8);
            //GeometricShape trig= Shapefact.CreateShape("triangle", 2.7, 9);

            //Console.WriteLine($"Area: {rect.CalculateArea()}");

            //Console.WriteLine($"TriangleArea: {trig.CalculateArea()}");
            //Console.WriteLine($"Perimeter: {trig.Perimeter}"); 
            #endregion



        }
}

    

}
