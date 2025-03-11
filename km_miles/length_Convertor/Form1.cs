using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace length_Convertor
{
    public partial class length_Convertor : Form
    {
        public length_Convertor()
        {
            InitializeComponent();
        }

        private void length_Convertor_Load(object sender, EventArgs e)
        {

        }
        double m, km;

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtValue.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (rbtnKmToMiles.Checked)
            {
                km = double.Parse(txtValue.Text);
                m = km / 1.6;
                txtResult.Text = Convert.ToString(m);
            }
            if (rbtnMilesToKm.Checked)
            {
                m = double.Parse(txtValue.Text);
                km = m * 1.6;
                txtResult.Text = Convert.ToString(km);
            }

        }
    }
}
