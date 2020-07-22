using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TanksGame
{
    public class Bonus : GameObject
    {
        public Bonus(int[,] pos, int[,] size, Bitmap img)
        {
            Position = pos;
            Size = size;
            Bitmap = new Bitmap(img);
        }
    }
}
