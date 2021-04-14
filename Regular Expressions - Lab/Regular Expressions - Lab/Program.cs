using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq
namespace Regular_Expressions___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*https://judge.softuni.bg/Contests/Practice/Index/1667#0
             * 01. Match Full Name
            
            string pattern = @"\b[A-Z]{1}[a-z]+ \b[A-Z]{1}[a-z]+";
            string input = Console.ReadLine();
            MatchCollection testMatchCollection = Regex.Matches(input, pattern);
            Match testMatch = Regex.Match(input, pattern);
            foreach (var match in testMatchCollection)
            {
                Console.Write($"{match} ");
            }

            02.Match Phone Number
            

            string pattern = @"(\+359)( |-)(2)\2(\d{3})\2(\d{4})\b";

            string input = Console.ReadLine();
            MatchCollection result = Regex.Matches(input, pattern);
            Console.WriteLine(string.Join(", ", result));

            03.Match Dates
             

            string pattern = @"(0|\d\d)(\/|-|.)([A-Z][a-z]{2})\2(\d{4})";

            string input = Console.ReadLine();

            MatchCollection results = Regex.Matches(input, pattern);
            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine($"Day: {results[i].Groups[1]}, Month: {results[i].Groups[3]}, Year: {results[i].Groups[4]}");
            }
            */
        }
    }
}
