using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealCalculator
{
    public partial class Calculator : Form
    {
        int num1;
        string num1String = "";
        int num2;
        string num2String = "";
        string operatorInput = "";
        Boolean isOperatorSelected = false;
        float output;
        Boolean calculationCompleted = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void numberClicked(Object b, EventArgs e)
        {
            Button btn = (Button)b;
            if (calculationCompleted == true)
            {
                calculationCompleted = false;
                clearInputAndOutput();
            }
            if (isOperatorSelected)
            {
                textBox1.Text = "";
                textBox1.Text += btn.Text;
            }
            else
            {
                textBox1.Text += btn.Text;
            }

        }

        private void signClicked(Object b, EventArgs e)
        {
            Button btn = (Button)b;
            if (!isOperatorSelected && textBox1.Text != "")
            {
                num1String = textBox1.Text;
                operatorInput += btn.Text;
                isOperatorSelected = true;
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter some numbers before selecting an operator.");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("An operator has already been selected, please press '=' or continue entering numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
        private void buttonEq_Click(object sender, EventArgs e)
        {
            if (num1String != "" && textBox1.Text != "" && operatorInput != "")
            {
                num1 = Int32.Parse(num1String);
                num2 = Int32.Parse(textBox1.Text);
                if (operatorInput.Equals("-"))
                {
                    output = num1 - num2;
                }
                else if (operatorInput.Equals("+"))
                {
                    output = num1 + num2;
                }
                else if (operatorInput.Equals("*"))
                {
                    output = num1 * num2;
                }
                else if (operatorInput.Equals("/"))
                {
                    output = (float)num1 / num2;
                }
                textBox1.Text = "" + output;
                calculationCompleted = true;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearInputAndOutput();
        }

        public void clearInputAndOutput()
        {
            num1String = "";
            num1 = 0;
            num2 = 0;
            textBox1.Text = "";
            operatorInput = "";
            isOperatorSelected = false;
        }
    }
}