using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake:Figure
    {
        Direction _direction;
        public Snake(Point tail, int length, Direction direction)
        {
            _direction = direction;
            line = new List<Point>();
            for(int j = 0; j< length; j++)
            {
                Point p = new Point(tail);
                p.Move(j, _direction);
                line.Add(p);

            }
        }

        internal void Move()
        {
            Point tail = line.First();
            line.Remove(tail);
            Point head = GetNextPoint();
            line.Add(head);
            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = line.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, _direction);
            return nextPoint;
        }
    }
}
