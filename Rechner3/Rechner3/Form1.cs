using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechner3
{
    public partial class Rechner : Form
    {
        public Rechner()
        {
            InitializeComponent();
        }
        double num1, num2;
        double result;
        string option;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn3.Text;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn0.Text;
        }

        private void btnKoma_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btnKoma.Text;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtTotal.Text);
            txtTotal.Clear();
            option = "*";

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtTotal.Text);
            txtTotal.Clear();
            option = "/";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtTotal.Text);
            txtTotal.Clear();
            option = "+";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtTotal.Text);
            txtTotal.Clear();
            option = "-";
        }

        

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (option == "*")
            {
                num2 = double.Parse(txtTotal.Text);
                result = num1 * num2;
                txtTotal.Text = Convert.ToString(result);
            }
            if (option == "/")
            {
                num2 = double.Parse(txtTotal.Text);
                result = num1 / num2;
                txtTotal.Text = Convert.ToString(result);
            }
            if (option == "+")
            {
                num2 = double.Parse(txtTotal.Text);
                result = num1 + num2;
                txtTotal.Text = Convert.ToString(result);
            }
            if (option == "-")
            {
                num2 = double.Parse(txtTotal.Text);
                result = num1 - num2;
                txtTotal.Text = Convert.ToString(result);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
