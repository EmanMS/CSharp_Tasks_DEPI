using System;
using System.ComponentModel;
using System.Security.Principal;

namespace task02

{
/*
   class Person { public string Name { get; set; } }              for problem4
  */
    class Program
    {
        static void Main()
        {


            #region Problem1
            //// the first value
            //int x = 10;
            //// the first value
            //int y = 20;
            //// calculation their sum 
            //int sum = x + y;
            //// display the sum 
            //Console.WriteLine(sum); 
            #endregion
            /*-----------------------------------------------------------------*/


            #region Problem2
            /*  : Identify and fix the errors in this code snippet:
              int x = "10";
              console.WriteLine(x + y);
              */

            //int x = 10 , y = 5;

            //Console.WriteLine(x + y); 
            #endregion


            /*----------------------------------------------------------------*/
            #region Problem3
            /*
                 Declare variables using proper naming conventions to store:
                  Your full name.
                  Your age.
                  Your monthly salary.
                  Whether you are a student.
                 */

            /*
            string Name = "Eman Salem";
            int Age = 22;
            decimal MonthlySalary = 15000.0m;
            bool IsStudent = true;
            */
            #endregion

            /*----------------------------------------------------------------*/


            #region Problem4
            /*  //Create a new Person object
                Person person1 = new Person { Name = "Ahmed" };
                // Create a second reference pointing to the same object
                Person person2 = person1;

                // Display initial values
                Console.WriteLine("Before :");
                Console.WriteLine("person1.Name: " + person1.Name);
                Console.WriteLine("person2.Name: " + person2.Name);

                // Change the Name property using one reference
                person1.Name = "Omar";

                // Display values after change
                Console.WriteLine("\n" + "After:");
                Console.WriteLine("person1.Name: " + person1.Name);
                Console.WriteLine("person2.Name: " + person2.Name);
               */
            #endregion


            /*----------------------------------------------------------------*/





            #region Problem5
            //int x = 15, y = 4;
            //int sum = x + y;
            //int dif = (x - y);
            //int product = x * y;
            //int divRes = x/ y;
            //int remainder = x % y;
            //Console.WriteLine(sum + '\n');
            //Console.WriteLine(dif + '\n');
            //Console.WriteLine(product + '\n');
            //Console.WriteLine(divRes + '\n');
            //Console.WriteLine(remainder + '\n'); 
            #endregion

            /*----------------------------------------------------------------*/

            #region Problem6
            /*

              int n ;
              if(n > 10) Console.WriteLine("n is Greater than 10");
              if (n % 2 == 0) Console.WriteLine("n is Even");

              */
            #endregion


            /*----------------------------------------------------------------*/



            #region Problem7
            //Console.WriteLine("Enter ur age");
            //string StringAge = Console.ReadLine();
            //int Age = int.Parse(StringAge);

            //if(Age > 0) Console.WriteLine("Valid Age !");
            //else Console.WriteLine("Not Valid ! Enter a valid Age "); 
            #endregion

            /*----------------------------------------------------------------*/



            #region Problem8
            //int x = 5;
            //    // Prefix increment
            //    Console.WriteLine("Prefix: " + ++x); // Outputs: 6
            //    // Reset x to 5
            //    x = 5;
            //    // Postfix increment
            //    Console.WriteLine("Postfix: " + x++); // Outputs: 5
            //    Console.WriteLine("After Postfix: " + x); // Outputs: 6 
            #endregion

        }
    }
}
