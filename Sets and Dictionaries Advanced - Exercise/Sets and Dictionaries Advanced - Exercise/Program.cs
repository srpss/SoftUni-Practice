using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dictionaries_Advanced___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://softuni.bg/trainings/resources/officedocument/64221/sets-and-dictionaries-advanced-exercise-csharp-advanced-september-2021/3483
            //_01_UniqueUsernames();
            //_02_SetsofElements();
            //_03_PeriodicTable();
            //_04_EvenTimes();
            //_05_CountSymbols();
            _06_Wardrobe();
        }
        class Wardrobe
        {
            public string color { get; set; }
            public Dictionary<string, string> cloths { get; set; }
        }
        private static void _06_Wardrobe()
        {
            var wardrobe = new List<Wardrobe>();
            int cycles = int.Parse(Console.ReadLine());
            for (int i = 0; i < cycles; i++)
            {
                List<string> input = Console.ReadLine().Trim().Split("->").ToList();
                string color = input[0].Trim();
                string[] cloths = input[1].Trim().Split(",");
                int element = -5;
                for (int j = 0; j < wardrobe.Count; j++)
                {
                    if (wardrobe[j].color == color)
                    {
                        element = j;
                        break;
                    }
                }
                if (element != -5)
                {
                    for (int j = 0; j < cloths.Length; j++)
                    {
                        if (wardrobe[element].cloths.ContainsKey(cloths[j]))
                        {
                            wardrobe[element].cloths[cloths[j]] = (int.Parse(wardrobe[element].cloths[cloths[j]])+1).ToString();
                        }
                        else
                        {
                            wardrobe[element].cloths.Add(cloths[j], "1");
                        }                        
                    }                   
                }
                else
                {
                    var clothers = new Dictionary<string, string>();
                    foreach (var cloth in cloths)
                    {
                        if (clothers.ContainsKey(cloth))
                        {
                            clothers[cloth] = (int.Parse(clothers[cloth])+1).ToString();
                        }
                        else
                        {
                            clothers.Add(cloth, "1");
                        }
                    }
                    Wardrobe item = new Wardrobe();
                    item.color = color;
                    item.cloths = clothers;                    
                    wardrobe.Add(item);
                }
            }
            string[] find = Console.ReadLine().Split();
            for (int j = 0; j < wardrobe.Count; j++)
            {
                if (wardrobe[j].color == find[0])
                {
                    if (wardrobe[j].cloths.ContainsKey(find[1]))
                    {
                        wardrobe[j].cloths[find[1]] += " (found!)";
                    }
                }
            }
            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.color} clothes:");
                foreach (var cloth in item.cloths)
                {
                    Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                }
            }
        }

        private static void _05_CountSymbols()
        {
            var charArray = Console.ReadLine().ToCharArray();
            var dictionary = new Dictionary<char, int>();
            for (int i = 0; i < charArray.Length; i++)
            {                
                if (dictionary.ContainsKey(charArray[i]))
                {
                    dictionary[charArray[i]] += 1;
                }
                else
                {
                    dictionary.Add(charArray[i], 1);
                }
            }
            foreach (var item in dictionary.OrderBy(n => n.Key))
            {
                    Console.WriteLine($"{(string)item.Key.ToString()}: {item.Value} time/s");
            }
        }

        private static void _04_EvenTimes()
        {
            var dictionary = new Dictionary<int, int>();
            int cycles = int.Parse(Console.ReadLine());
            for (int i = 0; i < cycles; i++)
            {
                int add = int.Parse(Console.ReadLine());
                if (dictionary.ContainsKey(add))
                {
                    dictionary[add] += 1;
                }
                else
                {
                    dictionary.Add(add, 1);
                }
            }
            foreach (var item in dictionary)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }

        private static void _03_PeriodicTable()
        {
            HashSet<string> set = new HashSet<string>();
            int cycles = int.Parse(Console.ReadLine());
            for (int i = 0; i < cycles; i++)
            {
                string[] values = Console.ReadLine().Split();
                for (int j = 0; j < values.Length; j++)
                {
                    set.Add(values[j]);
                }                
            }
            foreach (var item in set.OrderBy(n => n))
            {
                Console.Write(item + " ");
            }
        }

        private static void _02_SetsofElements()
        {
            int[] cycles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            for (int i = 0; i < cycles[0]; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < cycles[1]; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }
            var unque = new HashSet<int>();
            FindUnqueElements(set1, set2, unque);
        }

        private static void FindUnqueElements(HashSet<int> set1, HashSet<int> set2, HashSet<int> unque)
        {
            for (int i = 0; i < set1.Count; i++)
            {
                if (set2.Contains(set1.ElementAt(i)))
                {
                    unque.Add(set1.ElementAt(i));
                }
            }
            foreach (var item in unque)
            {
                Console.Write($"{item} ");
            }
        }

        private static void _1_UniqueUsernames()
        {
            HashSet<string> set = new HashSet<string>();
            int cycles = int.Parse(Console.ReadLine());
            for (int i = 0; i < cycles; i++)
            {
                set.Add(Console.ReadLine());
            }
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
