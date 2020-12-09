using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab3
{
    public partial class MainForm : Form
    {
        private const int SampleSize = 6000;
        private const int IntervalsCount = 25;

        private readonly Distribution _random;

        public MainForm()
        {
            InitializeComponent();
            _random = new Distribution();
        }

        private static int[] GetRepetitions(double[] sample)
        {
            double step = 1.5 / IntervalsCount;
            List<int> repetitions = new List<int>(IntervalsCount);
            for (int i = 0; i < IntervalsCount; i++)
            {
                repetitions.Add(sample.Count(p => p >= i * step && p < (i + 1) * step));
            }

            return repetitions.ToArray();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            double[] sample = GetArrayOfRandomNumbers();
            IList<int> hittingRandVarInAnInterval = GetHittingRandVarInAnInterval(sample);
            DisplayProbabilityValues(sample);
            DrawFirstDiagram(sample);
            DrawSecondDiagram(sample);
        }

        private double[] GetArrayOfRandomNumbers()
        {
            double[] array = new double[SampleSize];
            for (int i = 0; i < SampleSize; i++)
            {
                array[i] = _random.GetValue();
            }

            return array;
        }

        private void DisplayProbabilityValues(double[] sample)
        {
            this.mathExpectation.Text += ProbabilityTheory.GetMathExpectation(sample).ToString("F5");
            this.dispersionLbl.Text += ProbabilityTheory.GetDispersion(sample).ToString("F5");
            this.kolmogorovCriterionLbl.Text += KolmogorovCriterion.GetLambda(sample, SampleSize).ToString("F5");
        }

        private List<int> GetHittingRandVarInAnInterval(double[] sample)
        {
            double step = (double)1 / IntervalsCount;
            List<int> hittingRandVarInAnInterval = new List<int>(IntervalsCount);
            for (int i = 0; i < IntervalsCount; i++)
            {
                hittingRandVarInAnInterval.Add(sample.Count(p => p >= i * step && p < (i + 1) * step));
            }

            return hittingRandVarInAnInterval;
        }

        List<int> DrawingPreparation(double[] randomVariables)
        {
            double histogramStep = (double)randomVariables.Max() / IntervalsCount;
            List<int> listOfRepetitions = new List<int>(IntervalsCount);

            for (int i = 0; i < IntervalsCount; i++)
            {
                listOfRepetitions.Add(randomVariables.Count(p => p >= i * histogramStep && p < (i + 1) * histogramStep));
            }

            return listOfRepetitions;
        }
        void DrawFirstDiagram(double[] randomVariables)
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            chart1Histogram.Series.Add(series);
            chart1Histogram.ChartAreas[0].AxisX.Minimum = 0;
            chart1Histogram.ChartAreas[0].AxisX.Maximum = 10;
            List<int> listOfRepetitions = DrawingPreparation(randomVariables);
            double[] scaledRepetitions = new double[listOfRepetitions.Count];

            double step = randomVariables.Max() / IntervalsCount;
            double intervalValue = 0;

            for(int i = 0; i < listOfRepetitions.Count; i++)
            {
                scaledRepetitions[i] = (double)listOfRepetitions[i] / SampleSize / 10 * IntervalsCount;
            }

            for (int i = 0; i < scaledRepetitions.Length; i++)
            {
                double asix = intervalValue + step / 2;
                chart1Histogram.Series[0].Points.AddXY(asix, scaledRepetitions[i]);
                chart1Histogram.Series[1].Points.AddXY(asix, Distribution.GetDistributionDensity(asix));
                intervalValue += step;
            }
        }
        void DrawSecondDiagram(double[] randomVariables)
        {
            List<int> listOfRepetitions = DrawingPreparation(randomVariables);
            double[] scaledRepetitions = new double[listOfRepetitions.Count];

            double step = randomVariables.Max() / IntervalsCount;
            double intervalValue = 0;

            for (int i = 0; i < listOfRepetitions.Count; i++)
            {
                scaledRepetitions[i] = (double)listOfRepetitions[i] / SampleSize;
            }

            double sum = 0;
            for (int i = 0; i < scaledRepetitions.Length; i++)
            {
                double asix = intervalValue + step / 2;
                
                chart2Histogram.Series[0].Points.AddXY(i + 1, scaledRepetitions.Take(i + 1).Sum());
                intervalValue += step;
            }
        }
    }
   
}
