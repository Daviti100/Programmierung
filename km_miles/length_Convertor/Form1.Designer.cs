namespace length_Convertor
{
    partial class length_Convertor
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
            this.lblConvertor = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rbtnKmToMiles = new System.Windows.Forms.RadioButton();
            this.rbtnMilesToKm = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConvertor
            // 
            this.lblConvertor.AutoSize = true;
            this.lblConvertor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertor.Location = new System.Drawing.Point(12, 40);
            this.lblConvertor.Name = "lblConvertor";
            this.lblConvertor.Size = new System.Drawing.Size(163, 25);
            this.lblConvertor.TabIndex = 0;
            this.lblConvertor.Text = "Length Convertor";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(196, 100);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(66, 25);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(12, 100);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(114, 25);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Enter Value";
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(17, 140);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(144, 30);
            this.txtValue.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(201, 140);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(146, 30);
            this.txtResult.TabIndex = 4;
            // 
            // rbtnKmToMiles
            // 
            this.rbtnKmToMiles.AutoSize = true;
            this.rbtnKmToMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnKmToMiles.Location = new System.Drawing.Point(12, 176);
            this.rbtnKmToMiles.Name = "rbtnKmToMiles";
            this.rbtnKmToMiles.Size = new System.Drawing.Size(135, 29);
            this.rbtnKmToMiles.TabIndex = 5;
            this.rbtnKmToMiles.TabStop = true;
            this.rbtnKmToMiles.Text = "Km to Miles";
            this.rbtnKmToMiles.UseVisualStyleBackColor = true;
            // 
            // rbtnMilesToKm
            // 
            this.rbtnMilesToKm.AutoSize = true;
            this.rbtnMilesToKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMilesToKm.Location = new System.Drawing.Point(12, 202);
            this.rbtnMilesToKm.Name = "rbtnMilesToKm";
            this.rbtnMilesToKm.Size = new System.Drawing.Size(151, 29);
            this.rbtnMilesToKm.TabIndex = 6;
            this.rbtnMilesToKm.TabStop = true;
            this.rbtnMilesToKm.Text = "Mimles to Km";
            this.rbtnMilesToKm.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(17, 252);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(109, 36);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(154, 252);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 36);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(266, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // length_Convertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.rbtnMilesToKm);
            this.Controls.Add(this.rbtnKmToMiles);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblConvertor);
            this.Name = "length_Convertor";
            this.Text = "Length Convertor";
            this.Load += new System.EventHandler(this.length_Convertor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConvertor;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton rbtnKmToMiles;
        private System.Windows.Forms.RadioButton rbtnMilesToKm;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

