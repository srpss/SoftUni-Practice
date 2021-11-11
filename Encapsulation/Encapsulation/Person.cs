using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public Person(string firstName, string lastName, int age, decimal salary) :this(firstName, lastName, age)
        {
            Salary = salary;
        }


        public string FirstName
        {
            get 
            { 
                return firstName; 
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                firstName = value; 
            } 
        }
        public string LastName 
        { 
            get 
            {
                return lastName;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                lastName = value;
            } 
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");                    
                }
                age = value;
            }
        }
        public decimal Salary
        {
            get 
            { 
                return salary; 
            }
            private set
            {
                if (value < 650)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
                salary = value; 
            }
        }
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        public override string ToString()
        {
            //_1_ return $"{firstName} {lastName} is {Age} years old.";
            return $"{firstName} {lastName} receives {salary:F2} leva.";
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (age < 30)
            {
                salary += salary * (percentage/100) / 2;
            }
            else
            {
                salary += salary * percentage /100;
            }
        }
    }
}
