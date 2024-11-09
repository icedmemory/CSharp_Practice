using System;

namespace Glenn_Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of citizens: ");
            int citizens = int.Parse(Console.ReadLine());

            string row1 = "Id";
            Console.Write("{0,10}   ", row1);

            int[] id = new int[citizens];
            for (int i = 0; i < citizens; i++)
            {
                id[i] = i;
                Console.Write("{0,-4}", id[i]);
            }

            Console.WriteLine();

            string row2 = "Contactee";
            Console.Write("{0,10}   ", row2);

            int[] contactee = new int[id.Length];
            Array.Copy(id, contactee, id.Length);
            Random rnd = new Random();
            for (int j = 0; j < contactee.Length; j++) 
            {
                int k = rnd.Next(j, contactee.Length);
                int temp = contactee[j];
                contactee[j] = contactee[k];
                contactee[k] = temp;
            }
            // The Fisher-Yates Shuffle

            foreach (int c in contactee)
            {
                Console.Write("{0,-4}", c);
            }

            Console.WriteLine();
            Console.WriteLine("----------");

            Console.WriteLine("Enter id of infected citizen: ");
            int infected = int.Parse(Console.ReadLine());
            Console.WriteLine("These citizens are to be self-isolated in the following 14 days: ");
            List<int> infected_chain = new List<int>();
            infected_chain.Add(infected);
            do
            {
                if (infected == contactee[infected]) break;
                infected_chain.Add(contactee[infected]);
                infected = contactee[infected];
            }
            while (!(infected_chain.Contains(contactee[infected])));

            foreach (int sick in infected_chain)
            {
                Console.Write("{0} ", sick);
            }
        }
    }
}
