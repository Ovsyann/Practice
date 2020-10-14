namespace Lab1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelExpectedValue = new System.Windows.Forms.Label();
            this.labelDispersion = new System.Windows.Forms.Label();
            this.labelSecondCentralPoint = new System.Windows.Forms.Label();
            this.labelThirdCentralPoint = new System.Windows.Forms.Label();
            this.chart1Histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2Histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelPearsonTest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1Histogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2Histogram)).BeginInit();
            this.SuspendLayout();
            // 
            // labelExpectedValue
            // 
            this.labelExpectedValue.AutoSize = true;
            this.labelExpectedValue.Location = new System.Drawing.Point(608, 176);
            this.labelExpectedValue.Name = "labelExpectedValue";
            this.labelExpectedValue.Size = new System.Drawing.Size(35, 13);
            this.labelExpectedValue.TabIndex = 0;
            this.labelExpectedValue.Text = "label1";
            // 
            // labelDispersion
            // 
            this.labelDispersion.AutoSize = true;
            this.labelDispersion.Location = new System.Drawing.Point(608, 199);
            this.labelDispersion.Name = "labelDispersion";
            this.labelDispersion.Size = new System.Drawing.Size(35, 13);
            this.labelDispersion.TabIndex = 1;
            this.labelDispersion.Text = "label2";
            // 
            // labelSecondCentralPoint
            // 
            this.labelSecondCentralPoint.AutoSize = true;
            this.labelSecondCentralPoint.Location = new System.Drawing.Point(608, 223);
            this.labelSecondCentralPoint.Name = "labelSecondCentralPoint";
            this.labelSecondCentralPoint.Size = new System.Drawing.Size(35, 13);
            this.labelSecondCentralPoint.TabIndex = 2;
            this.labelSecondCentralPoint.Text = "label3";
            // 
            // labelThirdCentralPoint
            // 
            this.labelThirdCentralPoint.AutoSize = true;
            this.labelThirdCentralPoint.Location = new System.Drawing.Point(608, 245);
            this.labelThirdCentralPoint.Name = "labelThirdCentralPoint";
            this.labelThirdCentralPoint.Size = new System.Drawing.Size(35, 13);
            this.labelThirdCentralPoint.TabIndex = 3;
            this.labelThirdCentralPoint.Text = "label4";
            // 
            // chart1Histogram
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1Histogram.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1Histogram.Legends.Add(legend1);
            this.chart1Histogram.Location = new System.Drawing.Point(12, 12);
            this.chart1Histogram.Name = "chart1Histogram";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "histogramOne";
            this.chart1Histogram.Series.Add(series1);
            this.chart1Histogram.Size = new System.Drawing.Size(590, 200);
            this.chart1Histogram.TabIndex = 4;
            this.chart1Histogram.Text = "Histogram1Chart";
            // 
            // chart2Histogram
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2Histogram.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart2Histogram.Legends.Add(legend2);
            this.chart2Histogram.Location = new System.Drawing.Point(12, 223);
            this.chart2Histogram.Name = "chart2Histogram";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "histogramTwo";
            this.chart2Histogram.Series.Add(series2);
            this.chart2Histogram.Size = new System.Drawing.Size(590, 200);
            this.chart2Histogram.TabIndex = 6;
            this.chart2Histogram.Text = "Histogram2Chart";
            // 
            // labelPearsonTest
            // 
            this.labelPearsonTest.AutoSize = true;
            this.labelPearsonTest.Location = new System.Drawing.Point(608, 284);
            this.labelPearsonTest.Name = "labelPearsonTest";
            this.labelPearsonTest.Size = new System.Drawing.Size(35, 13);
            this.labelPearsonTest.TabIndex = 7;
            this.labelPearsonTest.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.labelPearsonTest);
            this.Controls.Add(this.chart2Histogram);
            this.Controls.Add(this.chart1Histogram);
            this.Controls.Add(this.labelThirdCentralPoint);
            this.Controls.Add(this.labelSecondCentralPoint);
            this.Controls.Add(this.labelDispersion);
            this.Controls.Add(this.labelExpectedValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1Histogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2Histogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExpectedValue;
        private System.Windows.Forms.Label labelDispersion;
        private System.Windows.Forms.Label labelSecondCentralPoint;
        private System.Windows.Forms.Label labelThirdCentralPoint;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1Histogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2Histogram;
        private System.Windows.Forms.Label labelPearsonTest;
    }
}

