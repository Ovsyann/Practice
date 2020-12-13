using System;

namespace MonteCarloUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int experimantsAmount = 500;
            double[] probabilitiesA = new double[experimantsAmount];
            double[] probabilitiesB = new double[experimantsAmount];
            double[] probabilitiesC = new double[experimantsAmount];

            for (int i = 0; i < experimantsAmount; i++)
            {
                int detailsAmount = 500;
                Factory.ControlQuality(detailsAmount);
                probabilitiesA[i] = Factory.probabilityA;
                probabilitiesB[i] = Factory.probabilityB;
                probabilitiesC[i] = Factory.probabilityC;
            }

            double am = GetAverageProbability(probabilitiesA);
            double ad = GetMarginOfError(probabilitiesA);
            double bm = GetAverageProbability(probabilitiesB);
            double bd = GetMarginOfError(probabilitiesA);
            double cm = GetAverageProbability(probabilitiesC);
            double cd = GetMarginOfError(probabilitiesA);
            Console.WriteLine("вероятность события А = " + Factory.probabilityA);
            Console.WriteLine("доверительный интервал = " + am + " +- " + ad);
            Console.WriteLine();
            Console.WriteLine("вероятность события В = " + Factory.probabilityB);
            Console.WriteLine("доверительный интервал = " + bm + " +- " + bd);
            Console.WriteLine();
            Console.WriteLine("вероятность события С = " + Factory.probabilityC);
            Console.WriteLine("доверительный интервал = " + cm + " +- " + cd);
        }

        private static double GetAverageProbability(double[] probabilities)
        {
            double sum = 0;
            for (int i = 0; i < probabilities.Length; i++)
            {
                sum += probabilities[i];
            }

            return sum / probabilities.Length;
        }

        private static double GetStandartDeviation(double[] probabilities)
        {
            double averageProbability = GetAverageProbability(probabilities);
            double s = 0;

            for (int i = 0; i < probabilities.Length; i++)
            {
                s += Math.Pow(probabilities[i] - averageProbability, 2);
            }

            return Math.Sqrt(s / probabilities.Length);
        }

        private static double GetMarginOfError(double[] probabilities)
        {
            return 10 * GetStandartDeviation(probabilities) / Math.Sqrt(probabilities.Length);
        }
    }
}
