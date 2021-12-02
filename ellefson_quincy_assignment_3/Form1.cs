using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ellefson_quincy_assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//Loads the setup form
        {
            setupForm frm2 = new setupForm();
            frm2.Show();
        }

        private void Form1_Shown(object sender, EventArgs e)//Hides form1
        {
            this.Hide();
        }
    }
}
