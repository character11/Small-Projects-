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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TemperatureConvert f4 = new TemperatureConvert();
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculator f5 = new Calculator();
            f5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrencyConvertor f6 = new CurrencyConvertor();
            f6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Encryptor f7 = new Encryptor();
            f7.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CafeSystem f8 = new CafeSystem();
            f8.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SnakeGame f9 = new SnakeGame();
            f9.Show();
        }
    }
}
