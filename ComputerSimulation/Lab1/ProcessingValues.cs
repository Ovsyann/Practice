using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class ProcessingValues
    {
        public static double GetExpectedValue(double[] randomVariables)
        {
            return randomVariables.Sum() / randomVariables.Length;
        }
        public static double GetDispersion(double[] randomVariables)
        {
            double expectedValue = GetExpectedValue(randomVariables);
            return randomVariables.Sum(i => Math.Pow((i - expectedValue), 2)) / randomVariables.Length;
        }
        public static double GetSecondCenterPoint(double[] randomVariables)
        {
            return randomVariables.Sum(i => Math.Pow(i, 2)) / randomVariables.Length;
        }
        public static double GetThirdCenterPoint(double[] randomVariables)
        {
            return randomVariables.Sum(i => Math.Pow(i, 3)) / randomVariables.Length;
        }
    }
}
