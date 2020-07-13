﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            HorizontalLine up = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine down = new HorizontalLine(0, 78, 24, '+');
            VerticalLine left = new VerticalLine(0, 24, 0, '+');
            VerticalLine right = new VerticalLine(0, 24, 78, '+');
            up.Draw();
            down.Draw();
            left.Draw();
            right.Draw();

            Point p = new Point(4, 5, '*');
            p.Draw();

            Console.ReadKey();

        }
    }
}
