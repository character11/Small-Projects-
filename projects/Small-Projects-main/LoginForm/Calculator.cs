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

    public partial class Calculator : Form
    {
        double firstnumber;
        string operation;
        public Calculator()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult != null)
            {
                txtResult.Text = "1";
            }
            else
            {
                txtResult.Text = txtResult.Text + "1";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult != null)
            {
                txtResult.Text = "2";
            }
            else
            {
                txtResult.Text = txtResult.Text + "2";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult != null)
            {
                txtResult.Text = "3";
            }
            else
            {
                txtResult.Text = txtResult.Text + "3";
            }
        }

        private void numCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult != null)
            {
                txtResult.Text = "4";
            }
            else
            {
                txtResult.Text = txtResult.Text + "4";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult != null)
            {
                txtResult.Text = "5";
            }
            else
            {
                txtResult.Text = txtResult.Text + "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult != null)
            {
                txtResult.Text = "6";
            }
            else
            {
                txtResult.Text = txtResult.Text + "6";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult != null)
            {
                txtResult.Text = "7";
            }
            else
            {
                txtResult.Text = txtResult.Text + "7";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult != null)
            {
                txtResult.Text = "8";
            }
            else
            {
                txtResult.Text = txtResult.Text + "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult != null)
            {
                txtResult.Text = "9";
            }
            else
            {
                txtResult.Text = txtResult.Text + "9";
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "0";
        }
        private void numplus_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "+";


        }

        private void numminus_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "-";
        }

        private void nummultipli_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "*";
        }

        private void numdiv_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "/";
        }

        private void numpow_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "^";
        }

        private void numdot_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + ".";
        }

        private void numsqrt_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "sqrt";
        }

        private void numproc_Click(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "%";
        }

        private void numplus_Click_1(object sender, EventArgs e)
        {
            firstnumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "+";
        }

        private void numeql_Click_1(object sender, EventArgs e)
        {
            double secondnumber;
            double result;

            secondnumber = Convert.ToDouble(txtResult.Text);

            if (operation == "+")
            {
                result = firstnumber + secondnumber;
                txtResult.Text = Convert.ToString(result);
                firstnumber = result;
            }
            if (operation == "-")
            {
                result = firstnumber - secondnumber;
                txtResult.Text = Convert.ToString(result);
                firstnumber = result;
            }

            if (operation == "*")
            {
                result = firstnumber * secondnumber;
                txtResult.Text = Convert.ToString(result);
                firstnumber = result;
            }
            if (operation == "/")
            {
                if (secondnumber == 0)
                {
                    txtResult.Text = "EROR";
                }
                else
                {
                    result = firstnumber / secondnumber;
                    txtResult.Text = Convert.ToString(result);
                    firstnumber = result;
                }
            }
            if (operation == "^")
            {
                double pow = 1;
                for (double x = 0; x < secondnumber; x++)
                {
                    pow = pow * firstnumber;
                }
                result = pow;
                txtResult.Text = Convert.ToString(result);
                firstnumber = result;

            }
            if (operation == "%")
            {
                result = secondnumber / 100 * firstnumber;
                txtResult.Text = Convert.ToString(result);
                firstnumber = result;
            }
            if (operation == "sqrt")
            {
                result = Math.Sqrt(firstnumber);
                txtResult.Text = Convert.ToString(result);
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
