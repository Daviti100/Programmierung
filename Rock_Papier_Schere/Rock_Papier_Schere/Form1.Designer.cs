namespace Rock_Papier_Schere
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNewGame = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.lblWinnerSide = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblCpuScore = new System.Windows.Forms.Label();
            this.lblCpuChoice = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewGame
            // 
            this.lblNewGame.AutoSize = true;
            this.lblNewGame.Location = new System.Drawing.Point(158, 24);
            this.lblNewGame.Name = "lblNewGame";
            this.lblNewGame.Size = new System.Drawing.Size(105, 25);
            this.lblNewGame.TabIndex = 0;
            this.lblNewGame.Text = "New game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cpu score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cpu chooses:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Player chooses:";
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(27, 247);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(103, 39);
            this.btnRock.TabIndex = 6;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(245, 247);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(103, 39);
            this.btnScissors.TabIndex = 7;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(136, 247);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(103, 39);
            this.btnPaper.TabIndex = 8;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // lblWinnerSide
            // 
            this.lblWinnerSide.AutoSize = true;
            this.lblWinnerSide.Location = new System.Drawing.Point(154, 82);
            this.lblWinnerSide.Name = "lblWinnerSide";
            this.lblWinnerSide.Size = new System.Drawing.Size(0, 25);
            this.lblWinnerSide.TabIndex = 9;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(154, 107);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(23, 25);
            this.lblPlayerScore.TabIndex = 10;
            this.lblPlayerScore.Text = "0";
            // 
            // lblCpuScore
            // 
            this.lblCpuScore.AutoSize = true;
            this.lblCpuScore.Location = new System.Drawing.Point(154, 132);
            this.lblCpuScore.Name = "lblCpuScore";
            this.lblCpuScore.Size = new System.Drawing.Size(23, 25);
            this.lblCpuScore.TabIndex = 11;
            this.lblCpuScore.Text = "0";
            // 
            // lblCpuChoice
            // 
            this.lblCpuChoice.AutoSize = true;
            this.lblCpuChoice.Location = new System.Drawing.Point(154, 173);
            this.lblCpuChoice.Name = "lblCpuChoice";
            this.lblCpuChoice.Size = new System.Drawing.Size(0, 25);
            this.lblCpuChoice.TabIndex = 12;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(27, 292);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(147, 39);
            this.btnNewGame.TabIndex = 13;
            this.btnNewGame.Text = "New game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(217, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 39);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 430);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblCpuChoice);
            this.Controls.Add(this.lblCpuScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblWinnerSide);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNewGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Rock Papier Schere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Label lblWinnerSide;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblCpuScore;
        private System.Windows.Forms.Label lblCpuChoice;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
    }
}

