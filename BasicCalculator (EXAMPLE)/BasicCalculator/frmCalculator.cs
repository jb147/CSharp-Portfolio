using System;
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
    public partial class frmCalculator : Form
    {
        private static double dblNumber1;
        private static double dblNumber2;
        private static double dblResult;
        private static string strSymbol;
        private static bool boldecimalUsed = false;
        private static int currentIndex = 0;
        private List<Button> buttonsToFlash = new List<Button>();

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void butOne_Click(object sender, EventArgs e)
        {
            butClicked(butOne);
        }

        private void butTwo_Click(object sender, EventArgs e)
        {
            butClicked(butTwo);
        }

        private void butThree_Click(object sender, EventArgs e)
        {
            butClicked(butThree);
        }

        private void butFour_Click(object sender, EventArgs e)
        {
            butClicked(butFour);
        }

        private void butFive_Click(object sender, EventArgs e)
        {
            butClicked(butFive);
        }

        private void butSix_Click(object sender, EventArgs e)
        {
            butClicked(butSix);
        }

        private void butSeven_Click(object sender, EventArgs e)
        {
            butClicked(butSeven);
        }

        private void butEight_Click(object sender, EventArgs e)
        {
            butClicked(butEight);
        }

        private void butNine_Click(object sender, EventArgs e)
        {
            butClicked(butNine);
        }

        private void butZero_Click(object sender, EventArgs e)
        {
            butClicked(butZero);
        }

        private void butDecimal_Click(object sender, EventArgs e)
        {
            butClicked(butDecimal);
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            butClicked(butCancel);
        }

        private void butAddition_Click(object sender, EventArgs e)
        {
            butClicked(butAddition);
        }

        private void butEquals_Click(object sender, EventArgs e)
        {
            butClicked(butEquals);
        }

        private void butSubtraction_Click(object sender, EventArgs e)
        {
            butClicked(butSubtraction);
        }

        private void butClicked(Control control)
        {
            if (txtInputResult.Text == "0") txtInputResult.Text = "";

            switch (control.Name)
            {
                case "butOne":
                    txtInputResult.Text += "1";
                    txtEquation.Text += "1";
                    break;
                case "butTwo":
                    txtInputResult.Text += "2";
                    txtEquation.Text += "2";
                    break;
                case "butThree":
                    txtInputResult.Text += "3";
                    txtEquation.Text += "3";
                    break;
                case "butFour":
                    txtInputResult.Text += "4";
                    txtEquation.Text += "4";
                    break;
                case "butFive":
                    txtInputResult.Text += "5";
                    txtEquation.Text += "5";
                    break;
                case "butSix":
                    txtInputResult.Text += "6";
                    txtEquation.Text += "6";
                    break;
                case "butSeven":
                    txtInputResult.Text += "7";
                    txtEquation.Text += "7";
                    break;
                case "butEight":
                    txtInputResult.Text += "8";
                    txtEquation.Text += "8";
                    break;
                case "butNine":
                    txtInputResult.Text += "9";
                    txtEquation.Text += "9";
                    break;
                case "butZero":
                    if (txtInputResult.Text != "0")
                    {
                        txtInputResult.Text += "0";
                        txtEquation.Text += "0";
                    }
                    break;
                case "butDecimal":
                    if (boldecimalUsed) return;
                    if (txtInputResult.Text == "")
                    {
                        txtInputResult.Text += "0.";
                        txtEquation.Text += "0.";
                    }
                    else
                    {
                        txtInputResult.Text += ".";
                        txtEquation.Text += ".";
                    }
                    boldecimalUsed = true;
                    break;
                case "butCancel":
                    txtInputResult.Text = "0";
                    txtEquation.Text = "";
                    boldecimalUsed = false;
                    break;
                case "butAddition":
                    dblNumber1 = Convert.ToDouble(txtInputResult.Text);
                    txtInputResult.Text = "0";
                    strSymbol = "+";
                    boldecimalUsed = false;
                    txtEquation.Text += " + ";
                    break;
                case "butSubtraction":
                    dblNumber1 = Convert.ToDouble(txtInputResult.Text);
                    txtInputResult.Text = "0";
                    strSymbol = "-";
                    boldecimalUsed = false;
                    txtEquation.Text += " - ";
                    break;
                case "butEquals":
                    dblNumber2 = Convert.ToDouble(txtInputResult.Text);
                    if (strSymbol == "") break;
                    if (strSymbol == "+") dblResult = dblNumber1 + dblNumber2;
                    if (strSymbol == "-") dblResult = dblNumber1 - dblNumber2;
                    txtInputResult.Text = Convert.ToString(dblResult);
                    txtEquation.Text = txtInputResult.Text;
                    boldecimalUsed = false;
                    break;
            }
        }

        private void flashButtons()
        {
            
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
        }
    }
}
