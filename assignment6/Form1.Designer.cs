namespace assignment6
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
            this.BarGraphButton = new System.Windows.Forms.Button();
            this.LineGraphButton = new System.Windows.Forms.Button();
            this.PieGraphButton = new System.Windows.Forms.Button();
            this.PlotGraphButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BarGraphButton
            // 
            this.BarGraphButton.Location = new System.Drawing.Point(82, 219);
            this.BarGraphButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarGraphButton.Name = "BarGraphButton";
            this.BarGraphButton.Size = new System.Drawing.Size(72, 19);
            this.BarGraphButton.TabIndex = 0;
            this.BarGraphButton.Text = "Bar Graph";
            this.BarGraphButton.UseVisualStyleBackColor = true;
            this.BarGraphButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LineGraphButton
            // 
            this.LineGraphButton.Location = new System.Drawing.Point(234, 219);
            this.LineGraphButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LineGraphButton.Name = "LineGraphButton";
            this.LineGraphButton.Size = new System.Drawing.Size(72, 19);
            this.LineGraphButton.TabIndex = 1;
            this.LineGraphButton.Text = "Line Graph";
            this.LineGraphButton.UseVisualStyleBackColor = true;
            this.LineGraphButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // PieGraphButton
            // 
            this.PieGraphButton.Location = new System.Drawing.Point(630, 219);
            this.PieGraphButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PieGraphButton.Name = "PieGraphButton";
            this.PieGraphButton.Size = new System.Drawing.Size(72, 19);
            this.PieGraphButton.TabIndex = 2;
            this.PieGraphButton.Text = "Pie Graph";
            this.PieGraphButton.UseVisualStyleBackColor = true;
            this.PieGraphButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // PlotGraphButton
            // 
            this.PlotGraphButton.Location = new System.Drawing.Point(775, 219);
            this.PlotGraphButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PlotGraphButton.Name = "PlotGraphButton";
            this.PlotGraphButton.Size = new System.Drawing.Size(72, 19);
            this.PlotGraphButton.TabIndex = 3;
            this.PlotGraphButton.Text = "Plot Graph";
            this.PlotGraphButton.UseVisualStyleBackColor = true;
            this.PlotGraphButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chart Portal";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(451, 296);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 19);
            this.button5.TabIndex = 5;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 366);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlotGraphButton);
            this.Controls.Add(this.PieGraphButton);
            this.Controls.Add(this.LineGraphButton);
            this.Controls.Add(this.BarGraphButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BarGraphButton;
        private System.Windows.Forms.Button LineGraphButton;
        private System.Windows.Forms.Button PieGraphButton;
        private System.Windows.Forms.Button PlotGraphButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
    }
}

