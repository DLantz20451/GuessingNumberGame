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

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnStartReplay_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int mySecreteNumber = rnd.Next(10) + 1;

            int guess = 0;

            int guessAmount = 0;
        
            try
            {
                if (mySecreteNumber > guess)
                {
                    guessAmount++;
                    lblHint.Text = "Higher";
                }
                else if (mySecreteNumber < guess)
                {
                    guessAmount++;
                        
                    lblHint.Text = "Lower";
                }
                else
                {
                    lblHint.Text = "CORRECT!!!";

                }
            }
            catch
            {
            
            }
        }

    }
}
