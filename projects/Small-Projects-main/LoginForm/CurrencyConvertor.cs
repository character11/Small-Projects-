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
    public partial class CurrencyConvertor : Form
    {
        double input = 0;
        double output = 0;
        public CurrencyConvertor()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboxInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboxInput.CanSelect == true)
            {
                txtOutput.Enabled = false;
                txtInput.Enabled = true;

                txtInput.Text = "";
                txtOutput.Text = "";

            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            if (txtInput.Text != "" && CboxInput.Text == "Euro" && CboxOutput.Text == "USD")
            {
                input = double.Parse(txtInput.Text);
                output = (input * 1.18);

                txtOutput.Text = output.ToString();
            }

            if (txtInput.Text != "" && CboxInput.Text == "Euro" && CboxOutput.Text == "MK Denar")
            {
                input = double.Parse(txtInput.Text);
                output = (input * 61.71);

                txtOutput.Text = output.ToString();
            }

            if (txtInput.Text != "" && CboxInput.Text == "USD" && CboxOutput.Text == "Euro")
            {
                input = double.Parse(txtInput.Text);
                output = (input * 0.85);

                txtOutput.Text = output.ToString();
            }

            if (txtInput.Text != "" && CboxInput.Text == "USD" && CboxOutput.Text == "MK Denar")
            {
                input = double.Parse(txtInput.Text);
                output = (input * 52.17);

                txtOutput.Text = output.ToString();
            }

            if (txtInput.Text != "" && CboxInput.Text == "MK Denar" && CboxOutput.Text == "Euro")
            {
                input = double.Parse(txtInput.Text);
                output = (input * 0.016);

                txtOutput.Text = output.ToString();
            }

            if (txtInput.Text != "" && CboxInput.Text == "MK Denar" && CboxOutput.Text == "USD")
            {
                input = double.Parse(txtInput.Text);
                output = (input * 0.019);

                txtOutput.Text = output.ToString();
            }
        }
    }
}
