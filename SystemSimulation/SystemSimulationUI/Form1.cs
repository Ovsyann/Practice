using Reliability_Lab6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SystemSimulationUI
{
    public partial class Form1 : Form
    {
        private static Device device = new Device();
        private static double positionX = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //обновляет данные об устройстве
            device.UpdateProperties();
            labelDeviceState.Text =
                string.Format("устройсво исправно : {0}", device.IsTheDeviceWorking);
            labelAverageResurrectTime.Text =
                string.Format("Среднее время восставновления\n{0}", device.AverageDeviceRecoveryTime);
            //обновляет график
            UpdateChart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            ConfigureChart();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        //обновляет график
        private void UpdateChart()
        {
            positionX += 1;

            ElementState[] elementStates = device.ElementStates;
            for (int i = 0; i < elementStates.Length; i++)
            {
                //рисовать графики в зависимсти от состояния элемента
                double positionY = elementStates[i] == ElementState.Works ? (i + 1) * 2 : (i + 1) * 2 - 1;
                UpdateSeries(i, positionX, positionY);//добавить точки графиков
            }

            Series series = chartElementsLife.Series[5];
            double deviceY = device.IsTheDeviceWorking ? 12 : 11;
            series.Points.AddXY(positionX, deviceY);

            if (positionX > 20)
            {
                chartElementsLife.ChartAreas[0].AxisX.ScaleView.Scroll(positionX);
            }
        }

        //Добавляет точки на графики
        private void UpdateSeries(int seriesNumber, double x, double y)
        {
            Series series = chartElementsLife.Series[seriesNumber];
            series.Points.AddXY(x, y);
        }

        private void ConfigureChart()
        {
            int scale = 20;//масштаб сетки
            chartElementsLife.ChartAreas[0].AxisX.Interval = 1; //интервал делений X
            chartElementsLife.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;//полоса прокрутки под цифрами
            chartElementsLife.ChartAreas[0].AxisX.ScaleView.Size = scale;//размер ползунка
            chartElementsLife.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;//только полоса прокрутки

            for (int i = 0; i < chartElementsLife.Series.Count; i++)
            {
                UpdateSeries(i, positionX, (i + 1) * 2);//добавить точки графиков
            }
        }
    }
}
