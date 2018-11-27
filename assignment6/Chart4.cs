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
    public partial class Chart4 : Form
    {
        protected Form1 CallingForm;
        public Chart4(Form1 form)
        {
            InitializeComponent();
            this.CallingForm = form;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Chart4_Load(object sender, EventArgs e)
        {

        }
    }
}