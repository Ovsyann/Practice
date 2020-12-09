using System;

namespace NormalDistributionLib
{
    public class BoxAndMahlerMethod
    {
        public double[] Random(int count, double m, double d)
        {
            Random rnd = new Random();
            double[] randomValuesArray = new double[count];
            double randomValue;
            for (int i = 0; i < count; i++)
            {
                double r1 = rnd.NextDouble();
                double r2 = rnd.NextDouble();
                randomValue = Math.Sqrt(-2 * Math.Log(r1)) * Math.Cos(2 * Math.PI * r2);
                randomValuesArray[i] = m + randomValue * Math.Sqrt(d);
            }
            return randomValuesArray;
        }
    }
}
