using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class HorizontalLine
    {
        List<Point> line;
        public HorizontalLine(int xLeft,int xRight,int y,char sym)
        {
            line = new List<Point>();
            for(int x = xLeft; x < xRight; x++)
            {
                Point p = new Point(x, y, sym);
                line.Add(p);
            }
        }
        public void Draw()
        {
            foreach(Point i in line)
            {
                i.Draw();
            }
        }
    }
}
