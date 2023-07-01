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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Train and train more to defeat the Ant Queen's defected army."; //displays this text
            textBox1.Text = "Go on, young hero! The outside world is dangerous."; //displays this text
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); //closes this form
        }

        
    }
}
