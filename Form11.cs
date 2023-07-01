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
    public partial class Form11 : Form
    {
        public static int myTrainingClick = 0;
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form12 = new Form12();
            Form12.Show(); //opens new window
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Form13 = new Form13();
            Form13.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Form14 = new Form14();
            Form14.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
