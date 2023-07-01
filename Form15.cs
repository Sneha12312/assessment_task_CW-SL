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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            textBox1.Text = "'NO! You've defeated me... '";
            textBox2.Text = "'My human will be disapointed.'";
            textBox3.Text = "'I must return to his side.'";
            textBox4.Text = "The Ant Queen has run to the Beetle Land";
            textBox5.Text = "Will you please journey yonder to bring our ruler back?"; //displays texts

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "My deepest gratitude to you, kind hero.";
            textBox2.Text = "Unfortunately, as the general of the ants, I cannot leave my country.";
            textBox3.Text = "However, you have become strong.";
            textBox4.Text = "You can venture beyond the narrow confines of our Kingdom.";
            textBox5.Text = "Good luck, friend, and you are always again welcome."; //changes displayed text
            button1.Click -= button1_Click;
            button1.Click += button1second_Click; //new event handler

        }

        private void button1second_Click(object sender, EventArgs e)
        {
            Application.Exit(); //closes application
        }

    }
}
