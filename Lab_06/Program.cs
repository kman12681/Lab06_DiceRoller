using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();         
                        
            {
                RollDice();                                
            }                    

        }

        static int counter = 0;

        static void RollDice()

        {
            int num;
            while (true)
            {
                Console.WriteLine();
                Console.Write("How many sides does your dice have? ");
                string sides = Console.ReadLine();
                bool success = int.TryParse(sides, out num);
                if (success && num >= 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nAre you sure about that?");
                }
            }

            bool again = true;
            while (again)
            {

                Random rnd = new Random();
                int roll1 = rnd.Next(1, (num + 1));
                int roll2 = rnd.Next(1, (num + 1));
                counter++; //increments roll counter each time the program runs

                if (roll1 == 1 && roll2 == 1) //checks for snake eyes
                {
                    Console.WriteLine($"\nRoll {counter}: Snake Eyes!\n\n{roll1}\n{roll2}\n");
                }
                else
                {
                    Console.WriteLine($"\nRoll {counter}:\n");
                    Console.WriteLine($"{roll1}");
                    Console.WriteLine($"{roll2}\n");
                }

                again = GetContinue();
            }
            Goodbye();
        }

        static void Welcome()
        {
            Console.WriteLine("Let's roll some dice!");
        }

        static void Goodbye()
        {
            Console.WriteLine("\nThank you for playing!");
            Console.ReadLine();
        }

        static bool GetContinue()
        {
            while (true)
            {
                //ask user if they want to continue
                Console.Write("Do you want to roll again (y/n)? ");
                //get string input
                string input = Console.ReadLine();

                //if it's yes, return true
                if (input == "y" || input == "Y")
                {
                    return true;
                }
                //if it's no, return false
                else if (input == "n" || input == "N")
                {
                    return false;
                }
                //anything else, ask again
                Console.WriteLine("\nNot a valid entry\n");
            }

        }
    }
}

