namespace guessTheNumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnEnterNumber = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMysteryNumber = new System.Windows.Forms.Label();
            this.lblYouGuessednumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTries = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess the number 1-100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the number:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(186, 118);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 30);
            this.txtNumber.TabIndex = 2;
            // 
            // btnEnterNumber
            // 
            this.btnEnterNumber.Location = new System.Drawing.Point(301, 118);
            this.btnEnterNumber.Name = "btnEnterNumber";
            this.btnEnterNumber.Size = new System.Drawing.Size(98, 30);
            this.btnEnterNumber.TabIndex = 3;
            this.btnEnterNumber.Text = "Enter";
            this.btnEnterNumber.UseVisualStyleBackColor = true;
            this.btnEnterNumber.Click += new System.EventHandler(this.btnEnterNumber_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mystery number is:";
            // 
            // lblMysteryNumber
            // 
            this.lblMysteryNumber.AutoSize = true;
            this.lblMysteryNumber.Location = new System.Drawing.Point(196, 164);
            this.lblMysteryNumber.Name = "lblMysteryNumber";
            this.lblMysteryNumber.Size = new System.Drawing.Size(0, 25);
            this.lblMysteryNumber.TabIndex = 5;
            // 
            // lblYouGuessednumber
            // 
            this.lblYouGuessednumber.AutoSize = true;
            this.lblYouGuessednumber.Location = new System.Drawing.Point(132, 64);
            this.lblYouGuessednumber.Name = "lblYouGuessednumber";
            this.lblYouGuessednumber.Size = new System.Drawing.Size(0, 25);
            this.lblYouGuessednumber.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tries:";
            // 
            // lblTries
            // 
            this.lblTries.AutoSize = true;
            this.lblTries.Location = new System.Drawing.Point(81, 204);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(23, 25);
            this.lblTries.TabIndex = 8;
            this.lblTries.Text = "0";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(18, 248);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(172, 37);
            this.btnNewGame.TabIndex = 9;
            this.btnNewGame.Text = "New game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(18, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 37);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 703);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblYouGuessednumber);
            this.Controls.Add(this.lblMysteryNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnterNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Guess the number 1-100";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnEnterNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMysteryNumber;
        private System.Windows.Forms.Label lblYouGuessednumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTries;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
    }
}

