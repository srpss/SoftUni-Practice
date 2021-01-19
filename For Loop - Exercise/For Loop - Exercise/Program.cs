using System;

namespace For_Loop___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* https://judge.softuni.bg/Contests/Compete/Index/2382#1
             * https://softuni.bg/trainings/resources/officedocument/56724/for-loop-exercise-programming-basics-with-csharp-january-2021/3199
             * 
             * 01. Numbers Ending in 7
             * 
            for (int i = 0; i < 1000; i++)
            {
                string a = (i.ToString());
                char b = a[a.Length - 1];

                if (b == '7')
                {
                    Console.WriteLine(i);
                }
               
            }

            02.Half Sum Element
            


            int input = int.Parse(Console.ReadLine());
            
            decimal max = 0;
            decimal party2 = 0;
            for (int i = 0; i < input; i++)
            {
                decimal input2 = decimal.Parse(Console.ReadLine());

                if (max < input2)
                {
                    party2 += max;
                    max = input2;
                    
                }
                else
                {
                    party2 += input2;
                }


            }

            if (max == party2)
            {

                Console.WriteLine($"Yes\nSum = {max}");
            }
            else
            {

                if (max > party2)
                {

                    Console.WriteLine($"No\nDiff = {max - party2}");
                }
                else
                {
                    Console.WriteLine($"No\nDiff = {party2 - max}");
                }
            }

            03.Odd / Even Position
           

            int input = int.Parse(Console.ReadLine());

            decimal OddSum = 0;
            decimal OddMin = decimal.MaxValue;
            decimal OddMax = decimal.MinValue;
            decimal EvenSum = 0;
            decimal EvenMin = decimal.MaxValue;
            decimal EvenMax = decimal.MinValue;

           
            for (int i = 1; i <= input; i++)
            {
                decimal input2 = decimal.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    EvenSum += input2;
                    if (EvenMin > input2)
                    {
                        EvenMin = input2;
                    }
                    if (EvenMax < input2)
                    {
                        EvenMax = input2;
                    }
                }
                else
                {
                    OddSum += input2;
                    if (OddMin > input2)
                    {
                        OddMin = input2;
                    }
                    if (OddMax < input2)
                    {
                        OddMax = input2;
                    }
                }
              

            }
            if (input == 0)
            {
                Console.WriteLine($"OddSum=0.00,\nOddMin=No,\nOddMax=No,\nEvenSum=0.00,\nEvenMin=No,\nEvenMax=No");
            }
            else if (input <= 1)
            {
                Console.WriteLine($"OddSum={OddSum:F2},\nOddMin={OddMin:F2},\nOddMax={OddMax:F2},\nEvenSum=0.00,\nEvenMin=No,\nEvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={OddSum:F2},\nOddMin={OddMin:F2},\nOddMax={OddMax:F2},\nEvenSum={EvenSum:F2},\nEvenMin={EvenMin:F2},\nEvenMax={EvenMax:F2}");
            }



            04. Histogram
            


            int input = int.Parse(Console.ReadLine());

            decimal twoh = 0;
            decimal threeh = 0;
            decimal sixH = 0;
            decimal eighth = 0;
            decimal eightplus = 0;
            

            for (int i = 0; i < input; i++)
            {
                decimal input2 = decimal.Parse(Console.ReadLine());

                if (200 > input2)
                {
                    twoh++;
                }
                else if (input2 <= 399)
                {
                    threeh++;
                }
                else if (599 >= input2 )
                {
                    sixH++;
                }
                else if (799 >= input2)
                {
                    eighth++;
                }
                else
                {
                    eightplus++;
                }
            }

            Console.WriteLine($"{twoh/input *100:F2}%\n{threeh / input * 100:F2}%\n{sixH / input * 100:F2}%\n{eighth / input * 100:F2}%\n{eightplus / input * 100:F2}%\n");


            05.Divide Without Remainder

             
            int input = int.Parse(Console.ReadLine());

            decimal twoh = 0;
            decimal threeh = 0;
            decimal sixH = 0;
        


            for (int i = 0; i < input; i++)
            {
                decimal input2 = decimal.Parse(Console.ReadLine());

                if (input2% 2 == 0)
                {
                    twoh++;
                }
                if (input2 % 3 == 0)
                {
                    threeh++;
                }
                if (input2 % 4 == 0)
                {
                    sixH++;
                }
                
               
            }

            Console.WriteLine($"{twoh / input * 100:F2}%\n{threeh / input * 100:F2}%\n{sixH / input * 100:F2}%\n");


            06.Salary

           

            int input = int.Parse(Console.ReadLine());
            decimal salary = decimal.Parse(Console.ReadLine());
            int limiter = 0;
            decimal cost = 0;
            while (salary >= cost &&  limiter < input)
            {
                string input2 = Console.ReadLine();
                if (input2 == "Facebook")
                {
                    cost += 150;
                }
                else if (input2 == "Instagram")
                {
                    cost += 100;
                }
                else if (input2 == "Reddit")
                {
                    cost += 50;
                }

                limiter++;
            }

            if (salary <= cost)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary - cost);
            }

                
 */



        }
    }
}
