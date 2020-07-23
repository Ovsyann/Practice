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
        public Bonus(float top, float left, float width, float height)
        {
            Top = top;
            Left = left;
            Width = width;
            Height = height;
        }

        public override void CreateSubject(Bitmap bitmap)
        {
            Image image = Properties.Resources.Tank;
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(image, Top, Left, Width, Height);
        }
    }
}
