using System;

namespace Nasl_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, h;
            bool koq;
            Console.Write("Vuvedete A na usporednika: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Vuvedete B na usporednika: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Vuvedete H na usporednika: ");
            h = double.Parse(Console.ReadLine());
            Console.Write("Vuvedete za koq strana e H na usporednika (A / B)? ");
            char c = (char)Console.Read();
            koq = (c == 'A');

            Usporednik u = new Usporednik(a, b, h, koq);
            Console.WriteLine($"Perimetyr: {u.Perimetyr():F2}");
            Console.WriteLine($"Plosht: {u.Plosht():F2}");

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Vuvedete A na romba: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Vuvedete H na romba: ");
            h = double.Parse(Console.ReadLine());

            Romb r = new Romb(a, h);
            Console.WriteLine($"Perimetyr: {r.Perimetyr():F2}");
            Console.WriteLine($"Plosht: {r.Plosht():F2}");
        }
    }
}
