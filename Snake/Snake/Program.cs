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
            Point point1 = new Point(1,3,'*');

            point1.Draw();

            Point point2 = new Point(2,3,'#');

            point2.Draw();

            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);

            int x = list[0];
            int y = list[1];
            int z = list[2];

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            list.RemoveAt(0);
            List<Point> pList = new List<Point>();
            pList.Add(point1);
            pList.Add(point2);

            Console.ReadKey();

        }
    }
}
