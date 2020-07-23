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
        public GameMap(float top, float bot, float width, float height)
        {
            Top = top;
            Left = bot;
            Width = width;
            Height = height;
        }

        public override void CreateSubject(Bitmap bitmap)
        {
            
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(Brushes.AliceBlue,Left,Top,Width,Height);
        }
    }
}
