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
            for (int i = 0; i < subdivisionsCount; i++)
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

        public static List<int> GetCollectionerCriterion(int K, int N, double[] x)
        {
            int i, y;
            int R = 0;
            List<int> R_Array = new List<int>();
            int[] numN = new int[K];
            while (R < N - K)
            {
                for (i = 0; i < K; i++)
                {
                    numN[i] = 0;
                }
                int M = 0;
                while ((M != K) && (R < N))
                {
                    y = (int)(x[R] * K);
                    if (numN[y] == 0)
                    {
                        numN[y] = 1;
                        M++;
                    };
                    R++;
                }
                int totalR = R_Array.Sum();
                R_Array.Add(R- totalR);
            }

            return R_Array;
        }
        //public static List<double> Calculate(double[] x, int n, int K)
        //{
        //    List<double> rList = new List<double>();
        //    int i, y;
        //    int j = 0;

        //    while (j < n)
        //    {
        //        int R = 0;
        //        int[] numN = new int[K];
        //        for (i = 0; i < K; i++)
        //        {
        //            numN[i] = 0;
        //        }

        //        int M = 0;
        //        while ((M != K) && (j < n))
        //        {
        //            y = (int)(x[j] * K);
        //            if (numN[y] == 0)
        //            {
        //                numN[y] = 1;
        //                M++;
        //            }

        //            R++;
        //            j++;
        //        }

        //        rList.Add(R);
        //    }

        //    return rList;
        //}
    }
}
