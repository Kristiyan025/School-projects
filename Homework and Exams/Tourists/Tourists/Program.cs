using System;

namespace Tourists
{
    class Program
    {
        static void Main(string[] args)
        {
            A();
            B();
            C();
            D();
        }

        static void Read(out Tourist[] tourists, out int n)
        {
            n = int.Parse(Console.ReadLine());
            tourists = new Tourist[n];
            for (int i = 0; i < n; i++)
            {
                tourists[i] = new Tourist();
                Console.WriteLine($"Enter the name of the {i + 1}-th tourist: ");
                tourists[i].Name = Console.ReadLine();
                Console.WriteLine($"Enter the gender of the {i + 1}-th tourist(Male / Female): ");
                if (Console.ReadLine() == "Male") tourists[i].Gender = true;
                else tourists[i].Gender = false;
                Console.WriteLine($"Enter the country of the {i + 1}-th tourist: ");
                tourists[i].Country = Console.ReadLine();
                Console.WriteLine($"Enter the age of the {i + 1}-th tourist: ");
                tourists[i].Age = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter how many days will the {i + 1}-th tourist stay in Bulgaria: ");
                tourists[i].Duration = int.Parse(Console.ReadLine());
            }
        }

        static void A()
        {
            int n;
            Tourist[] tourists;
            Read(out tourists, out n);
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += tourists[i].Age;
            }

            Console.WriteLine($"Average Age: {1.0 * sum / n:D3}");
        }

        static void B()
        {
            int n;
            Tourist[] tourists;
            Read(out tourists, out n);
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (!tourists[i].Gender) count++;
            }

            Console.WriteLine($"Females: {count}");
        }

        static void C()
        {
            int n;
            Tourist[] tourists;
            Read(out tourists, out n);
            int maxiI = 0;
            for (int i = 1; i < n; i++)
            {
                if (tourists[i].Age > tourists[maxiI].Age && tourists[i].Gender) maxiI = i;
            }

            Console.WriteLine($"Name of the oldest mane: {tourists[maxiI].Name}");
        }

        static void D()
        {
            int n;
            Tourist[] tourists;
            Read(out tourists, out n);
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                if (tourists[i].Country == "Sweden" && 
                    tourists[i].Age < 25 && 
                    !tourists[i].Gender &&
                    tourists[i].Duration > 30) count++;
            }

            Console.WriteLine($"Answer: {count}");
        }
    }
}
