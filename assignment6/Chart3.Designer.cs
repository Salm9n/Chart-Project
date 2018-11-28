namespace assignment6
{
    partial class Chart3
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
            this.PieGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.PieGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // PieGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.PieGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PieGraph.Legends.Add(legend1);
            this.PieGraph.Location = new System.Drawing.Point(12, 12);
            this.PieGraph.Name = "PieGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            series1.Legend = "Legend1";
            series1.Name = "Titles";
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            this.PieGraph.Series.Add(series1);
            this.PieGraph.Size = new System.Drawing.Size(995, 560);
            this.PieGraph.TabIndex = 0;
            this.PieGraph.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "NBA Titles by Team";
            this.PieGraph.Titles.Add(title1);
            // 
            // Chart3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 584);
            this.Controls.Add(this.PieGraph);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Chart3";
            this.Text = "Chart3";
            this.Load += new System.EventHandler(this.Chart3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PieGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart PieGraph;
    }
}