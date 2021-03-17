using System;
using System.Collections;
using System.Collections.Generic;

namespace Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.softuni.bg/Contests/Compete/Index/1206#0
             * 01. Train
            

            int input = int.Parse(Console.ReadLine());
            List<int> values = new List<int>();
            for (int i = 0; i < input; i++)
            {
                int input2 = int.Parse(Console.ReadLine());
                values.Add(input2);
            }
            int sum = 0;
            foreach (var item in values)
            {
                Console.Write($"{item} ");
                sum += item;
            }
            Console.WriteLine();
            Console.WriteLine(sum);

            02.Common Elements
             
           string [] input = Console.ReadLine().Split();
           string [] input2 = Console.ReadLine().Split();
           
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input2.Length; j++)
                {
                  
                        if (input2[j] == input[i])
                        {
                            Console.Write($"{input2[j]} ");
                        }
                    
                   
                    
                }
            }

            03.Zig - Zag Arrays
            
            int input = int.Parse(Console.ReadLine());
            string[] array1 = new string[input];
            string[] array2 = new string[input];

            for (int i = 1; i <= input; i++)
            {
                string[] input2 = Console.ReadLine().Split();
                if (i % 2 == 0)
                {
                    array1[i - 1] = input2[0];
                    array2[i - 1] = input2[1];
                }
                else
                {
                    array2[i - 1] = input2[0];
                    array1[i - 1] = input2[1];
                }
            }
            output(array2);
            output(array1);
            

            void output(string [] array1)
            {
                foreach (var item in array1)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();

                
            }

            04.Array Rotation
          
            string[] input = Console.ReadLine().Split();
            int input2 = int.Parse(Console.ReadLine());
            Queue qt = new Queue(input);
            for (int i = 0; i < input2; i++)
            {
                string current = qt.Peek().ToString();
                qt.Dequeue();
                qt.Enqueue(current);
            }

            output(qt);
            void output(Queue array1)
            {
                foreach (var item in array1)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();


            }
            5.Top Integers
            

            string[] input = Console.ReadLine().Split();
       

            for (int i = 0; i < input.Length; i++)
            {
                bool checker = false;
                for (int j = i+1; j < input.Length ; j++)
                {
                    
                    if (int.Parse(input[i]) < int.Parse(input[j]))
                    {
                        checker = true;
                        break;
                    }
                   
                }
                if (checker == false)
                {
                    Console.Write($"{input[i]} ");
                }


            }
            06.Equal Sum

            
            string[] input = Console.ReadLine().Split();
            bool found = false;
            for (int i = 0; i < input.Length; i++)
            {

                int sumLeft = 0;
                int sumRight = 0;
                for (int j = 0; j < i; j++)
                {
                    sumLeft += int.Parse(input[j]);
                }
                for (int j = input.Length - 1; j > i; j--)
                {
                    sumRight += int.Parse(input[j]);
                }

                if (sumLeft == sumRight)
                {
                    found = true;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (found == false)
            {
                Console.WriteLine("no");
            }

            07.Max Sequence of Equal Elements
           

            string[] input = Console.ReadLine().Split();
            string current = "";
            int counter = 1;
            string sym = "";
            int trueCount = 0;
            for (int i = 1; i < input.Length; i++)
            {
                current = input[i - 1];
                if (input[i] == current)
                {
                    counter++;
                    
                    if (trueCount < counter)
                    {
                        trueCount = counter;
                        sym = input[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            for (int i = 0; i < trueCount; i++)
            {
                Console.Write(sym + " ");
            }

            08.Magic Sum
              

            string[] input = Console.ReadLine().Split();
            int input2 = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
               
                for (int j = 0; j < input.Length; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }

                    if (int.Parse(input[i]) + int.Parse(input[j]) == input2)
                    {
                        
                        if (numbers.Contains(int.Parse(input[i])) && numbers.Contains(int.Parse(input[j])))
                        {

                        }
                        else
                        {
                            Console.WriteLine($"{input[i]} {input[j]}");
                            numbers.Add(int.Parse(input[i]));
                            numbers.Add(int.Parse(input[j]));
                        }
                        
                    }
                }
            }
             */
        }
    }
}
