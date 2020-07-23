using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TanksGame
{
    public abstract class Subject :GameObject
    {
        public int Speed { get; set; }
        public int Damage { get; set; }
        public Direction Direction { get; set; }
        public bool Affiliation { get; set; }

        

    }
}
