using System;
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
            Point point1 = new Point();
            point1.x = 1;
            point1.y = 3;
            point1.sym = '*';
            point1.Draw();


            Point point2 = new Point();
            point2.x = 2;
            point2.y = 3;
            point2.sym = '#';
            point2.Draw();


            Console.ReadKey();

        }
    }
}
