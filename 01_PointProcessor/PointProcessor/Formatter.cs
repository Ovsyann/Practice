using System;
using System.Text.RegularExpressions;

namespace PointProcessor
{
    public class Formatter
    {
        public static string Format(Point point)
        {
            if (point != null)
            {
                string formattedLine = string.Format("X: {0,9:###0.0###;###0.0###;'   '0.0'   '} Y: {1,9:###0.0###;###0.0###;'   '0.0'   '}", point.X, point.Y);
                return formattedLine;
            }
            return null;
        }
    }
}
