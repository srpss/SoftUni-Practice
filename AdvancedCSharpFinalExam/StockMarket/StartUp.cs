using System;
using System.Linq;
using System.Collections.Generic;

namespace StockMarket
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //https://judge.softuni.org/Contests/Compete/Index/3228#0
            //_01_FoodFinder();
            //_02_PawnWars();
            _03_StockMarket();
        }

        private static void _03_StockMarket()
        {
            // Sample Code Usage:

            // Initialize Investor
            Investor investor = new Investor("Peter Lynch", "p.lynch@gmail.com", 2000m, "Fidelity");

            // Initialize Stock
            Stock ibmStock = new Stock("IBM", "Arvind Krishna", 138.50m, 5000);

            // Print a stock
            Console.WriteLine(ibmStock.ToString());

            // Company: IBM
            // Director: Arvind Krishna
            // Price per share: $138.50
            // Market capitalization: $692500.00

            // Buy a stock
            investor.BuyStock(ibmStock);
            // Sell a stock
            Console.WriteLine(investor.SellStock("IBM", 150.00m)); // "IBM was sold."
                                                                   // Add stocks
            Stock teslaStock = new Stock("Tesla", "Elon Musk", 743.17m, 6520);
            Stock amazonStock = new Stock("Amazon", "Jeff Bezos", 3457.17m, 8500);
            Stock twitterStock = new Stock("Twitter", "Jack Dorsey", 59.66m, 11200);
            Stock blizzardStock = new Stock("Activision Blizzard", "Bobby Kotick", 78.53m, 5520);

            // Buy more stocks
            investor.BuyStock(teslaStock);
            investor.BuyStock(amazonStock);
            investor.BuyStock(twitterStock);
            investor.BuyStock(blizzardStock);

            // FindBiggestCompany
            Console.WriteLine(investor.FindBiggestCompany());

            // Company: Tesla
            // Director: Elon Musk
            // Price per share: $743.17
            // Market capitalization: $4845468.40

            // Print investor information
            Console.WriteLine(investor.InvestorInformation());

            // The investor Peter Lynch with a broker Fidelity has stocks:
            // Company: Tesla
            // Director: Elon Musk
            // Price per share: $743.17
            // Market capitalization: $4845468.40
            // Company: Twitter
            // Director: Jack Dorsey
            // Price per share: $59.66
            // Market capitalization: $668192.00
            // Company: Activision Blizzard
            // Director: Bobby Kotick
            // Price per share: $78.53
            // Market capitalization: $433485.60

        }

        private static void _02_PawnWars()
        {
            char[][] board = new char[8][];
            int[] b = { 0, 0 };
            int[] w = { 0, 0 };
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = Console.ReadLine().ToCharArray();
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == 'b')
                    {
                        b[0] = i;
                        b[1] = j;
                        continue;
                    }
                    else if (board[i][j] == 'w')
                    {
                        w[0] = i;
                        w[1] = j;
                        continue;
                    }
                }
            }
            bool turns = false;
            bool winner = false;
            bool promoted = false;
            while (true)
            {
                if (turns == false)
                {
                    int place = w[0];
                    int place2 = w[1];
                    if (place - 1 >= 0)
                    {
                        if (place2 - 1 >= 0 )
                        {
                            if (board[place - 1][place2 - 1] == 'b')
                            {
                                winner = false;
                                board[place][place2] = '-';
                                board[place - 1][place2 - 1] = 'w';
                                w[0] = place - 1;
                                w[1] = place2 - 1;
                                break;
                            }
                            
                        }
                        if (place2 + 1 < board[place].Length )
                        {
                            if (board[place - 1][place2 + 1] == 'b')
                            {
                                board[place][place2] = '-';
                                board[place - 1][place2 + 1] = 'w';
                                w[0] = place - 1;
                                w[1] = place2 + 1;
                                winner = false;
                                break;
                            }
                        }                        
                    }
                    board[place][place2] = '-';
                    board[place - 1][place2] = 'w';
                    w[0] = place - 1;
                    if (w[0] == 0)
                    {
                        winner = false;
                        promoted = true;
                        break;
                    }
                    turns = true;                
                }
                else
                {
                    int place = b[0];
                    int place2 = b[1];
                    if (place + 1 <= board.Length - 1)
                    {
                        if (place2 - 1 >= 0)
                        {
                            if (board[place + 1][place2 - 1] == 'w')
                            {
                                winner = true;
                                board[place][place2] = '-';
                                board[place + 1][place2 - 1] = 'b';
                                b[0] = place + 1;
                                b[1] = place2 - 1;
                                break;
                            }

                        }
                        if (place2 + 1 < board[place].Length)
                        {
                            if (board[place + 1][place2 + 1] == 'w')
                            {
                                board[place][place2] = '-';
                                board[place + 1][place2 + 1] = 'b';
                                b[0] = place + 1;
                                b[1] = place2 + 1;
                                winner = true;
                                break;
                            }
                        }
                    }
                    board[place][place2] = '-';
                    board[place + 1][place2] = 'b';
                    b[0] = place + 1;
                    if (b[0] == board.Length - 1)
                    {
                        winner = true;
                        promoted = true;
                        break;
                    }
                    turns = false;
                }
            }
            string coord = "";
            if (winner == false)
            {
                if (w[1] == 0)
                {
                    coord += "a";
                }
                else if(w[1] == 1)
                {
                    coord += "b";
                }
                else if (w[1] == 2)
                {
                    coord += "c";
                }
                else if (w[1] == 3)
                {
                    coord += "d";
                }
                else if (w[1] == 4)
                {
                    coord += "e";
                }
                else if (w[1] == 5)
                {
                    coord += "f";
                }
                else if (w[1] == 6)
                {
                    coord += "g";
                }
                else if (w[1] == 7)
                {
                    coord += "h";
                }
                if (w[0] == 7)
                {
                    coord += "1";
                }
                else if (w[0] == 6)
                {
                    coord += "2";
                }
                else if (w[0] == 5)
                {
                    coord += "3";
                }
                else if (w[0] == 4)
                {
                    coord += "4";
                }
                else if (w[0] == 3)
                {
                    coord += "5";
                }
                else if (w[0] == 2)
                {
                    coord += "6";
                }
                else if (w[0] == 1)
                {
                    coord += "7";
                }
                else if (w[0] == 0)
                {
                    coord += "8";
                }
                if (promoted == false)
                {
                    Console.WriteLine($"Game over! White capture on {coord}.");
                }
                else
                {
                    Console.WriteLine($"Game over! White pawn is promoted to a queen at {coord}.");
                }
            }
            else
            {
                if (b[1] == 0)
                {
                    coord += "a";
                }
                else if (b[1] == 1)
                {
                    coord += "b";
                }
                else if (b[1] == 2)
                {
                    coord += "c";
                }
                else if (b[1] == 3)
                {
                    coord += "d";
                }
                else if (b[1] == 4)
                {
                    coord += "e";
                }
                else if (b[1] == 5)
                {
                    coord += "f";
                }
                else if (b[1] == 6)
                {
                    coord += "g";
                }
                else if (b[1] == 7)
                {
                    coord += "h";
                }
                if (b[0] == 7)
                {
                    coord += "1";
                }
                else if (b[0] == 6)
                {
                    coord += "2";
                }
                else if (b[0] == 5)
                {
                    coord += "3";
                }
                else if (b[0] == 4)
                {
                    coord += "4";
                }
                else if (b[0] == 3)
                {
                    coord += "5";
                }
                else if (b[0] == 2)
                {
                    coord += "6";
                }
                else if (b[0] == 1)
                {
                    coord += "7";
                }
                else if (b[0] == 0)
                {
                    coord += "8";
                }
                if (promoted == false)
                {
                    Console.WriteLine($"Game over! Black capture on {coord}.");
                }
                else
                {
                    Console.WriteLine($"Game over! Black pawn is promoted to a queen at {coord}.");
                }
            }
        }

        private static void _01_FoodFinder()
        {
            string[] test = Console.ReadLine().Split(" ");
            char[] test1 = new char[test.Length];
            for (int i = 0; i < test.Length; i++)
            {
                test1[i] = test[i][0];
            }
            string[] test2 = Console.ReadLine().Split(" ");
            char[] test3 = new char[test2.Length];
            for (int i = 0; i < test2.Length; i++)
            {
                test3[i] = test2[i][0];
            }
            Queue<char> que = new Queue<char>(test1);
            Stack<char> stack = new Stack<char>(test3);
            char[] pear = { 'p', 'e', 'a', 'r' };
            char[] flour = { 'f', 'l', 'o', 'u', 'r' };
            char[] pork = { 'p', 'o', 'r', 'k' };
            char[] olive = { 'o', 'l', 'i', 'v', 'e' };
            List<string> words = new List<string>();
            List<char> chars = new List<char>();
            while (stack.Count > 0)
            {
                char current = que.Dequeue();
                que.Enqueue(current);
                char currentStack = stack.Pop();
                chars.Add(current);
                chars.Add(currentStack);
                if (chars.Contains('p') && !words.Contains("pear"))
                {
                    if (chars.Contains('e'))
                    {
                        if (chars.Contains('a'))
                        {
                            if (chars.Contains('r'))
                            {
                                words.Add("pear");
                            }
                        }


                    }
                }
                if (chars.Contains('f') && !words.Contains("flour"))
                {
                    if (chars.Contains('l'))
                    {
                        if (chars.Contains('o'))
                        {
                            if (chars.Contains('u'))
                            {
                                if (chars.Contains('r'))
                                {
                                    words.Add("flour");
                                }
                            }
                        }


                    }
                }
                if (chars.Contains('p') && !words.Contains("pork"))
                {
                    if (chars.Contains('o'))
                    {
                        if (chars.Contains('r'))
                        {
                            if (chars.Contains('k'))
                            {
                                words.Add("pork");
                            }
                        }


                    }
                }
                if (chars.Contains('o') && !words.Contains("olive"))
                {
                    if (chars.Contains('l'))
                    {
                        if (chars.Contains('i'))
                        {
                            if (chars.Contains('v'))
                            {
                                if (chars.Contains('e'))
                                {
                                    words.Add("olive");
                                }
                            }
                        }


                    }
                }
            }
           
            Console.WriteLine($"Words found: {words.Count}");
            words.Reverse();
            if (words.Contains("pear"))
            {
                Console.WriteLine("pear");
            }
            if (words.Contains("flour"))
            {
                Console.WriteLine("flour");
            }
            if (words.Contains("pork"))
            {
                Console.WriteLine("pork");
            }
            if (words.Contains("olive"))
            {
                Console.WriteLine("olive");
            }
        }
    }
}
