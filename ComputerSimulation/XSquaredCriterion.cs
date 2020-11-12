using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomValuesEstimator
{
    public static class XSquaredCriterion
    {
        public static double Calculate(double[] hst, double[] pt, int k, long n)
        {
            double xi = 0;
            for (int i = 0; i < k; i++)
                xi += Math.Pow(hst[i] - n * pt[i], 2) / (n * pt[i]);
            return xi;
        }
    }
}