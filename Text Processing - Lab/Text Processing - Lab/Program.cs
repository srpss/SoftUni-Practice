using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
namespace Text_Processing___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /* https://judge.softuni.bg/Contests/Practice/Index/1216#1*/
            /*_01_ReverseStrings();*/
            /*_02_RepeatStrings();*/
            /*_03_Substring();*/
            /*_04_TextFilter();*/
            _05_DigitsLettersandOther();
        }

        private static void _05_DigitsLettersandOther()
        {
            string letters = @"[A-Za-z]";
            string digits = @"[\d]";
            string specials = @"[^A-Za-z\d]";
            string input = Console.ReadLine();
            MatchCollection text = Regex.Matches(input, letters);
            MatchCollection digit = Regex.Matches(input, digits);
            MatchCollection special = Regex.Matches(input, specials);
            foreach (var item in digit)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            foreach (var item in text)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            foreach (var item in special)
            {
                Console.Write(item);
            }
        }

        private static void _04_TextFilter()
        {
            string[] destroyer = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();
            StringBuilder test = new StringBuilder();
            test.Append(input);
            while (checker(destroyer, test))
            {
                for (int i = 0; i < destroyer.Length; i++)
                {
                    int index = destroyer[i].Length;
                    test.Replace(destroyer[i], new string('*', index));
                }
                Console.WriteLine(test);
            }            
        }

        private static bool checker(string [] destroyer, StringBuilder input)
        {
            bool theCheck = false;
            for (int i = 0; i < destroyer.Length; i++)
            {
                string test = input.ToString();
                if (test.Contains(destroyer[i]))
                {
                    theCheck = true;
                    break;
                }
            }
            return theCheck;
        }

        private static void _03_Substring()
        {
            string destroyer = Console.ReadLine().ToLower();
            string input = Console.ReadLine().ToLower();
            while (input.Contains(destroyer))
            {
                input = input.Replace(destroyer,"");
            }
            Console.WriteLine(input);
        }

        private static void _02_RepeatStrings()
        {
            string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in input)
            {
                int size = item.Length;
                for (int i = 0; i < size; i++)
                {
                    Console.Write(item);
                }
            }
        }

        private static void _01_ReverseStrings()
        {
            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                StringBuilder test = new StringBuilder();
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    test.Append(input[i]);
                }
                Console.WriteLine($"{input} = {test}");
            }
        }
    }
}
