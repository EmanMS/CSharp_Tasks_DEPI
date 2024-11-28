using System;
using System.Text;

namespace Task03
{

    class MyClass
    {
        public int Val { get; set; }
    }
        class Program
        {
            static void Main()
            {
            //Part01

            #region Problem1

            //try
            //{
            //    string StrAge = Console.ReadLine();
            //    int intAge1 = int.Parse(StrAge);
            //    int intAge2 = Convert.ToInt32(StrAge);
            //}
            //catch (FormatException fe)
            //{
            //    Console.WriteLine("error!  " + fe.Message);
            //}
            //catch(OverflowException oe)
            //{
            //    Console.WriteLine("error!  " + oe.Message);
            //} 
            #endregion


            #region Problem2
            //Console.WriteLine("Enter a number ");
            //string s = Console.ReadLine();
            //int num;

            //if (int.TryParse(s, out num))
            //{
            //    Console.WriteLine(num);
            //}
            //else
            //{
            //    Console.WriteLine("error ! : the input not valid!");
            //}
            #endregion


            #region Problem3
            //object obj1;
            //obj1 = 5;        //int
            //Console.WriteLine(obj1.GetHashCode());

            //obj1 = 5.544;        //double
            //Console.WriteLine(obj1.GetHashCode());

            //obj1 = "Eman";        //string
            //Console.WriteLine(obj1.GetHashCode()); 
            #endregion


            #region Problem4
            //MyClass c1 = new MyClass();
            //c1.Val = 5;
            //Console.WriteLine("c1 Before " + c1.Val);

            //MyClass c2 = c1;
            //c2.Val = 10;
            //Console.WriteLine("c1 After " + c1.Val);
            #endregion


            #region Problem5
            //string s1 = "Hello";
            //Console.WriteLine("s1: " + s1);
            //Console.WriteLine(" s1_HashCode: " + s1.GetHashCode());

            //string s2 = s1 + " Hi Willy";
            //Console.WriteLine("s2: " + s2);
            //Console.WriteLine("s2_HashCode: " + s2.GetHashCode()); 
            #endregion





            #region Problem6
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int sum = a + b;

            //// Concat
            //Console.WriteLine(a + " + " + b + " = " + sum);

            //// formatting
            //Console.WriteLine(string.Format("{0} + {1} = {2}", a, b, sum));

            //// String interpolation
            //Console.WriteLine($" {a} + {b} = {sum} "); 
            #endregion




            #region Problem7
            /*Create a program using StringBuilder to: o Append text. 
             * o Replace a substring. 
             * o Insert a string at a specific position. 
             * o Remove a portion of text.
             */
            //StringBuilder strb = new StringBuilder("I am Eman Salem");
            //strb.Append(", How are you today?");
            //Console.WriteLine(strb.ToString());


            //strb.Replace("Salem", "Mohamed");
            //Console.WriteLine(strb.ToString());
            //strb.Insert(0, "Hello ");
            //Console.WriteLine(strb.ToString());

            //strb.Remove(6, 10);
            //Console.WriteLine(strb.ToString());
            #endregion





        }

    }
}
