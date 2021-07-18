using System;
using System.Linq;
using System.Collections.Generic;

namespace Associative_Arrays___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*_01_CountRealNumbers();*/
            /*_02_OddOccurrences();*/
            /*_03_WordSynonyms();*/
            /*_04_Largest3Numbers();*/
            _05_WordFilter();
        }

        private static void _05_WordFilter()
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> evenList = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].Length % 2 == 0)
                {
                    evenList.Add(input[i]);
                }
            }
            foreach (var item in evenList)
            {
                Console.WriteLine(item);
            }
        }

        private static void _04_Largest3Numbers()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<int, int> dic = new SortedDictionary<int, int>();
            for (int i = 0; i < input.Length; i++)
            {
                dic.Add(input[i], input[i]);
            }            
            int counterToThree = 0;
            
            foreach (var item in dic.Reverse())
            {
                if (counterToThree == 3)
                {
                    break;
                }               
                Console.Write($"{item.Value} ");
                counterToThree++;
            }          
        }

       

        private static void _03_WordSynonyms()
        {
            int cycleCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            for (int i = 0; i < cycleCount; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (dic.ContainsKey(word))
                {
                    dic[word].Add(synonym);
                }
                else
                {
                    dic.Add(word, new List<string>(){synonym});
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }

        private static void _02_OddOccurrences()
        {
            string[] input = Console.ReadLine().Split(' ').Select(n => n.ToLower()).ToArray() ;
            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (var item in input)
            {
                if (count.ContainsKey(item))
                {
                    count[item]++;
                }
                else
                {
                    count.Add(item,1);
                }
            }
            foreach (var item in count)
            {
                if (item.Value % 2 == 1)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }

        private static void _01_CountRealNumbers()
        {
            decimal[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
            SortedDictionary<decimal, int> count = new SortedDictionary<decimal, int>();

            foreach (var number in input)
            {
                if (count.ContainsKey(number))
                {
                    count[number]++;
                }
                else
                {
                    count.Add(number,1);
                }
            }
            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
