using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiWindowMaths
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        float output;
        Boolean hasOutput = false;
        MathsOutput outputWindow;

        public Form1()
        {
            InitializeComponent();
            outputWindow = new MathsOutput();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Int32.Parse(textBox1.Text);
            num2 = Int32.Parse(textBox2.Text);
            if (this.radioButton1.Checked)
            {
                output = num1 + num2;
                hasOutput = true;
            }
            else if (this.radioButton2.Checked)
            {
                output = num1 - num2;
                hasOutput = true;
            }
            else if (this.radioButton3.Checked)
            {
                output = num1 * num2;
                hasOutput = true;
            }
            else if (this.radioButton4.Checked)
            {
                output = (float)num1 / num2;
                hasOutput = true;
            }
            else
            {
                MessageBox.Show("Please select and operation.");
                hasOutput = false;
            }
            if (hasOutput)
            {
               outputWindow.showMe(output);
            }
        }
    }
}
