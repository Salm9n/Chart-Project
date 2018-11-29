namespace assignment6
{
    partial class Chart1
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
            this.BarGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BarGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // BarGraph
            // 
            chartArea1.AxisX.Title = "Years";
            chartArea1.AxisY.Title = "3PA %";
            chartArea1.Name = "ChartArea1";
            this.BarGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BarGraph.Legends.Add(legend1);
            this.BarGraph.Location = new System.Drawing.Point(15, 14);
            this.BarGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarGraph.Name = "BarGraph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "3PA";
            this.BarGraph.Series.Add(series1);
            this.BarGraph.Size = new System.Drawing.Size(1083, 417);
            this.BarGraph.TabIndex = 0;
            this.BarGraph.Text = "3-Point Attempts";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            title1.Name = "Three Point Attempts in NBA";
            title1.Text = "Three Point Attempts in NBA";
            this.BarGraph.Titles.Add(title1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chart1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BarGraph);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Chart1";
            this.Text = "Chart1";
            this.Load += new System.EventHandler(this.Chart1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BarGraph;
        private System.Windows.Forms.Button button1;
    }
}