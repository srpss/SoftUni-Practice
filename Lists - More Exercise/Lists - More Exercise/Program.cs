using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lists___More_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* https://softuni.bg/trainings/resources/officedocument/60420/lists-more-exercise-csharp-fundamentals-may-2021/3365
             * https://judge.softuni.bg/Contests/Practice/Index/1300#0
             * 01. Messaging
             Messaging();

            02.Car Race
             CarRace();

            03. Take/Skip Rope
            
            Take_Skip_Rope();

            Without stars problems
            */

        }

        private static void Take_Skip_Rope()
        {
            string nonDigitPattern = @"[^\d]";
            string digitPattern = @"[\d]";
            string input = Console.ReadLine();
            MatchCollection nonDig = Regex.Matches(input, nonDigitPattern);
            MatchCollection dig = Regex.Matches(input, digitPattern);

            List<string> chars = nonDig.Select(n => n.ToString()).ToList();
            List<int> nonchars = dig.Select(n => int.Parse(n.ToString())).ToList();
            List<int> takeList = new List<int>();
            List<int> evenList = new List<int>();

            for (int i = 0; i < nonchars.Count; i++)
            {
                if (i % 2 == 1)
                {
                    evenList.Add(nonchars[i]);
                }
                else
                {

                    takeList.Add(nonchars[i]);
                }
            }

            List<string> output = new List<string>();
            for (int i = 0; i < takeList.Count; i++)
            {
                if (takeList[i] > chars.Count)
                {
                    takeList[i] = chars.Count;
                }
                for (int j = 0; j < takeList[i]; j++)
                {
                    output.Add(chars[0]);
                    chars.RemoveRange(0, 1);
                }
                chars.RemoveRange(0, evenList[i]);
            }
            Console.WriteLine(string.Join(string.Empty, output));
        }

        private static void CarRace()
        {
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> firstHalf = new List<int>();
            List<int> secondHalf = new List<int>();
            for (int i = 0; i < input.Count / 2; i++)
            {
                firstHalf.Add(input[i]);
            }
            for (int i = input.Count - 1; i > input.Count / 2; i--)
            {
                secondHalf.Add(input[i]);
            }

            decimal calcFirst = 0;
            decimal calcSecond = 0;

            calcFirst = CalcTime(firstHalf, calcFirst);
            calcSecond = CalcTime(secondHalf, calcSecond);

            if (calcFirst < calcSecond)
            {
                Console.WriteLine($"The winner is left with total time: {calcFirst}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {calcSecond}");
            }
        }

        private static decimal CalcTime(List<int> firstHalf, decimal calcFirst)
        {
            
            for (int i = 0; i < firstHalf.Count; i++)
            {
                if (firstHalf[i] != 0)
                {
                    calcFirst += firstHalf[i];
                }
                else
                {
                    calcFirst *= 0.8m;
                }

            }
            

            return calcFirst;
        }

        private static void Messaging()
        {
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            input = CalcValues(input);

            string input2 = Console.ReadLine();
            string output = "";
            FinalCalculations(input, ref input2, ref output);
        }

        private static void FinalCalculations(List<int> input, ref string input2, ref string output)
        {
            for (int i = 0; i < input.Count; i++)
            {
                int check = 0;
                if (input[i] > input2.Length)
                {
                    check = input[i] % input2.Length;
                }
                else
                {
                    check = input[i];
                }
                output += input2[check];
                input2 = input2.Remove(check, 1);
            }

            Console.WriteLine(output);
        }

        private static List <int> CalcValues(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                string number = input[i].ToString();
                int calc = 0;
                for (int j = 0; j < number.Length; j++)
                {
                    calc += int.Parse(number[j].ToString());
                }
                input[i] = calc;
            }
            return input;
        }
    }
}
