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


namespace assignment6
{
    public partial class Chart3 : Form
    {
        protected Form1 CallingForm;
        private List<string> titleTeams;
        private List<double> titleCount;

        public Chart3(Form1 form)
        {
            InitializeComponent();
            this.CallingForm = form;
            this.StartPosition = FormStartPosition.CenterScreen;    //center 

            titleTeams = new List<string>();
            titleCount = new List<double>();

            titleTeams = this.CallingForm.TitleTeams;
            titleCount = this.CallingForm.TitleCount;
        }

        private void Chart3_Load(object sender, EventArgs e)
        {
            double total = titleCount.Sum();
            for (int i = 0; i < titleTeams.Count; i++)
            {
                PieGraph.Series["Titles"].Points.AddXY(titleCount[i], titleCount[i]/total);     //adding data 
                PieGraph.Series["Titles"].Points[i].LegendText = titleTeams[i] + " - " + titleCount[i];
            }

            foreach (DataPoint p in PieGraph.Series["Titles"].Points)
            {
                p.Label = "#PERCENT";   //label 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form F1 = new Form1();
            F1.Show();
        }
    }
}