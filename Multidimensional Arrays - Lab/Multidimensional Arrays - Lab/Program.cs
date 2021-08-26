using System;
using System.Collections.Generic;
using System.Linq;

namespace Multidimensional_Arrays___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://judge.softuni.bg/Contests/Practice/Index/1452#0
            //_1_SumMatrixElements();
            //_2_SumMatrixColumns();
            //_3_PrimaryDiagonal();
            //_4_SymbolInMatrix();
            //_5_SquareWithMaximumSum();
            //_6_JaggedArrayModification();
            _7_PascalTriangle();
        }

        private static void _7_PascalTriangle()
        {
            long input = long.Parse(Console.ReadLine());
            long[][] jagmatrix = new long[input][]; 
            if (input == 1)
            {
                Console.WriteLine("1");
            }
            else if (input == 2)
            {
                Console.WriteLine("1");
                Console.WriteLine("1 1");
            }
            else
            {
                jagmatrix[0] = new long[] { 1 };
                jagmatrix[1] = new long[] { 1, 1 };
                Console.WriteLine("1");
                Console.WriteLine("1 1");
                for (long i = 2; i < jagmatrix.Length; i++)
                {
                    jagmatrix[i] = new long[i + 1];
                    for (long j = 1; j < jagmatrix[i].Length - 1; j++)
                    {
                        jagmatrix[i][0] = 1;
                        jagmatrix[i][jagmatrix[i].Length - 1] = 1;
                        jagmatrix[i][j] = jagmatrix[i - 1][j - 1] + jagmatrix[i - 1][j];
                    }
                    Console.WriteLine(string.Join(" ", jagmatrix[i]));
                }
            }
        }

        private static void _6_JaggedArrayModification()
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagmatrix = new int[rows][];
            for (int i = 0; i < jagmatrix.Length; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagmatrix[i] = input;
            }
            string[] commands = { "", "", "", "" };
            while ((commands = Console.ReadLine().Split().ToArray())[0] != "END")
            {
                //
                if (int.Parse(commands[1]) > jagmatrix.Length - 1 || int.Parse(commands[1]) < 0 || int.Parse(commands[2]) > jagmatrix.Length - 1 || int.Parse(commands[2]) < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (commands[0] == "Add")
                {
                    jagmatrix[int.Parse(commands[1])][int.Parse(commands[2])] += int.Parse(commands[3]);
                }
                else if (commands[0] == "Subtract")
                {
                    jagmatrix[int.Parse(commands[1])][int.Parse(commands[2])] -= int.Parse(commands[3]);
                }
            }
            foreach (var item in jagmatrix)
            {
                Console.WriteLine(string.Join(' ', item));
            }
        }

        private static void _5_SquareWithMaximumSum()
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[dimensions[0], dimensions[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int biggest = 0;
            int[] index = { 0, 0 };
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (sum > biggest)
                    {
                        biggest = sum;
                        index = new int[] { i, j };
                    }
                }
            }
            Console.WriteLine($"{matrix[index[0], index[1]]} {matrix[index[0], index[1] + 1]}");
            Console.WriteLine($"{matrix[index[0] + 1, index[1]]} {matrix[index[0] + 1, index[1] + 1]}");
            Console.WriteLine(biggest);
        }

        private static void _4_SymbolInMatrix()
        {
            int dimentions = int.Parse(Console.ReadLine());
            char[,] matrix = new char[dimentions, dimentions];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            bool occurs = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (symbol == matrix[i, j])
                    {
                        Console.WriteLine($"({i}, {j})");
                        occurs = true;
                        break;
                    }
                }
            }
            if (occurs == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }

        private static void _3_PrimaryDiagonal()
        {
            int dimensions = int.Parse(Console.ReadLine());
            int[,] matrix = new int[dimensions, dimensions];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int totaValue = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    totaValue += matrix[i, j];
                    i++;
                }
            }
            Console.WriteLine(totaValue);
        }

        private static void _2_SumMatrixColumns()
        {
            int[] dimensions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[dimensions[0], dimensions[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int columnValue = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    columnValue += matrix[j, i];
                }
                Console.WriteLine(columnValue);
                columnValue = 0;
            }
        }

        private static void _1_SumMatrixElements()
        {
            long[] dimensions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            long[,] matrix = new long[dimensions[0], dimensions[1]];
            for (long i = 0; i < matrix.GetLength(0); i++)
            {
                long[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
                for (long j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            long totalValue = 0;
            foreach (long item in matrix)
            {
                totalValue += item;
            }
            Console.WriteLine(totalValue);
        }
    }
}
