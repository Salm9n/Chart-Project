namespace assignment6
{
    partial class Chart4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.PlotGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlotGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // PlotGraph
            // 
            chartArea2.Name = "ChartArea1";
            this.PlotGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.PlotGraph.Legends.Add(legend2);
            this.PlotGraph.Location = new System.Drawing.Point(16, 15);
            this.PlotGraph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlotGraph.Name = "PlotGraph";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Navy;
            series5.Legend = "Legend1";
            series5.Name = "Pacers";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Gold;
            series6.Legend = "Legend1";
            series6.Name = "Warriors";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Maroon;
            series7.Legend = "Legend1";
            series7.Name = "Cavs";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Red;
            series8.Legend = "Legend1";
            series8.Name = "Bulls";
            this.PlotGraph.Series.Add(series5);
            this.PlotGraph.Series.Add(series6);
            this.PlotGraph.Series.Add(series7);
            this.PlotGraph.Series.Add(series8);
            this.PlotGraph.Size = new System.Drawing.Size(1080, 415);
            this.PlotGraph.TabIndex = 0;
            this.PlotGraph.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "IDK WHAT TO PUT HERE";
            this.PlotGraph.Titles.Add(title2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chart4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlotGraph);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Chart4";
            this.Text = "Chart4";
            this.Load += new System.EventHandler(this.Chart4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlotGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart PlotGraph;
        private System.Windows.Forms.Button button1;
    }
}