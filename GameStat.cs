using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperGUI
{
    public class GameStat
    {
        // Properties
        public string Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public DateTime GameTime { get; set; }

        // Default constructor
        public GameStat() { }

        // Constructor 
        public GameStat(string id, string name, int score, DateTime gameTime)
        {
            Id = id;
            Name = name;
            Score = score;
            GameTime = gameTime;
        }
    }
}
