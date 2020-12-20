using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneDimRandomWalk
{
    public partial class Form1 : Form
    {
        double leftXBorder;
        double rightXBorder;
        double intervalsCount = 30;
        //int ExperimentsCount = 500;
        double d = 0.01;
        double tb = 1.96;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double[] randomValues = WalkModeling.Calculate();
            leftXBorder = randomValues.Min();
            rightXBorder = randomValues.Max();
            double averageDistance = randomValues.Sum() / randomValues.Length;

            double mx = StatisticData.CalculateMathExpectation(randomValues);
            double dx = StatisticData.CalculateDispersoin(randomValues, mx);
            double N = tb * tb * dx  / (d * d);

            label5.Text = $"Оптимальный объем выборки = {N}";
            // GetAverageDistances();

            ConstructFrequencyHistogram(randomValues);
            ConstructStatisticalDistributionFunction(randomValues);

            //вычисление критерия Колмагорова
            double kolmogorovCriterionLambdaValue = KolmogorovCriterion.GetLambda(randomValues);
            double kolmogorovCriterionValue = KolmogorovCriterion.Calculate(randomValues, randomValues.Length);
            label1.Text = "средняя дистанция = " + averageDistance;
            //label2.Text = $"Лямбда по критерию Колмогорова равна {Math.Round(kolmogorovCriterionLambdaValue, 3)}; \nОценка генератора " +
            //    $"случайных чисел равна {kolmogorovCriterionValue}";
        }

        //private void GetAverageDistances()
        //{
        //    double[] averageDistances = new double[ExperimentsCount];
        //    for(int i = 0; i < ExperimentsCount; i++)
        //    {
        //        double[] randomVariables = WalkModeling.Calculate();
        //        averageDistances[i] = randomVariables.Sum() / randomVariables.Length;
        //    }

        //    double expectation = ShowMathExpectation(averageDistances);
        //    double squaredDispersion = ShowSquaredDispersion(averageDistances, expectation);
        //    double N = 1.96 * squaredDispersion / 0.000001;
        //    label3.Text = "Mx = " + expectation;
        //    label4.Text = "dx = " + squaredDispersion;
        //    label5.Text = "N = " + N;
        //}

        //private double ShowSquaredDispersion(double[] averageDistances, double expectation)
        //{
        //    double dispersion = StatisticData.CalculateDispersoin(averageDistances, expectation);
        //    double squareDispersion = dispersion / Math.Sqrt(ExperimentsCount);
        //    return squareDispersion;
        //}

        //private double ShowMathExpectation(double[] averageDistances)
        //{
        //    double mx = StatisticData.CalculateMathExpectation(averageDistances);
        //    return mx;
        //}

        List<int> DrawingPreparation(double[] randomVariables)
        {
            double histogramStep = (double)randomVariables.Max() / intervalsCount;
            List<int> listOfRepetitions = new List<int>((int)intervalsCount);

            for (int i = 0; i < intervalsCount; i++)
            {
                listOfRepetitions.Add(randomVariables.Count(p => p >= i * histogramStep && p < (i + 1) * histogramStep));
            }

            return listOfRepetitions;
        }

        void ConstructFrequencyHistogram(double[] randomValues)
        {
            chart1.ChartAreas[0].AxisX.Minimum = leftXBorder;
            chart1.ChartAreas[0].AxisX.Maximum = rightXBorder;
            List<int> listOfRepetitions = DrawingPreparation(randomValues);
            double[] scaledRepetitions = new double[listOfRepetitions.Count];

            double step = randomValues.Max() / intervalsCount;
            double intervalValue = 0;

            for (int i = 0; i < listOfRepetitions.Count; i++)
            {
                scaledRepetitions[i] = (double)listOfRepetitions[i] * intervalsCount / randomValues.Length;
            }

            for (int i = 0; i < scaledRepetitions.Length; i++)
            {
                double asix = intervalValue + step / 2;
                chart1.Series[0].Points.AddXY(asix, scaledRepetitions[i]);
                intervalValue += step;
            }
        }

        private void ConstructStatisticalDistributionFunction(double[] randomValues)
        {
            chart2.ChartAreas[0].AxisX.Minimum = leftXBorder;
            chart2.ChartAreas[0].AxisX.Maximum = rightXBorder;
            List<int> listOfRepetitions = DrawingPreparation(randomValues);
            double[] scaledRepetitions = new double[listOfRepetitions.Count];

            double step = randomValues.Max() / intervalsCount;
            double intervalValue = 0;

            for (int i = 0; i < listOfRepetitions.Count; i++)
            {
                scaledRepetitions[i] = (double)listOfRepetitions[i] / randomValues.Length;
            }

            for (int i = 0; i < scaledRepetitions.Length; i++)
            {
                double asix = intervalValue + step / 2;

                chart2.Series[0].Points.AddXY(asix, scaledRepetitions.Take(i + 1).Sum());
                intervalValue += step;
            }
        }
    }
}
