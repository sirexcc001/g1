using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Program
    {
        static void Main(string[] args)
        {
           
            
                Random random = new Random();
                bool playAgain = true;
                  int min; 
                 int max;
                int guess;
                int number;
                int guesses;
                String response;

                while (playAgain)
                {
                    guess = 0;
                    guesses = 0;
                    response = "";
                Console.WriteLine("Choose your maximum number or write 0 for default: ");
                max=Convert.ToInt32(Console.ReadLine());
                if (max == 0)
                {
                    max = 100;
                }
                Console.WriteLine("Choose your minimum number or write 0 for default: ");
                min = Convert.ToInt32(Console.ReadLine());
                if (min == 0)
                {
                    min = 0;
                }

                number = random.Next(min, max + 1);

                    while (guess != number)
                    {
                        Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Guess: " + guess);

                        if (guess > number)
                        {
                            Console.WriteLine(guess + " is to high!");
                        }
                        else if (guess < number)
                        {
                            Console.WriteLine(guess + " is to low!");
                        }
                        guesses++;
                    }
                    Console.WriteLine("Number: " + number);
                    Console.WriteLine("YOU WIN!");
                    Console.WriteLine("Guesses: " + guesses);

                    Console.WriteLine("Would you like to play again (Y/N): ");
                    response = Console.ReadLine();
                    response = response.ToUpper();

                    if (response == "Y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }
                }

                Console.WriteLine("Thanks for playing!");

                Console.ReadKey();
            }
        }

    }
    