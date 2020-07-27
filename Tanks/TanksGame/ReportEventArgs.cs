using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksGame
{
    public class ReportEventArgs : EventArgs
    {
        public ReportEventArgs(Player player, List<Enemy> enemies, List<Bonus> bonuses)
        {
            Player = player;
            Enemies = enemies;
            Bonuses = bonuses;
        }

        public Player Player { get; set; }
        public List<Enemy> Enemies { get; set; }
        public List<Bonus> Bonuses { get; set; }
    }
}
