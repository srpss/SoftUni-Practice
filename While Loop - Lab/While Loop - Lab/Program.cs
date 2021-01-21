using System;

namespace While_Loop___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            https://judge.softuni.bg/Contests/Compete/Index/2383#8
            https://softuni.bg/trainings/resources/officedocument/56726/while-loop-lab-programming-basics-with-csharp-january-2021/3199

            01. Read Text
            
            string input = Console.ReadLine();
            while (input.ToLower() != "stop")
            {
                Console.WriteLine(input);


                input = Console.ReadLine();
            }


            02.Password

           
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();


            string pass = Console.ReadLine();
            while (input2 != pass)
            {
                pass = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {input}!");


            03.Sum Numbers

            
            decimal input = decimal.Parse(Console.ReadLine());


            decimal input2 = decimal.Parse(Console.ReadLine());
            
            while (input > input2)
            {

               

                input2 += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(input2);


            04.Sequence 2k + 1

             
            decimal input = decimal.Parse(Console.ReadLine());
            decimal sum = 0;
            while (input > sum)
            {

                sum = sum * 2 + 1;
                if (input >= sum)
                {
                    Console.WriteLine(sum);
                }
                
                
            }

            05.Account Balance
         

            string input =Console.ReadLine();
            decimal total = 0;
            while (input != "NoMoreMoney")
            {
                decimal input1 = decimal.Parse(input);
                if (input1 >= 0)
                {
                    Console.WriteLine($"Increase: {input1:F2}");
                    total += input1;
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {total:F2}");

            06.Max Number

             

            string input = Console.ReadLine();
            decimal max = decimal.MinValue;
            while (input != "Stop")
            {
                decimal input1 = decimal.Parse(input);

                if (input1 > max)
                {
                    max = input1;
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"{max}");
           
            
            07.Min Number

             
            string input = Console.ReadLine();
            decimal max = decimal.MaxValue;
            while (input != "Stop")
            {
                decimal input1 = decimal.Parse(input);

                if (input1 < max)
                {
                    max = input1;
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"{max}");

            08.Graduation pt.2
            

            string input = Console.ReadLine();
            decimal max = decimal.Parse(Console.ReadLine());
            int checher = 1;
            int killed = 0;
            decimal totalScore = 0;
            while (checher <= 12 )
            {
                

                if (max >= 4.00m)
                {
                    totalScore += max;
                    checher++;
                    killed = 0;
                    if (checher == 13)
                    {
                        break;
                    }
                    
                  
                }
                else
                {
                    killed++;
                    if (killed == 2)
                    {
                        Console.WriteLine($"{input} has been excluded at {checher} grade");
                        break;
                    }
                    
                   
                }
                max = decimal.Parse(Console.ReadLine());


            }
            if (killed != 2)
            {
                Console.WriteLine($"{input} graduated. Average grade: {totalScore / 12:F2}");
            }

           
        }
    }
}
