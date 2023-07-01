using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace assessment_task
{
    public partial class Form5 : Form
    {   
        public Form5()
        {
            InitializeComponent();
            pictureBox4.MouseEnter += pictureBox4_MouseEnter; //new event handlers
            pictureBox4.MouseLeave += pictureBox4_MouseLeave;
            pictureBox3.MouseEnter += pictureBox3_MouseEnter;
            pictureBox3.MouseLeave += pictureBox3_MouseLeave;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            label4.Visible = false; //labels start invisible
            label3.Visible = false;
            label2.Visible = false;
            label1.Visible = false;

        }


        
        
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true; //when the mouse hovers over, the label is visible
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false; //when the mouse is not hovering, the label is not visible
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form Form6 = new Form6();
            Form6.Show(); //creates a variables for the form, shows a the form in a new window(same for all below)
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form Form6 = new Form6();
            Form6.Show();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            Form Form7 = new Form7();
            Form7.Show();
        }

        public void pictureBox4_Click(object sender, EventArgs e)
        {

            Form Form11 = new Form11();
            Form11.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //ignore
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Form Form11 = new Form11();
            Form11.Show();
        }
    }
}
