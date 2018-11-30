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
    public partial class Chart1 : Form
    {
        protected Form1 CallingForm;
        private List<double> years;
        private List<double> threePA;

        public Chart1(Form1 form)
        {
            InitializeComponent();
            this.CallingForm = form;
            this.StartPosition = FormStartPosition.CenterScreen;    //center 

            this.FormClosing += Form_FormClosing;

            years = new List<double>();
            threePA = new List<double>();

            years = this.CallingForm.Years;
            threePA = this.CallingForm.ThreePA;
        }

        private void Chart1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < years.Count; i++)
            {
                BarGraph.Series["3PA"].Points.AddXY(years[i], threePA[i]);  //adding data to chart 
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
