using System;
using System.Linq;
using System.Collections.Generic;
namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://judge.softuni.bg/Contests/Practice/Index/1465#0
            //_01_CountSameValuesInArray();
            //_02_AverageStudentGrades();
            //_03_ProductShop();
            //_04_CitiesByContinentAndCountry();
            //_05_RecordUniqueNames();
            //_06_ParkingLot();
            _07_SoftUniParty();
        }

        private static void _07_SoftUniParty()
        {

            HashSet<string> output = new HashSet<string>();          
            string input = "";
            while ((input = Console.ReadLine()) != "PARTY")
            {
                output.Add(input);
            }
            while ((input = Console.ReadLine()) != "END")
            {
                output.Remove(input);
            }
            Console.WriteLine(output.Count);
            foreach (var item in output.OrderBy(n => n))
            {
                Console.WriteLine(item);
            }
        }

        private static void _06_ParkingLot()
        {
            HashSet<string> output = new HashSet<string>();
            string[] input = { "", "" };
            while ((input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries))[0] != "END")
            {
                if (input[0] == "IN")
                {
                    output.Add(input[1]);
                }
                else if (input[0] == "OUT")
                {
                    output.Remove(input[1]);
                }
            }
            if (output.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in output)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void _05_RecordUniqueNames()
        {
            HashSet<string> input = new HashSet<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                input.Add(Console.ReadLine());
            }
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }

        private static void _04_CitiesByContinentAndCountry()
        {
            int count = int.Parse(Console.ReadLine());            
            var dic = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                var test = new Dictionary<string, List<string>>()
                {
                    { input[1], new List<string> {input[2] } }
                };

                if (dic.ContainsKey(input[0]))
                {
                    bool checker = false;
                    for (int j = 0; j < dic.Count; j++)
                    {
                        if (dic.ElementAt(j).Value.ContainsKey(input[1]))
                        {
                            int index = 0;
                            for (int k = 0; k < dic.ElementAt(j).Value.Count; k++)
                            {
                                if (dic.ElementAt(j).Value.ElementAt(k).Key == input[1])
                                {
                                    index = k;
                                }
                            }
                            dic.ElementAt(j).Value.ElementAt(index).Value.Add(input[2]);
                            checker = true;
                        }
                    }
                    if (checker == false)
                    {
                        dic[input[0]].Add(input[1], new List<string> { input[2] });
                    }                  
                }
                else
                {
                    dic.Add(input[0], test);
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var country in item.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }

        private static void _03_ProductShop()
        {
            string[] input = {"","","" };
            var dic = new Dictionary<string, Dictionary<string, decimal>>();
            while ((input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries))[0] != "Revision")
            {
                Dictionary<string, decimal> test = new Dictionary<string, decimal>();
                test.Add(input[1], decimal.Parse(input[2]));
                if (dic.ContainsKey(input[0])) 
                {
                    dic[input[0]].Add(input[1], decimal.Parse(input[2]));
                }
                else
                {                   
                    dic.Add(input[0], test);
                }
            }
            foreach (var item in dic.OrderBy(n => n.Key).ToDictionary(n => n.Key, n => n.Value))
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var product in item.Value)
                {
                    string test = product.Value.ToString("F1");
                    Console.WriteLine($"Product: {product.Key}, Price: {test}");
                }
            }
        }

        class Student
        {
            public string name { get; set; }
            public List<decimal> grade { get; set; }
        }
        private static void _02_AverageStudentGrades()
        {
            int count = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                Student student = new Student()
                {
                    name = input[0],
                    grade = new List<decimal> { decimal.Parse(input[1]) }
                };
                bool checker = false;
                for (int j = 0; j < students.Count; j++)
                {
                    if (students[j].name == student.name)
                    {
                        students[j].grade.Add(decimal.Parse(input[1]));
                        checker = true;
                        break;
                    }                     
                }
                if (checker == false)
                {
                    students.Add(student);
                }
            }
            foreach (var item in students)
            {
                Console.WriteLine($"{item.name} -> {string.Join(' ', item.grade)} (avg: {item.grade.Average():F2})");
            }
        }
        private static void _01_CountSameValuesInArray()
        {
            decimal[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (!(input[i] == -435123))
                {
                    decimal totalVaue = 1;
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (input[i] == input[j])
                        {
                            totalVaue++;
                            input[j] = -435123;
                        }
                    }
                    Console.WriteLine($"{input[i]} - {totalVaue} times");
                    totalVaue = 1;
                    input[i] = -435123;
                }
            }
        }
    }
}
