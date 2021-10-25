using System;
using System.Windows.Forms;

namespace TipCalculator
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void tipDecreaseValue(object sender, EventArgs e)
        {
            int a;
            if (String.IsNullOrEmpty(tipPercentTextBox.Text))
            {
                a = 0;
            }
            else
            {
                a = Convert.ToInt32(tipPercentTextBox.Text);
            }
                
            int val = decreaseVal(a);
            tipPercentTextBox.Text = val.ToString();
        }

        private void tipIncreaseValue(object sender, EventArgs e)
        {

            int a;
            if (String.IsNullOrEmpty(tipPercentTextBox.Text))
            {
                a = 0;
            }
            else
            {
                a = Convert.ToInt32(tipPercentTextBox.Text);
            }
            int val = increaseVal(a);
            tipPercentTextBox.Text = val.ToString();
        }

        private void leftNoPerson_Click(object sender, EventArgs e)
        {
            int b;
            if (String.IsNullOrEmpty(noPersonTextBox.Text))
            {
                b = 0;
            }
            else
            {
                b = Convert.ToInt32(noPersonTextBox.Text);
            }
            int val = decreaseVal(b);
            noPersonTextBox.Text = val.ToString();
        }

        private void rightNoPerson_Click(object sender, EventArgs e)
        {
            int b;
            if (String.IsNullOrEmpty(noPersonTextBox.Text))
            {
                b = 0;
            }
            else
            {
                b = Convert.ToInt32(noPersonTextBox.Text);
            }
            int val = increaseVal(b);
            noPersonTextBox.Text = val.ToString();
        }

        public int increaseVal(int b)
        {
            b += 1;
            return b;
        }

        public int decreaseVal(int b)
        {

            if (b > 0)
            {
                b -= 1;
                return b;
            }
            return 0;
        }

        
        private void billAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                messageLabel.Text = "Enter valid input.";
            }
           
        }

        private void tipTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkValue(sender, e);
        }

        private void noPersonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkValue(sender, e);
        }

        public void checkValue(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                messageLabel.Text = "Enter valid input.";
            }
        }

        private void tipPercentTextBox_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void noPersonTextBox_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        public void calculate()
        {
            double bill;
            if(String.IsNullOrEmpty(billAmountTextBox.Text))
            {
                bill = 0;
            }
            else
            {
                bill = double.Parse(billAmountTextBox.Text);
            }

            int tipPercent;
            if (String.IsNullOrEmpty(tipPercentTextBox.Text))
            {
                tipPercent = 0;
            }
            else
            {
                tipPercent = Convert.ToInt32(tipPercentTextBox.Text);
            }

            int noPerson;
            if (String.IsNullOrEmpty(noPersonTextBox.Text))
            {
                noPerson = 0;
            }
            else
            {
                noPerson = Convert.ToInt32(noPersonTextBox.Text);
            }
            if (bill > 0)
            {
                double tipAmount = 0;
                double totalAmount = 0;
                if (bill > 0 && tipPercent >= 0 && noPerson > 0)
                {
                    tipAmount = ((bill * tipPercent) / 100) / noPerson;
                    totalAmount = (bill / noPerson) + tipAmount;
                    totalAmountLabel.Text = totalAmount.ToString("C2");
                    tipAmountLabel.Text = tipAmount.ToString("C2");
                    messageLabel.Text = "";
                }
                if (noPerson == 0)
                {
                    messageLabel.Text = "Select no. of people.";
                    totalAmountLabel.Text = 0.ToString("C2");
                    tipAmountLabel.Text = 0.ToString("C2");
                }
            }
            else
            {
                messageLabel.Text = "Enter bill amount.";
            }

        }

        private void billAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }
    }


}