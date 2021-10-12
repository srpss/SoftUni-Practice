using System;
using System.Collections.Generic;
using System.Linq;
namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //https://softuni.bg/trainings/resources/officedocument/64233/defining-classes-exercise-csharp-advanced-september-2021/3483
            //_1_DefineaClassPerson();
            //_02_CreatingConstructors();
            //_03_OldestFamilyMember();
            //_04_OpinionPoll();
            _06_SpeedRacing();
        }

        private static void _06_SpeedRacing()
        {
            
        }

        private static void _04_OpinionPoll()
        {
            List<Person> family = new List<Person>();
            int cycle = int.Parse(Console.ReadLine());
            for (int i = 0; i < cycle; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (int.Parse(input[1]) > 30)
                {
                    family.Add(new Person(input[0], int.Parse(input[1])));
                }                
            }
            family =  family.OrderBy(n => n.Name).ToList();
            foreach (var item in family)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }

        private static void _03_OldestFamilyMember()
        {
            int cycle = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < cycle; i++)
            {
                string[] input = Console.ReadLine().Split();
                family.AddMember(new Person(input[0], int.Parse(input[1])));
            }
            Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
        }

        private static void _02_CreatingConstructors()
        {
            Person person = new Person(10);
            Console.WriteLine($"{person.Age} {person.Name}");
        }

        private static void _1_DefineaClassPerson()
        {
            Person person = new Person();
            person.Name = "Peter";
            person.Age = 20;
            Console.WriteLine($"{person.Age} {person.Name}");
        }
    }
}
