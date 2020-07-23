using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TanksGame
{
    public class Enemy : Subject
    {
        public Enemy(int health, float top, float left, float width, float height, int speed, int damage, Direction dir)
        {
            Health = health;
            Top = top;
            Left = left;
            Speed = speed;
            Width = width;
            Height = height;
            Damage = damage;
            Direction = dir;
        }

        public override void CreateSubject(Bitmap bitmap)
        {
            Image image = Properties.Resources.Tank;
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(image, Top, Left, Width, Height);
        }
    }
}
