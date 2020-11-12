using RandomValuesEstimator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomValuesQualityCheck
{
    public static class CollectorsCriterion
    {
        public static string Calculate(double[] x, int n, int K)
        {
            List<double> rList = new List<double>();
            int i, y;
            int j = 0;

            while (j < n)
            {
                int R = 0;
                int[] numN = new int[K];
                for (i = 0; i < K; i++)
                {
                    numN[i] = 0;
                }
                int M = 0;
                while ((M != K) && (j < n))
                {
                    y = (int)(x[j] * K);
                    if (numN[y] == 0)
                    {
                        numN[y] = 1;
                        M++;
                    }
                    R++;
                    j++;
                }
                rList.Add(R);
            }

            for (int o = 0; o < rList.Count; o++)
                rList[o] /= 100;
            //rList.Sort();
            //kolmogorovCriterionLambdaValue = KolmogorovCriterion.Lambda(rList.ToArray(), rList.Count, 1);
            //kolmogorovCriterionValue = KolmogorovCriterion.Calculate(rList.ToArray(), rList.Count, 1);

            const int intervalsCount = 16;
 

            double step = (double)1 / intervalsCount;

            //количество попаданий случайной величины в интервал
            double[] hst = new double[intervalsCount];
            int hstCounter = 0;

            //массив критических значений для критерия хи-квадрат
            double[,] xSquaredCriticalValues = new double[2, 10] { 
                { 0.990, 0.975, 0.950, 0.900, 0.800, 0.700, 0.600, 0.500, 0.400, 0.300 },
                { 5.23, 6.26, 7.26, 8.55, 10.31, 11.72, 13.03, 14.34, 15.73, 17.32 } 
            };

            //заполнение массива теоретической вероятности попадания случайной величины в интервалы (при равнмерном распределении не изменяется)
            double[] pt = new double[intervalsCount];
            for (int k = 0; k < intervalsCount; k++)
                pt[k] = step;

            //гистограмма частот
            double minXValue = 0;
            while (minXValue < 1)
            {
                int count = 0;
                foreach (double value in rList)
                {
                    if (value >= minXValue && value < minXValue + step)
                        count++;
                }
                hst[hstCounter] = count;
                hstCounter++;
                double yValue = (double)count / n * intervalsCount;
                minXValue += step;
            }

            //вычисление критерия хи-квадрат Пирсона  
            double xSquaredValue = XSquaredCriterion.Calculate(hst, pt, intervalsCount, n);

            int estimator;
            for (estimator = 0; estimator < xSquaredCriticalValues.GetLength(1); estimator++)
            {
                //удовлетворение условия нахождения оценки случайной величины
                if (xSquaredValue <= xSquaredCriticalValues[1, estimator])
                {
                    break;
                }
            }

            return $"Критерий хи-квадрат равен {xSquaredValue};\nОценка генератора случайных чисел по уровням 1-а равен " +
                $"{xSquaredCriticalValues[0, estimator]}";
        }
    }
}
