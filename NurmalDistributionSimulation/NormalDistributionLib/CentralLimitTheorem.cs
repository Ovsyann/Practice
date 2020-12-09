using System;

namespace NormalDistributionLib
{
    public class CentralLimitTheorem
    {
        public double[] Random(int count, double m, double d)
        {
            Random rnd = new Random();
            double s, randomValue;
            double[] randomValuesArray = new double[count];
            for (int i = 0; i < count; i++)
            {
                s = 0;
                for (int j = 0; j < 12; j++)
                {
                    s += rnd.NextDouble();
                }
                randomValue = s - 6;
                randomValuesArray[i] = m + randomValue * Math.Sqrt(d);
            }
            return randomValuesArray;
        }
    }
}
