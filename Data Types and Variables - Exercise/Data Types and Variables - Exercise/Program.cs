using System;
using System.Linq;
using System.Collections.Generic;
namespace Data_Types_and_Variables___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*https://judge.softuni.bg/Contests/Compete/Index/1205#0
             * 01. Integer Operations   
             * 
             * 
            

            int input = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine()) + input;
            int input3 = input2/int.Parse(Console.ReadLine());
            int input4 = input3 * int.Parse(Console.ReadLine());

            Console.WriteLine(input4);

            02.Sum Digits
            
            int input =  Console.ReadLine().Select(x => int.Parse(x.ToString())).Sum();
            Console.WriteLine(input);

            03.Elevator
        
            decimal input = decimal.Parse(Console.ReadLine())/ decimal.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling(input));

            04.Sum of Chars
             
            int input = int.Parse(Console.ReadLine());
            decimal totalValue = 0;
            
            for (int i = 0; i < input; i++)
            {
                totalValue += char.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The sum equals: {totalValue}");

            05. Print Part Of ASCII Table
           
            int input = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            for (int i = input; i <= input2; i++)
            {
                
                Console.Write($"{(char)i} ");
            }


            06.Triples of Latin Letters
           

            int input = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97+ input; i++)
            {
                for (int y = 97; y < 97 + input; y++)
                {
                    for (int c = 97; c < 97 + input; c++)
                    {
                        Console.WriteLine($"{(char)i}{(char)y}{(char)c}");
                    }
                }
            }

            07.Water Overflow
             

            int input = int.Parse(Console.ReadLine());
            int cap = 0;
            for (int i = 0; i < input; i++)
            {
                int input2 = int.Parse(Console.ReadLine());
                if (input2 + cap > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    cap += input2;
                }
            }
            Console.WriteLine(cap);

            08.Beer Kegs
          

            int input = int.Parse(Console.ReadLine());
            string currentBig = "";
            decimal size2 = decimal.MinValue;
            for (int i = 0; i < input; i++)
            {
                string keg = Console.ReadLine();
                decimal size = (decimal)Math.PI * (decimal)Math.Pow(double.Parse(Console.ReadLine()),2) * decimal.Parse(Console.ReadLine());
                if (size > size2)
                {
                    size2 = size;
                    currentBig = keg;
                }

            }
            Console.WriteLine(currentBig);
             */
        }
    }
}
