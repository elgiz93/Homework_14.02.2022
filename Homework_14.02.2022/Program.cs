using System;

namespace Homework_14._02._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1

            //Console.WriteLine("1ci ededi daxil edin");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("2ci ededi daxil edin");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("3cu ededi daxil edin");
            //int z = int.Parse(Console.ReadLine());
            //if (x == y || y == z || x == z)
            //        Console.WriteLine("Daxil edilen ededlerde beraberlik var");
            //else
            //Console.WriteLine("Daxil edilmish ededlerin en boyuyu >>>"+task1(x,y,z));
            #endregion


            #region task2

            //Console.WriteLine("Ededi daxil edin");
            //int x = int.Parse(Console.ReadLine());
            //if (x <= 0)
            //    Console.WriteLine("Duzgun eded daxil edin!");
            //else
            //    Console.WriteLine("Reqemlerin cemi>>>" + task2(x));

            #endregion

            #region task3

            Console.WriteLine("1ci malin deyerini daxil edin");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("2ci malin deyerini daxil edin");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("3cu malin deyerini daxil edin");
            double z = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0 && z > 0)
                Console.WriteLine("Odenilecek mebleg >>>" + task3(x, y, z));
            else
                Console.WriteLine("Malin deyerini duzgun daxil edin!");

            #endregion

        }

        static int task1(int a, int b, int c)
        {
            
            if (a > b && a > c)
                return a;
            else if (b > a && b > c) 
                return b;
            else if (c > a && c > b)
                return c;
            else 
                return 0;

        }
        static int task1(int a, int b, int c,int d)
        {

            if (a > b && a > c && a > d)
                return a;
            else if (b > a && b > c && b > d)
                return b;
            else if (c > a && c > b && c > d)
                return c;
            else if (d > a && d > b && d > c)
            return d;
            else
                return 0;

        }
        static int task1(int a, int b, int c, int d,int e)
        {

            if (a > b && a > c && a > d && a > e)
                return a;
            else if (b > a && b > c && b > d && b > e)
                return b;
            else if (c > a && c > b && c > d && c > e)
                return c;
            else if (d > a && d > b && d > c && c > d)
                return d;
            else if (e > a && e > b && e > c && e > d)
                return e;
            else
                return 0;

        }

        static int task2(int a)
        {
            int sum = 0;
            for (int i = 0; a!=0; i++)
            {
                sum += a % 10;
                a = (a - (a % 10)) / 10;
            }
            return sum;

        }

        static double task3(double a,double b,double c)
        {
            if (a <= b && a <= c)
                return b+c;
            else if (b <= a && b <= c)
                return a+c;
            else if (c <= a && c <= b)
                return b+a;
            else
                return 0;
        }










    }


}
