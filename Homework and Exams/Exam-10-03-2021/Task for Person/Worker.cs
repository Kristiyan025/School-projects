using System;
using System.Collections.Generic;
using System.Text;

namespace Task_for_Person
{
    class Worker : Human
    {
        private double weekSalary;
        private int workingHours;

        public Worker(string firstName, string lastName, int age, double weekSalary, int workingHours)
            :base(firstName, lastName, age)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHours = workingHours;
        }

        public double WeekSalary
        {
            get
            {
                return weekSalary;
            }
            protected set
            {
                weekSalary = value;
            }
        }
        public int WorkingHours
        {
            get
            {
                return workingHours;
            }
            protected set
            {
                workingHours = value;
            }
        }
        public override string ToString()
        {
            return $"First Name: {this.FirstName}" + '\n' +
                $"Last Name: {this.LastName}" + '\n' +
                $"Age: {this.Age}" + '\n' +
                $"Week Salary: {this.WeekSalary}" + '\n' +
                $"Hours per day: {this.WorkingHours}" + '\n' +
                $"Salary per hour: {this.WeekSalary / this.WorkingHours}";
        }
    }
}
