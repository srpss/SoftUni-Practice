using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercise_Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://softuni.bg/trainings/resources/officedocument/60435/regular-expressions-exercise-csharp-fundamentals-may-2021/3365
             
             
            List<string> input = new List<string>();
            string pattern = @"[^<>! ]+";
            string pattern2 = @"(^>>[a-zA-Z]+<<)([\d]+(\?|[.][\d]+|)+(!)[0-9]+)$";
            decimal totalValue = 0;
            string input3 = "";
            Match checker;
            List<string> store = new List<string>();
            while ( (input = Regex.Matches(input3 = Console.ReadLine(), pattern).Select(n => n.ToString()).ToList())[0] != "Purchase" )
            {
                checker = Regex.Match(input3, pattern2);
                if (checker.Success == false)
                {
                    continue;
                } 
                totalValue += decimal.Parse(input[1]) * decimal.Parse(input[2]);
                store.Add(input[0]);
            }
            Console.WriteLine($"Bought furniture:\n{string.Join(Environment.NewLine, store)}\nTotal money spend: {totalValue:F2}");


            02. Race
           

            string letterPattern = @"[A-Za-z]+";
            string digiPattern = @"\d";
            string endPattern = @"end of race";
            List<string> initialInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, decimal> input = new Dictionary<string, decimal>();
            for (int i = 0; i < initialInput.Count; i++)
            {
                input.Add(initialInput[i], 0);
            }

            string command = "";
            while (Regex.Match(command = Console.ReadLine(), endPattern).Success == false )
            {
                MatchCollection name = Regex.Matches(command, letterPattern);
                MatchCollection numbers = Regex.Matches(command, digiPattern);
                string finalName = "";
                for (int i = 0; i < name.Count; i++)
                {
                    finalName += name[i];
                }
                decimal finalNumbers = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    finalNumbers += decimal.Parse(numbers[i].Value);
                }
                if (input.ContainsKey(finalName))
                {
                    input[finalName] += finalNumbers;
                }
            }
            

            int index = 1;
            foreach (var item in input.OrderByDescending(n => n.Value))
            {
                if (index == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if (index == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else if (index == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }


                index++;
            }

            03.SoftUni Bar Income

            ^(?|.+|)%([A-Z][a-z]+)%(?|.+|)<([A-Z][a-z]+)>(?|.+|)\|(\d+)\|(?|.+|)(\d+(?|.|)\d+)\$(?|.+|)$
            

            string pattern = @"^(\?|.+|)%([A-Z][a-z]+)%(\?|.+|)<(\w+)>(\?|.+|)\|(\d+)\|(\?|[a-zA-Z]+|)(\d+(\?|.|)\d+)\$(\?|.+|)$";
            string endCycle = @"end of shift";
            string input = "";
            decimal totalIncome = 0;
            while (Regex.Match(input = Console.ReadLine(), endCycle).Success == false)
            {
                if (Regex.Match(input , pattern).Success == false)
                {

                    continue;
                }
                MatchCollection collection= Regex.Matches(input, pattern);
                //2 4 6 8
                
                    string customerName = collection[0].Groups[2].Value;
                    string product = collection[0].Groups[4].Value;
                    decimal qua = decimal.Parse(collection[0].Groups[6].Value);
                    decimal price = decimal.Parse(collection[0].Groups[8].Value);

                Console.WriteLine($"{customerName}: {product} - {(qua* price):f2}");
                totalIncome += qua * price;
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
             */
        }
    }
}
