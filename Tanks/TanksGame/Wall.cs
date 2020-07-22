using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TanksGame
{
    public class Wall : GameObject
    {
        public Wall(int[,] pos, int[,] size, int health, Bitmap img)
        {
            Position = pos;
            Size = size;
            Health = health;
            Bitmap = new Bitmap(img);
        }
    }
}
