using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingNumberGame
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();

        int guessTotal = 0;

        int mySecretNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            //after everytime we take a guess it comes back to the box
            txtBoxGuess.Focus();

            int userGuess = 0;

            try
            {
                if (int.TryParse(txtBoxGuess.Text, out userGuess))
                {
                    if (userGuess < 0 || userGuess > 101)
                    {
                        {
                            MessageBox.Show("Invalid Info. Please put in a number between 1-100.");
                        }
                    }
                    else
                    {
                        if (mySecretNumber > userGuess)
                        {
                            guessTotal++;
                            lblGeusses.Text = guessTotal.ToString();
                            lblHint.Text = "Higher ↑";
                        }
                        else if (mySecretNumber < userGuess)
                        {
                            guessTotal++;
                            lblGeusses.Text = guessTotal.ToString();
                            lblHint.Text = "Lower ↓";
                        }
                        else
                        {
                            guessTotal++;
                            lblGeusses.Text = guessTotal.ToString();
                            lblHint.Text = "CORRECT!☻!☻!";
                            btnReplay.Visible = true;
                            btnGuess.Visible = false;
                        }
                    }
                }
            }
            catch
            {

            }
            txtBoxGuess.Text = "" ;
        }

        private void bntReplay_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            guessTotal = guessTotal - guessTotal;
            mySecretNumber = rnd.Next(100) + 1;
            btnReplay.Visible = false;
            btnGuess.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mySecretNumber = rnd.Next(100) + 1;
            btnReplay.Visible = false;
            btnGuess.Visible = true;
        }
    }
}
