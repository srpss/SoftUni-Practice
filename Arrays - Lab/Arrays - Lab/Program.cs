using System;
using System.Collections.Generic;
namespace Arrays___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             https://judge.softuni.bg/Contests/Practice/Index/1202#0
             01.Day of Week
             var dayOfWeek = new Dictionary<int, string>()
            {
             { 1, "Monday" },
             { 2, "Tuesday" } ,
             { 3, "Wednesday" },
             { 4, "Thursday" },
             { 5, "Friday" },
             { 6, "Saturday" },
             { 7, "Sunday" }

            };
             int input = int.Parse(Console.ReadLine());

             if (dayOfWeek.ContainsKey(input))
             {
                 Console.WriteLine(dayOfWeek[input]);
             }
             else
             {
                 Console.WriteLine("Invalid day!");
             }


             02.Print Numbers in Reverse Order
           

            int input = int.Parse(Console.ReadLine());

            int[] numbers = new int[input];

            for (int i = 0; i < numbers.Length; i++)
            {
                int input2 = int.Parse(Console.ReadLine());
                numbers[i] = input2;
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }

            03.Rounding Numbers
            
            

            string[] a = Console.ReadLine().Split();

            decimal[] array1 = new decimal[a.Length];
            int Index = 0;
            foreach (var item in a)
            {
                array1[Index] = decimal.Parse(item);
                Index++;
            }

            calc(array1);

            static decimal [] calc(decimal [] array1)
            {
                decimal number = 0;
                for (int i = 0; i < array1.Length; i++)
                {
                    number =  Math.Round(array1[i], MidpointRounding.AwayFromZero);
                    Console.WriteLine($"{array1[i]} => {number}");
                }
               

                return array1;


            }

              04.Reverse Array of Strings
           

            string[] a = Console.ReadLine().Split();
            int last = a.Length - 1;
          

            for (int i = 0; i < a.Length/2; i++)
            {
                string lastString = a[last];

                a[a.Length - 1 - i] = a[i];
                a[i] = lastString;
                last-- ;
            }

            foreach (var item in a)
            {
                Console.Write(item + " ");
            }

            05.Sum Even Numbers
           

            string[] input = Console.ReadLine().Split();
            decimal sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (decimal.Parse(input[i]) % 2 == 0)
                {
                    sum += decimal.Parse(input[i]);
                }
               
            }
            Console.WriteLine(sum);

            06.Even and Odd Subtraction

          

            string[] input = Console.ReadLine().Split();
            decimal evenSum = 0;
            decimal oddSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (decimal.Parse(input[i]) % 2 == 0)
                {
                    evenSum += decimal.Parse(input[i]);
                }
                else
                {
                    oddSum += decimal.Parse(input[i]);
                }

            }
            Console.WriteLine((evenSum - oddSum));

            07.Equal Arrays


                
            string[] input = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();

            decimal sum = 0;
            bool broken = false;
            for (int i = 0; i < input.Length; i++)
            {
                sum += decimal.Parse(input[i]);
                if (input[i] != input2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    broken = true;
                    break;
                }

            }
            if (broken == false)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

            08.Condense Array to Number
             */
            string[] input = Console.ReadLine().Split();
            
            int remover = input.Length - 1;
            for (int i = 0; i < (input.Length) - 1; i++)
            {
                for (int j = 0; j < (input.Length) - 1; j++)
                {

                    input[j] = (int.Parse(input[j]) + int.Parse(input[j + 1])).ToString();
                }
                input[remover] = "0";
                remover--;
            }

            Console.WriteLine(input[0]);
        }
    }
}
