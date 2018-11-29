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
        List<double> years;
        List<double> threePA;
        List<string> titleTeams;
        List<double> titleCount;

        public Form1()
        {
            InitializeComponent();

            years = new List<double>();
            threePA = new List<double>();
            titleTeams = new List<string>();
            titleCount = new List<double>();

            readData("threePA_data.txt", years, threePA);
            readData("TitleTeams_data.txt", titleTeams, titleCount);
        }
        
        public List<double> Years
        {
            get { return years; }
            set { years = value; }
        }

        public List<double> ThreePA
        {
            get { return threePA; }
            set { threePA = value; }
        }

        public List<string> TitleTeams
        {
            get { return titleTeams; }
            set { titleTeams = value; }
        }

        public List<double> TitleCount
        {
            get { return titleCount; }
            set { titleCount = value; }
        }

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
        *   readData()
        *   
        *   Purpose:
        * 
        **************************************************/
        private void readData(string path, List<double> xValues, List<double> yValues)
        {
            string line;
            string[] fields;

            StreamReader file = new System.IO.StreamReader(path);

            while ((line = file.ReadLine()) != null)
            {
                fields = line.Split(); //get the difficulty and name of the puzzle
                xValues.Add(Convert.ToDouble(fields[0]));
                yValues.Add(Convert.ToDouble(fields[1]));
            }

            file.Close();
        }

        /***************************************************
        * 
        *   readData()
        *   
        *   Purpose:
        * 
        **************************************************/
        private void readData(string path, List<string> xValues, List<double> yValues)
        {
            string line;
            string[] fields;

            StreamReader file = new System.IO.StreamReader(path);

            while ((line = file.ReadLine()) != null)
            {
                fields = line.Split(); //get the difficulty and name of the puzzle
                xValues.Add(fields[0]);
                yValues.Add(Convert.ToDouble(fields[1]));
            }

            file.Close();
        }
    }
}
