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
        string num1String;
        int num2;
        string num2String;
        string operatorInput = "";
        Boolean isOperatorSelected = false;
        float output;
        Boolean calculationCompleted = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getInputAndDisplay(1);
        }

        private void getInputAndDisplay(int a)
        {
            if (calculationCompleted == true)
            {
                calculationCompleted = false;
                clearInputAndOutput();
            }
            if (isOperatorSelected)
            {
                textBox1.Text = "";
                num2String += a;
                textBox1.Text += a;
            } else
            {
                num1String += a;
                textBox1.Text += a;
            }
        }

        private void getInputAndDisplay(string a)
        {
            textBox1.Text += a;
            if (!isOperatorSelected && num1String != "")
            {
                operatorInput += a;
                isOperatorSelected = true;
            }
            else if (num1String == "")
            {
                MessageBox.Show("Please enter some numbers before selecting an operator.");
            }
            else
            {
                MessageBox.Show("An operator has already been selected, please press '=' or continue entering numbers.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getInputAndDisplay(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getInputAndDisplay(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getInputAndDisplay(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            getInputAndDisplay(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            getInputAndDisplay(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            getInputAndDisplay(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            getInputAndDisplay(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            getInputAndDisplay(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            getInputAndDisplay(0);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            getInputAndDisplay("+");
            operatorInput = "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            getInputAndDisplay("-");
            operatorInput = "-";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            getInputAndDisplay("x");
            operatorInput = "x";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            getInputAndDisplay("/");
            operatorInput = "/";
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            if (num1String != "" && num2String != "" && operatorInput != "")
            {
                num1 = Int32.Parse(num1String);
                num2 = Int32.Parse(num2String);
                if (operatorInput.Equals("-"))
                {
                    output = num1 - num2;
                }
                else if (operatorInput.Equals("+"))
                {
                    output = num1 + num2;
                }
                else if (operatorInput.Equals("x"))
                {
                    output = num1 * num2;
                }
                else if (operatorInput.Equals("/"))
                {
                    output = (float) num1 / num2;
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
            num2String = "";
            num1 = 0;
            num2 = 0;
            textBox1.Text = "";
            operatorInput = "";
            isOperatorSelected = false;
        }
    }
}
