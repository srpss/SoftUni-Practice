using System;
using System.Collections.Generic;
using System.Numerics;

namespace Data_Types_and_Variables___More_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* https://judge.softuni.bg/Contests/Practice/Index/1271#3
            01.Data Type Finder 

            string input = Console.ReadLine();
            string dataType = "";
            
           
            while (input != "END")
            {


                float floater;
                int integering;
               
                bool booler;
                char ch;



                if (int.TryParse(input, out integering))
                {
                    dataType = "integer";

                }


                else if (char.TryParse(input, out ch) == true)
                {
                   
                        dataType = "character";
                     
                    
                }
                else if (bool.TryParse(input, out booler))
                {
                    dataType = "boolean";
                    
                }

             
               
                else if(float.TryParse(input, out floater) == true)
                {
                    dataType = "floating point";
                }
                else
                
                {
                    dataType = "string";
                }

                Console.WriteLine($"{input} is {dataType} type");
                input = Console.ReadLine();
            }

            02.From Left to The Right
          

            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                string [] input2 = Console.ReadLine().Split();

                if (BigInteger.Parse(input2[0]) > BigInteger.Parse(input2[1]))
                {
                    BigInteger sum =  calc(input2[0]);
                    Console.WriteLine(sum);
                }
                else
                {
                    BigInteger sum = calc(input2[1]);
                    Console.WriteLine(sum);
                }
            }

            static BigInteger calc(string input2)
            {
                

                char[] zero = input2.ToCharArray();
                BigInteger sum = 0;
                bool checker = false;
                foreach (var item in zero)
                {
                    
                    if (item == '-')
                    {
                        checker = true;
                    }
                    else
                    {
                        if (checker == true)
                        {
                            sum += BigInteger.Parse(item.ToString()) * -1;
                            checker = false;
                        }
                        else
                        {
                            sum += BigInteger.Parse(item.ToString());
                        }
                        
                    }
                    
                }

                return sum;
            }

            03.Floating Equality 

            decimal input = decimal.Parse(Console.ReadLine());
            decimal input2 = decimal.Parse(Console.ReadLine());
            bool check = false;
            if (Math.Round(input, 5) == Math.Round(input2, 5))
            {
                check = true;
            }
            
            Console.WriteLine(check);

            04.Refactoring: Prime Checker 
       
            int input = int.Parse(Console.ReadLine());
            for (int i = 2; i <= input; i++)
            {
                bool checker = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        checker = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, checker.ToString().ToLower());
            }


            05.Decrypting Message
           

            int input = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            List <char> chars = new List<char>();
            for (int i = 0; i < input2; i++)
            {
                string input3 = Console.ReadLine();
                chars.Add(char.Parse(input3));

            }
            foreach (var item in chars)
            {
                Console.Write((char)(item+input));
            }

            06.Balanced Brackets
               

            int input = int.Parse(Console.ReadLine());
            
            bool unbalanced = false;
            int counter = 0;
            for (int i = 0; i < input; i++)
            {
                string input3 = Console.ReadLine();

                if (input3.Contains(")") && counter == 0)
                {
                    unbalanced = true;
                    break;
                }
                else if( input3.Contains(")"))
                {
                    counter = 0;
                }

                 if (input3.Contains("(") )
                {
                    counter++;
                    if (counter == 2)
                    {
                        unbalanced = true;
                        break;
                    }
                }
               
            }
            if (unbalanced == false)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
           
               */
        }
    }
}
