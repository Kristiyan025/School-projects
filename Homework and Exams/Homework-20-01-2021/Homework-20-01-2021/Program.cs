using System;

namespace Homework_20_01_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            TestZad1();
            TestZad2();
            TestZad3();
        }

        private static void TestZad1()
        {
            // Test zad 1
            Time t1 = new Time();
            Console.WriteLine(t1.Format());

            Time t2 = new Time(2, 23, 34);
            Console.WriteLine(t2.Format());

            try
            {
                Time t3 = new Time(20, 12, 12);
            }
            catch(Exception e)
            {
                Console.WriteLine("Wrong Hour! " + e.Message);
            }

            try
            {
                Time t3 = new Time(20, 60, 12);
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong Minute! " + e.Message);
            }

            try
            {
                Time t3 = new Time(20, 12, 60);
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong Second! " + e.Message);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        private static void TestZad2()
        {
            //Test zad 2
            Circle c1 = new Circle();
            Console.WriteLine(c1.Area());

            Circle c2 = new Circle(3.4);
            Console.WriteLine(c2.Area());

            try
            {
                Circle c3 = new Circle(-2.4);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Rectangle r1 = new Rectangle();
            Console.WriteLine(r1.Area());

            Rectangle r2 = new Rectangle(2.5, 4.7);
            Console.WriteLine(r2.Area());

            try
            {
                Rectangle r3 = new Rectangle(-2, 4.5);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"For parameter '{e.ParamName}': {e.Message}");
            }

            try
            {
                Rectangle r3 = new Rectangle(2, -4.5);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"For parameter '{e.ParamName}': {e.Message}");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        private static void TestZad3()
        {
            //Test zad 3

            Student s1 = new Student();
            Console.WriteLine(s1);

            Student s2 = new Student("Ivan", "Kirilov", "Petrov");
            Console.WriteLine(s2);

            Student s3 = new Student("Ivan", "Petrov");
            Console.WriteLine(s3);

            Student s4 = new Student("Ivan", "Kirilov", "Petrov", 58345398);
            Console.WriteLine(s4);

            Student s5 = new Student("Ivan", "Kirilov", "Petrov", "Informatics", "C#");
            Console.WriteLine(s5);

            Student s6 = new Student("Ivan", "Kirilov", "Petrov", 58345398, "Informatics", "C#");
            Console.WriteLine(s6);

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
