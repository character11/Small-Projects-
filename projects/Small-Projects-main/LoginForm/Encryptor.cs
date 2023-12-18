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
    public partial class Encryptor : Form
    {
        public Encryptor()
        {
            InitializeComponent();
        }

        private void Encryptor_Load(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOW DOES ENCRYPT WORK? \n \n" +
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
                "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris" +
                "nisi ut aliquip ex ea commodo consequat." +
                "Duis aute irure dolor in reprehenderit in voluptate velit esse " +
                "cillum dolore eu fugiat nulla pariatur. " +
                "Excepteur sint occaecat cupidatat non proident, " +
                "sunt in culpa qui officia deserunt mollit anim id est laborum.");
        }

        private void btnecrypt_Click(object sender, EventArgs e)
        {
            /*
            string orgMessage = txtOriginalText.Text;
            int shiftnum = Int32.Parse(txtShift.Text);
            txtEncryptedText.Text = doencryption(orgMessage, shiftnum);
            */
            
        }
        /*
        private static string doencryption(string words, int shiftnum)
        {
            char[] buffer = words.ToCharArray();

            for(int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter + shiftnum);

                    if(letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    if(letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }

                buffer[i] = letter;
            }
        
        }
        */
        
    }
}
