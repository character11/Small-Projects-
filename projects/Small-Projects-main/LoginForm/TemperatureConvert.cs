using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class TemperatureConvert : Form
    {

        int cel = 0;
        int fr = 0;
        public TemperatureConvert()
        {
            InitializeComponent();
        }

        private void rbtnCF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCF.Checked == true)
            {
                txtFar.Enabled = false;
                txtCel.Enabled = true;

                txtCel.Text = "";
                txtFar.Text = "";
            }
        }

        private void rbtnFC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFC.Checked == true)
            {
                txtCel.Enabled = false;
                txtFar.Enabled = true;

                txtCel.Text = "";
                txtFar.Text = "";

            }
        }

        private void txtCel_TextChanged(object sender, EventArgs e)
        {
            if (txtCel.Text != "" && rbtnCF.Checked == true)
            {
                cel = int.Parse(txtCel.Text);
                fr = (cel * 9) / 5 + 32;

                txtFar.Text = fr.ToString();
            }
        }

        private void txtFar_TextChanged(object sender, EventArgs e)
        {
            if (txtFar.Text != "" && rbtnFC.Checked == true)
            {
                fr = int.Parse(txtFar.Text);
                cel = (fr - 32) * 5 / 9;

                txtCel.Text = cel.ToString();
            }
        }

        private void TemperatureConvert_Load(object sender, EventArgs e)
        {
            rbtnCF.Checked = true;
        }
    }
}
