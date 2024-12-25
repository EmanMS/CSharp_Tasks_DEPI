using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using task09;

namespace task09
{
    #region Prob1
    //enum Days{
    //    Monday =1,
    //    Tuesday ,
    //    Wednesday ,
    //    Thursday ,
    //    Friday ,
    //    Saturday,
    //    Sunday ,

    //} 
    #endregion

    #region Prob2
    //enum Grades : short
    //{
    //    A, B, C, D, E, F = 1
    //} 
    #endregion

    #region Prob3
    //enum Gender : byte
    //{
    //    Male = 1,
    //    Female
    //}
    //class Person
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public Gender gender { get; set; }
    //    public string Department { get; set; }

    //    public Person(int id , string name , Gender gender , string dep) {
    //        Id = id;
    //        Name = name;
    //        this.gender = gender;
    //        Department = dep;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Person Info: ID: {Id} , Name: {Name} , Gender: {gender} , Department: {Department} ";
    //    }

    //} 
    #endregion

    #region Prob4
    //internal class Parent
    //{
    //    public virtual void Print()
    //    {
    //        Console.WriteLine("Parent");
    //    }
    //    private int salary;

    //    // virtual prop
    //    public virtual int Salary
    //    {
    //        get { return salary; }
    //        set { salary = value + 1000; }
    //    }

    //}
    //internal class Child : Parent
    //{
    //    // sealed method
    //    public sealed override void Print()
    //    {
    //        Console.WriteLine("Child");
    //    }
    //    // sealed prop
    //    public sealed override int Salary
    //    {
    //        get { return base.Salary; }
    //        set { base.Salary = value + 2000; }
    //    }

    //    public void DisplaySalary()
    //    {
    //       Console.WriteLine($"Salary = { Salary}");
    //    }
    //} 
    #endregion

    #region Prob5
    //internal static class utility
    //{
    //    //public int x { get; set; }
        //public int y { get; set; }

        //public utility(int _x,int _y)
        //{
        //    x = _x;
        //    y = _y;
        //}

        //public static double cmtoinch(double cm)
        //{
        //    return cm / 2.54;
        //}
        //public static double calccirclearea(double radius)
        //{
        //    return Math.PI * radius * radius;
        //}
        //public static double ConvertTemperature(double temperature, string fromUnit, string toUnit)
        //{
        //    if (fromUnit.Equals("Celsius", StringComparison.OrdinalIgnoreCase)
        //        && toUnit.Equals("Fahrenheit", StringComparison.OrdinalIgnoreCase))
        //    {
        //        return (temperature * 9 / 5) + 32;
        //    }
        //    else if (fromUnit.Equals("Fahrenheit", StringComparison.OrdinalIgnoreCase)
        //        && toUnit.Equals("Celsius", StringComparison.OrdinalIgnoreCase))
        //    {
        //        return (temperature - 32) * 5 / 9;
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Invalid units");
        //    }
        //}
        #region Prob5
        //public static double calcrectangleperimeter(double width, double height)
        //{
        //    return (height * width) * 2;
        //} 
        #endregion
    }
    #endregion

    #region Prob6
    //internal class ComplexNumber
    //{
    //    public int Real { get; set; }
    //    public int Imag { get; set; }

    //    public override string ToString()
    //    {
    //        return $"{Real} + {Imag}i";
    //    }

    //    // this
    //    public static ComplexNumber operator +(ComplexNumber Left, ComplexNumber Right)
    //    {
    //        // my own implementattion ?
    //        // Derefrencing
    //        return new ComplexNumber()
    //        {
    //            Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
    //            Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0),
    //            // Left.real = lef.Real is not null ? left.Real : null >> ?  
    //        };
    //    }
    //    public static ComplexNumber operator -(ComplexNumber Left, ComplexNumber Right)
    //    {
    //        // my own implementattion ?
    //        return new ComplexNumber()
    //        {
    //            Real = Left.Real - Right.Real,
    //            Imag = Left.Imag - Right.Imag,
    //        };
    //    }

    //    public static ComplexNumber operator *(ComplexNumber Left, ComplexNumber Right)
    //    {
    //        return new ComplexNumber()
    //        {

    //            Real = Left.Real * Right.Real - Left.Imag * Right.Imag,
    //            Imag = Left.Real * Right.Imag + Left.Imag * Right.Real,

    //        };
    //    }
    //} 
    #endregion

    #region Prob7
    enum Gender : byte
    {
        Male = 1,
        Female
    }
    enum IntGender
    {
        Male = 1,
        Female
}
#endregion

#region Prob14
//public class Department
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public Department(int id, string name)
//    {
//        Id = id;
//        Name = name;
//    }

//    public override string ToString()
//    {
//        return Name;
//    }
//}

//public class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public double Salary { get; set; }
//    public Department Department { get; set; }

