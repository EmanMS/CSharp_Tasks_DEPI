using Needed;
using System;
using System.Drawing;
using task6;

namespace task6
{

    #region Problem1
    //public struct Point
    //{
    //    public int X, Y;

    //    public Point(int x, int y)
    //    {
    //        X = x;  // or use this 
    //        Y = y;
    //    }

    //    public override string ToString()
    //    {
    //        return $"x : {X} , y : {Y}";
    //    }
    //} 
    #endregion


    #region Problem3
    //public struct Employee
    //{
    //    private int EmpId;
    //    private string Name;
    //    private decimal Salary;

    //    public decimal Salary1 { get => Salary; set => Salary = value; }
    //    public int EmpId1 { get => EmpId; set => EmpId = value; }

    //    //or
    //    public void SetName(string name)
    //    {
    //        Name = name;
    //    }
    //    public String GetName () {
    //        return Name;
    //    }
    //} 
    #endregion


    #region Problem4
    //public struct Point2
    //{
    //    public int X, Y;

    //    public Point2(int x)
    //    {
    //        X = x;  // or use this 
    //        Y = 0;
    //    }

    //    public Point2(int x , int y)
    //    {
    //        X = x;  
    //        Y = y;
    //    }
    //} 
    #endregion

    public struct Point
    {
        public int X, Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"(x = {X} , y = {Y})";
        }

    }

    class Program
    {
        #region Problem6
        //static void SetPoint(Point p)
        //{
        //    p.X = 10; 
        //    p.Y = 20;
        //}
        //static void SetEmployee(Employee e)
        //{
        //    e.Name = "Wafaa";
        //    e.Salary = 18000;
        //} 
        #endregion
        static void Main() 
        {
            #region Problem1
            //Point p = new Point();
            //p = new Point(2, 5);
            //Console.WriteLine(p.ToString());

            //Point p2 = new Point(9, 3);
            //Console.WriteLine(p2.ToString()); 
            #endregion


            #region Problem2
            // TypeA type1a = new TypeA();
            // TypeB type1b = new TypeB();
            // TypeC type1c = new TypeC();


            // // Console.WriteLine(type.F);  can not access f since it is private
            // Console.WriteLine(type1a.g);
            // Console.WriteLine(type1a.h);


            // //Console.WriteLine(type1b.f);    can not access f since it is private && of typeA
            // //Console.WriteLine(type1c.g);    can not access f since it is private && of typeA
            // //Console.WriteLine(type1c.h);    can not access f since it is private && of typeA


            //TypeX typeX = new TypeX();  //can use this class as (import its project + using it (needed))

            #endregion 




            #region Problem3
            /* 
                Employee emp2 = new Employee();

                emp2.SetName("Eman");
                emp2.EmpId1 = 12;
                emp2.Salary1 = 9500;
                Console.WriteLine($"Employ id : {emp2.EmpId1}");
                Console.WriteLine($"Employ Name : {emp2.GetName()}");
                Console.WriteLine($"Employ Salary : {emp2.Salary1}");
                */
            #endregion

            #region Problem4
            //Point2 pt1 = new Point2(5);
            //Point2 pt2 = new Point2(10 , 20);

            //Console.WriteLine($"point1 X : {pt1.X} , point1 Y : {pt1.Y}");
            //Console.WriteLine($"point2 X : {pt2.X} , point2 Y : {pt2.Y}"); 
            #endregion

            #region Problem5
            //Point p1 = new Point(2, 8);
            //Console.WriteLine(p1);

            //Point p2 = new Point(9, 3);
            //Console.WriteLine(p2.ToString());

            //Point p3 = new Point(1, 5);
            //Console.WriteLine(p3.ToString());
            #endregion

            #region Problem6
            //Point pt1 = new Point();
            //Point pt2 = new Point(3, 4);

            //Employee emp = new Employee("Eman", 15000);

            //SetPoint(pt1);
            //Console.WriteLine($"pt1 values : {pt1}");

            //Console.WriteLine($"pt2 values before : x : {pt2.X} , y : {pt2.Y}");
            //SetPoint(pt2);
            //Console.WriteLine($"pt2 values after :  x : {pt2.X} , y : {pt2.Y}");
            //// Point unchanges


            //Console.WriteLine($"emp values before : Name: {emp.Name} ,salary: {emp.Salary} ");
            //SetEmployee(emp);
            //Console.WriteLine($"emp values after :  Name: {emp.Name} ,salary: {emp.Salary} ");
            //// employee changed 
            #endregion



        }
    }
}

