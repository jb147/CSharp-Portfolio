using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimesTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int num1;
            if(!int.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("Only a whole number should be entered in the text box.");
                txtNum1.Clear();
                return;
            }
            

            lsTimesTable.Items.Clear();
            for(int i = 1; i <= 12; i++)
            {
                lsTimesTable.Items.Add($"{i} x {num1} = {i * num1}").ToString();
            }
            btnClear.Enabled = true;
            btnGo.Enabled = false;
            txtNum1.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
        }

        private void lsTimesTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Text = string.Empty;
            btnGo.Enabled = true;
            txtNum1.Enabled = true;
            lsTimesTable.Items.Clear();
            lsTimesTable.Items.Add("Enter a Number above, then press Go");
            lsTimesTable.Items.Add("To generate a Times Table");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
