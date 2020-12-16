using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimRandomWalk
{
    public static class StatisticData
    {
        public static double CalculateMathExpectation(double[] randomNumbers)
        {
            double sum = 0;
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                sum += randomNumbers[i];
            }

            return sum / randomNumbers.Length;
        }

        public static double CalculateDispersoin(double[] randomNumbers, double Mx)
        {
            double dispersion = 0;
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                dispersion += (randomNumbers[i] * randomNumbers[i] - Mx * Mx);
            }

            return dispersion / randomNumbers.Length;
        }
    }
}
