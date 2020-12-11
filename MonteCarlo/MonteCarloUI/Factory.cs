using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloUI
{
    public static class Factory
    {
        const double defectP = 0.1;
        const double firstP = 0.7;
        const double secondP = 0.8;
        const double thirdP = 0.9;
        const double qcdP = 0.95;

        static Random random = new Random();
        public static double probabilityA;
        public static double probabilityB;
        public static double probabilityC;
        static double findAmount = 0;
        static int workshopFindAmount = 0;
        static int qcpFindAmount = 0;

        static public void ControlQuality(int exparimentsAmount)
        {
            for(int i = 0; i < exparimentsAmount; i++)
            {
                double p = random.NextDouble();

                if (p < 0.333)
                {
                    ControlByController(firstP);
                }

                if(p>0.333 && p < 0.666)
                {
                    ControlByController(secondP);
                }

                if (p > 0.666)
                {
                    ControlByController(thirdP);
                }
            }

            FindProbabilities(exparimentsAmount);
        }

        static private void ControlByController(double controllerP)
        {
            double p = random.NextDouble();
            if (p <= defectP)
            {
                double p2 = random.NextDouble();
                if (p2 < controllerP)
                {
                    findAmount++;
                    workshopFindAmount++;
                }
                else 
                {
                    double p3 = random.NextDouble();
                    if (p3<qcdP) 
                    {
                        findAmount++;
                        qcpFindAmount++;
                    } 
                }
            }
        }

        static private void FindProbabilities(int exparimentsAmount)
        {
            probabilityB = (double)workshopFindAmount / exparimentsAmount;
            probabilityC = (double)qcpFindAmount / exparimentsAmount;
            probabilityA = probabilityB + probabilityC;
        }
    }
}
