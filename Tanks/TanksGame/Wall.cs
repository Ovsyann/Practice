﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TanksGame
{
    public class Wall : GameObject
    {
        public Wall(float top, float left, float width, float height, int health)
        {
            Top = top;
            Left = left;
            Width = width;
            Height = height;
            Health = health;
           
        }

        public override void CreateSubject(Bitmap bitmap)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(Brushes.Brown, Left, Top, Width, Height);
        }
    }
}
