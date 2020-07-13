using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Figure
    {
        protected List<Point> line;
        public void Draw()
        {
            foreach (Point i in line)
            {
                i.Draw();
            }
        }
    }
}
