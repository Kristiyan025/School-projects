using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_20_01_2021
{
    public class Student
    {
        private string firstName, middleName, lastName;
        private long facultyNumber;
        private string major;
        private string course;

        public Student()
        {
            this.firstName = "";
            this.middleName = "";
            this.lastName = "";
            this.facultyNumber = 0;
            this.major = "";
            this.course = "";
        }

        public Student(string firstName, string middleName, string lastName) 
            :this()
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
        }

        public Student(string firstName, string lastName)
            : this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Student(string firstName, string middleName, string lastName, long facultyNumber)
            : this()
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.facultyNumber = facultyNumber;
        }

        public Student(string firstName, string middleName, string lastName, string major, string course)
            : this()
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.major = major;
            this.course = course;
        }

        public Student(string firstName, string middleName, string lastName, long facultyNumber, string major, string course)
            : this()
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.facultyNumber = facultyNumber;
            this.major = major;
            this.course = course;
        }

        public override string ToString()
        {
            string msg = "Student\n";
            if (this.firstName != "" ||
               this.middleName != "" ||
               this.lastName != "")
            {
                msg += $"Name: {(this.firstName != "" ? this.firstName : "")} " +
                             $"{(this.middleName != "" ? this.middleName : "")} " +
                             $"{(this.lastName != "" ? this.lastName : "")}\n";
            }
            if (this.facultyNumber != 0)
            {
                msg += $"Faculty Number: {this.facultyNumber}\n";
            }
            if (this.major != "")
            {
                msg += $"Major Study: {this.major}\n";
            }
            if (this.course != "")
            {
                msg += $"Course: {this.course}\n\n";
            }

            return msg;
        }
    }
}
