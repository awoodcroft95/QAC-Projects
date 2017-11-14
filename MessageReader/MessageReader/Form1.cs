using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageReader
{
    public partial class Form1 : Form
    {
        string input;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            input = textBox1.Text;
            if (radioButton1.Checked)
            {
                string[] inputArray = input.Split(' ');
                textBox2.Text = inputArray.Length.ToString();
            }
            else if (radioButton2.Checked)
            {
                foreach (Char c in input)
                {
                    if (Char.IsUpper(c))
                    {
                        textBox2.Text += c;
                    }
                }
            }
            else if (radioButton3.Checked)
            {
                foreach (Char c in input)
                {
                    if (Char.IsLower(c))
                    {
                        textBox2.Text += c;
                    }
                }
            }
            else if (radioButton4.Checked)
            {
                foreach (Char c in input)
                {
                    if (Char.IsDigit(c))
                    {
                        textBox2.Text += c;
                    }
                }
            }
            else if (radioButton5.Checked)
            {
                foreach (Char c in input)
                {
                    if (!Char.IsLetterOrDigit(c))
                    {
                        textBox2.Text += c;
                    }
                }
            }
        }
    }
}
