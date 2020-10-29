using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Lab2TestMethods
    {
        public static double PearsonMethod(double[] hitCounts, double[] hitProbabilities,
            byte subdivisionsCount, long sampleSize)
        {
            double Xi2 = 0;
            for(int i = 0; i < subdivisionsCount; i++)
            {
                Xi2 += Math.Pow((hitCounts[i] - sampleSize * hitProbabilities[i]), 2) / (sampleSize * hitProbabilities[i]);
            }

            return Xi2;
        }

        public static double KolmogorovMethod(double[] sortedSamples, ref int sampleSize)
        {
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

            return dMax * Math.Sqrt(sampleSize);
        }

        public static double[] SortSamples(double[] samples)
        {
            Array.Sort(samples, (x, y) => x.CompareTo(y));
            double[] sortedSamples = samples;
            return sortedSamples;
        }

        public static int CollectorMethod(double[] randomVariables, int sampleSize, int subdivisionsAmount)
        {
            int i;
            int y;
            int R = 0;
            int[] numN = new int[subdivisionsAmount];
            for (i = 0; i < subdivisionsAmount; i++)
            {
                numN[i] = 0;
            }

            int M = 0;
            while ((M != subdivisionsAmount) && (R < sampleSize))
            {
                y = (int)(randomVariables[R] * subdivisionsAmount);
                if (numN[y] == 0)
                {
                    numN[y] = 1;
                    M++;
                }

                R++;
            }

            return R;
        }
    }
}
