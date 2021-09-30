using System;
using System.Collections.Generic;
using System.Linq;

namespace Multidimensional_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://softuni.bg/trainings/resources/officedocument/64217/multidimensional-arrays-exercise-csharp-advanced-september-2021/3483
            //_1_Diagonal_Difference();
            //_2_SquaresinMatrix();
            //_3_MaximalSum();
            //_4_MatrixShuffling();
            //_5_SnakeMoves();
            _6_JaggedArrayManipulator();
        }

        private static void _6_JaggedArrayManipulator()
        {
            
        }

        private static void _5_SnakeMoves()
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[size[0], size[1]];
            Queue<char> snake = new Queue<char>(Console.ReadLine().ToCharArray());
            int even = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int jj = 0 + size[1]- 1;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {                    
                    if (even % 2 == 1)
                    {
                        snake.Enqueue(snake.Peek());
                        matrix[i, j] = snake.Dequeue();
                    }
                    else
                    {
                        snake.Enqueue(snake.Peek());
                        matrix[i, jj] = snake.Dequeue();
                        jj = jj - 1;
                    }
                }
                even++;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }

        private static void _4_MatrixShuffling()
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[size[0], size[1]];
            for (int i = 0; i < size[0]; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < size[1]; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            string[] command = {"","","","","" };
            while ((command = Console.ReadLine().Split())[0] != "END")
            {
                if (command[0] != "swap" || command.Count() != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else if (int.Parse(command[1]) > matrix.GetLength(0) || int.Parse(command[1]) < 0 || int.Parse(command[2]) > matrix.GetLength(1) || int.Parse(command[2]) < 0
                    || int.Parse(command[3]) > matrix.GetLength(0) || int.Parse(command[3]) < 0 || int.Parse(command[4]) > matrix.GetLength(1) || int.Parse(command[4]) < 0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                string swap1 = matrix[int.Parse(command[1]), int.Parse(command[2])];
                string swap2 = matrix[int.Parse(command[3]), int.Parse(command[4])];
                matrix[int.Parse(command[1]), int.Parse(command[2])] = swap2;
                matrix[int.Parse(command[3]), int.Parse(command[4])] = swap1;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write($"{matrix[i,j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void _3_MaximalSum()
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            for (int i = 0; i < size[0]; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < size[1]; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int currentMax = int.MinValue;
            int [] coordinates = { 0, 0};
            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] 
                        + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] 
                        + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (currentMax < sum)
                    {
                        currentMax = sum;
                        coordinates[0] = i;
                        coordinates[1] = j;
                    }
                }
            }
            if (currentMax != int.MinValue)
            {
                Console.WriteLine($"Sum = {currentMax}");
                Console.WriteLine($"{matrix[coordinates[0], coordinates[1]]} {matrix[coordinates[0], coordinates[1] + 1]} {matrix[coordinates[0], coordinates[1] + 2]}");
                Console.WriteLine($"{matrix[coordinates[0] + 1, coordinates[1]]} {matrix[coordinates[0] + 1, coordinates[1] + 1]} {matrix[coordinates[0] + 1, coordinates[1] + 2]}");
                Console.WriteLine($"{matrix[coordinates[0] + 2, coordinates[1]]} {matrix[coordinates[0] + 2, coordinates[1] + 1]} {matrix[coordinates[0] + 2, coordinates[1] + 2]}");

            }
        }

        private static void _2_SquaresinMatrix()
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[size[0], size[1]];
            for (int i = 0; i < size[0]; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < size[1]; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int found = 0;
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    if (matrix[i,j] == matrix[i, j+1] && matrix[i, j] == matrix[i+1 , j ] && matrix[i, j] == matrix[i+ 1, j + 1])
                    {
                        found++;
                    }
                }
            }
            Console.WriteLine(found);
        }

        private static void _1_Diagonal_Difference()
        {
            int size = int.Parse(Console.ReadLine());
            int [,] matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int diagonalLeft = 0;
            int diagnoalRight = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                diagonalLeft += matrix[i, i];
            }
            int count = 0;
            for (int i = matrix.GetLength(0) -1; i >= 0 ; i--)
            {
                diagnoalRight += matrix[i, count];
                count++;
            }
            int endResult = Math.Abs(diagonalLeft - diagnoalRight);
            Console.WriteLine(endResult);
        }
    }
}