//    public Employee(int id, string name, double salary, Department department)
//    {
//        Id = id;
//        Name = name;
//        Salary = salary;
//        Department = department;
//    }

//    public override string ToString()
//    {
//        return $"Id: {Id}, Name: {Name}, Salary: {Salary}, Department: {Department.Name}";
//    }
//}


//public class Helper4
//{     
//    public static Employee[] SearchArray(Employee[] emps, string deptName)
//        {
//            List<Employee> ans = new List<Employee>();
//            foreach (var e in emps)
//            {
//                if (e.Department.Name.Equals(deptName, StringComparison.OrdinalIgnoreCase))
//                {
//                   ans.Add(e);
//                }
//            }
//            return ans.ToArray();
//        }
//}

#endregion


#region Prob17
//public class GenericStack<T>
//{
//    private Node<T> top;
//    private int size;

//    private class Node<T>
//    {
//        public T Data { get; set; }
//        public Node<T> Next { get; set; }

//        public Node(T data)
//        {
//            Data = data;
//        }
//    }

//    public GenericStack()
//    {
//        top = null;
//        size = 0;
//    }

//    public void Push(T item)
//    {
//        Node<T> newNode = new Node<T>(item);
//        newNode.Next = top;
//        top = newNode;
//        size++;
//    }

//    public T Pop()
//    {
//        if (IsEmpty())
//        {
//            throw new InvalidOperationException("Stack is empty");
//        }
//        T item = top.Data;
//        top = top.Next;
//        size--;
//        return item;
//    }

//    public T Peek()
//    {
//        if (IsEmpty())
//        {
//            throw new InvalidOperationException("Stack is empty");
//        }
//        return top.Data;
//    }

//    public bool IsEmpty()
//    {
//        return top == null;
//    }

//    public int Size()
//    {
//        return size;
//    }
//} 
#endregion

public class HelperP02
{
    public static void Swap<T>(T[] arr, int idx1, int idx2)
    {
        if (arr == null)
        {
            throw new ArgumentNullException(nameof(arr));
        }

        if (idx1 < 0 || idx1 >= arr.Length || idx2 < 0 || idx2 >= arr.Length)
        {
            throw new ArgumentOutOfRangeException("out of bound!");
        }

        T temp = arr[idx1];
        arr[idx1] = arr[idx2];
        arr[idx2] = temp;
    }


    public static T GetMax<T>(T[] arr) where T : IComparable<T>
    {
     
        T max = arr[0];
        foreach (T item in arr)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }
        return max;
    }

}



public enum Grades { A, B, C, D, F }

#region Prob12

//public static class Helper2<T>
//{
//    // Search array >> return Index
//    public static int SearchArray(T[] arr, T value)
//    {
//        for (int i = 0; i < arr?.Length; i++)
//        {
//            if (value.Equals(arr[i]))
//                return i;
//        }
//        return -1;
//    }

//    public static void ReplaceArray(T[] arr, T Before, T After)
//    {
//        for (int i = 0; i < arr?.Length; i++)
//        {
//            if (Before.Equals(arr[i]))
//            {
//                arr[i] = After;
//            }
//        }
//    }
//} 
#endregion

#region Prob13
//public struct Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public override string ToString()
//    {
//        return $"width: {Width} , Height: {Height}";
//    }

//}

//public static class Helper3
//{
//    public static void Swap(ref Rectangle rect1, ref Rectangle rect2)
//    {
//        Rectangle temp = rect1;
//        rect1 = rect2;
//        rect2 = temp;
//    }
//} 
#endregion

/*custom struct Circle with properties Radius and Color*/
#region Prob15

//public struct Circle
//{
//    public double Radius { get; set; }
//    public string Color
//    {
//        get; set;
//    }

//    public Circle(double radius, string color)
//    {
//        Radius = radius;
//        Color = color;
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj is Circle)
//        {
//            var other = (Circle)obj;

//            return this.Radius == other.Radius && this.Color == other.Color;
//        }
//        return false;

//    }
//    public override int GetHashCode() { 
//        return (Radius, Color).GetHashCode();
//    }
//    public static bool operator ==(Circle left, Circle right) {
//        return left.Equals(right);
//    }
//    public static bool operator !=(Circle left, Circle right)
//    {
//        return !(left == right);
//    }
//}

//public class CircleClass
//{
//    public double Radius { get; set; }
//    public string Color { get; set; }
//    public CircleClass(double radius, string color) { 
//        Radius = radius; Color = color;
//    }
//    public override bool Equals(object obj) { if (obj is CircleClass) {
//            var other = (CircleClass)obj; return this.Radius == other.Radius && this.Color == other.Color;
//        }
//        return false;
//    }
//    public override int GetHashCode() { return (Radius, Color).GetHashCode(); }
//    public static bool operator ==(CircleClass left, CircleClass right) { if (ReferenceEquals(left, right)) { return true; }
//        if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) { 
//            return false;
//        }
//        return left.Equals(right); 
//    }
//    public static bool operator !=(CircleClass left, CircleClass right) { return !(left == right); }

