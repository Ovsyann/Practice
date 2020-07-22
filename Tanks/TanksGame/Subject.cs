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
        protected int Speed
        {
            get
            {
                return Speed;
            }
            set
            {
                Speed = value;
            }
        }
        protected int Damage
        {
            get
            {
                return Damage;
            }
            set
            {
                Damage = value;
            }
        }
        public Direction Direction
        {
            get
            {
                return Direction;
            }
            set
            {
                Direction = value;
            }
        }
        public bool Affiliation
        {
            get
            {
                return Affiliation;
            }
            set
            {
                Affiliation = value;
            }
        }
    }
}
