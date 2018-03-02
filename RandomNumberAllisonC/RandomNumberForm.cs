/*
     * Created by: Allison Cook
     * Created on: 2 March, 2018
     * Created for: ICS3U Programming
     * Daily Assignment – Day #16 - Random Number
     * This program asks the user to guess a number form 1-10 and see if the guessed the right number
    */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberAllisonC
{
    public partial class frmRandomNumber : Form
    {
        //variable
        int userNumber;
        public frmRandomNumber()
        {
            InitializeComponent();
            //hide text before it starts
            lblRight.Hide();
            lblWrong.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            //constant numbers
            const int MAX = 10;
            const int MIN = 1;

            //calling random number 
            Random randomNumberGenerator = new Random();

            //get random number
            int randomNumber = randomNumberGenerator.Next(MIN, MAX + 1);
            //hide text if using agian without starting up
            lblRight.Hide();
            lblWrong.Hide();

           //getting random number


            try
            {
                //Try to set it as a number
                userNumber = Convert.ToInt16(txtInput.Text);
            }
            catch
            {
                //tell the user they need to input a number
                MessageBox.Show("Please input a number");
            }

            if (userNumber == randomNumber)
            {
                //show the user they got it right
                lblRight.Show();
                this.picCheck.Image = Properties.Resources.checkmark;
            }
            else
            {
                //show the user they got it wrong
                lblWrong.Show();
                this.picCheck.Image = Properties.Resources.red_x;

            }
        }
    }
}
