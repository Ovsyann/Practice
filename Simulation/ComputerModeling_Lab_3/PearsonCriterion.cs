using System;
using System.Collections.Generic;

namespace ComputerModeling_Lab_2
{
    public static class PearsonCriterion
    {
        public static double GetXI2(IList<int> countOfIncomingRandVarInInterval,
            double probabilityOfIncomingRandVarInInterval, int sampleSize)
        {
            int countOfSplittingIntervals = countOfIncomingRandVarInInterval.Count;
            double xi = 0;
            for (int i = 0; i < countOfSplittingIntervals; i++)
            {
                xi += Math.Pow(countOfIncomingRandVarInInterval[i] -
                    sampleSize * probabilityOfIncomingRandVarInInterval, 2) /
                    (sampleSize * probabilityOfIncomingRandVarInInterval );
            }

            return xi;
        }
    }
}
