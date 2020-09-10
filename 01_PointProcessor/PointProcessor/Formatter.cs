using System;
using System.Text.RegularExpressions;

namespace PointProcessor
{
    public class Formatter
    {
        public static string Format(Point point)
        {
            //throw new NotImplementedException();

            string formattedLine = string.Format("X: {0,-9} Y: {1,-9}", point.X, point.Y);
            return formattedLine;
        }
    }
}
