﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            Lab2PearsonTest(randomVariables);
            Lab2CollectorTest(randomVariables, generationMethod.sampleSize, generationMethod.numberOfSubdivisions);
            Lab2KolmogorovTest(randomVariables, generationMethod.sampleSize);
        }

        private void Lab2CollectorTest(double[] randomVariables, int sampleSize, int subdivisionsAmount)
        {
            double Xi2 = Lab2TestMethods.GetCollector(subdivisionsAmount, sampleSize, randomVariables);
            labelCollectorTest.Text = string.Format("Collector test Xi2 = {0}", Xi2);
        }

        private void Lab2KolmogorovTest(double[] randomVariables, int sampleSize)
        {
            double[] sortedSamples;
            double lambdaKolmogorov;
            sortedSamples = Lab2TestMethods.SortSamples(randomVariables);
            lambdaKolmogorov = Lab2TestMethods.KolmogorovMethod(sortedSamples, ref sampleSize);
            labelKolmogorovTest.Text = string.Format("Критерий Колмогорова = {0}", lambdaKolmogorov);
        }

        void DisplayProcessingValues(double[] randomVariables)
        {
            labelExpectedValue.Text = "Математическое ожидание = " + ProcessingValues.GetExpectedValue(randomVariables);
            labelDispersion.Text = "Дисперсия = " + ProcessingValues.GetDispersion(randomVariables);
            labelSecondCentralPoint.Text = "Второй центральный момент = " + ProcessingValues.GetSecondCenterPoint(randomVariables);
            labelThirdCentralPoint.Text = "Третий центральный момент = " + ProcessingValues.GetThirdCenterPoint(randomVariables);
        }
        List<double> DrawingPreparation(double[] randomVariables)
        {
            double histogramStep = (double)1 / generationMethod.numberOfSubdivisions;
            List<double> listOfRepetitions = new List<double>(generationMethod.numberOfSubdivisions);
            for(int i = 0; i < generationMethod.numberOfSubdivisions; i++)
            {
                listOfRepetitions.Add(randomVariables.Count(p => p >= i * histogramStep && p < (i + 1) * histogramStep));
            }

            return listOfRepetitions;
        }
        void DrawFirstDiagram(double[] randomVariables)
        {
            List<double> listOfRepetitions = DrawingPreparation(randomVariables);
            listOfRepetitions[5] = 0;
            for(int i = 0; i < listOfRepetitions.Count; i++)
            {
                chart1Histogram.Series[0].Points.AddXY(i + 1, listOfRepetitions[i]/1000);
            }
        }
        void DrawSecondDiagram(double[] randomVariables)
        {
            List<double> listOfRepetitions = DrawingPreparation(randomVariables);
            for (int i = 0; i < listOfRepetitions.Count; i++)
            {
                chart2Histogram.Series[0].Points.AddXY(i + 1, listOfRepetitions.Take(i+1).Sum()/1000);
            }
        }

        void Lab2PearsonTest(double[] randomVariables)
        {
            double subdivisionStep = (double)1 / generationMethod.numberOfSubdivisions;
            double[] hitCounts = new double[generationMethod.numberOfSubdivisions];
            double[] hitProbabilities = new double[generationMethod.numberOfSubdivisions];

            for(int i=0;i< generationMethod.numberOfSubdivisions; i++)
            {
                hitCounts[i] = randomVariables.Count(p => p >= i * subdivisionStep && p < (i + 1) * subdivisionStep);
                hitProbabilities[i] = subdivisionStep;
            }

            double Xi2;
            Xi2 = Lab2TestMethods.PearsonMethod(hitCounts, hitProbabilities,
                        generationMethod.numberOfSubdivisions, generationMethod.sampleSize);
            labelPearsonTest.Text = string.Format("Pearson test Xi2 = {0}",Xi2);
        }

       

        private void ToScale(List<double> randomVariables, double newMax, double newMin)
        {
            double oldMin = randomVariables.Min();
            double oldMax = randomVariables.Max();
            for(int i = 0; i < randomVariables.Count; i++)
            {
                double oldRange = oldMax - oldMin;
                double newRange = newMax - newMin;
                randomVariables[i] = ((randomVariables[i] - oldMin) * newRange / oldRange) + newMin;
            }
        }
    }
}
