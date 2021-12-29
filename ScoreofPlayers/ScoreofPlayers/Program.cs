using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreofPlayers
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Player> players = new List<Player>();
            players.Add(new Player { Name = "Sarah", Team = "A", Score = 80 });
            players.Add(new Player { Name = "Ross", Team = "A", Score = 30 });
            players.Add(new Player { Name = "Jen", Team = "L", Score = 50 });
            players.Add(new Player { Name = "Lisa", Team = "L", Score = 70 });
            PlayerImplementation playerImplementation = new PlayerImplementation();
            Console.WriteLine(playerImplementation.Average(players));
            Console.WriteLine(playerImplementation.Max(players));
            Console.WriteLine(playerImplementation.Min(players));




        }
    }
}
