using System;
using System.Collections.Generic;
using System.Linq;
namespace Stacks_and_Queues___Lab___Core
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://judge.softuni.bg/Contests/Practice/Index/1445#0
            //_1_ReverseStrings();
            //_2_StackSum();
            //_3_SimpleCalculator();
            //_4_MatchingBrackets();
            //_5_PrintEvenNumbers();
            //_6_Supermarket();
            //_7_HotPotato();
            _8_TrafficJam();
        }

        private static void _8_TrafficJam()
        {
            int popper = int.Parse(Console.ReadLine());
            string input = "";
            Queue<string> output = new Queue<string>();
            int passed = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < popper; i++)
                    {
                        if (!(output.Count == 0))
                        {
                            Console.WriteLine($"{output.Dequeue()} passed!");
                            passed++;
                        }
                       
                    }
                }
                else
                {
                    output.Enqueue(input);
                }
            }
            Console.WriteLine($"{passed} cars passed the crossroads.");
        }

        private static void _7_HotPotato()
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Queue<string> output = new Queue<string>(input);
            int popper = int.Parse(Console.ReadLine());
            while (output.Count > 1)
            {
                for (int i = 0; i < popper; i++)
                {
                    if (i == popper -1)
                    {                        
                        Console.WriteLine($"Removed {output.Dequeue()}");
                    }
                    else
                    {
                        output.Enqueue(output.Dequeue());
                    }                    
                }
            }
            Console.WriteLine($"Last is {output.Peek()}");
        }

        private static void _6_Supermarket()
        {
            string input = "";
            Queue<string> test = new Queue<string>();
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                   while(test.Count > 0)
                    {
                        Console.WriteLine(test.Dequeue());
                    }   
                }
                else
                {
                    test.Enqueue(input);
                }
            }
            Console.WriteLine($"{test.Count} people remaining.");
        }

        private static void _5_PrintEvenNumbers()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> test = new Queue<int>(input);
            List<int> even = new List<int>();
            for (int i = 0; i < test.Count; i++)
            {
                if (test.Peek() % 2 == 0)
                {
                    even.Add(test.Peek());                   
                }
                test.Dequeue();
                i--;
            }
            Console.WriteLine(string.Join(", ", even));
        }

        private static void _4_MatchingBrackets()
        {
            string test = Console.ReadLine();
            Stack<int> stackInput = new Stack<int>();
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] == '(')
                {
                    stackInput.Push(i);
                }
                else if (test[i] == ')')
                {
                    int oldIndex = stackInput.Pop();
                    string current = "";
                    for (int j = oldIndex; j <= i; j++)
                    {
                        current += test[j];
                    }
                    Console.WriteLine(current);
                }                
            }
        }

        private static void _3_SimpleCalculator()
        {
            string[] ini = Console.ReadLine().Split().Reverse().ToArray();
            Stack<string> input = new Stack<string>(ini);
            bool sym = false;
            while(input.Count > 1)
            {
                //int number = int.Parse(input.Pop());
                int number1 = int.Parse(input.Pop());
                string oper = input.Pop();
                int number2 = int.Parse(input.Pop());
                if (oper == "+")
                {
                    input.Push((number2 + number1).ToString());
                    continue;
                }
                else if (oper == "-")
                {
                    input.Push((number1 - number2).ToString());
                    continue;
                }              
            }
            Console.WriteLine(input.Peek());
        }

        private static void _2_StackSum()
        {
            string [] input = { "","","","","" };
            int[] initial = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stackInt = new Stack<int>(initial);
            while ((input = Console.ReadLine().ToLower().Split())[0] != "end")
            {
                if (input[0] == "add")
                {
                    stackInt.Push(int.Parse(input[1]));
                    stackInt.Push(int.Parse(input[2]));
                }
                else if (input[0] == "remove")
                {
                    int index = int.Parse(input[1]);
                    if (!(index > stackInt.Count))
                    {
                        for (int i = 0; i < index; i++)
                        {
                            stackInt.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {stackInt.Sum()}");
        }

        private static void _1_ReverseStrings()
        {
            char[] test = Console.ReadLine().ToCharArray();
            Stack<char> stackInput = new Stack<char>(test);
            
            for (int i = 0; i < stackInput.Count; i++)
            {
                stackInput.Push(stackInput.Pop());
            }
            Console.WriteLine(string.Join(string.Empty, stackInput));
        }
    }
}