//} 
#endregion

#region Prob16
//public static class HelperP2
//{
//    public static T[] Reverse<T>(T[] arr)
//    {
//        T[] t = new T[arr.Length];

//        for (int i = 0; i < arr.Length; i++) {
//            t[i] = arr[arr.Length - 1 - i];
//        }
//        return t;
//    }
//}

public class Custom
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Custom(int id, string name)
    {
        Id = id; Name = name;
    }
    public override string ToString()
    {
        return $"[id={Id}, name={Name}]";
    }
}
#endregion
class Program
{

    /*Write a non-generic Swap method for a custom struct Rectangle with properties Length and
Width. Create instances of Rectangle and demonstrate swapping their values.*/

    #region prob10
    //static class Helper
    //{
    //    public static void Swap<T>(ref T x, ref T y) 
    //    { 
    //        T temp = x; x = y; y = temp;
    //    }
    //    public static int SearchArr<T>(T[] arr, T value) 
    //    { 
    //        for (int i = 0; i < arr?.Length; i++) {
    //            if (value.Equals(arr[i])) return i; 
    //        } return -1;
    //    }
    //    public static T GetMax<T>(T x, T y) where T : IComparable<T> 
    //    { 
    //        return x.CompareTo(y) > 0 ? x : y;
    //    }
    //}
    #endregion

   




