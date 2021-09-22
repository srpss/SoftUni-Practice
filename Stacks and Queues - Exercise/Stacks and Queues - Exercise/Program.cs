using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://judge.softuni.org/Contests/Compete/Index/1447#0
            //_01_BasicStackOperations();
            //_02_BasicQueueOperations();
            //_03_MaximumandMinimumElement();
            // _04_FastFood();
            _05_FashionBoutique();
        }

        private static void _05_FashionBoutique()
        {
            int[] totalCloths = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int racks = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(totalCloths);
        }

        private static void _04_FastFood()
        {
            int totalFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var que = new Queue<int>(orders);
            int maxOrder = 0;
            while (que.Count > 0)
            {
                if (que.Peek() >= totalFood)
                {
                    break;
                }
                if (maxOrder < que.Peek())
                {
                    maxOrder = que.Peek();
                }
                totalFood -= que.Dequeue();
            }
            Console.WriteLine(maxOrder);
            if (que.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(' ', que)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }

        private static void _03_MaximumandMinimumElement()
        {
            Stack<int> stack = new Stack<int>();
            int cycle = int.Parse(Console.ReadLine());
            for (int i = 0; i < cycle; i++)
            {
                int[] command = ReadIntArray();
                if (command[0] == 1)
                {
                    stack.Push(command[1]);
                }
                else if (command[0] == 2)
                {
                    if (stack.Count != 0)
                    {
                        stack.Pop();
                    }                                        
                }
                else if (command[0] == 3)
                {
                    if (stack.Count == 0)
                    {
                        
                    }
                    else 
                    {
                        Console.WriteLine(stack.Max());
                    }                            
                }
                else if (command[0] == 4)
                {
                    if (stack.Count == 0)
                    {
                        
                    }
                    else
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
        static int [] ReadIntArray()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
        private static void _02_BasicQueueOperations()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> que = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            for (int i = 0; i < input[1]; i++)
            {
                que.Dequeue();
            }
            if (que.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                int min = int.MaxValue;
                while (que.Count > 0)
                {
                    if (que.Peek() < min)
                    {
                        min = que.Dequeue();
                    }
                    else
                    {
                        que.Dequeue();
                    }
                }
                if (min == int.MaxValue)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(min);
                }
            }
        }

        private static void _01_BasicStackOperations()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            for (int i = 0; i < input[1]; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                int min = int.MaxValue;
                while (stack.Count > 0)
                {               
                    if (stack.Peek() < min)
                    {
                        min = stack.Pop();
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                if (min == int.MaxValue)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(min);
                }                
            }
        }
    }
}
