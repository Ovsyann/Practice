using System;
using System.Globalization;

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
                    NumberStyles numberStyles = NumberStyles.AllowDecimalPoint;
                    CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("en-GB");
                    if (decimal.TryParse(twoLines[0].ToString(), numberStyles, cultureInfo, out decimal pointValueX))
                        if (decimal.TryParse(twoLines[1], numberStyles, cultureInfo, out decimal pointValueY))
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
