using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assessment_task
{
    public partial class Form7 : Form
    {

        public static int myTrainingClick = 0;
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form3 = new Form3();
            Form3.Show(); //open the window 3 (same function for all below)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Form8 = new Form8();
            Form8.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Form9 = new Form9();
            Form9.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Form10 = new Form10();
            Form10.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //ignore
        }
    }
}
