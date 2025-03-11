using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void btnConver_Click(object sender, EventArgs e)
        {
            double c, f;
            if (rdbtnC2F.Checked == true)
            {
                c = Double.Parse(txtbtnValue.Text);
                f = (c * 9 / 5) + 32;
                txtbtnResult.Text = Convert.ToString(f); 
            }
            if (rdbtnF2C.Checked == true)
            {
                f = Double.Parse(txtbtnValue.Text);
                c = (f - 32) * 5 / 9;
                txtbtnResult.Text = Convert.ToString(c);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtbtnResult.Clear();
            txtbtnValue.Clear();
        }

        private void btnmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
