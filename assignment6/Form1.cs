using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace assignment6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        /*
        public List<int> Years
        {
            get => years;
            set { years = value; }
        }

        public List<int> Fga
        {
            get => fga;
            set { fga = value; }
        }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            Form C1 = new Chart1(this);
            C1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form C2 = new Chart2(this);
            C2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form C3 = new Chart3(this);
            C3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form C4 = new Chart4(this);
            C4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /***************************************************
        * 
        *   readDirectory()
        *   
        *   Purpose: Reads the directory file and creates
        *       a puzzle for each puzzle file found
        * 
        **************************************************/
        private void readData()
        {
            string line;
            string[] fields;

            StreamReader file = new System.IO.StreamReader("data.txt");

            while ((line = file.ReadLine()) != null)
            {
                fields = line.Split(); //get the difficulty and name of the puzzle
                
            }

            file.Close();
        }
    }
}
