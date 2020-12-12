
namespace SystemSimulationUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartElementsLife = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelAverageResurrectTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelDeviceState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartElementsLife)).BeginInit();
            this.SuspendLayout();
            // 
            // chartElementsLife
            // 
            this.chartElementsLife.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea1.Name = "ChartArea1";
            this.chartElementsLife.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartElementsLife.Legends.Add(legend1);
            this.chartElementsLife.Location = new System.Drawing.Point(9, 9);
            this.chartElementsLife.Margin = new System.Windows.Forms.Padding(0);
            this.chartElementsLife.Name = "chartElementsLife";
            this.chartElementsLife.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.LegendText = "Элемент1";
            series1.Name = "Series1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.LegendText = "Элемент2";
            series2.Name = "Series2";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.Legend = "Legend1";
            series3.LegendText = "Элемент3";
            series3.Name = "Series3";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series4.Legend = "Legend1";
            series4.LegendText = "Элемент4";
            series4.Name = "Series4";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series5.Legend = "Legend1";
            series5.LegendText = "Элемент5";
            series5.Name = "Series5";
            series6.BorderWidth = 4;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series6.Legend = "Legend1";
            series6.LegendText = "Устройство";
            series6.Name = "Series6";
            series6.ShadowColor = System.Drawing.Color.Blue;
            this.chartElementsLife.Series.Add(series1);
            this.chartElementsLife.Series.Add(series2);
            this.chartElementsLife.Series.Add(series3);
            this.chartElementsLife.Series.Add(series4);
            this.chartElementsLife.Series.Add(series5);
            this.chartElementsLife.Series.Add(series6);
            this.chartElementsLife.Size = new System.Drawing.Size(668, 426);
            this.chartElementsLife.TabIndex = 0;
            this.chartElementsLife.Text = "chart1";
            // 
            // labelAverageResurrectTime
            // 
            this.labelAverageResurrectTime.AutoSize = true;
            this.labelAverageResurrectTime.Location = new System.Drawing.Point(686, 114);
            this.labelAverageResurrectTime.Name = "labelAverageResurrectTime";
            this.labelAverageResurrectTime.Size = new System.Drawing.Size(171, 13);
            this.labelAverageResurrectTime.TabIndex = 1;
            this.labelAverageResurrectTime.Text = "Среднее время восстановления";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(689, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(168, 37);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(689, 55);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(168, 37);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // labelDeviceState
            // 
            this.labelDeviceState.AutoSize = true;
            this.labelDeviceState.Location = new System.Drawing.Point(686, 143);
            this.labelDeviceState.Name = "labelDeviceState";
            this.labelDeviceState.Size = new System.Drawing.Size(60, 13);
            this.labelDeviceState.TabIndex = 4;
            this.labelDeviceState.Text = "состояние";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.labelDeviceState);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelAverageResurrectTime);
            this.Controls.Add(this.chartElementsLife);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartElementsLife)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartElementsLife;
        private System.Windows.Forms.Label labelAverageResurrectTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelDeviceState;
    }
}

