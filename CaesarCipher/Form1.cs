using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{

    public partial class frmCaesarCipher : Form
    {
        public int shift = 1;
        bool encrypt = true;
        string encroMessage = "";
        string rawMessage = "";
        string formatMessage = "";
        char[] alphabet = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public frmCaesarCipher()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tstShift.Text = Convert.ToString(shift);
        }

        private void btnKeyIncrease_Click(object sender, EventArgs e)
        {
            shift++;
            lblKey.Text = Convert.ToString(shift);
            tstShift.Text = Convert.ToString(shift);
            txtMessage.Text += "";
        }

        private void btnKeyDecrease_Click(object sender, EventArgs e)
        {
            shift--;
            tstShift.Text = Convert.ToString(shift);
            lblKey.Text = Convert.ToString(shift);
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            MessageFormat();
            Encryption();
            lblMessageDisplay.Text = encroMessage;
        }

        private void rEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            encrypt = true;
            lblEntry.Text = "Enter message to Encrypt: ";
        }

        private void rDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            encrypt = false;
            lblEntry.Text = "Enter message to Decrypt: ";
        }

        private void MessageFormat()
        {
            rawMessage = txtMessage.Text;
            rawMessage = rawMessage.ToLower();

            string tMessage = "";
            foreach (char ch in rawMessage)//For each loop iterates over each character in message
            {
                if (alphabet.Contains(ch))//If the character is in the alphabet array
                {
                    tMessage += ch;//The character is added to a new string called tMessage
                }
            }
            formatMessage = tMessage;
        }

        private void Encryption()
        {
            if (encrypt == true)
            {

                foreach (char ch in rawMessage)
                {
                    int index = Array.IndexOf(alphabet, ch);
                    if (index != -1) // If the character is found in the alphabet
                    {
                        encroMessage += alphabet[(index + shift) % 26];
                    }
                    //else
                    //{
                        // Handle characters not in the alphabet, like spaces or punctuation
                    //    encroMessage += ch;
                    //}
                }
            }

        }
         private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


