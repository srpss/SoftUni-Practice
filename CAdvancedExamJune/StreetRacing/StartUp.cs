using System;
using System.Collections.Generic;
using System.Linq;

namespace StreetRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //https://judge.softuni.org/Contests/Practice/Index/2703#2
            //https://judge.softuni.org/Contests/Practice/Index/3020#0
            //_01_Masterchef();
            //_02_Survivor();
            _03_StreetRacing_03_SkiRental();
        }

        private static void _03_StreetRacing_03_SkiRental()
        {
            //Sample Code Usage:

            //Initialize Race
            Race race = new Race("RockPort Race", "Sprint", 1, 4, 150);

            //Initialize Car
            Car car = new Car("BMW", "320ci", "NFS2005", 150, 1450);

            //Print car
            Console.WriteLine(car.ToString());

            //Make: BMW
            //Model: 320ci
            //License Plate: NFS2005
            //Horse Power: 150
            //Weight: 1450

            //Add car
            race.Add(car);
            race.Add(car);
            //Remove car
            Console.WriteLine(race.Remove("NFS2005")); // True

            Car carOne = new Car("BMW", "320cd", "NFS2007", 150, 1350);
            Car carTwo = new Car("Audi", "A3", "NFS2004", 131, 1300);

            //Add cars
            race.Add(carOne);
            race.Add(carTwo);
            Console.WriteLine(race.Count); 
            //GetMostPowerfulCar
            Console.WriteLine(race.GetMostPowerfulCar());

            //Make: BMW
            //Model: 320cd
            //License Plate: NFS2007
            //Horse Power: 150
            //Weight: 1350


            //Print Race report
            Console.WriteLine(race.Report());

            //Race: RockPort Race - Type: Sprint (Laps: 1)
            //Make: BMW
            //Model: 320cd
            //License Plate: NFS2007
            //Horse Power: 150

        }

        private static void _02_Survivor()
        {
            int armor = int.Parse(Console.ReadLine());
            int row = int.Parse(Console.ReadLine());
            char [][] map = new char[row][];
            int [] A = { 0 , 0};
            int[] M = { 0, 0 };
            for (int i = 0; i < map.Length; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                map[i] = input;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 'A')
                    {
                        A[0] = i;
                        A[1] = j;
                    }
                    else if (input[j] == 'M')
                    {
                        M[0] = i;
                        M[1] = j;
                    }
                }
            }
            bool win = false;
            while (armor > 0)
            {
                string[] input = Console.ReadLine().Split();
                map[int.Parse(input[1])][int.Parse(input[2])] = 'O';
                if (input[0] == "up")
                {
                    if (A[0] == 0)
                    {
                        
                    }
                    else
                    {
                        if (map[A[0] - 1][A[1]] == 'O')
                        {
                            armor -= 2;                           
                        }
                        else if (map[A[0] - 1][A[1]] == 'M')
                        {
                            map[A[0] - 1][A[1]] = '-';
                            map[A[0]][A[1]] = '-';
                            armor--;
                            win = true;
                            break;
                        }
                        map[A[0]][A[1]] = '-';
                        map[A[0]-1][A[1]] = 'A';
                        A[0]--;
                    }
                }
                else if (input[0] == "down")
                {

                    if (A[0] == map.Length - 1)
                    {

                    }
                    else
                    {
                        if (map[A[0] + 1][A[1]] == 'O')
                        {
                            armor -= 2;
                        }
                        else if (map[A[0] + 1][A[1]] == 'M')
                        {
                            map[A[0] + 1][A[1]] = '-';
                            map[A[0]][A[1]] = '-';
                            armor--;
                            win = true;
                            break;
                        }
                        map[A[0]][A[1]] = '-';
                        map[A[0] + 1][A[1]] = 'A';
                        A[0]++;
                    }
                }
                else if (input[0] == "left")
                {
                    if (A[1] == 0)
                    {

                    }
                    else
                    {
                        if (map[A[0]][A[1]- 1] == 'O')
                        {
                            armor -= 2;
                        }
                        else if (map[A[0]][A[1] - 1] == 'M')
                        {
                            map[A[0]][A[1] - 1] = '-';
                            map[A[0]][A[1]] = '-';
                            armor--;
                            win = true;
                            break;
                        }
                        map[A[0]][A[1]] = '-';
                        map[A[0]][A[1] - 1] = 'A';
                        A[1]--;
                    }
                }
                else if (input[0] == "right")
                {
                    if (A[1] == map[A[0]].Length - 1)
                    {

                    }
                    else
                    {
                        if (map[A[0]][A[1]+1] == 'O')
                        {
                            armor -= 2;
                        }
                        else if (map[A[0]][A[1] + 1] == 'M')
                        {
                            map[A[0]][A[1] + 1] = '-';
                            map[A[0]][A[1]] = '-';
                            armor--;
                            win = true;
                            break;
                        }
                        map[A[0]][A[1]] = '-';
                        map[A[0]][A[1] + 1] = 'A';
                        A[1]++;
                    }                    
                }
                armor--;
                if (armor < 1)
                {
                    map[A[0]][A[1]] = 'X';
                }
            }
            if (win)
            {
                Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");                
            }
            else
            {
                Console.WriteLine($"The army was defeated at {A[0]};{A[1]}.");
            }
            printMap(map);
        }

        private static void printMap(char [][]map)
        {
            foreach (var item in map)
            {
                Console.WriteLine(string.Join("", item));
            }
        }

        private static void _01_Masterchef()
        {
            Queue<int> ing = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> fresh = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Dictionary<string, int> dishes = new Dictionary<string, int>() 
            {
                {"Dipping sauce", 0 },
                {"Green salad", 0 },
                {"Chocolate cake", 0 },
                {"Lobster", 0 }
            };
            while (ing.Count > 0 && fresh.Count > 0)
            {

                int currentIng = ing.Peek();
                if (currentIng == 0)
                {
                    ing.Dequeue();
                    continue;
                }
                int currentValue = ing.Dequeue() * fresh.Pop();
                if (currentValue == 150)
                {                  
                    dishes["Dipping sauce"]++;
                }
                else if (currentValue == 250)
                {                   
                    dishes["Green salad"]++;
                }
                else if (currentValue == 300)
                {                   
                    dishes["Chocolate cake"]++;
                }
                else if (currentValue == 400)
                {
                   
                    dishes["Lobster"]++;
                }
                else
                {
                    ing.Enqueue(currentIng + 5);                    
                }
            }
            bool check = false;
            foreach (var item in dishes)
            {
                if (item.Value > 0)
                {
                    check = true;
                }
                else
                {
                    check = false;
                    break;
                }
            }
            Console.WriteLine(check? "Applause! The judges are fascinated by your dishes!" : "You were voted off. Better luck next year.");
            if (ing.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ing.Sum()}");
            }
            foreach (var item in dishes.OrderBy(n => n.Key))
            {
                if(item.Value > 0)
                {
                    Console.WriteLine($" # {item.Key} --> {item.Value}");
                }                
            }
        }
    }
}
