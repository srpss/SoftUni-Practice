using System;
using System.Collections.Generic;
namespace For_Loop___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 01.Numbers from 1 to 100
            

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }


            02.Numbers N...1

           

           int input =  int.Parse(Console.ReadLine());


            for (int i = input; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            03.Numbers 1...N with Step 3

             


            int input = int.Parse(Console.ReadLine());


            for (int i = 1; i <= input; i+=3)
            {
                Console.WriteLine(i);
            }

            04.Even Powers of 2
          


            int input = int.Parse(Console.ReadLine());

            int number = 2;
            Console.WriteLine(1);
            for (int i = 1; i <= input; i ++)
            {
                if (i % 2== 0)
                {
                    Console.WriteLine(Math.Pow(number, i));
                }
                
            }
           
            
            
            
            05.Character Sequence
             

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }


            06.Vowels Sum
        

            string input = Console.ReadLine();

            var dic = new Dictionary<string, int>
            {
                {"a", 1 },
                {"e", 2 },
                {"i", 3 },
                {"o", 4 },
                {"u", 5 }
            };
            
            int totalScore = 0;
            for (int i = 0; i < input.Length; i++)
            {
                
                if (dic.ContainsKey(input[i].ToString()))
                {
                    
                    totalScore += dic[input[i].ToString()];
                }
            }

            Console.WriteLine(totalScore);

            07.Sum Numbers
            

            int input = int.Parse(Console.ReadLine());
            int totalScore = 0;
           
            for (int i = 0; i < input; i++)
            {

                int newInput = int.Parse(Console.ReadLine());
                totalScore += newInput;
            }
            Console.WriteLine(totalScore);

            08.Number sequence
           

            decimal input = decimal.Parse(Console.ReadLine());
            decimal min = 0;
            decimal max = 0;
            
            
            for (int i = 0; i < input; i++)
            {

                decimal newInput = decimal.Parse(Console.ReadLine());

                if (i ==0 )
                {
                    max = newInput;
                    min = newInput;
                }

                if (max <= newInput)
                {
                    max = newInput;
                }
                if (min >= newInput)
                {
                    min = newInput;
                }
                 
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");


            09.Left and Right Sum
            
            decimal input = decimal.Parse(Console.ReadLine());
            decimal totalSum1 = 0;
            decimal totalSum2 = 0;

            for (int i = 0; i < input; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                totalSum1 += number;
            }
            for (int i = 0; i < input; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                totalSum2 += number;
            }

            if (totalSum1 == totalSum2)
            {
                Console.WriteLine($"Yes, sum = {totalSum2}");
            }
            else
            {
                decimal num = 0;
                if (totalSum1 > totalSum2)
                {
                    num = totalSum1 - totalSum2;
                }
                else
                {
                    num = totalSum2 - totalSum1;
                }
                Console.WriteLine($"No, diff = {num}");
            }

            10.Odd Even Sum

             

            decimal input = decimal.Parse(Console.ReadLine());
            decimal totalSum1 = 0;
            decimal totalSum2 = 0;

            for (int i = 1; i <= input; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    totalSum1 += number;
                }
                else
                {
                    totalSum2 += number;
                }

            }

                if (totalSum1 == totalSum2)
                {
                    Console.WriteLine($"Yes\nSum = {totalSum2}");
                }
                else
                {
                    decimal num = 0;
                    if (totalSum1 > totalSum2)
                    {
                        num = totalSum1 - totalSum2;
                    }
                    else
                    {
                        num = totalSum2 - totalSum1;
                    }
                    Console.WriteLine($"No\nDiff = {num}");
                }
           
             11. Clever Lily
             
          


            decimal age = decimal.Parse(Console.ReadLine());
            decimal washingPrice = decimal.Parse(Console.ReadLine());
            decimal toyPrice = decimal.Parse(Console.ReadLine());
            decimal moneyPres = 10;
            decimal totalMoney = 0;
            int counter = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    totalMoney += moneyPres;
                    moneyPres += 10;
                    counter ++;
                }
                else
                {
                    totalMoney += toyPrice;
                }
            }
            totalMoney -= counter;
            if (totalMoney >= washingPrice)
            {
                totalMoney -= washingPrice;
                Console.WriteLine($"Yes! {totalMoney:F2}");
            }
            else
            {
                washingPrice -= totalMoney;
                Console.WriteLine($"No! {washingPrice:F2}");
            }

               */
        }
    }
    }
