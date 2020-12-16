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
        double intervalsCount = 16;

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
            label1.Text = "средняя дистанция = " + averageDistance;
            
            ConstructFrequencyHistogram(randomValues);

            ConstructStatisticalDistributionFunction(randomValues);

            //вычисление критерия Колмагорова
            double kolmogorovCriterionLambdaValue = KolmogorovCriterion.GetLambda(randomValues);
            double kolmogorovCriterionValue = KolmogorovCriterion.Calculate(randomValues, randomValues.Length);
            label2.Text = $"Лямбда по критерию Колмогорова равна {Math.Round(kolmogorovCriterionLambdaValue, 3)}; \nОценка генератора " +
                $"случайных чисел равна {kolmogorovCriterionValue}";
        }

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
                scaledRepetitions[i] = (double)listOfRepetitions[i] / randomValues.Length * intervalsCount;
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

            double sum = 0;
            for (int i = 0; i < scaledRepetitions.Length; i++)
            {
                double asix = intervalValue + step / 2;

                chart2.Series[0].Points.AddXY(asix, scaledRepetitions.Take(i + 1).Sum());
                intervalValue += step;
            }
        }
    }
}
