using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreofPlayers
{
    class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public int Score { get; set; }
    }
    class PlayerImplementation
    {
        public double Average(IList<Player>players)
        {
            int count = 0;
            int avg = 0;
            foreach (var item in players)
            {
                avg = avg + item.Score;
                count++;
            }
            avg = avg / count;
            return avg;
        }
        public int Max(IList<Player>players)
        {
            int Maximum = 0;
           
            for(int i=0;i<players.Count;i++)
            {
                
            }

            return Maximum;
        }
        public int Min(IList<Player> players)
        {
            int Minimum = 0;
         
            foreach (var item in players)
            {
                Minimum = Minimum + item.Score;
            }
            return Minimum;
        }

    }
    
}
