using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        public Person()
        {
            age = 1;
            name = "No name";
        }
        public Person(int age) : this()
        {
            this.age = age;
        }
        public Person(string name, int age): this(age)
        {
            Name = name;
        }
        private string name;
        private int age;
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
    }
}
