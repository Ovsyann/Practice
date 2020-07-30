using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksGame
{
    public class River : GameObject
    {
        public River(float left, float top, float width, float height)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
        }
        
        public override void CreateSubject(Bitmap bitmap)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(Brushes.Aqua, Left, Top, Width, Height);
        }
    }
}