    static void Main()
    {
        #region Prob1
        //foreach (Days day in Enum.GetValues(typeof(Days)))
        //{ 
        //  Console.WriteLine($"{(int)day} : {day} ");
        //} 
        #endregion

        #region Prob2
        //foreach (Grades grade in Enum.GetValues(typeof(Grades)))
        //{
        //    Console.WriteLine($"{(int)grade} : {grade} ");
        //} 
        #endregion

        #region Prob3
        //Person person1 = new Person(1, "Kamal", Gender.Male, "HR");
        //Person person2 = new Person(2 , "Amira" , Gender.Female , "PR");
        //Console.WriteLine(person1);
        //Console.WriteLine(person2); 
        #endregion

        #region Prob4
        //Child child = new Child();
        //child.Salary = 8000; //+3000 = 11000
        //child.DisplaySalary(); 
        #endregion

        #region Prob5
        //Console.WriteLine(Utility.CalcRectanglePerimeter(2, 4)); 
        #endregion

        #region Prob6
        //ComplexNumber compA = new ComplexNumber();
        //ComplexNumber compB = new ComplexNumber();
        //compA.Real = 3;
        //compA.Imag = 5;

        //compB.Real = 2;
        //compB.Imag = 6;

        //Console.WriteLine(compA * compB); 
        #endregion

        #region Prob7
        //default int
        //Console.WriteLine(IntGender.Female); //2
        //Console.WriteLine(IntGender.Male);//1
        //Console.WriteLine((IntGender)1);
        //Console.WriteLine((IntGender)2);
        //Console.WriteLine((IntGender)300);
        //Console.WriteLine((IntGender)300000000);
        //// Console.WriteLine((IntGender)3000000000);//out of boubd -> compile-time error 



        ////byte
        //Console.WriteLine((byte)Gender.Female);//2
        //Console.WriteLine((byte)Gender.Male);//1
        //Console.WriteLine((Gender)1);
        //Console.WriteLine((Gender)2);
        //Console.WriteLine((Gender)200); //200
        //Console.WriteLine((Gender)255); //255 max value

        // Console.WriteLine((Gender)256); //out of boubd -> compile-time error 

        #endregion

        #region Prob8
        //Console.WriteLine(utility.ConvertTemperature(25, "Celsius", "Fahrenheit"));   // 77 f       
        #endregion

        #region Prob9
        //string[] str = { "A", "B", "C", "D", "E", "M" };

        //foreach (var it in str) {

        //    if (Enum.TryParse(it, true, out Grades grade))
        //    {

        //        Console.WriteLine($" '{it}' : {grade}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"'{it}' invalid");
        //    }

        #endregion

        #region Prob10
        //Employee[] emplist = new Employee[] {
        //    new Employee(1, "Ahmed", 8000m, 29),
        //    new Employee(2, "Ali", 16000m, 38),
        //    new Employee(3, "Omar", 15000m, 30) };

        //Employee SearchForEmp = new Employee(2, "Ziad", 11000m, 33);

        //if (Helper<Employee>.SearchArr(emplist, SearchForEmp) != -1) 
        //    Console.WriteLine($"found");
        //else Console.WriteLine("not found"); 
        #endregion

        #region Prob11
        //Console.WriteLine(Helper.GetMax(2, 5));
        //Console.WriteLine(Helper.GetMax(20.5, 15.5));
        //Console.WriteLine(Helper.GetMax("Eman", "Amr"));
        #endregion


        #region Prob12
        //int[] arr = { 1, 2, 3, 4, 5, 2, 2, 2 };
        //String[] strings = { "Eman", "Eman", "Omar", "Eman" };

        //Helper2<int>.ReplaceArray(arr,2 , 7);
        //foreach (int i in arr)
        //{
        //    Console.Write(i + " ");
        //}
        //Console.WriteLine();
        //Helper2<string>.ReplaceArray(strings,"Eman" , "Salem");
        //foreach (string i in strings)
        //{
        //    Console.Write(i + " ");
        //} 
        #endregion

        #region Prob13
        //Rectangle rectA = new Rectangle(3 ,4);
        //Rectangle rectB = new Rectangle(2, 5);

        //Helper3.Swap(ref rectA,ref rectB);

        //Console.WriteLine("RectA: "+rectA);
        //Console.WriteLine("RectB: "+rectB); 
        #endregion

        #region Prob14
        //Department JvDepart = new Department(1, "Java");
        //Department HRDepart= new Department(3, "HR");

        //Employee[] employees = new Employee[] { 
        //    new Employee(1, "Ahmed", 40000, JvDepart), 
        //    new Employee(2, "Basel", 20000, HRDepart), 
        //    new Employee(3, "Omar", 50000, HRDepart),
        //    new Employee(4, "Menna", 65000, JvDepart)
        //};

        //Employee[] hrEmployees = Helper4.SearchArray(employees, "Java");

        //Console.WriteLine("in HR :");
        //foreach (var emp in hrEmployees) { 
        //    Console.WriteLine(emp);
        //} 
        #endregion

        #region Prob15

        //Circle struc1 = new Circle(2.5, "red");
        //Circle struc2 = new Circle(7, "green");
        //Circle struc3 = new Circle(7, "green");


        //CircleClass c1 = new CircleClass(2.5, "red");
        //CircleClass c2 = new CircleClass(7, "green");
        //CircleClass c3 = new CircleClass(7, "green");


        //Console.WriteLine($"c1 == c2: {c1 == c2}"); 
        //Console.WriteLine($"c1.Equals(c2): {c1.Equals(c2)}"); 
        //Console.WriteLine($"c2 == c3: {c2 == c3}"); 
        //Console.WriteLine($"c2.Equals(c3): {c2.Equals(c3)}"); 
        #endregion

        #region Prob16
        //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        //int [] RevArr = HelperP2.Reverse(arr); 

        //foreach (int i in RevArr)
        //{
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine("**************");

        //string[] names = { "Ali", "Fatma", "Shady", "Omar"};
        //string[] RevStr = HelperP2.Reverse(names);
        //foreach (string i in RevStr)
        //{
        //    Console.WriteLine(i);
        //}

        //Custom[] Objects =
        //{
        //    new Custom(2 , "Sameh")
        //    , new Custom(4 , "Amira"),
        //    new Custom(6 , "Menna")
        //};

        //Console.WriteLine("**************");

        //Custom[] NewReversedObj = HelperP2.Reverse(Objects);
        //foreach (Custom obj in NewReversedObj) {
        //    Console.WriteLine(obj);
        //}

        #endregion


        #region Prob17
        //GenericStack<int> stack = new GenericStack<int>();
        //stack.Push(1);
        //stack.Push(2);
        //Console.WriteLine(stack.Peek());
        //stack.Pop();
        //Console.WriteLine(stack.Size());

        //GenericStack<string> stack2 = new GenericStack<string>();
        //stack2.Push("Ali");
        //stack2.Push("Eman");
        //Console.WriteLine(stack2.Peek());
        //stack2.Push("Salem");
        //stack2.Pop();
        //Console.WriteLine(stack2.Size());

        //GenericStack<Custom> stack3 = new GenericStack<Custom>();
        //stack3.Push(new Custom(2 , "Ali"));
        //stack3.Push(new Custom(4, "Eman"));
        //Console.WriteLine(stack3.Peek());
        //stack3.Push(new Custom(6, "Salem"));
        //stack3.Pop();
        //Console.WriteLine(stack3.Size()); 
        #endregion
        #region Prob18
        ////             0  1  2  3  4  5  6  7
        //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
        //HelperP02.Swap(nums, 2, 6);
        //foreach (int i in nums)
        //{
        //    Console.Write(i + " ");
        //} 
        #endregion


        int[] nums = { 1, 2, 3, 4, 10, 6, 7, 8 };
        Console.WriteLine(HelperP02.GetMax<int>(nums)); // 10






    }


}
