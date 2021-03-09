using System;
using System.Collections.Generic;
using System.Globalization;

namespace Basic_Syntax__Conditional_Statements_and_Loops___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   https://judge.softuni.bg/Contests/Practice/Index/1188#0
            01. Student Information


     
            string input = Console.ReadLine();
            decimal input1 = decimal.Parse(Console.ReadLine());
            string input2 = Console.ReadLine();

            Console.WriteLine($"Name: {input}, Age: {input1}, Grade: {input2}");


            02. Passed
            decimal input1 = decimal.Parse(Console.ReadLine());
            //string input2 = Console.ReadLine();

            if (input1 >= 3.0m)
            {
                Console.WriteLine($"Passed!");
            }
            03. Passed or Failed
             

            decimal input1 = decimal.Parse(Console.ReadLine());
            //string input2 = Console.ReadLine();

            if (input1 >= 3.0m)
            {
                Console.WriteLine($"Passed!");
            }
            else
            {
                Console.WriteLine($"Failed!");
            }

            04.Back In 30 Minutes
           
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            input1 *= 60;
            int total = input1 + input2 + 30;
            int hours = total / 60;
            if (hours == 24)
            {
                hours = 0;
            }
            int minutes = total % 60;
            if (minutes <10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
            05.Month Printer
            
            int input1 = int.Parse(Console.ReadLine());
            switch (input1)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("Febulary");
                    break;
                case 3:
                    Console.WriteLine("January");
                    break;
                case 4:
                    Console.WriteLine("January");
                    break;
                case 5:
                    Console.WriteLine("January");
                    break;
                case 6:
                    Console.WriteLine("January");
                    break;
                case 7:
                    Console.WriteLine("January");
                    break;
                case 8:
                    Console.WriteLine("January");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }

            06.Foreign Languages
             

           
                string input1 = (Console.ReadLine());
            switch (input1)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Mexico":
                case "Argentina":
                case "Spain":
                    Console.WriteLine("Spanish");
                    break;
              
                default:
                    Console.WriteLine("unknown");
                    break;
            }

            07.Theatre Promotion
           

            int[] weekday = {12,18,12 };
            int[] weekend = { 15, 20, 15 };
            int[] holiday = { 5, 12, 10 };

            string input1 = (Console.ReadLine());
            int[] array = {0,0,0 };
            if (input1 == "Weekday")
            {
                array = weekday;
            }
            else if (input1 == "Weekend")
            {
                array = weekend;
            }
            else 
            {
                array = holiday;
            }
            int input2 = int.Parse(Console.ReadLine());

            int index = 0;
            bool er = false;
            if (input2 < 0)
            {
                er = true;
            }
            else if (input2 <=18)
            {
                index = 0;
            }
            else if (input2 <=64)
            {
                index = 1;
            }
            else if (input2 <= 122)
            {
                index = 2;
            }
            else
            {
                er = true;
            }
            if (er == false)
            {
                Console.WriteLine($"{array[index]}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }

            08.Divisible by 3
             

            for (int i = 3; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }

            09.Sum of Odd Numbers
          
            int input2 = int.Parse(Console.ReadLine());
            int start = 1;
            int total = 0;
            for (int i = 0; i < input2; i++)
            {
                Console.WriteLine(start);
                total += start;
                start += 2;
            }
            Console.WriteLine("Sum: " +total);

            10.Multiplication Table
              

            int input2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{input2} X {i} = {input2 * i}");
            }


            11.Multiplication Table 2.0
         

            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());
            if (input3 > 10)
            {
                Console.WriteLine($"{input2} X {input3} = {input2 * input3}");
            }
            else
            {
                for (int i = input3; i <= 10; i++)
                {
                    Console.WriteLine($"{input2} X {i} = {input2 * i}");
                }
            }
            12.Even Number
              
            int input3 = Math.Abs(int.Parse(Console.ReadLine()));
            while (input3 %2 != 0)
            {
               Console.WriteLine("Please write an even number.");
               input3 = Math.Abs(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"The number is: {input3}");

  */
    }
    }
}
