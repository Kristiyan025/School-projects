using System;
using System.Collections.Generic;
using System.Text;

namespace Task_for_Person
{
    class Human
    {
        private string firstName;
        private string lastName;
        private int age;

        public Human(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            protected set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            protected set
            {
                lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            protected set
            {
                age = value;
            }
        }
    }
}
