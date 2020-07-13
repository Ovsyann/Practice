using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake:Figure
    {
        public Snake(Point tail, int length, Direction direction)
        {
            line = new List<Point>();
            for(int j = 0; j< length; j++)
            {
                Point p = new Point(tail);
                p.Move(j,direction);
                line.Add(p);

            }
        }
    }
}
