namespace WindowsFormsApp2
{
    partial class TemperatureConverter
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
            this.lblValue = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.rdbtnC2F = new System.Windows.Forms.RadioButton();
            this.rdbtnF2C = new System.Windows.Forms.RadioButton();
            this.txtbtnResult = new System.Windows.Forms.TextBox();
            this.txtbtnValue = new System.Windows.Forms.TextBox();
            this.btnConver = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnmExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(50, 107);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(132, 25);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "Enter Value:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(491, 107);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(79, 25);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result:";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(50, 248);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(124, 25);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "Select Unit:";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(185, 9);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(236, 25);
            this.lblTemperature.TabIndex = 3;
            this.lblTemperature.Text = "Temperature Converter";
            // 
            // rdbtnC2F
            // 
            this.rdbtnC2F.AutoSize = true;
            this.rdbtnC2F.Location = new System.Drawing.Point(55, 275);
            this.rdbtnC2F.Name = "rdbtnC2F";
            this.rdbtnC2F.Size = new System.Drawing.Size(238, 29);
            this.rdbtnC2F.TabIndex = 4;
            this.rdbtnC2F.TabStop = true;
            this.rdbtnC2F.Text = "Celcius to Fehrenheit";
            this.rdbtnC2F.UseVisualStyleBackColor = true;
            // 
            // rdbtnF2C
            // 
            this.rdbtnF2C.AutoSize = true;
            this.rdbtnF2C.Location = new System.Drawing.Point(55, 310);
            this.rdbtnF2C.Name = "rdbtnF2C";
            this.rdbtnF2C.Size = new System.Drawing.Size(238, 29);
            this.rdbtnF2C.TabIndex = 5;
            this.rdbtnF2C.TabStop = true;
            this.rdbtnF2C.Text = "Fehrenheit to Celcius";
            this.rdbtnF2C.UseVisualStyleBackColor = true;
            // 
            // txtbtnResult
            // 
            this.txtbtnResult.Location = new System.Drawing.Point(496, 135);
            this.txtbtnResult.Name = "txtbtnResult";
            this.txtbtnResult.Size = new System.Drawing.Size(171, 30);
            this.txtbtnResult.TabIndex = 6;
            // 
            // txtbtnValue
            // 
            this.txtbtnValue.Location = new System.Drawing.Point(55, 135);
            this.txtbtnValue.Name = "txtbtnValue";
            this.txtbtnValue.Size = new System.Drawing.Size(177, 30);
            this.txtbtnValue.TabIndex = 7;
            // 
            // btnConver
            // 
            this.btnConver.Location = new System.Drawing.Point(55, 359);
            this.btnConver.Name = "btnConver";
            this.btnConver.Size = new System.Drawing.Size(119, 33);
            this.btnConver.TabIndex = 8;
            this.btnConver.Text = "Convert";
            this.btnConver.UseVisualStyleBackColor = true;
            this.btnConver.Click += new System.EventHandler(this.btnConver_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(237, 359);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 33);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnmExit
            // 
            this.btnmExit.Location = new System.Drawing.Point(447, 359);
            this.btnmExit.Name = "btnmExit";
            this.btnmExit.Size = new System.Drawing.Size(106, 33);
            this.btnmExit.TabIndex = 10;
            this.btnmExit.Text = "Exit";
            this.btnmExit.UseVisualStyleBackColor = true;
            this.btnmExit.Click += new System.EventHandler(this.btnmExit_Click);
            // 
            // TemperatureConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 424);
            this.Controls.Add(this.btnmExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConver);
            this.Controls.Add(this.txtbtnValue);
            this.Controls.Add(this.txtbtnResult);
            this.Controls.Add(this.rdbtnF2C);
            this.Controls.Add(this.rdbtnC2F);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblValue);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TemperatureConverter";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.RadioButton rdbtnC2F;
        private System.Windows.Forms.RadioButton rdbtnF2C;
        private System.Windows.Forms.TextBox txtbtnResult;
        private System.Windows.Forms.TextBox txtbtnValue;
        private System.Windows.Forms.Button btnConver;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnmExit;
    }
}

