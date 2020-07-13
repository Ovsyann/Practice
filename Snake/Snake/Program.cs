using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                    snake.Move();
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo Key = Console.ReadKey();
                    snake.HandleSnake(Key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
           

        }
    }
}
