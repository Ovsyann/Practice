using System;
using System.Linq;

namespace Lab3
{
    static class ProbabilityTheory
    {
        public static double GetMathExpectation(double[] probabilities)
        {
            return probabilities.Sum() / probabilities.Length;
        }

        public static double GetDispersion(double[] probabilities)
        {
            double mx = GetMathExpectation(probabilities);
            return probabilities.Sum(i => Math.Pow(i - mx, 2)) / probabilities.Length;
        }
    }
}
