using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace assessment_task
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int myAnswer = 0; //a user input variable
        int bossHealth = 10; //the number of answers the user must get correct to win
        int num1 = 0; //variable for random number generation
        int num2 = 0; //variable for random number generation
        int myTotal = 0; //variable for total of num1 and num2
        static string Formula = ""; //variable to print random formula for users to guess. It is static so that the variables in it do not change each call.
        int scorecorrect = 0; //total number of correct answers by user
        int scoretotal = 0; //total number of questions attempted by user
        private void Form3_Load(object sender, EventArgs e)
        {

            Random myRandom = new Random(); //the variable myRandom produces a random number
            num1 = myRandom.Next(1, 5); //generate a number between 1 - 5
            num2 = myRandom.Next(1, 5); //generate a number between 1 - 5
            myTotal = num1 + num2; //add num1 + num2 and assign this value to Total
            Formula = "\n" + num1 + "+" + num2 + "\n"; //writes an equation for users to solve
            richTextBox1.Text = Formula; //writes the above string
            richTextBox2.Text = ""; //positions the cursor at the bottom of the text
            richTextBox2.Select(richTextBox2.Text.Length, 0); //positions the cursor at the bottom of the text
            richTextBox1.Select(richTextBox1.Text.Length, 0); //positions the cursor at the bottom of the text
            textBox1.Text = scorecorrect + " / " + scoretotal; //as shown, displays current score to users

        }

        public void button1_Click(object sender, EventArgs e)
        {
            while (bossHealth > 0)//the following code is followed if the user has not died and enemy has not also died
            {

                if (Button1.Text == "Continue") //when an exception is thrown from the answer, the button text is changed to continue.
                {
                    Button1.Text = "Submit"; //change back the text to submit
                    richTextBox1.Text = Formula; //redisplay the formula
                    richTextBox1.Select(richTextBox1.Text.Length, 0); //positions the cursor at the bottom of the text
                    return; //exit the while loop
                }

                try
                {
                    myAnswer = Convert.ToInt32(richTextBox2.Text.Trim()); //trim whitespaces off text in the textbox. Convert to integers
                }
                catch (FormatException) //if the text in richtextbox2 cannot be converted to integers
                {
                    richTextBox1.Text = "\nYou haven't entered numbers! please try again\n"; //tells user
                    richTextBox2.Text = ""; //removes text
                    richTextBox1.Select(richTextBox1.Text.Length, 0); //positions the cursor at the bottom of the text
                    Button1.Text = "Continue"; //as coded
                    return; //exit the while loop
                }



                if (myAnswer == myTotal) //checks if the players answer is the same as the correct answer
                {
                    bossHealth = bossHealth - 1; //decrease bosshealth
                    scorecorrect = ++scorecorrect; //increase correct score
                    scoretotal = ++scoretotal; //increase total score
                    textBox1.Text = scorecorrect + " / " + scoretotal; //display new scores

                    if (bossHealth <= 8) //hearts are lost in increments of 2
                    {
                        pictureBox10.Visible = false; //boss lose 1 heart
                    }

                    if (bossHealth <= 6)
                    {
                        pictureBox9.Visible = false; //boss lose second heart
                    }

                    if (bossHealth <= 4)
                    {
                        pictureBox8.Visible = false; //boss lose third heart
                    }

                    if (bossHealth <= 2)
                    {
                        pictureBox7.Visible = false; //boss lose fourth heart
                    }
                }
                else
                {
                    scoretotal = ++scoretotal; //total score increase
                    textBox1.Text = scorecorrect + " / " + scoretotal; //display new score

                }

                Random myRandom = new Random();
                num1 = myRandom.Next(1, 5); //generate a number between 1 - 20
                num2 = myRandom.Next(1, 5); //generate a number between 1 - 20
                myTotal = num1 + num2; //add num1 + num2 and assign this value to Total
                Formula = "\n" + num1 + "+" + num2 + "\n"; //see above
                richTextBox1.Text = Formula; //writes the above string
                richTextBox2.Select(richTextBox2.Text.Length, 0); //positions the cursor at the bottom of the text
                richTextBox1.Select(richTextBox1.Text.Length, 0); //positions the cursor at the bottom of the text
                richTextBox2.Text = "";
                return; //exit while loop


            }

            Close(); //closes the form1 window


        }
    }
}
