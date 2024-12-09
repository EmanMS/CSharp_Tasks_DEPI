using System;
using System.ComponentModel;
using System.Linq;

namespace Task05
{
     class Program
    {

        #region Problem2
        //public static void TestDegensiveCode()
        //{
        //    int X, Y, Z;

        //    do
        //        Console.WriteLine("enter first number :");
        //    while (!int.TryParse(Console.ReadLine(), out X) || X <= 0);
        //    do
        //        Console.WriteLine("enter second number :");
        //    while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);
        //    Z = X / Y;

        //    //int[] arr = { 1, 2, 3, 4 };
        //    //if (arr?.Length > 108)
        //    //    arr[108] = 78;
        //} 
        #endregion

        #region Problem9
        // static void SumAndMultiply(int num1 , int num2 , out int sum, out int prod)
        //{            
        //    sum = num1 + num2;
        //    prod = num1 * num2;

        //} 
        #endregion

        #region Problem10
        //static void RepeatStr(string value , int times = 5) {

        //    for (int i = 0; i < times; i++)
        //    {
        //        Console.WriteLine(value);
        //    }
        //} 
        #endregion

        #region Problem13
        //static long sumArray(params int[] nums)
        //{
        //    long sum = 0;
        //    foreach (int num in nums)
        //    {
        //        sum += num;

        //    }
        //    return sum;
        //} 
        #endregion
        static void Main()
        {



            #region Problem1
            //try
            //{
            //    int num1, num2;
            //    num1 = int.Parse(Console.ReadLine());
            //    num2 = int.Parse(Console.ReadLine());
            //    if (num2 == 0)
            //    {
            //        Console.WriteLine("Can not divide by zero !");
            //    }
            //    else
            //    {
            //        int divRes = num2 / num1;
            //        Console.WriteLine(divRes);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //} 
            #endregion

            //TestDegensiveCode();

            #region Problem3
            //int? nullX = null;

            //int num = nullX ?? 5;

            //Console.WriteLine(num);

            //if (nullX.HasValue)
            //{
            //    Console.WriteLine("nullX hase value : " + nullX);
            //}
            //else
            //{
            //    Console.WriteLine("nullX is null !" );
            //}
            //nullX = 22;

            //if (nullX.HasValue)
            //{
            //    Console.WriteLine("nullX hase value : " + nullX);
            //}
            //else
            //{
            //    Console.WriteLine("nullX is null !");
            //} 
            #endregion

            #region Problem4
            //int[] arr = new int[5] {7 ,5 , 1 ,9 ,3 };

            //int idx = 3;
            //try
            //{
            //    if (idx > arr.Length) Console.WriteLine("invalid index");
            //    else Console.WriteLine(arr[idx]);

            //}catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine("Complete operation!"); 
            #endregion

            #region Problem5
            //int[,] m_arr = new int[3,3];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        int val = int.Parse(Console.ReadLine());
            //        m_arr[i, j] = val ;
            //    }
            //}

            //long[] SumOfEachRow = new long[3];
            //long[] SumOfEachCol = new long[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        SumOfEachCol[j] += m_arr[i, j];
            //        SumOfEachRow[i] += m_arr[i, j];
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Row " + i+1 + " : " + SumOfEachRow[i]);
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Col "+ i+1 + " : " + SumOfEachCol[i]);
            //} 
            #endregion

            #region Problem6
            //int[][] JagArr = new int[3][];

            //JagArr[0] = new int[3];
            //JagArr[1] = new int[2];
            //JagArr[2] = new int[4];

            //for (int i = 0; i < JagArr.Length; i++)
            //{
            //    for (int j = 0; j < JagArr[i].Length; j++)
            //    {
            //        int val = int.Parse(Console.ReadLine());
            //        JagArr[i][j] = val;
            //    }
            //}

            //for (int i = 0; i < JagArr.Length; i++)
            //{
            //    for (int j = 0; j < JagArr[i].Length; j++)
            //    {
            //        Console.Write(JagArr[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Problem7
            // string? name = null;

            // Console.WriteLine(" enter string value like ur name !");
            //string  str = Console.ReadLine();

            // if (str != null) 
            //     name = str;

            // Console.WriteLine(name!); 
            #endregion

            #region Problem8
            //int x = 6;
            //Object obj = x;  //box
            //try
            //{
            //    int y = (int)obj;  //unbox valid
            //    Console.WriteLine("Success! " + y);
            //    try
            //    {
            //        Double d = (Double)obj;  //unbox invalid
            //        Console.WriteLine(y);
            //    }catch (InvalidCastException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
            #endregion

            #region Problem9
            //int num1 = 2, num2 = 3 , sum , Prod;
            //SumAndMultiply(num1, num2 ,out sum, out Prod);

            //Console.WriteLine($"the result of sum = {sum}");
            //Console.WriteLine($"the result of product = {Prod}"); 
            #endregion

            #region Prblem10
            //string name = "Eman";

            //RepeatStr(value :name);
            //Console.WriteLine("********************");
            //RepeatStr(value :name, times : 10); 
            #endregion


            #region Problem11
            //int[]? arr = default;

            //int? len = arr?.Length;
            //Console.WriteLine(len); 
            #endregion

            #region Problem12
            //int day = int.Parse(Console.ReadLine());

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine($"{day} -> Saturday");
            //        break;
            //    case 2:
            //        Console.WriteLine($"{day} -> Sunday");
            //        break;
            //    case 3:
            //        Console.WriteLine($"{day} -> Monday");
            //        break;
            //    case 4:
            //        Console.WriteLine($"{day} -> Tuesday");
            //        break;
            //    case 5:
            //        Console.WriteLine($"{day} -> Wednesday");
            //        break;
            //    case 6:
            //        Console.WriteLine($"{day} -> Thursday");
            //        break;
            //    case 7:
            //        Console.WriteLine($"{day} -> friday");
            //        break;

            //} 
            #endregion

            #region Problem13
            //long res = sumArray(3 ,2, 1 ,4 ,5);
            //Console.WriteLine($"sum result =  {res}"); 
            #endregion

            //Part02


            #region Problem1
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write(i + " ");
            //} 
            #endregion

            #region Problem2
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(n * i + " "); 
            //} 
            #endregion


            #region Problem3
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= n; i++)
            //{
            //  if(i % 2 == 0)  Console.Write(i + " ");
            //} 
            #endregion


