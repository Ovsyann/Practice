﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimRandomWalk
{
    public static class WalkModeling
    {
        static int experimentsCount = 100;
        static double rightStepProbability = 0.5;
        static int stepsCount = 10;
        
        static Random random = new Random();
        private static int circlesCount = 570;

        public static double[] Calculate()
        {
            random = new Random();
            double x1;
            double x2;
            double[] randomValues = new double[circlesCount];
            double L;
            double D;

            for(int k = 0; k < circlesCount; k++)
            {
                x1 = 0;
                x2 = 0;
                for (int i = 0; i < experimentsCount; i++)
                {
                    double x = 0.0;
                    for (int j = 0; j < stepsCount; j++)
                    {
                        double r = random.NextDouble();
                        if (r < rightStepProbability)
                        {
                            x = DoStep(random, x, true);

                        }
                        else
                        {
                            x = DoStep(random, x, false);
                        }
                    }

                    x1 += Math.Abs(x);
                    x2 += x * x;
                }

                L = x1 / experimentsCount;
                D = x2 / experimentsCount - L * L;

                randomValues[k] = L;
            }

            return randomValues;
        }

        private static double DoStep(Random random, double x, bool direction)
        {
            double a = 0;
            for(int j = 0; j < 100; j++)
            {
                a += Math.Exp(-j);
            }

            int i = 0;
            double p = 0;
            double r = random.NextDouble();
            if (direction)
            {
                while (r > p)
                {
                    i++;
                    double tmp = Math.Exp(-i);
                    double tmp2 = 2 * a * tmp;
                    p += tmp2;
                }

                x += i;
            }
            else
            {
                while (r > p)
                {
                    i++;
                    double tmp = Math.Exp(-i);
                    double tmp2 = 2 * a * tmp;
                    p += tmp2;
                }

                x += -i;
            }

            return x;
        }
    }
}
