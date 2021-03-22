using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays___More_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://judge.softuni.bg/Contests/Practice/Index/1275#0

               01. Encrypt, Sort and Print Array
      
           

            int input =int.Parse(Console.ReadLine());
            List<int> holder = new List<int>();
            for (int i = 0; i < input; i++)
            {
                int sum = 0;
                char[] input2 = Console.ReadLine().ToCharArray();
                for (int j = 0; j < input2.Length; j++)
                {
                    char checker = input2[j];
                    switch (checker)
                    {
                        case 'a':
                        case 'e':
                        case 'u':
                        case 'o':
                        case 'i':
                        case 'A':
                        case 'E':
                        case 'U':
                        case 'O':
                        case 'I':
                            sum += checker * input2.Length;
                            break;

              
                            

                        default:
                            sum += checker / input2.Length;
                            break;
                    }
                    
                   
                }
                holder.Add(sum);
            }
            holder.Sort();
            foreach (var item in holder)
            {
                Console.WriteLine(item);
            }

            02.Pascal Triangle
           

            int input = int.Parse(Console.ReadLine());
            int  val = 1, blank, i, j;
            
            for (i = 0; i < input; i++)
            {
               // for (blank = 1; blank <= input - i; blank++)
                   // Console.Write(" ");
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        val = 1;
                    else
                        val = val * (i - j + 1) / j;
                    Console.Write(val + " ");
                }
                Console.WriteLine();
           }

            03.Recursive Fibonacci
             
            int input = int.Parse(Console.ReadLine());

            int sum = 0;
            int prevNumber = 0;
            int total = 0;
            for (int i = 0; i < input; i++)
            {
                total = sum + prevNumber;
                prevNumber = sum;
                sum = total;
                if (sum == 0)
                {
                    sum = 1;
                }
            }
            Console.WriteLine(total);

            4.Fold and Sum
             

            string [] input = (Console.ReadLine()).Split();
            int[] converted = new int[input.Length];
            int index = 0;
            foreach (var item in input)
            {
                converted[index] = int.Parse(item);
                    index ++;
            }

            int[] firstRow = new int[converted.Length / 2];
            int[] secondRow = new int[converted.Length / 2];

            for (int i = 0; i < converted.Length / 2; i++)
            {
                firstRow[i] = converted[i];
            }
            index = 0;
            for (int i = converted.Length / 2; i < converted.Length; i++)
            {
                
                secondRow[index] = converted[i];
                index++;
            }

            for (int i = 0; i < firstRow.Length/2; i++)
            {
                firstRow[i] += firstRow[firstRow.Length - 1 - i];
                firstRow[firstRow.Length - 1 - i]= 0;
            }
            for (int i = 0; i < secondRow.Length / 2; i++)
            {
                secondRow[i] += secondRow[secondRow.Length - 1 - i];
                secondRow[secondRow.Length - 1 - i] = 0;
            }

            for (int i = firstRow.Length- 1; i >= 0; i--)
            {
                if (firstRow[i] != 0)
                {
                    Console.Write(firstRow[i] + " ");
                }
            }
            for (int i = 0; i < secondRow.Length; i++)
            {
                if (secondRow[i] != 0)
                {
                    Console.Write(secondRow[i] + " ");
                }
                
            }

            05.Longest Increasing Subsequence
          not complete

            string[] input = (Console.ReadLine()).Split();
            int[] true123 = new int[input.Length];
            int index = 0;
            foreach (var item in input)
            {
                true123[index] = int.Parse(item);
                index++;
            }
            List<int> current = new List<int>(true123);

            List<int> finalle = new List<int>(lis(current));


            foreach (var item in finalle)
            {
                Console.Write($"{item} ");
            }

            int lis(List<int> A)
            {
                int[] dp = new int[A.Count];
                dp[0] = 1;
                for (int i = 1; i < A.Count; i++)
                {
                    int max = 1;
                    for (int j = 0; j < i; j++)
                    {
                        if (A[j] > A[i])
                            max = Math.Max(max, dp[j] + 1);
                    }

                    dp[i] = max;
                }

                return dp.Max();
               */
        }
    }
    }
}