            #region Problem4
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //long res = 1;
            //for (int i = 0; i < num2; i++)
            //{
            //    res *= num1;
            //}
            //Console.WriteLine($"{num1} power {num2} = {res}"); 
            #endregion


            #region Problem5
            //string word = Console.ReadLine();
            //int len = word.Length;
            //for (int i = len - 1; i >= 0; i--)
            //{
            //    Console.Write(word[i]);
            //} 
            #endregion

            #region Probem6
            //long num = int.parse(console.readline());

            //while (num > 0)
            //{
            //    console.write(num % 10);
            //    num /= 10;
            //}
            ////or take it as string 
            #endregion

            #region Problem7
            /*

                 Console.Write("Enter the no. of  elements : ");
                int n = int.Parse(Console.ReadLine());

                int[] arr = new int[n];
                Console.WriteLine("Enter ur elements :");
                for (int i = 0; i < n; i++)
                {
                    int x = int.Parse(Console.ReadLine());
                    arr[i] = x;
                }

                int maxDis = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            maxDis = Math.Max(maxDis, j - i);
                        }

                    }
                }

                Console.WriteLine($"max distance is {maxDis} ");
                 */ 
            #endregion 

            #region Problem8
            //string Sentence = Console.ReadLine();
            //string temp = "" , reversed = "";
            //for (int i = Sentence.Length - 1; i >= 0; i--)
            //{
            //    temp += Sentence[i];
            //    if (Sentence[i] == ' ')
            //    {
            //        for (int j = temp.Length - 1; j >= 0; j--)
            //        {
            //            reversed += temp[j];
            //        }
            //        reversed += " ";
            //        temp = "";
            //    }
            //}
            //for (int j = temp.Length-1; j >= 0; j--)
            //{
            //    reversed += temp[j];
            //}

            //Console.WriteLine(reversed); 
            #endregion



        }

    }
}
