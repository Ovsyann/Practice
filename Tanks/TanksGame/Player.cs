using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TanksGame
{
    public class Player : Subject
    {
        public Player(int health, int[,] size, int speed, Bitmap img, int[,] pos, int damage, Direction dir)
        {
            Health = health;
            Size = size;
            Speed = speed;
            Bitmap = new Bitmap(img);
            Position = pos;
            Damage = damage;
            Direction = dir;
        }
    }
}
