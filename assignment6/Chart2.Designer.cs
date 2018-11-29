namespace assignment6
{
    partial class Chart2
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.LineGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.LineGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // LineGraph
            // 
            chartArea1.AxisX.Title = "Years";
            chartArea1.AxisY.Title = "3PA %";
            chartArea1.Name = "ChartArea1";
            this.LineGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.LineGraph.Legends.Add(legend1);
            this.LineGraph.Location = new System.Drawing.Point(12, 12);
            this.LineGraph.Name = "LineGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "3PA";
            this.LineGraph.Series.Add(series1);
            this.LineGraph.Size = new System.Drawing.Size(810, 337);
            this.LineGraph.TabIndex = 0;
            this.LineGraph.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Three Point Attempts in NBA";
            this.LineGraph.Titles.Add(title1);
            // 
            // Chart2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 361);
            this.Controls.Add(this.LineGraph);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Chart2";
            this.Text = "Chart2";
            this.Load += new System.EventHandler(this.Chart2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LineGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart LineGraph;
    }
}