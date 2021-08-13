using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace _01._Programming_Fundamentals_Final_Exam_Retake
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://judge.softuni.bg/Contests/Practice/Index/2525#1

            /*_01_TheImitationGame();*/
            /*_02_AdAstra();*/
            _03_ThePianist();
        }
        class Piece
        {
            public string piece { get; set; }
            public string composer { get; set; }
            public string key { get; set; }
        }
        private static void _03_ThePianist()
        {
            int total = int.Parse(Console.ReadLine());
            List<Piece> pieces = new List<Piece>();
            for (int i = 0; i < total; i++)
            {
                string[] peiceses = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
                Piece current = new Piece();
                current.piece = peiceses[0];
                current.composer = peiceses[1];
                current.key = peiceses[2];
                pieces.Add(current);
            }
            string[] command = { "", "", "", "" };
            while ((command = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries))[0] != "Stop")
            {
                int index = 0;
                bool checker = false;
                for (int i = 0; i < pieces.Count; i++)
                {
                    if (pieces[i].piece == command[1])
                    {
                        index = i;
                        checker = true;
                    }
                }
                if (command[0] == "Add")
                {
                    if (checker == true)
                    {                        
                        Console.WriteLine($"{command[1]} is already in the collection!");
                    }
                    else
                    {
                        Piece current = new Piece();
                        current.piece = command[1];
                        current.composer = command[2];
                        current.key = command[3];
                        pieces.Add(current);
                        Console.WriteLine($"{command[1]} by {command[2]} in {command[3]} added to the collection!");
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (checker == true)
                    {
                        pieces.RemoveAt(index);
                        Console.WriteLine($"Successfully removed {command[1]}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {command[1]} does not exist in the collection.");
                    }
                }
                else if (command[0] == "ChangeKey")
                {
                    if (checker == true)
                    {
                        pieces[index].key = command[2];
                        Console.WriteLine($"Changed the key of {command[1]} to {command[2]}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {command[1]} does not exist in the collection.");
                    }
                }
            }
            foreach (var item in pieces.OrderBy(n => n.piece).ThenBy(n => n.composer))
            {
                Console.WriteLine($"{item.piece} -> Composer: {item.composer}, Key: {item.key}");
            }
        }

        private static void _02_AdAstra()
        {
            //([#?\|])([A-Za-z ]+)\1(0?\d\d\/0?\d\d\/0?\d\d)\1(\d{1,5})\1
            string pattern = @"([#?\|])([A-Za-z ]+)\1(0?\d\d\/0?\d\d\/0?\d\d)\1(\d{1,5})\1";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, pattern);
            int total = 0;
            for (int i = 0; i < matches.Count; i++)
            {
                total += int.Parse(matches[i].Groups[4].ToString());
            }
            int days = total / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");
            for (int i = 0; i < matches.Count; i++)
            {
                Console.WriteLine($"Item: {matches[i].Groups[2]}, Best before: {matches[i].Groups[3]}, Nutrition: {matches[i].Groups[4]}"); 
            }
        }

        private static void _01_TheImitationGame()
        {
            string input = Console.ReadLine();
            string[] command = {"","","","" };
            while ((command = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries))[0] != "Decode")
            {
                if (command[0] == "Move")
                {
                    string part = input.Substring(0, int.Parse(command[1]));
                    input = input.Remove(0, int.Parse(command[1]));
                    input = input.Insert(input.Length, part);
                }
                else if (command[0] == "Insert")
                {
                   input =  input.Insert(int.Parse(command[1]),command[2]);
                }
                else if (command[0] == "ChangeAll")
                {
                    input = input.Replace(command[1], command[2]);
                }
            }
            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
