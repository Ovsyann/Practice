using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using NormalDistributionLib;
using RandomValuesEstimator;

namespace UI
{
    public partial class Form1 : Form
    {
        const int sampleSize = 4150;//количество генерируемых случайных чисел
        const int intervalsCount = 25;
        const double leftXBorder = -2.5;
        const double rightXBorder = 6.5;
        const int m = 2;
        const int dpow2 = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CalculateCentralLimitTheorem();
            CalculateBoxAndMahlerMethod();
        }

        private void CalculateBoxAndMahlerMethod()
        {
            BoxAndMahlerMethod rnd = new BoxAndMahlerMethod();
            double[] randomValues = rnd.Random(sampleSize, m, dpow2);

            double step = (double)rightXBorder / intervalsCount;
            ConstructBoxAndMahlerfrequencies(randomValues, step);
            ConstructBoxAndMahlerDistributionFunc(randomValues, step);

            double mx = StatisticData.CalculateMathExpectation(randomValues);
            double dx = StatisticData.CalculateDispersoin(randomValues, mx);

            label3.Text = "M(X) = " + mx + "   D(X) = " + dx;
            //вычисление критерия Колмагорова
            double kolmogorovCriterionLambdaValue = KolmogorovCriterion.GetLambda(randomValues, sampleSize);
            double kolmogorovCriterionValue = KolmogorovCriterion.Calculate(randomValues, sampleSize);
            label4.Text = $"Лямбда по критерию Колмогорова равна {Math.Round(kolmogorovCriterionLambdaValue, 3)}; \nОценка генератора " +
                $"случайных чисел равна {kolmogorovCriterionValue}";
        }

        private void ConstructBoxAndMahlerDistributionFunc(double[] randomValues, double step)
        {
            //Статистическая функция распределения
            chart4.Series["Distribution"].Points.Clear();
            double minXValue1 = leftXBorder;
            chart4.ChartAreas[0].AxisX.Minimum = leftXBorder;
            chart4.ChartAreas[0].AxisX.Maximum = rightXBorder;
            //chart5.Titles.Add("Статистическая функция распределения");
            while (minXValue1 < rightXBorder)
            {
                double sum = 0;
                foreach (double value in randomValues)
                {
                    if (value < minXValue1 + step)
                        sum++;
                }
                double yValue = (double)sum / sampleSize;
                this.chart4.Series["Distribution"].Points.AddXY(minXValue1 + step / 2, yValue);
                minXValue1 += step;
            }
        }

        private void ConstructBoxAndMahlerfrequencies(double[] randomValues, double step)
        {
            //гистограмма частот
            chart3.Series["Frequencies"].Points.Clear();
            double minXValue = leftXBorder;
            chart3.ChartAreas[0].AxisX.Minimum = leftXBorder;
            chart3.ChartAreas[0].AxisX.Maximum = rightXBorder;
            //chart6.Titles.Add("Гистограмма частот");
            while (minXValue < rightXBorder)
            {
                int count = 0;
                foreach (double value in randomValues)
                {
                    if (value >= minXValue && value < minXValue + step)
                        count++;
                }
                double yValue = (double)count * intervalsCount / sampleSize;
                this.chart3.Series["Frequencies"].Points.AddXY(minXValue + step / 2, yValue);
                minXValue += step;
            }
        }

        private void CalculateCentralLimitTheorem()
        {
            CentralLimitTheorem rnd = new CentralLimitTheorem();
            double[] randomValues = rnd.Random(sampleSize, m, dpow2);

            double step = (double)rightXBorder / intervalsCount;
            ConstructFrequencyHistogram(randomValues, step);

            ConstructStatisticalDistributionFunction(randomValues, step);

            double mx = StatisticData.CalculateMathExpectation(randomValues);
            double dx = StatisticData.CalculateDispersoin(randomValues, mx);

            label1.Text = "M(X) = " + mx + "   D(X) = " + dx;
            //вычисление критерия Колмагорова
            double kolmogorovCriterionLambdaValue = KolmogorovCriterion.GetLambda(randomValues, sampleSize);
            double kolmogorovCriterionValue = KolmogorovCriterion.Calculate(randomValues, sampleSize);
            label2.Text = $"Лямбда по критерию Колмогорова равна {Math.Round(kolmogorovCriterionLambdaValue, 3)}; \nОценка генератора " +
                $"случайных чисел равна {kolmogorovCriterionValue}";

        }

        private void ConstructStatisticalDistributionFunction(double[] randomValues, double step)
        {
            chart2.Series["Distribution"].Points.Clear();
            double minXValue1 = leftXBorder;
            chart2.ChartAreas[0].AxisX.Minimum = leftXBorder;
            chart2.ChartAreas[0].AxisX.Maximum = rightXBorder;
            while (minXValue1 < rightXBorder)
            {
                double sum = 0;
                foreach (double value in randomValues)
                {
                    if (value < minXValue1 + step)
                        sum++;
                }
                double yValue = (double)sum / sampleSize;
                this.chart2.Series["Distribution"].Points.AddXY(minXValue1 + step / 2, yValue);
                minXValue1 += step;
            }
        }

        void ConstructFrequencyHistogram(double[] randomValues, double step)
        {
            chart1.Series["Frequencies"].Points.Clear();
            double minXValue = leftXBorder;
            chart1.ChartAreas[0].AxisX.Minimum = leftXBorder;
            chart1.ChartAreas[0].AxisX.Maximum = rightXBorder;
            while (minXValue < rightXBorder)
            {
                int count = 0;
                foreach (double value in randomValues)
                {
                    if (value >= minXValue && value < minXValue + step)
                        count++;
                }
                double yValue = (double)count * intervalsCount / sampleSize;
                this.chart1.Series["Frequencies"].Points.AddXY(minXValue + step / 2, yValue);
                minXValue += step;
            }
        }
    }
}
