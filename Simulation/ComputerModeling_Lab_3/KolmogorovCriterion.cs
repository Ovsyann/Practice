using System;
using System.Linq;

namespace Lab3
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
                    double currentF = Distribution.GetDistributionFunction(sortedSamples[i]);

                    double dp = Math.Abs((double)(i + 1) / sampleSize - currentF);
                    double dm = Math.Abs(currentF - (double)i / sampleSize);

                    if (dp > dMax)
                    {
                        dMax = dp;
                    }
                    if (dm > dMax)
                    {
                        dMax = dm;
                    }
                }

                return dMax * Math.Sqrt(sampleSize)/1000;
            

            //double[] sortedSample = (double[])sample.Clone();
            //Array.Sort(sortedSample);

            //double dMax = 0;
            //int length = sortedSample.Length;
            //for (int i = 0; i < length; i++)
            //{
            //    double dp = Math.Abs((double)(i + 1) / length - Distribution.Distribution000(sortedSample[i]));
            //    double dm = Math.Abs(Distribution.Distribution000(sortedSample[i]) - (double)i / length);

            //    if (dp > dMax) dMax = dp;
            //    if (dm > dMax) dMax = dm;
            //}

            //return dMax * Math.Sqrt(length);
        }

        private static double[] SortSamples(double[] samples)
        {
            Array.Sort(samples, (x, y) => x.CompareTo(y));
            double[] sortedSamples = samples;
            return sortedSamples;
        }
    }
}
