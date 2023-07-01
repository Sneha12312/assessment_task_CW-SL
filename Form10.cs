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

namespace assessment_task
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        //see the comments on form1

        int myAnswer = 0;
        int bossHealth = 10;
        int num1 = 0;
        int num2 = 0;
        int myTotal = 0;
        static string Formula = "";
        int scorecorrect = 0;
        int scoretotal = 0;
        private void Form10_Load(object sender, EventArgs e)
        {

            Random myRandom = new Random();
            num1 = myRandom.Next(10, 20); //generate a number between 1 - 20
            num2 = myRandom.Next(10, 20); //generate a number between 1 - 2
            myTotal = num1 + num2; //add num1 + num2 and assign this value to Total
            Formula = "\n" + num1 + "+" + num2;
            richTextBox1.Text = Formula; //writes the above string
            richTextBox2.Text = ""; //positions the cursor at the bottom of the text
            richTextBox2.Select(richTextBox2.Text.Length, 0); //positions the cursor at the bottom of the text
            richTextBox1.Select(richTextBox1.Text.Length, 0); //positions the cursor at the bottom of the text
            textBox1.Text = scorecorrect + " / " + scoretotal;

        }

        public void button1_Click(object sender, EventArgs e)
        {
            while (bossHealth > 0)
            {
                if (Button1.Text == "Continue")
                {
                    Button1.Text = "Submit";
                    richTextBox1.Text = Formula;
                    richTextBox1.Select(richTextBox1.Text.Length, 0); //positions the cursor at the bottom of the text
                    return;
                }

                try
                {
                    myAnswer = Convert.ToInt32(richTextBox2.Text.Trim());
                }
                catch (FormatException)
                {
                    richTextBox1.Text = "\nYou haven't entered numbers! please try again";
                    richTextBox2.Text = "";
                    richTextBox1.Select(richTextBox1.Text.Length, 0); //positions the cursor at the bottom of the text
                    Button1.Text = "Continue";
                    return;
                }


                if (myAnswer == myTotal) //checks if the players answer is not the same as the correct answer
                {
                    bossHealth = bossHealth - 1;
                    scorecorrect = ++scorecorrect;
                    scoretotal = ++scoretotal;
                    textBox1.Text = scorecorrect + " / " + scoretotal;

                    if (bossHealth <= 8)
                    {
                        pictureBox10.Visible = false;
                    }

                    if (bossHealth <= 6)
                    {
                        pictureBox9.Visible = false;
                    }

                    if (bossHealth <= 4)
                    {
                        pictureBox8.Visible = false;
                    }

                    if (bossHealth <= 2)
                    {
                        pictureBox7.Visible = false;
                    }
                }
                else
                {
                    scoretotal = ++scoretotal;
                    textBox1.Text = scorecorrect + " / " + scoretotal;

                }

                Random myRandom = new Random();
                num1 = myRandom.Next(10, 20); //generate a number between 1 - 20
                num2 = myRandom.Next(10, 20); //generate a number between 1 - 20
                myTotal = num1 + num2; //add num1 + num2 and assign this value to Total
                Formula = "\n" + num1 + "+" + num2;
                richTextBox1.Text = Formula; //writes the above string
                richTextBox2.Select(richTextBox2.Text.Length, 0); //positions the cursor at the bottom of the text
                richTextBox1.Select(richTextBox1.Text.Length, 0); //positions the cursor at the bottom of the text
                richTextBox2.Text = ""; //positions the cursor at the bottom of the text
                return;


            }

            Close();

        }
    }
}
