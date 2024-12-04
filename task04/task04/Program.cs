using System;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace task04
{
    enum WeekDays
    {
        Saturday = 1,
        Sunday,
        Monday,
        Tuesday,
        Wednesday, 
        Thursday,
        Friday
    }

    class Program
    {
        static void Main()
        {
            //Part01

            #region problem1
            //int[] M1 = { 4, 5, 6 };
            //int[] M2 = new int[] { 7, 8, 9 };
            //int[] M3 = new int[3] { 1, 2, 3 };

            //foreach (int i in M1)
            //{
            //    Console.Write(i + " ");

            //}

            //Console.WriteLine();

            //foreach (int i in M2)
            //{
            //    Console.Write(i + " ");
            //}

            //Console.WriteLine();

            //foreach (int i in M3)
            //{
            //    Console.Write(i + " ");
            //}

            //int index = 10;

            //// IndexOutOfRangeException
            //Console.WriteLine(M2[index]);    // this will get (IndexOutOfRangeException)

            //// Exception handling
            //try
            //{
            //    if (index < M2.Length)
            //    {
            //        Console.WriteLine(M2[index]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Out of Bound");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
            #endregion

            #region Problem2
            //int[] M1 = new int[] { 1, 2, 3 };
            //int[] M2 = new int[] { 7, 8, 9 };

            //M2 = M1;                         // shallow copy
            //Console.Write("M1 Elements :");
            //foreach (int x in M1)
            //{
            //    Console.Write(x + " ");
            //}
            //Console.WriteLine();

            //Console.Write("M2 Elements :");
            //foreach (int x in M2)
            //{
            //    Console.Write(x + " ");
            //}
            //Console.WriteLine();


            //M2 = (int[])M1.Clone();
            //M2[2] = 99;

            ////Console.Write("M1 Elements :");
            ////foreach (int x in M1)
            ////{
            ////    Console.Write(x + " ");
            ////}
            ////Console.WriteLine();

            ////Console.Write("M2 Elements :");
            ////foreach (int x in M2)
            ////{
            ////    Console.Write(x + " ");
            ////}
            ////Console.WriteLine(); 
            #endregion


            #region Problem3
            //int[,] arr = new int[3, 3];         //{ { 17, 18, 20 }, { 15, 12, 13 }, { 20, 18, 16 } };
            //Console.WriteLine("Enter Grades :");

            ////for (int i = 0; i < 3; i++) { 
            ////    for (int j = 0; j < 3; j++) { 
            ////        arr[i, j] = int.Parse(Console.ReadLine()); 
            ////    } 
            ////}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter grades for Student {i + 1}:");
            //    for (int j = 0; j < 3; j++)
            //    {
            //        bool success;
            //        do
            //        {
            //            Console.Write($"Subject {j + 1}: ");
            //            string input = Console.ReadLine();
            //            success = int.TryParse(input, out arr[i, j]);
            //            if (!success)
            //            {
            //                Console.WriteLine("Invalid input. Please enter a valid integer.");
            //            }
            //        }
            //        while (!success);
            //    }
            //}



            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Grades for Student {i + 1}:");
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(arr[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Problem4
            //int [] arr = new int[] { 1, 5, 3 , 9};
            //int [] arr2 = new int[] { 7 , 9 , 4 , 2};
            //int[] arr3 = new int[4];

            //Array.Sort(arr);
            //foreach (int i in arr)
            //{
            //    Console.Write(i + " ");

            //}
            //Console.WriteLine();
            //Array.Reverse(arr);
            //foreach (int i in arr)
            //{
            //    Console.Write(i + " ");

            //}

            //Console.WriteLine();
            //int Index = Array.IndexOf(arr2, 4);
            //Console.WriteLine(Index);//2
            //foreach (int i in arr2)
            //{
            //    Console.Write(i + " ");

            //}
            //Console.WriteLine();

            //Array.Copy(arr, arr3, 3);
            //foreach (int i in arr3)
            //{
            //    Console.Write(i + " ");

            //}
            //Console.WriteLine();

            //Array.Clear(arr, 0, 2); 
            //foreach (int i in arr)
            //{
            //    Console.Write(i + " ");

            //} 
            #endregion

            #region Problem5
            //int[] M = new int []{ 1, 2, 3, 4, 5};
            //// for
            //for (int i = 0; i < M.Length; i++)
            //{
            //    Console.Write(M[i] + " ");
            //}
            //Console.WriteLine();
            ////foreach
            //foreach (int i in M)
            //{
            //    Console.Write(i+ " ");
            //}
            //Console.WriteLine();
            //// While
            //int len = M.Length-1;
            //while (len >= 0)
            //{
            //    Console.Write(M[len] + " ");
            //    len--;
            //} 
            #endregion



            #region Problem6
            //int n;
            //bool f;
            //do
            //{
            //    Console.Write("Enter an odd Positive num: ");
            //    f = int.TryParse(Console.ReadLine(), out n) && (n & 1) == 1;

            //    if (!f) Console.WriteLine("Invalid! try again");
            //} while (!f);
            //Console.WriteLine("Done!"); 
            #endregion


            #region Problem7
            //int[,] v = new int[3,3] { {1, 2, 3 } ,{ 4 , 5 , 6} , { 9, 8, 7 } };

            //for (int i = 0; i < v.GetLength(0); i++)
            //{
            //    for (int j = 0; j < v.GetLength(1); j++)
            //    {
            //        Console.Write(v[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Problem8
            //int n;
            //bool f = int.TryParse(Console.ReadLine(), out n);
            //if (f)
            //{
            //    if (n == 1)
            //    {
            //        Console.WriteLine("January");
            //    }
            //    else if (n == 2)
            //    {
            //        Console.WriteLine("February");
            //    }
            //    else if (n == 3)
            //    {
            //        Console.WriteLine("March");
            //    }
            //    else if (n == 4)
            //    {
            //        Console.WriteLine("April");
            //    }
            //    else if (n == 5)
            //    {
            //        Console.WriteLine("May");
            //    }
            //    else if (n == 6)
            //    {
            //        Console.WriteLine("June");
            //    }
            //    else if (n == 7)
            //    {
            //        Console.WriteLine("July");
            //    }
            //    else if (n == 8)
            //    {
            //        Console.WriteLine("August");
            //    }
            //    else if (n == 9)
            //    {
            //        Console.WriteLine("September");
            //    }
            //    else if (n == 10)
            //    {
            //        Console.WriteLine("October");
            //    }
            //    else if (n == 11)
            //    {
            //        Console.WriteLine("November");
            //    }
            //    else if (n == 12)
            //    {
            //        Console.WriteLine("December");
            //    }
            //}
            //else{
            //    Console.WriteLine("Not Valid");
            //}

            //int n;
            //bool f = int.TryParse(Console.ReadLine(), out n);
            //if (f)
            //{
            //    switch (n)
            //    {
            //        case 1:
            //            Console.WriteLine("January");
            //            break;

            //        case 2:
            //            Console.WriteLine("February");
            //            break;

            //        case 3:
            //            Console.WriteLine("March");
            //            break;
            //        case 4:
            //            Console.WriteLine("April");
            //            break;

            //        case 5:
            //            Console.WriteLine("May");
            //            break;

            //        case 6:
            //            Console.WriteLine("June");
            //            break;

            //        case 7:
            //            Console.WriteLine("July");
            //            break;
            //        case 8:
            //            Console.WriteLine("August");
            //            break;
            //        case 9:
            //            Console.WriteLine("September");
            //            break;
            //        case 10:
            //            Console.WriteLine("October");
            //            break;

            //        case 11:
            //            Console.WriteLine("November");
            //            break;
            //        case 12:
            //            Console.WriteLine("December");
            //            break;

            //    }
            //}
            //  else
            //{
            //    Console.WriteLine("Not Valid");
            //} 
            #endregion

            #region Problem9
            // int[] v = new int[] {8 , 2 , 4 , 7 , 3 , 1 , 5 , 3 , 3};
            //                 //0 1 2 3 4 5 6
            // Array.Sort(v); // 1 2 3 4 5 7 8
            // foreach (int i in v)
            // {
            //     Console.Write(i + " ");
            // }
            // Console.WriteLine();

            // int x = Array.IndexOf(v , 5); // 6
            //Console.WriteLine(x);

            // int y = Array.LastIndexOf(v , 3); // 4
            // Console.WriteLine(y); 
            #endregion


            #region Problem10
            //int[] v = { 1, 2, 3 , 4, 5};
            //int sumfor = 0;
            //for (int i = 0; i < v.Length; i++)
            //{
            //    sumfor += v[i];
            //}
            //Console.WriteLine(sumfor);

            //int sumforeach = 0;
            //foreach (int i in v)
            //{
            //    sumforeach += i;
            //}
            //Console.WriteLine(sumforeach); 
            #endregion

            //Part02

            #region Problem
            //Console.WriteLine("Enter num inbetween (1:7)");

            //if(int.TryParse(Console.ReadLine(), out int numofDay))
            //{
            //    WeekDays day = (WeekDays)Enum.Parse(typeof(WeekDays), numofDay.ToString());
            //    Console.WriteLine(day.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("INvalid");
            //} 
            #endregion 









        }
    }
}