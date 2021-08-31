using System;
using System.Linq;
using System.Collections.Generic;
namespace CSharp_Advanced_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://judge.softuni.bg/Contests/Practice/Index/2597#0
            //_01_Scheduling();
            //_02_Garden();

        }


        private static void _02_Garden()
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[][] jagged = new int[dimentions[0]][];
            for (int i = 0; i < jagged.GetLength(0); i++)
            {
                jagged[i] = new int[dimentions[1]];           
            }
            string[] command = { "", "", "" };
            while ((command = Console.ReadLine().Split()).Length != 3)
            {
                int x = int.Parse(command[0]);
                int y = int.Parse(command[1]);
                
                if (int.Parse(command[0]) > jagged.Length  || int.Parse(command[0]) < 0 || int.Parse(command[1]) > jagged[x].Length || int.Parse(command[1]) < 0)
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }
                int current = jagged[x][y];
                for (int i = 0; i < jagged.Length; i++)
                {
                    jagged[0 + i][y] += 1;                    
                }
                for (int j = 0; j < jagged[x].Length; j++)
                {
                    jagged[x][0 + j] += 1;
                }
                jagged[x][y] = current + 1;
            }
            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(' ', item));
            }
        }

        private static void _01_Scheduling()
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Queue<int> que = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int kill = int.Parse(Console.ReadLine());
            while (stack.Peek() != kill)
            {
                if (stack.Peek() <= que.Peek())
                {
                    stack.Pop();
                    que.Dequeue();
                }
                else
                {
                    que.Dequeue();
                }
            }
            Console.WriteLine($"Thread with value {que.Peek()} killed task {kill}");
            Console.WriteLine(string.Join(' ', que));
        }
    }
}
