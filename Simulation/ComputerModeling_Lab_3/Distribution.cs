using System;

namespace Lab3
{
   public class Distribution
   {
        private const double _a = 0d;
        private const double _c = 5d;
        private const double _b = 10d;
        private readonly GenerationMethod _random;
        private readonly Random random;

        public Distribution()
        {
            // _random = new GenerationMethod();
            random = new Random();
        }

        public static double GetDistributionDensity(double x, double a = _a, double c = _c, double b = _b)
        {
            if (x > a && x <= c)
            {
                return (2 * (x - a)) / ((b - a)*(c - a));
            }
            if (x > c && x <= b)
            {
                return (2 * (b - x)) / ((b - a) * (b - c));
            }

            return 0;
        }

        public static double GetDistributionFunction(double x, double a = _a, double c = _c, double b = _b)
        {
            if (x > a && x <= c)
            {
                return (2 * (Math.Pow(x,2)/2 - a)) / ((b - a) * (c - a));
            }
            if (x > c && x <= b)
            {
                return (2 * (b - Math.Pow(x, 2) / 2)) / ((b - a) * (b - c));
            }

            return 0;
        }

        public double GetValue()
        {
            double a = _a;
            double b = _b;
            double C = 5d;

            double x = 0;

            bool flag = true;
            while (flag) 
            {
                double r1 = random.NextDouble();
                double r2 = random.NextDouble();
                double z1 = a + r1 * (b - a);
                double z2 = r2 * C;

                if (z2 < GetDistributionDensity(z1))
                {
                    x = z1;
                    flag = false;
                } 
            }

            return x;
        }
    }
}
