namespace Glenn_Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 0, max = 99;
            
            Random rnd = new Random();
            int secretNumber = rnd.Next(100);
            // Console.WriteLine(secretNumber + "\n"); [see what the secret number is]
            
            int input, numbersExceptSecretNumber;
            do
            {
                Console.WriteLine("({0}, {1})?", min, max);
                input = int.Parse(Console.ReadLine());
                if (input >= min && input <= max)
                {
                    if (input < secretNumber)
                    {
                        min = input + 1;
                    }
                    else if (input > secretNumber)
                    {
                        max = input - 1;
                    }
                    else
                    {
                        Console.WriteLine("Bingo.");
                    }
                }
                else
                {
                    Console.WriteLine("Out of range. Try again?");
                }
                
                numbersExceptSecretNumber = max - min;
                /* Console.WriteLine(numbersExceptSecretNumber); [check how many numbers are left,
                except the secret number] */
                if (numbersExceptSecretNumber == 0)
                {
                    Console.WriteLine("Game over.");
                    break;
                }
            }
            while (input != secretNumber);
        }
    }
}
