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
        public Player(int health, float top, float left, float width, float height,
                    int speed, int damage, Direction dir)
        {
            Health = health;
            Top = top;
            Speed = speed;
            Left = left;
            Width = width;
            Height = height;
            Damage = damage;
            Direction = dir;
            
        }
        public Image image = Properties.Resources.Tank;
        public override void CreateSubject(Bitmap bitmap)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(image, Top, Left, Width, Height);  
        }
    }
}
