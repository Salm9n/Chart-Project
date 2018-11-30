/*****************************************
 * 
 *  Programmers: Salman Mohammed, Ryne Heron
 * 
 *       Course: CSCI 473
 * 
 *   Assignment: 6
 *         Date: November 29, 2018
 * 
 *****************************************/


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
    public partial class Chart4 : Form
    {
        protected Form1 CallingForm;
        private List<double> years;
        private List<int> pacers;
        private List<int> warriors;
        private List<int> cavs;
        private List<int> bulls;

        public Chart4(Form1 form)
        {
            InitializeComponent();
            this.CallingForm = form;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.FormClosing += Form_FormClosing;

            years = new List<double>();
            pacers = new List<int>();
            warriors = new List<int>();
            cavs = new List<int>();
            bulls = new List<int>();

            years = this.CallingForm.Years2;
            pacers = this.CallingForm.Pacers;
            warriors = this.CallingForm.Warriors;       //reading data from main form 
            cavs = this.CallingForm.Cavs;
            bulls = this.CallingForm.Bulls;


        }

        private void Chart4_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < years.Count; i++)
            {
                PlotGraph.Series["Pacers"].Points.AddXY(years[i], pacers[i]);
                PlotGraph.Series["Warriors"].Points.AddXY(years[i], warriors[i]);       //bunch of data being added in 
                PlotGraph.Series["Cavs"].Points.AddXY(years[i], cavs[i]);
                PlotGraph.Series["Bulls"].Points.AddXY(years[i], bulls[i]);

            }
        }


        /******************************************
         * button1_Click()
         * 
         * Purpose: Goes back to the Chart Portal
         *
         * ***************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form F1 = new Form1();
            F1.Show();
        }

        /******************************************
         * Form_FormClosing()
         * 
         * Purpose: Closes the entire application
         *  when the user clicks the x in the corner
         *
         * ***************************************/

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}