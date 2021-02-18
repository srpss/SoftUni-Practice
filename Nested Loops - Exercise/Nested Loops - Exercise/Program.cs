using System;

namespace Nested_Loops___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* https://judge.softuni.bg/Contests/Compete/Index/2386#0
             01. Number Pyramid
            
             
           

            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {

                    Console.Write(counter + " ");
                    counter++;
                    if (counter == n + 1)
                    {
                        break;
                    }
                }
                if (counter == n + 1)
                {
                    break;
                }
                Console.WriteLine();

            }

            02.Equal Sums Even Odd Position

              
            int n = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string current = "";
            
            for (int i = n; i <= n2; i++)
            {
                int even = 0;
                int odd = 0;
                current = i.ToString();
                for (int j = 0; j < current.Length; j++)
                {
                    char a = current[j];
                    int b = int.Parse(a.ToString());
                    if (j % 2 == 0)
                    {
                        even += b;
                    }
                    else
                    {
                        odd += b;
                    }
                }
                if (even == odd)
                {
                    Console.Write(i + " ");
                }
                
            }


            03.Sum Prime Non Prime

           

            string input = Console.ReadLine();
            long prime = 0;
            long none = 0;
            
            while (input != "stop")
            {
                long number = long.Parse(input);
                bool truth = true;
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (long i = 2; i <= number / 2; i++)
                    {
                        if (number % i == 0)
                        {

                            truth = false;
                            break;
                        }

                    }


                    if (truth == true)
                    {
                        prime += number;
                    }
                    else
                    {
                        none += number;
                    }

                }

                input = Console.ReadLine();
                truth = false;
            }
            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {none}");


            04.Train The Trainers

         

            double n = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            double totalScore = 0;
            double total = 0;
            double counter = 0;
            while (input != "Finish")
            {
               
                for (int i = 0; i < n; i++)
                {
                    double input1 = double.Parse(Console.ReadLine());
                    totalScore  += input1;
                    counter++;
                }
                Console.WriteLine($"{input} - {totalScore/n:f2}.");
                total += totalScore;
                input = Console.ReadLine();
                totalScore = 0;
            }
            Console.WriteLine($"Student's final assessment is {total/counter:f2}.");

            05.Password Generator
                
            decimal n = decimal.Parse(Console.ReadLine());
            decimal l = decimal.Parse(Console.ReadLine());
            decimal big = n;
           

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (int m = 97; m < 97 +l; m++)
                    {
                        for (int b = 97; b < 97 + l; b++)
                        {
                            if (i > j)
                            {
                                big = i+1;
                            }
                            else
                            {
                                big = j+1;
                            }
                            for (decimal g = big ; g <= n; g++)
                            {
                                Console.Write($"{i}{j}{Convert.ToChar(m)}{Convert.ToChar(b)}{g} ");
                            }
                        }
                    }
                }
            }

            06. Special Numbers
            

            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 9; i++)
            {
                if (n%i ==0)
                {

                }
                else
                {
                    continue;
                }
                for (int j = 1; j <= 9; j++)
                {
                    if (n % j == 0)
                    {

                    }
                    else
                    {
                        continue;
                    }
                    for (int m = 1; m <= 9; m++)
                    {
                        if (n % m == 0)
                        {

                        }
                        else
                        {
                            continue;
                        }
                        for (int h = 1; h <= 9; h++)
                        {
                            if (n % h == 0)
                            {
                                Console.Write($"{i}{j}{m}{h} ");
                            }
                            else
                            {
                                continue;
                            }
                            
                        }
                    }
                }
            }  
            */
        }
    }
}
