using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksGame
{
    public class SuperWall : GameObject
    {
        public SuperWall(float left,float top,float width,float height)
        {
            Top = top;
            Left = left;
            Width = width;
            Height = height;
        }
        public Image image = Properties.Resources.Wall;
        public override void CreateSubject(Bitmap bitmap)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(image, Left, Top, Width, Height);
        }
    }
}
