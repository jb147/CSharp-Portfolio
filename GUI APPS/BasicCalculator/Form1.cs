using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class frmBasicCalc : Form
    {
        public string operation = "";
        public bool dec = false;
       
        public double num1, num2;


        public frmBasicCalc()
        {
            InitializeComponent();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            CheckZero();
            txtInput.Text = txtInput.Text + "1";
        }

        private void btnNum2_Click_1(object sender, EventArgs e)
        {
            CheckZero();
            txtInput.Text = txtInput.Text + "2";
        }

        private void btnNum3_Click_1(object sender, EventArgs e)
        {
            CheckZero();
            txtInput.Text = txtInput.Text + "3";
        }

        private void btnNum4_Click_1(object sender, EventArgs e)
        {
            CheckZero();
            txtInput.Text = txtInput.Text + "4";
        }

        private void btnNum5_Click_1(object sender, EventArgs e)
        {
            CheckZero();
            txtInput.Text = txtInput.Text + "5";
        }

        private void btnNum6_Click_1(object sender, EventArgs e)
        {
            CheckZero();
            txtInput.Text = txtInput.Text + "6";
        }

        private void btnNum7_Click_1(object sender, EventArgs e)
        {
            CheckZero();
            txtInput.Text = txtInput.Text + "7";
        }

        private void btnNum8_Click_1(object sender, EventArgs e)
        {
            CheckZero();
            txtInput.Text = txtInput.Text + "8";
        }

        private void btnNum9_Click_1(object sender, EventArgs e)
        {
            CheckZero();
            txtInput.Text = txtInput.Text + "9";
        }

        private void CheckZero()
        {
            if (txtInput.Text == "0")
            {
                txtInput.Text = "";
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            CheckZero();
            txtInput.Text = txtInput.Text + "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtInput.Text);
            txtInput.Text = "0";
            operation = "+";
            dec = false;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtInput.Text);
            txtInput.Text = "0";
            operation = "-";
            dec = false;
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            
            if (dec == true)
            {
                txtInput.Text = txtInput.Text;
            }
            else
            {
                dec = true;
                CheckZero();
                txtInput.Text = txtInput.Text + ".";
                
                
                

            }
         
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "0";
            num1 = 0;
            num2 = 0;
            operation = "";

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtInput.Text);

            if (operation == "+")
            {
                txtInput.Text = $"{num1 + num2}"; 
            }

            if (operation == "-")
            {
                txtInput.Text = $"{num1 - num2}";
            }

        }
    }
}
