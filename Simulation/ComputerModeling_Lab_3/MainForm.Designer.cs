namespace Lab3
{
    partial class MainForm
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
            this.dispersionLbl = new System.Windows.Forms.Label();
            this.mathExpectation = new System.Windows.Forms.Label();
            this.kolmogorovCriterionLbl = new System.Windows.Forms.Label();
            this.chart1Histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2Histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1Histogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2Histogram)).BeginInit();
            this.SuspendLayout();
            // 
            // dispersionLbl
            // 
            this.dispersionLbl.AutoSize = true;
            this.dispersionLbl.Location = new System.Drawing.Point(667, 223);
            this.dispersionLbl.Name = "dispersionLbl";
            this.dispersionLbl.Size = new System.Drawing.Size(70, 13);
            this.dispersionLbl.TabIndex = 6;
            this.dispersionLbl.Text = "Дисперсия: ";
            // 
            // mathExpectation
            // 
            this.mathExpectation.AutoSize = true;
            this.mathExpectation.Location = new System.Drawing.Point(667, 204);
            this.mathExpectation.Name = "mathExpectation";
            this.mathExpectation.Size = new System.Drawing.Size(86, 13);
            this.mathExpectation.TabIndex = 5;
            this.mathExpectation.Text = "Мат ожидание: ";
            // 
            // kolmogorovCriterionLbl
            // 
            this.kolmogorovCriterionLbl.AutoSize = true;
            this.kolmogorovCriterionLbl.Location = new System.Drawing.Point(667, 242);
            this.kolmogorovCriterionLbl.Name = "kolmogorovCriterionLbl";
            this.kolmogorovCriterionLbl.Size = new System.Drawing.Size(53, 13);
            this.kolmogorovCriterionLbl.TabIndex = 11;
            this.kolmogorovCriterionLbl.Text = "Лямбда: ";
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
            this.chart1Histogram.TabIndex = 12;
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
            this.chart2Histogram.TabIndex = 13;
            this.chart2Histogram.Text = "Histogram2Chart";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 460);
            this.Controls.Add(this.chart2Histogram);
            this.Controls.Add(this.chart1Histogram);
            this.Controls.Add(this.kolmogorovCriterionLbl);
            this.Controls.Add(this.dispersionLbl);
            this.Controls.Add(this.mathExpectation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Метод отбора";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1Histogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2Histogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dispersionLbl;
        private System.Windows.Forms.Label mathExpectation;
        private System.Windows.Forms.Label kolmogorovCriterionLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1Histogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2Histogram;
    }
}

