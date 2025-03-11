using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Papier_Schere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int playerScore = 0;
        int cpuScore = 0;
        int cpuChoice;
        Random random = new Random();

        private void btnRock_Click(object sender, EventArgs e)
        {
            cpuChoice = random.Next(1,4);
            if (cpuChoice == 1 )
            {
                lblWinnerSide.Text = "Tie";
                lblCpuChoice.Text = "Rock";
            }
            if (cpuChoice == 2 )
            {
                lblCpuChoice.Text = "Paper";
                lblWinnerSide.Text = "Cpu";
                cpuScore++;
                lblCpuScore.Text = Convert.ToString(cpuScore);
            }
            if (cpuChoice == 3 )
            {
                lblCpuChoice.Text = "Scissors";
                lblWinnerSide.Text = "Player";
                playerScore++;
                lblPlayerScore.Text = Convert.ToString(playerScore);
            }
            if (cpuScore == 3)
            {
                lblNewGame.Text = "Cpu wins the game!";
                cpuScore = 0;
                playerScore = 0;
                btnRock.Enabled = false;
                btnPaper.Enabled = false;
                btnScissors.Enabled = false;

            }
            if (playerScore == 3)
            {
                lblNewGame.Text = "Player wins the game!";
                playerScore = 0;
                cpuScore = 0;
                btnRock.Enabled = false;
                btnPaper.Enabled = false;
                btnScissors.Enabled = false;
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            cpuChoice = random.Next(1, 4);
            if (cpuChoice == 2)
            {
                lblWinnerSide.Text = "Tie";
                lblCpuChoice.Text = "Paper";
            }
            if (cpuChoice == 3)
            {
                lblCpuChoice.Text = "Scissors";
                lblWinnerSide.Text = "Cpu";
                cpuScore++;
                lblCpuScore.Text = Convert.ToString(cpuScore);
            }
            if (cpuChoice == 1)
            {
                lblCpuChoice.Text = "Rock";
                lblWinnerSide.Text = "Player";
                playerScore++;
                lblPlayerScore.Text = Convert.ToString(playerScore);
            }
            if (cpuScore == 3)
            {
                lblNewGame.Text = "Cpu wins the game!";
                cpuScore = 0;
                playerScore = 0;
                btnRock.Enabled = false;
                btnPaper.Enabled = false;
                btnScissors.Enabled = false;
            }
            if (playerScore == 3)
            {
                lblNewGame.Text = "Player wins the game!";
                playerScore = 0;
                cpuScore = 0;
                btnRock.Enabled = false;
                btnPaper.Enabled = false;
                btnScissors.Enabled = false;
            }

        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            cpuChoice = random.Next(1, 4);
            if (cpuChoice == 3)
            {
                lblWinnerSide.Text = "Tie";
                lblCpuChoice.Text = "Scissors";
            }
            if (cpuChoice == 1)
            {
                lblCpuChoice.Text = "Rock";
                lblWinnerSide.Text = "Cpu";
                cpuScore++;
                lblCpuScore.Text = Convert.ToString(cpuScore);
            }
            if (cpuChoice == 2)
            {
                lblCpuChoice.Text = "paper";
                lblWinnerSide.Text = "Player";
                playerScore++;
                lblPlayerScore.Text = Convert.ToString(playerScore);
            }
            if (cpuScore == 3)
            {
                lblNewGame.Text = "Cpu wins the game!";
                cpuScore = 0;
                playerScore = 0;
                btnRock.Enabled = false;
                btnPaper.Enabled = false;
                btnScissors.Enabled = false;

            }
            if (playerScore == 3)
            {
                lblNewGame.Text = "Player wins the game!";
                playerScore = 0;
                cpuScore = 0;
                btnRock.Enabled = false;
                btnPaper.Enabled = false;
                btnScissors.Enabled = false;
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lblNewGame.Text = "New game";
            playerScore = 0;
            cpuScore = 0;
            lblCpuScore.Text = Convert.ToString(cpuScore);
            lblPlayerScore.Text = Convert.ToString(playerScore);
            lblWinnerSide.Text = "";
            lblCpuChoice.Text = "";
            btnRock.Enabled = true;
            btnPaper.Enabled = true;
            btnScissors.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
