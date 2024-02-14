using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBank
{
    
    public partial class frmMiniBank : Form
    {
        public double balance;
        public frmMiniBank()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            balance = 800.00;
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            lblBalance.Text = "£" + balance.ToString();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (balance - Convert.ToDouble(txtMoney.Text) < 0)
            {
                lblBalance.Text = "Insufficient Funds";
            }
            else
            {
                balance -= Convert.ToDouble(txtMoney.Text);
                lblBalance.Text = "£" + balance.ToString();
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            balance += Convert.ToDouble(txtMoney.Text);
            lblBalance.Text = "£" + balance.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();        }
    }
}
