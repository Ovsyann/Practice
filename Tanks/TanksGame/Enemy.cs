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
        Image image = Properties.Resources.Tank;
        public int counter = 0;
        public int timeToShoot=0;
        public override void CreateSubject(Bitmap bitmap)
        {
            
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(image, Left, Top, Width, Height);
        }
    }
}
