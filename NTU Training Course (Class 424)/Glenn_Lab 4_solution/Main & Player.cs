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
            Console.WriteLine();
            
            bool valid;
            do
            {
                valid = true; 
                // Assign the bool to "true" here, so that 1) it updates the value set at the end of the switch loop; 2) it needs no re-assignment in every true case. 
                Console.WriteLine("Enter player type: (Human / Naive AI / Binary AI)");
                string input = Console.ReadLine().ToLower();
                Console.WriteLine();
                switch (input)
                {
                    case "human":
                        Player hp = new HumanPlayer(playerName);
                        hp.PlayGame(hp);
                        break;
                    case "naive ai":
                        Player na = new NaiveAI(playerName);
                        na.PlayGame(na);
                        break;
                    case "binary ai":
                        Player ba = new BinaryAI(playerName);
                        ba.PlayGame(ba);
                        break;
                    // The cases exemplify polymorphism.
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
        
        public void PlayGame(Player player)
        {
            Game Game = new Game(player);
            Game.Run();
        }
        /* Abstract classes can have non-abstract methods.
           To implement those methods, write the following code:
           AbstractClass [polymorphism] / DerivedConcreteClass foo = new DerivedConcreteClass(optional parameters);
           foo.Method(optional parameters); */
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
