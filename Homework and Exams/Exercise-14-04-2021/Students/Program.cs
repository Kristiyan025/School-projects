using System;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students;
            ReadStudents(out students);
            A(ref students);
            B(ref students);
            C(ref students);
            D(ref students);
            E(ref students);
            F(ref students);

        }

        private static void ReadStudents(out Student[] students)
        {
            int n = int.Parse(Console.ReadLine());
            students = new Student[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter student's id in class: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter student's name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter student's grade: ");
                double grade = double.Parse(Console.ReadLine());
                students[i] = new Student(id, name, grade);
            }
        }

        private static void A(ref Student[] students)
        {
            Console.WriteLine("Excellent students:");
            int count = 0;
            for(int i = 0; i < students.Length; i++)
            {
                if(students[i].Grade > 5.50)
                {
                    Console.WriteLine($"{++count}. {students[i].Name}");
                }
            }
        }

        private static void B(ref Student[] students)
        {
            int count = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Grade < 3.00) count++;
            }

            Console.WriteLine($"No. of failed students is {count}!");
        }

        private static double C(ref Student[] students)
        {
            double sum = 0.0;
            for (int i = 0; i < students.Length; i++)
            {
                sum += students[i].Grade;
            }

            double average = double.Parse($"{(sum / students.Length):F2}");
            Console.WriteLine($"Average score: {average}!");
            return average;
        }

        private static void D(ref Student[] students)
        {
            double maxi = 0;
            int count = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Grade == maxi) count++;
                else if(students[i].Grade > maxi)
                {
                    maxi = students[i].Grade;
                    count = 1;
                }
            }

            Console.WriteLine($"Maximum grade: {maxi:F2}!");
            Console.WriteLine($"Achieved by {count} students!");
        }

        private static void E(ref Student[] students)
        {
            double average = C(ref students);
            Console.WriteLine("Students with grades greater than the average:");
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Grade > average)
                {
                    Console.WriteLine(students[i].Name);
                }
            }
        }

        private static void F(ref Student[] students)
        {
            Student[] sorted = MergeSort(ref students, 0, students.Length);
            foreach(var student in sorted)
            {
                Console.WriteLine($"№{student.Id}. {student.Name} - {student.Grade:F2}");
            }
        }

        private static Student[] MergeSort(ref Student[] students, int start, int n)
        {
            if (students.Length < 2) return students;

            var left = MergeSort(ref students, start, start + (n - start) >> 1);
            var right = MergeSort(ref students, ((n - start) >> 1) + 1, n);
            int i = 0, j = 0, k = 0;
            Student[] sorted = new Student[n];
            while(i < left.Length && j < right.Length)
            {
                sorted[k++] = left[i].Grade < right[j].Grade ? left[i++] : right[j++];
            }

            while (i < left.Length) sorted[k++] = left[i++];
            while (j < right.Length) sorted[k++] = right[j++];
            return sorted;
        }
    }
}
