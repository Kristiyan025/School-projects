using System;

namespace Task_for_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            string SfirstName = Console.ReadLine();
            string SlastName = Console.ReadLine();
            int Sage = int.Parse(Console.ReadLine());
            string SfacultyNumber = Console.ReadLine();
            Student s = new Student(SfirstName, SlastName, Sage, SfacultyNumber);
            Console.WriteLine(s);
            Console.WriteLine();

            string WfirstName = Console.ReadLine();
            string WlastName = Console.ReadLine();
            int Wage = int.Parse(Console.ReadLine());
            double WweekSalary = double.Parse(Console.ReadLine());
            int WworkingHours = int.Parse(Console.ReadLine());
            Worker w = new Worker(WfirstName, WlastName, Wage, WweekSalary, WworkingHours);
            Console.WriteLine(w);
        }
    }
}
