using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Programming_Fundamentals_Mid_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            /*https://judge.softuni.bg/Contests/Practice/Index/2474#0
             * 01. SoftUni Reception
             
            List<Receptionist> receptionists = new List<Receptionist>();
            for (int i = 0; i < 3; i++)
            {
                receptionists.Add(new Receptionist { HowManyStudentCanHandlePerHour = decimal.Parse(Console.ReadLine()) });
            }
            decimal totalStudentsPerHour = 0;
            foreach (var receptionist in receptionists)
            {
                totalStudentsPerHour += receptionist.HowManyStudentCanHandlePerHour;
            }

            
            decimal totalStudents = decimal.Parse(Console.ReadLine());
            int hour = 0;
            while (totalStudents >0)
            {
                if (hour != 0  && hour % 3 ==0)
                {
                    hour++;
                    continue;
                }
                hour++;
                
                totalStudents -= totalStudentsPerHour;
            }

            Console.WriteLine($"Time needed: {hour}h.");
        
            */

            /*
            02. Array Modifier
            
            List<int> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string [] command = new string[3];
            while ((command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries))[0] != "end")
            {
                if (command[0] == "swap")
                {
                    int first = input[int.Parse(command[1])];
                    int second = input[int.Parse(command[2])];
                    input[int.Parse(command[1])] = second;
                    input[int.Parse(command[2])] = first;
                }
                else if (command[0] == "multiply")
                {
                    int first = input[int.Parse(command[1])];
                    int second = input[int.Parse(command[2])];
                    input[int.Parse(command[1])] = first * second;
                }
                else if (command[0] == "decrease")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        input[i] -= 1;
                    }
                }
            } 
            Console.WriteLine(string.Join(", ", input));
        
            */

            /*
            03. Numbers
                
            List<decimal> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();
            decimal average = input.Sum() / input.Count;
            input.Sort();
            input.Reverse();
            List<decimal> top5 = new List<decimal>();
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > average)
                {
                    top5.Add(input[i]);
                }
            }
            if (top5.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = 0; i < top5.Count; i++)
                {
                    if (i == 5)
                    {
                        break;
                    }
                    Console.Write($"{top5[i]} ");
                }
            }
            */
        }
        class Receptionist
        {

            public decimal HowManyStudentCanHandlePerHour { get; set; }

        }
    }
}
