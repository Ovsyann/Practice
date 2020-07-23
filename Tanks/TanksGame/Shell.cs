﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksGame
{
    public class Shell : Subject
    {
        public Shell(float top, float left, float width, float height, int speed,
                        int damage, bool affiliation, Direction dir)
        {
            Top = top;
            Left = left;
            Width = width;
            Height = height;
            Speed = speed;
            Direction = dir;
            Affiliation = affiliation;
            Damage = damage;
        }

        public override void CreateSubject(Bitmap bitmap)
        {
            Image image = Properties.Resources.Shell;
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(image, Top, Left, Width, Height);
        }
    }
}
