using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksGame
{
    public class Shell : Subject
    {
        public Shell(int[,] pos, int[,] size, int speed,
                        int damage, bool affiliation, Direction dir)
        {
            Position = pos;
            Size = size;
            Speed = speed;
            Direction = dir;
            Affiliation = affiliation;
            Damage = damage;
        }
    }
}
