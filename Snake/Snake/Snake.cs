using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake:Figure
    {
        public Direction _direction;
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
        public void HandleSnake(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                _direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                _direction = Direction.RIGHT;
            if (key == ConsoleKey.DownArrow)
                _direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                _direction = Direction.UP;
        }
    }
}
