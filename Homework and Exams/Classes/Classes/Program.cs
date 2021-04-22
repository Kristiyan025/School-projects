using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(5, 3);
            int b = 5;
            double rezult = 0;
            Zadacha('a', ref rezult);
            Zadacha('a', ref rezult);
            Console.WriteLine(rezult);
        }


        static void Zadacha(char a, ref double rezult)
        {
            rezult = 3;
        }

        static void Zadacha(int a, char b)
        {

        }
    }
}
