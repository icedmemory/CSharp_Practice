using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Glenn_Lab_4
{
    internal class Game
    {
        private int min = 0, max = 99, secretNumber, guessCount = 0;
        private Player player;
        public bool win;

        public Game(Player player)
        {
            this.player = player;
        }

        public void Run()
        {
            Random rnd = new Random();
            secretNumber = rnd.Next(min, max+1);
            
            int number, numbersExceptSecretNumber;

            do
            {
                Console.WriteLine("({0}, {1})?", min, max);
                number = player.RandomNumber(min, max);
                Console.WriteLine(number);
                if (number >= min && number <= max)
                {
                    if (number < secretNumber)
                    {
                        min = number + 1;
                    }
                    else if (number > secretNumber)
                    {
                        max = number - 1;
                    }
                    else
                    {
                        Console.WriteLine("Bingo.");
                        win = true;
                    }
                }
                else
                {
                    Console.WriteLine("Out of range. Try again?");
                }
                
                numbersExceptSecretNumber = max - min;
                if (numbersExceptSecretNumber == 0)
                {
                    Console.WriteLine("Game over.");
                    guessCount++;
                    break;
                }
                guessCount++;
            }
            while (!win);
            Console.WriteLine();
            Console.WriteLine("It takes {0} {1} guesses to get the result.", player.Name, guessCount);
        }
    }
}
