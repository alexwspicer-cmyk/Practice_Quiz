using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void question01Button_Click(object sender, EventArgs e)
        {
            //Makes the output label visible and changes the text
            question1OutputLabel.Visible = true;
            question1OutputLabel.Text = "Happy Hump Day!";
        }

        private void question2Button_Click(object sender, EventArgs e)
        {
            //makes the output label visible and changes the text
            //uses question2TextBox.Text to get the players username
            question2OutputLabel.Visible= true;
            question2OutputLabel.Text = "Hello " + question2TextBox.Text + "!";
        }

        private void question3Button_Click(object sender, EventArgs e)
        {
            question3OutputLabel.Visible = true;
            try
            {
                int firstNum = Convert.ToInt32(q3Int1Text.Text);
                int secondNum = Convert.ToInt32(q3int2Text.Text);

                int outputNum = firstNum * secondNum;

                question3OutputLabel.Text = outputNum.ToString();

            }
            catch {

                question3OutputLabel.Text = "Invalid Input, Try Again";

            }
        }
    }
}
