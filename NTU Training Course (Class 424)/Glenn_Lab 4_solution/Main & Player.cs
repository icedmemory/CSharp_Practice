using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Glenn_Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter player name: ");
            string playerName = Console.ReadLine();
            
            bool valid;
            do
            {
                Console.WriteLine("Enter player type: (Human / Naive AI / Binary AI)");
                string input = Console.ReadLine().ToLower();
                Console.WriteLine();
                switch (input)
                {
                    case "human":
                        HumanPlayer hp = new HumanPlayer(playerName);
                        Game numGuess_Human = new Game(hp);
                        numGuess_Human.Run();
                        Console.WriteLine("It takes {0} {1} guesses to get the result.", playerName, numGuess_Human.GuessCount);
                        valid = true;
                        break;
                    case "naive ai":
                        NaiveAI na = new NaiveAI(playerName);
                        Game numGuess_Naive = new Game(na);
                        numGuess_Naive.Run();
                        Console.WriteLine("It takes {0} {1} guesses to get the result.", playerName, numGuess_Naive.GuessCount);
                        valid = true;
                        break;
                    case "binary ai":
                        BinaryAI ba = new BinaryAI(playerName);
                        Game numGuess_Binary = new Game(ba);
                        numGuess_Binary.Run();
                        Console.WriteLine("It takes {0} {1} guesses to get the result.", playerName, numGuess_Binary.GuessCount);
                        valid = true;
                        break;
                    default:
                        valid = false;
                        break;
                }
            }
            while (!valid);
        }
    }

    abstract class Player
    {
        public string Name
        { get; set; }
        public Player(string Name)
        {
            this.Name = Name;
        }
        public abstract int RandomNumber(int minAfterGuess, int maxAfterGuess);
    }

    class HumanPlayer : Player
    {
        public HumanPlayer(string Name) : base(Name) { }
        /* When constructors with parameter(s) are inherited, they need to be specified (as seen above, ":base(Name)");
           otherwise, the default (parameter-less) constructor will be automatically called and cause error. */

        public override int RandomNumber(int minAfterGuess, int maxAfterGuess)
        {
            return int.Parse(Console.ReadLine());
        }
    }

    class NaiveAI : Player
    {
        public NaiveAI(string Name) : base(Name) { }

        public override int RandomNumber(int minAfterGuess, int maxAfterGuess)
        {
            Random rnd = new Random();
            return rnd.Next(minAfterGuess, maxAfterGuess + 1);
        }
    }

    class BinaryAI : Player
    {
        public BinaryAI(string Name) : base(Name) { }

        public override int RandomNumber(int minAfterGuess, int maxAfterGuess)
        {
            return (minAfterGuess + maxAfterGuess) / 2;
        }
    }
}
