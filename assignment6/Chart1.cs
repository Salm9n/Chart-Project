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
    public partial class Chart1 : Form
    {
        protected Form1 CallingForm;
        private List<int> years;
        private List<int> fga;
        public Chart1(Form1 form)
        {
            InitializeComponent();
            this.CallingForm = form;
            this.StartPosition = FormStartPosition.CenterScreen;
            //years = this.CallingForm.Years;
            //fga = this.CallingForm.Fga;
        }

        private void Chart1_Load(object sender, EventArgs e)
        {
            chart2.Series.Add("Ah");
            /*Chart chart1 = new Chart();
            ChartArea area = new ChartArea("First");
            chart1.ChartAreas.Add(area); */
        }
    }
}
