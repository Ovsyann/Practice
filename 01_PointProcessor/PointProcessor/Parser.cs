using System;

namespace PointProcessor
{
    public static class Parser
    {
        public static bool TryParsePoint(string line, out Point point)
        {
            point = null;

            if (line != null)
            {
                string[] twoLines = line.Split(',');
                if (twoLines.Length == 2)
                {
                    if (decimal.TryParse(twoLines[0], out decimal pointValueX))
                        if (decimal.TryParse(twoLines[1], out decimal pointValueY))
                        {
                            point = new Point(pointValueX, pointValueY);
                            return true;
                        }
                }
                return false;
            }
            return false;
        }
    }
}
