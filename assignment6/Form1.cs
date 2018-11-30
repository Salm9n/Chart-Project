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
        List<double> years2;
        List<double> threePA;
        List<string> titleTeams;    //lists of multiple data streams
        List<double> titleCount;
        List<int> pacers;
        List<int> warriors;
        List<int> cavs;
        List<int> bulls;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;    //center
            this.FormClosing += Form_FormClosing;

            years = new List<double>();
            years2 = new List<double>();
            threePA = new List<double>();
            titleTeams = new List<string>();
            titleCount = new List<double>();
            pacers = new List<int>();
            warriors = new List<int>();
            cavs = new List<int>();
            bulls = new List<int>();

            readData("threePA_data.txt", years, threePA);
            readData("TitleTeams_data.txt", titleTeams, titleCount);        //reading in all the data needed for graphs 
            readData("team_data.txt", years2, pacers, warriors, cavs, bulls);

        }
        
        public List<double> Years
        {
            get { return years; }
            set { years = value; }
        }

        public List<double> Years2
        {
            get { return years2; }
            set { years2 = value; }     //these getters are needed for multiple form access
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

        public List<int> Pacers
        {
            get { return pacers; }
            set { pacers = value; }
        }

        public List<int> Warriors
        {
            get { return warriors; }
            set { warriors = value; }
        }

        public List<int> Cavs
        {
            get { return cavs; }
            set { Cavs = value; }
        }

        public List<int> Bulls
        {
            get { return bulls; }
            set { bulls = value; }
        }




        //BarGraph
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form C1 = new Chart1(this);
            C1.Show();
            
        }

        //LineGraph
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form C2 = new Chart2(this);
            C2.Show();
            
        }

        //PieGraph
        private void button3_Click(object sender, EventArgs e)      //when buttons clicked take to form 
        {
            this.Hide();
            Form C3 = new Chart3(this);
            C3.Show();
           
        }


        //SplineGraph
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form C4 = new Chart4(this);
            C4.Show();
            
        }

        //exit button
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /***************************************************
        * 
        *   readData()
        *   
        *   Purpose: Read data with 3 fields 
        *       (string, List<double>, List<double>)
        * 
        **************************************************/
        private void readData(string path, List<double> xValues, List<double> yValues)
        {
            string line;
            string[] fields;

            StreamReader file = new System.IO.StreamReader(path);

            while ((line = file.ReadLine()) != null)
            {
                fields = line.Split(); //split by space
                xValues.Add(Convert.ToDouble(fields[0]));
                yValues.Add(Convert.ToDouble(fields[1]));
            }

            file.Close();
        }

        /***************************************************
        * 
        *   readData()
        *   
        *   Purpose: Read data with 6 fields 
        * 
        **************************************************/
        private void readData(string path, List<double> xValues, List<int> yValues, List<int> moreValues, List<int> mostValues, List<int> mostestValues)
        {
            string line;
            string[] fields;

            StreamReader file = new System.IO.StreamReader(path);

            while ((line = file.ReadLine()) != null)
            {
                fields = line.Split(); //split by space
                xValues.Add(Convert.ToDouble(fields[0]));
                yValues.Add(Convert.ToInt32(fields[1]));
                moreValues.Add(Convert.ToInt32(fields[2])); //filling list with data 
                mostValues.Add(Convert.ToInt32(fields[3]));
                mostestValues.Add(Convert.ToInt32(fields[4]));
            }

            file.Close();
        }

        /***************************************************
        * 
        *   readData()
        *   
        *   Purpose: Read data with 3 fields
        *       (string, List<string>, List<double>)
        *   
        * 
        **************************************************/
        private void readData(string path, List<string> xValues, List<double> yValues)
        {
            string line;
            string[] fields;

            StreamReader file = new System.IO.StreamReader(path);

            while ((line = file.ReadLine()) != null)
            {
                fields = line.Split(); //split by space 
                xValues.Add(fields[0]);
                yValues.Add(Convert.ToDouble(fields[1]));
            }

            file.Close();
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
