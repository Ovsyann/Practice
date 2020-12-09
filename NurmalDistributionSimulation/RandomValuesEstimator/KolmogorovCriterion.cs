using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomValuesEstimator
{
    public static class KolmogorovCriterion
    {
        public static double GetLambda(double[] samples, int sampleSize)
        {
            double[] tmp = (double[])samples.Clone();
            double[] sortedSamples = SortSamples(tmp);

            double dMax = 0.0;
            for (int i = 0; i < sampleSize; i++)
            {
                double dp = Math.Abs((double)(i + 1) / sampleSize - sortedSamples[i]);
                double dm = Math.Abs(sortedSamples[i] - (double)i / sampleSize);

                if (dp > dMax)
                {
                    dMax = dp;
                }
                if (dm > dMax)
                {
                    dMax = dm;
                }
            }

            return dMax * Math.Sqrt(sampleSize) / 1000;
        }

        private static double[] SortSamples(double[] samples)
        {
            Array.Sort(samples, (x, y) => x.CompareTo(y));
            double[] sortedSamples = samples;
            return sortedSamples;
        }

        private static readonly double[,] lambdaTable = new double[2, 21] {
            { 0.0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1.0, 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 1.7, 1.8, 1.9, 2.0 },
            { 1.000, 1.000, 1.000, 1.000, 0.997,0.964,0.864,0.711,0.544,0.393,0.270,0.178,0.112,0.068,0.040,0.022,0.12,0.006,0.003,0.002,0.001}
        };

        public static double Calculate(double[] x, int n)
        {
            //вычисление критерия Колмагорова  
            double lambdaValue = GetLambda(x, n);

            int estimator;
            bool check = false;
            for (estimator = 0; estimator < lambdaTable.GetLength(1); estimator++)
            {
                //удовлетворение условия нахождения оценки случайной величины
                if (lambdaValue <= lambdaTable[0, estimator])
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                estimator = lambdaTable.GetLength(1) - 1;
            }
            return lambdaTable[1, estimator];
        }

        //public static double Lambda(double[] x, int n, int distributionKind, double m = 0, double dpow2 = 1)
        //{
        //    double dMax = 0d;
        //    for (int i = 0; i < n; i++)
        //    {
        //        double dp = Math.Abs((double)(i + 1) / n - Ft(x[i], distributionKind, m, dpow2));
        //        double dm = Math.Abs(Ft(x[i], distributionKind, m, dpow2) - (double)i / n);
        //        if (dp > dMax) dMax = dp;
        //        if (dm > dMax) dMax = dm;
        //    }
        //    return dMax * Math.Sqrt(n);
        //}

        //private static double Ft(double x, int distributionKind, double m = 0, double dpow2 = 1)
        //{
        //    switch (distributionKind)
        //    {
        //        case 1:
        //            if (x < 0)
        //            {
        //                return 0;
        //            }
        //            else
        //            {
        //                if (x >= 0 && x < 1)
        //                {
        //                    return x;
        //                }
        //                else
        //                    return 1;
        //            }
        //        case 2:
        //            if (x >= 0 && x < 0.5)
        //            {
        //                return Math.Sqrt(0.25 - Math.Pow(x - 0.5, 2));
        //            }
        //            else
        //            {
        //                if (x >= 0.5 && x < 1.3)
        //                {
        //                    return 0.3125 * x + 0.34375;
        //                }
        //                else
        //                {
        //                    if (x >= 1.3 && x <= 1.5)
        //                    {
        //                        return 1.25 * x - 0.875;
        //                    }
        //                }
        //            }
        //            break;
        //        case 3:
        //            double erf = Meta.Numerics.Functions.AdvancedMath.Erf((x - m) / Math.Sqrt(2 * dpow2));
        //            return (double)1 / 2 * (1 + erf);
        //    }
        //    return 0;
        //}
    }
}
