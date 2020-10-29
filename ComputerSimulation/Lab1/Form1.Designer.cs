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
            this.labelKolmogorovTest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1Histogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2Histogram)).BeginInit();
            this.SuspendLayout();
            // 
            // labelExpectedValue
            // 
            this.labelExpectedValue.AutoSize = true;
            this.labelExpectedValue.Location = new System.Drawing.Point(811, 217);
            this.labelExpectedValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExpectedValue.Name = "labelExpectedValue";
            this.labelExpectedValue.Size = new System.Drawing.Size(46, 17);
            this.labelExpectedValue.TabIndex = 0;
            this.labelExpectedValue.Text = "label1";
            // 
            // labelDispersion
            // 
            this.labelDispersion.AutoSize = true;
            this.labelDispersion.Location = new System.Drawing.Point(811, 245);
            this.labelDispersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDispersion.Name = "labelDispersion";
            this.labelDispersion.Size = new System.Drawing.Size(46, 17);
            this.labelDispersion.TabIndex = 1;
            this.labelDispersion.Text = "label2";
            // 
            // labelSecondCentralPoint
            // 
            this.labelSecondCentralPoint.AutoSize = true;
            this.labelSecondCentralPoint.Location = new System.Drawing.Point(811, 274);
            this.labelSecondCentralPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSecondCentralPoint.Name = "labelSecondCentralPoint";
            this.labelSecondCentralPoint.Size = new System.Drawing.Size(46, 17);
            this.labelSecondCentralPoint.TabIndex = 2;
            this.labelSecondCentralPoint.Text = "label3";
            // 
            // labelThirdCentralPoint
            // 
            this.labelThirdCentralPoint.AutoSize = true;
            this.labelThirdCentralPoint.Location = new System.Drawing.Point(811, 302);
            this.labelThirdCentralPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThirdCentralPoint.Name = "labelThirdCentralPoint";
            this.labelThirdCentralPoint.Size = new System.Drawing.Size(46, 17);
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
            this.chart1Histogram.Location = new System.Drawing.Point(16, 15);
            this.chart1Histogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1Histogram.Name = "chart1Histogram";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "histogramOne";
            this.chart1Histogram.Series.Add(series1);
            this.chart1Histogram.Size = new System.Drawing.Size(787, 246);
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
            this.chart2Histogram.Location = new System.Drawing.Point(16, 274);
            this.chart2Histogram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart2Histogram.Name = "chart2Histogram";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "histogramTwo";
            this.chart2Histogram.Series.Add(series2);
            this.chart2Histogram.Size = new System.Drawing.Size(787, 246);
            this.chart2Histogram.TabIndex = 6;
            this.chart2Histogram.Text = "Histogram2Chart";
            // 
            // labelKolmogorovTest
            // 
            this.labelKolmogorovTest.AutoSize = true;
            this.labelKolmogorovTest.Location = new System.Drawing.Point(811, 367);
            this.labelKolmogorovTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKolmogorovTest.Name = "labelKolmogorovTest";
            this.labelKolmogorovTest.Size = new System.Drawing.Size(46, 17);
            this.labelKolmogorovTest.TabIndex = 7;
            this.labelKolmogorovTest.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 554);
            this.Controls.Add(this.labelKolmogorovTest);
            this.Controls.Add(this.chart2Histogram);
            this.Controls.Add(this.chart1Histogram);
            this.Controls.Add(this.labelThirdCentralPoint);
            this.Controls.Add(this.labelSecondCentralPoint);
            this.Controls.Add(this.labelDispersion);
            this.Controls.Add(this.labelExpectedValue);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label labelKolmogorovTest;
    }
}

