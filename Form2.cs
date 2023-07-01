using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace assessment_task
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string myUsername = "";

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Young slime, welcome to Our Ant Kingdom."; //display this text
            textBox2.Text = "You must be wondering what you’ve been called here for. We need your help.";//display this text
            textBox3.Text = "Grow stronger and save this Kingdom by defeating the EVIL ANT QUEEN!";//display this text

        }

        private void button1_Click(object sender, EventArgs e) //first time button clicked
        {
            button1.Text = "{ OK }"; //display this text
            textBox1.Text = "Thank you hero!"; //display this text
            textBox2.Text = "What is your name?"; //display this text
            textBox3.BackColor = Color.FromArgb(157, 166, 250); //change color to indicate input box
            textBox3.Text = ""; //no text
            textBox3.ReadOnly = false; //can be edited
            button1.Click -= button1_Click; 
            button1.Click += button1second_Click;//change event handler

        }

        private void button1second_Click(object sender, EventArgs e) //second time button clicked
        {
            myUsername = textBox3.Text; //extract username
            textBox3.ReadOnly = true; //cannot be edited
            textBox4.Text = "I shall be guiding you, " + myUsername + " to become the strongest slime in the world!"; //display this text
            button1.Click -= button1second_Click;
            button1.Click += button1third_Click; //change event handler
        }

        private void button1third_Click(object sender, EventArgs e) //third time button clicked
        {
            textBox3.BackColor = Color.FromArgb(110, 123, 255); //changes textbox color to continue dialogue
            textBox1.Text = "To defeat monsters you must correctly answer their questions."; //display this text
            textBox2.Text = "For numbers 1-9, you can count them together."; //display this text
            textBox3.Text = "1 + 4 = ?"; //display this text
            textBox4.Text = "Count 1 and 4 together! 1 on your left hand, 4 on your right."; //display this text
            button1.Click -= button1third_Click;
            button1.Click += button1fourth_Click; //change event handler

        }

        private void button1fourth_Click(object sender, EventArgs e)
        {
            textBox3.Text = "1 + 4 = 5!"; //display this text
            button1.Click -= button1fourth_Click;
            button1.Click += button1fifth_Click; //change event handler
        }

        private void button1fifth_Click(object sender, EventArgs e)
        {
            textBox1.Text = " For numbers bigger than 9, you should first add the units"; //display this text
            textBox2.Text = "11 + 29 = ?"; //display this text
            textBox3.Text = "1 plus 9 is 10"; //display this text
            textBox4.Text = "10 plus 20 is 30"; //display this text
            textBox5.Text = "add our two answers, 30 + 10 = 40"; //display this text
            button1.Click -= button1fifth_Click;
            button1.Click += button1sixth_Click; //change event handler
        }

        private void button1sixth_Click(object sender, EventArgs e)
        {
            textBox2.Text = "11 + 29 = 40!"; //display this text
            button1.Click -= button1sixth_Click;
            button1.Click += button1seventh_Click; //change event handler
        }

        private void button1seventh_Click(object sender, EventArgs e)
        {
            textBox1.Text = "You have learnt how to add basic numbers.";//display this text
            textBox2.Text = "We'll test your new skills at the training grounds.";//display this text
            textBox3.Text = "The outside world is dangerous so train and train more to defeat the Ant Queen's defected army.";//display this text
            textBox4.Text = "Go on, young hero! Give it a try!";//display this text
            textBox5.Text = "";//no text
            button1.Click -= button1seventh_Click;
            button1.Click += button1eighth_Click; //change event handler
        }

        private void button1eighth_Click(object sender, EventArgs e)
        {
            Close(); //close this window
        }

    }
}
