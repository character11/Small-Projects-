using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        // SQL connection 
        public string conString = "Data Source=DESKTOP-HDIF75Q\\SQLEXPRESS;Initial Catalog=LoginProject;Integrated Security=True";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string[] username = { "user1", "user2" };
        public string[] passwords = { "111", "222" };
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (username.Contains(txtusername.Text) && passwords.Contains(txtpassword.Text) && Array.IndexOf(username, txtusername.Text) == Array.IndexOf(passwords, txtpassword.Text))
            {
                this.Hide();
                Options f3 = new Options();
                f3.Show();
            }
            else
            {
                MessageBox.Show("Username or Password  is incorect.");
            }

        }
    }
}
