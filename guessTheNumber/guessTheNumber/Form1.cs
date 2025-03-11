using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessTheNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            mysteryNumber = rand.Next(1, 101);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Random rand = new Random();
        int mysteryNumber;
        
        int chosenNumber;
        int tries = 0;
       
         
       
        private void btnEnterNumber_Click(object sender, EventArgs e)
        {
             
            chosenNumber = Convert.ToInt32(txtNumber.Text);
            
            if (mysteryNumber > chosenNumber)
            {
                lblMysteryNumber.Text = "bigger than entered number!";
                tries++;
                lblTries.Text = Convert.ToString(tries);
            }
            if (mysteryNumber < chosenNumber)
            {
                lblMysteryNumber.Text = "smaller than entered number!";
                tries++;
                lblTries.Text = Convert.ToString(tries);
            }
            if (mysteryNumber == chosenNumber)
            {
                lblMysteryNumber.Text = "the same, that enttered number";
                tries++;
                lblYouGuessednumber.Text = $"You guessed the number {mysteryNumber} in {tries} tries";
                lblTries.Text = Convert.ToString(tries);
            }

            

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            tries = 0;
            lblMysteryNumber.Text = "";
            lblYouGuessednumber.Text = "";
            lblTries.Text = "0";
            txtNumber.Text = "";
            mysteryNumber = rand.Next(1, 101);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
