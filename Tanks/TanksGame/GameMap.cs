using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksGame
{
    public class GameMap : GameObject
    {
        public GameMap(float top, float left, float width, float height)
        {
            Top = top;
            Left = left;
            Width = width;
            Height = height;
        }

        public override void CreateSubject(Bitmap bitmap)
        {
            
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(Brushes.Gray,Left,Top,Width,Height);
        }
    }
}
