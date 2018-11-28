using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6
{
    public partial class Chart2 : Form
    {
        protected Form1 CallingForm;
        private List<double> years;
        private List<double> threePA;

        public Chart2(Form1 form)
        {
            InitializeComponent();
            this.CallingForm = form;
            this.StartPosition = FormStartPosition.CenterScreen;

            years = new List<double>();
            threePA = new List<double>();

            years = this.CallingForm.Years;
            threePA = this.CallingForm.ThreePA;
        }

        private void Chart2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < years.Count; i++)
            {
                LineGraph.Series["3PA"].Points.AddXY(years[i], threePA[i]);
            }
        }
    }
}