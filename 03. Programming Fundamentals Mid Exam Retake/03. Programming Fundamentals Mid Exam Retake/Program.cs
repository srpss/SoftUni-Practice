using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._Programming_Fundamentals_Mid_Exam_Retake
{
    class Program
    {
        private static object Checker;

        static void Main(string[] args)
        {
            /*https://judge.softuni.bg/Contests/Practice/Index/2305#0
            01.Counter Strike
            */

            /* int energy = int.Parse(Console.ReadLine());
               int count = 0;
               string battles = "";
               bool lostBattles = false;
               int siquence = 0;
               while ((battles = Console.ReadLine()) != "End of battle")
               {
                   int battleEnergy = int.Parse(battles);
                   if (energy < battleEnergy)
                   {
                       lostBattles = true;
                       break;
                   }
                   count++;
                   siquence++;
                   energy -= battleEnergy;
                   if (siquence == 3)
                   {
                       siquence = 0;
                       energy += count;
                   }
               }
               if (lostBattles == true)
               {
                   Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {energy} energy");
               }
               else
               {
                   Console.WriteLine($"Won battles: {count}. Energy left: {energy}");
               }*/

            /*  02.ShootfortheWin*/

            /*   List<int> sequenceIntergers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
               string shoot = "";
               int count = 0;
               while ((shoot = Console.ReadLine()) != "End")
               {
                   int shootted = int.Parse(shoot);
                   if (shootted < sequenceIntergers.Count)
                   {
                       if (sequenceIntergers[shootted] != -1)
                       {
                           count++;
                           int currentValue = sequenceIntergers[shootted];
                           sequenceIntergers[shootted] = -1;
                           for (int i = 0; i < sequenceIntergers.Count; i++)
                           {
                               if ( sequenceIntergers[i] == -1)
                               {
                                   continue;
                               }                           
                               if (currentValue < sequenceIntergers[i])
                               {
                                   sequenceIntergers[i] -= currentValue;
                               }
                               else if (currentValue >= sequenceIntergers[i])
                               {
                                   sequenceIntergers[i] += currentValue;
                               }  
                           }
                       }      
                   }
               }
               Console.WriteLine($"Shot targets: {count} -> {string.Join(' ', sequenceIntergers)}");*/

            /* 03.Moving Target*/
          /*  List<int> sequenceIntergers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string [] shoot = {"","","" };
            int count = 0;
            while ((shoot = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries))[0] != "End")
            {
                if (shoot[0] == "Shoot")
                {
                    bool indexChecker = CheckerIndex(sequenceIntergers.Count, int.Parse(shoot[1]));
                    if (indexChecker == false)
                    {
                        continue;
                    }
                    else if (int.Parse(shoot[1]) < 0)
                    {
                        continue;
                    }
                    sequenceIntergers[int.Parse(shoot[1])] -= int.Parse(shoot[2]);
                    if (sequenceIntergers[int.Parse(shoot[1])] <= 0)
                    {
                        sequenceIntergers.RemoveAt(int.Parse(shoot[1]));
                    }
                    
                }
                else if (shoot[0] == "Add")
                {
                    bool indexChecker = CheckerIndex(sequenceIntergers.Count, int.Parse(shoot[1]));
                    if (indexChecker == false)
                    {
                        Console.WriteLine("Invalid placement!"); 
                        continue;
                    }
                    else if (int.Parse(shoot[1]) < 0)
                    {
                        Console.WriteLine("Invalid placement!");
                        continue;
                    }
                    sequenceIntergers.Insert(int.Parse(shoot[1]), int.Parse(shoot[2]));
                }
                else if (shoot[0] == "Strike")
                {
                    bool indexChecker = CheckerIndex(sequenceIntergers.Count, int.Parse(shoot[1]));
                    if (indexChecker == false)
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }
                    else if (int.Parse(shoot[1]) - int.Parse(shoot[2]) < 0 || int.Parse(shoot[1]) + int.Parse(shoot[2]) > sequenceIntergers.Count)
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }
                sequenceIntergers.RemoveRange(int.Parse(shoot[1])- int.Parse(shoot[2]) , 1 + int.Parse(shoot[2]) * 2);
                }
            }
            Console.WriteLine(string.Join('|', sequenceIntergers));   */    
        }
        static bool CheckerIndex(int sequenceIntergers, int number)
        {
            bool check = false;
            if (sequenceIntergers > number)
            {
                check = true;
            }
            return check;
        }
    }
}
