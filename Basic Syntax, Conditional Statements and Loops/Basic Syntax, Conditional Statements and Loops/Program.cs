using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Syntax__Conditional_Statements_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://judge.softuni.bg/Contests/Practice/Index/1453#0
            //01. Sort Numbers
            /*
     
             
            List<int> list1 = new List<int>();
            list1.Add(int.Parse(Console.ReadLine()));
            list1.Add(int.Parse(Console.ReadLine()));

            list1.Add(int.Parse(Console.ReadLine()));

            // var ordered =  list1.OrderByDescending( x => x);
            // foreach (var item in ordered)
            //{
            //      Console.WriteLine(item);
            //  }

            list1.Sort();
            list1.Reverse();
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            02.English Name of the Last Digit
            

            var words = new Dictionary<int, string>()
            {
                {1,"one" },
                {2,"two" },
                {3,"three" },
                {4,"four" },
                {5,"five" },
                {6,"six" },
                {7,"seven" },
                {8,"eight" },
                {9,"nine" },
                {0,"zero" }
            };

            int input = int.Parse(Console.ReadLine());
            int magicNum = input % 10;

            Console.WriteLine(words[magicNum]);

            03.Gaming Store
         

            var words = new Dictionary<string, decimal>()
            {
                { "OutFall 4" ,39.99m },
                { "CS: OG" ,15.99m},
                {"Zplinter Zell", 19.99m},
                { "Honored 2" ,59.99m},
                { "RoverWatch", 29.99m},
                { "RoverWatch Origins Edition", 39.99m}
            };
            decimal total = decimal.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            decimal value = 0;
            
            decimal totalSpend = 0;
            while (input !="Game Time")
            {
                if (!words.ContainsKey(input))
                {
                    Console.WriteLine("Not Found");
                    
                }
                else 
                {
                value = words[input];
                if (value > total)
                {
                    Console.WriteLine("Too Expensive");
                    
                }
                else
                    {

                    
                total -= value;
                totalSpend += value;
                Console.WriteLine($"Bought {input}");
               
                    }
                }
                input = Console.ReadLine();
                
            }

            if (total == 0)
            {
                Console.WriteLine("Out of money!");
            }
            else 
            {
                Console.WriteLine($"Total spent: ${totalSpend:f2}. Remaining: ${total:F2}");
            }

            04.Reverse String
            

            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            input = new string(chars);
            Console.WriteLine(input);

       
               */


        }
    }
}
