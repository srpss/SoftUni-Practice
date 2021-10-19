using System;
using System.Collections.Generic;
using System.Linq;

namespace Guild
{
    class Startup
    {
        static void Main(string[] args)
        {
            //https://judge.softuni.org/Contests/2032/CSharp-Advanced-Exam-22-Feb-2020
            //_01_LootBox();
            //_02_ReVolt();
            _03_Guild();
        }
        private static void _03_Guild()
        {
            //Initialize the repository (guild)
            Guild guild = new Guild("Weekend Raiders", 20);
            //Initialize entity
            Player player = new Player("Mark", "Rogue");
            //Print player
            Console.WriteLine(player); //Player Mark: Rogue
                                       //Rank: Trial
                                       //Description: n/a

            //Add player
            guild.AddPlayer(player);
            Console.WriteLine(guild.Count); //1
            Console.WriteLine(guild.RemovePlayer("Gosho")); //False

            Player firstPlayer = new Player("Pep", "Warrior");
            Player secondPlayer = new Player("Lizzy", "Priest");
            Player thirdPlayer = new Player("Mike", "Rogue");
            Player fourthPlayer = new Player("Marlin", "Mage");

            //Add description to player
            secondPlayer.Description = "Best healer EU";

            //Add players
            guild.AddPlayer(firstPlayer);
            guild.AddPlayer(secondPlayer);
            guild.AddPlayer(thirdPlayer);
            guild.AddPlayer(fourthPlayer);

            //Promote player
            guild.PromotePlayer("Lizzy");

            //RemovePlayer
            Console.WriteLine(guild.RemovePlayer("Pep")); //True

            Player[] kickedPlayers = guild.KickPlayersByClass("Rogue");
            Console.WriteLine(string.Join(", ", kickedPlayers.Select(p => p.Name))); //Mark, Mike

            Console.WriteLine(guild.Report());
            //Players in the guild: Weekend Raiders
            //Player Lizzy: Priest
            //Rank: Member
            //Description: Best healer EU
            //Player Marlin: Mage
            //Rank: Trial
            //Description: n/a


        }
        private static void _02_ReVolt()
        {
            bool win = false;
            int rows = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            char[][] matrix = new char[rows][];
            int[] F = { 0, 0 };
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 'f')
                    {
                        F[0] = i;
                        F[1] = j;
                        break;
                    }
                }
            }
            if (count > 0)
            {
                matrix[F[0]][F[1]] = '-';
            }
            for (int i = 0; i < count; i++)
            {
           
                string command = Console.ReadLine();
                if (command == "up")
                {
                    Up(rows, matrix, F);
                }
                else if (command == "down")
                {
                    int power = 1;
                    for (int j = 0; j < power; j++)
                    {
                        int[] C = { F[0], F[1] };
                        if (F[0] < rows - 1)
                        {
                            if (matrix[F[0] + 1][F[1]] == 'B')
                            {
                                power++;

                            }
                            else if (matrix[F[0] + 1][F[1]] == 'T')
                            {
                                continue;
                            }
                            F[0]++;                            
                        }
                        else if (F[0] == rows - 1)
                        {
                            if (matrix[0][F[1]] == 'B')
                            {
                                power++;
                            }
                            else if (matrix[0][F[1]] == 'T')
                            {
                                continue;
                            }
                            F[0] = 0;
                        }
                    }
                }
                else if (command == "left")
                {
                    int power = 1;
                    for (int j = 0; j < power; j++)
                    {
                        int[] C = { F[0], F[1] };
                        if (F[1] > 0)
                        {
                            if (matrix[F[0]][F[1] - 1] == 'B')
                            {
                                power++;

                            }
                            else if (matrix[F[0]][F[1] - 1] == 'T')
                            {
                                continue;
                            }
                            F[1]--;
                        }
                        else if (F[1] == 0)
                        {
                            if (matrix[F[0]][rows - 1] == 'B')
                            {
                                power++;
                            }
                            else if (matrix[F[0]][rows - 1] == 'T')
                            {
                                continue;
                            }
                            F[1] = rows - 1;
                        }
                    }
                }
                else if (command == "right")
                {
                    int power = 1;
                    for (int j = 0; j < power; j++)
                    {
                        int[] C = { F[0], F[1] };
                        if (F[1] < rows - 1)
                        {
                            if (matrix[F[0]][F[1] + 1] == 'B')
                            {
                                power++;

                            }
                            else if (matrix[F[0]][F[1] + 1 ] == 'T')
                            {
                                continue;
                            }
                            F[1]++;
                        }
                        else if (F[0] == rows - 1)
                        {
                            if (matrix[F[0]][0] == 'B')
                            {
                                power++;
                            }
                            else if (matrix[0][F[rows - 1]] == 'T')
                            {
                                continue;
                            }
                            F[1] = 0;
                        }
                    }
                }
                if (matrix[F[0]][F[1]] == 'F')
                {
                    Console.WriteLine("Player won!");
                    win = true;
                    break;
                }
            }
            if (win == false)
            {
                Console.WriteLine("Player lost!");
            }
            matrix[F[0]][F[1]] = 'f';
            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(String.Empty, item));
            }
        }

        private static void Up(int rows, char[][] matrix, int[] F)
        {
            int power = 1;
            for (int j = 0; j < power; j++)
            {
                int[] C = { F[0], F[1] };
                if (F[0] > 0)
                {
                    if (matrix[F[0] - 1][F[1]] == 'B')
                    {
                        power++;

                    }
                    else if (matrix[F[0] - 1][F[1]] == 'T')
                    {
                        continue;
                    }
                    F[0]--;
                }
                else if (F[0] == 0)
                {
                    if (matrix[rows - 1][F[1]] == 'B')
                    {
                        power++;
                    }
                    else if (matrix[rows - 1][F[1]] == 'T')
                    {
                        continue;
                    }
                    F[0] = rows - 1;
                }
            }
        }

        private static void _01_LootBox()
        {
            Queue<int> que = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int collection = 0;
            while (que.Count > 0 && stack.Count > 0)
            {
                if ((que.Peek() + stack.Peek()) % 2 == 0)
                {
                    collection += que.Dequeue() + stack.Pop();
                }
                else
                {
                    que.Enqueue(stack.Pop());
                }
            }
            if (que.Count > 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            else
            {
                Console.WriteLine("First lootbox is empty");
            }
            if (collection >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {collection}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {collection}");
            }
        }
    }
}
