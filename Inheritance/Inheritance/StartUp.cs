using System;
using System.Collections.Generic;
using CustomRandomList;
using Inheritance;
namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //https://judge.softuni.org/Contests/Practice/Index/1499#0
            //_01_SingleInheritance();
            //_02_MultipleInheritance();
            //_03_HierarchicalInheritance();
            //_04_RandomList();
            _05_StackofStrings();
        }

        private static void _05_StackofStrings()
        {
            
        }

        private static void _04_RandomList()
        {
            RandomList <string> randomList= new RandomList<string>();
            randomList.Add("test");
            randomList.Add("ball");
            randomList.Add("pizza");
            Console.WriteLine($"{randomList.RandomString()}"); 
        }

        private static void _03_HierarchicalInheritance()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }

        private static void _02_MultipleInheritance()
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }

        private static void _01_SingleInheritance()
        {
            Dog dog = new Dog();
            dog.Bark();
            dog.Bark();
            dog.Eat();
        }
    }
}
