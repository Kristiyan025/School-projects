using System;
using System.Collections.Generic;
using System.Text;

namespace Task_for_Person
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, int age, string facultyNumber)
            : base(firstName, lastName, age)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return facultyNumber;
            }
            protected set
            {
                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return $"First Name: {this.FirstName}" + '\n' +
                $"Last Name: {this.LastName}" + '\n' +
                $"Age: {this.Age}" + '\n' +
                $"Faculty Number: {this.FacultyNumber}";
        }
    }
}
