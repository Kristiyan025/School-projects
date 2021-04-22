using System;

namespace dates
{
    class Program
    {

        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            ReturnNDaysForth(ref day, ref month, ref year);
            Console.WriteLine($"{day} {month} {year}");
        }

        static int DaysInMonth(int month, int year)
        {
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (year % 4 == 0 && !(year % 100 == 0 && year % 400 != 0)) return 29;
                    return 28;
            }

            return -1;
        }

        static void After1Day(ref int day, ref int month, ref int year)
        {
            int days = DaysInMonth(month, year);
            if (day == days)
            {
                day = 1;
                if (month == 12)
                {
                    year++;
                    month = 1;
                }
                else
                {
                    month++;
                }
            }
            else
            {
                day++;
            }
        }

        static void ReturnNDaysForth(int n, ref int day, ref int month, ref int year)
        {
            for(int i = 0; i < n; i++)
            {
                Before1Day(ref day, ref month, ref year);
            }
        }

        static void Before1Day(ref int day, ref int month, ref int year)
        {
            if(day == 1)
            {
                if(month == 1)
                {
                    year--;
                    day = 31;
                    month = 12;
                }
                else
                {
                    month--;
                    day = DaysInMonth(month, year);
                }
            }
            else
            {
                day--;
            }
        }

        static double Quadratic(double a, double b, double c)
        {
            double sum = 0;
            if(a == 0) //linear
            {
                if(b == 0) //const
                {
                    if(c == 0)
                    {
                        Console.WriteLine("vsqko x");
                    }
                    else
                    {
                        Console.WriteLine("nrr");
                    }
                }
                else
                {
                    double root = (double)-c / b;
                    Console.WriteLine($"edno reshenie {root:F2}");
                    sum += root;
                }
            }
            else //quadratic
            {
                double d = b * b - 4 * a * c;
                if(d == 0) //x1==x2
                {
                    double root = (double)-b / (2 * a);
                    Console.WriteLine($"repeated root {root:F2}");
                    sum += 2 * root;
                }
                else if(d > 0)
                {
                    double sqrt = Math.Sqrt(d);
                    double root1 = ((double)-b + sqrt) / (2 * a);
                    double root2 = ((double)-b - sqrt) / (2 * a);
                    Console.WriteLine($"x1 = {root1:F2} and x2 = {root2:F2}");
                    sum += root1 + root2;
                }
            }
            return sum;
        }
    }
}
