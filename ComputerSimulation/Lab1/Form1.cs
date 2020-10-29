using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        GenerationMethod generationMethod;
        public Form1()
        {
            InitializeComponent();
            generationMethod = new GenerationMethod();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double[] randomVariables = generationMethod.GetRandomArray();
            //Call methods
            //...
            DisplayProcessingValues(randomVariables);
            DrawFirstDiagram(randomVariables);
            DrawSecondDiagram(randomVariables);
            Lab2KolmogorovTest(randomVariables, generationMethod.sampleSize);

        }

        private void Lab2KolmogorovTest(double[] randomVariables, int sampleSize)
        {
            double[] sortedSamples;
            double lambdaKolmogorov;
            sortedSamples = Lab2Tests.SortSamples(randomVariables);
            lambdaKolmogorov = Lab2Tests.KolmogorovTest(sortedSamples,ref sampleSize);
            labelKolmogorovTest.Text = string.Format("Критерий Колмогорова = {0}", lambdaKolmogorov);
        }

        void DisplayProcessingValues(double[] randomVariables)
        {
            labelExpectedValue.Text = "Математическое ожидание = " + ProcessingValues.GetExpectedValue(randomVariables);
            labelDispersion.Text = "Дисперсия = " + ProcessingValues.GetDispersion(randomVariables);
            labelSecondCentralPoint.Text = "Второй центральный момент = " + ProcessingValues.GetSecondCenterPoint(randomVariables);
            labelThirdCentralPoint.Text = "Третий центральный момент = " + ProcessingValues.GetThirdCenterPoint(randomVariables);
        }
        List<int> DrawingPreparation(double[] randomVariables)
        {
            double histogramStep = (double)1 / generationMethod.numberOfSubdivisions;
            List<int> listOfRepetitions = new List<int>(generationMethod.numberOfSubdivisions);
            for(int i = 0; i < generationMethod.numberOfSubdivisions; i++)
            {
                listOfRepetitions.Add(randomVariables.Count(p => p >= i * histogramStep && p < (i + 1) * histogramStep));
            }
            return listOfRepetitions;
        }
        void DrawFirstDiagram(double[] randomVariables)
        {
            chart1Histogram.ChartAreas[0].AxisY.Maximum=800;
            List<int> listOfRepetitions = DrawingPreparation(randomVariables);
            for(int i = 0; i < listOfRepetitions.Count; i++)
            {
                chart1Histogram.Series[0].Points.AddXY(i + 1, listOfRepetitions[i]);
            }
        }
        void DrawSecondDiagram(double[] randomVariables)
        {
            List<int> listOfRepetitions = DrawingPreparation(randomVariables);
            for (int i = 0; i < listOfRepetitions.Count; i++)
            {
                chart2Histogram.Series[0].Points.AddXY(i + 1, listOfRepetitions.Take(i+1).Sum());
            }
        }

    }
}
