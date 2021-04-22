using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    public class Student
    {
        public Student(int id, string name, double grade)
        {
            this.Id = id;
            this.Name = name;
            this.Grade = grade;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }

        public double Grade { get; private set; }
    }
}
