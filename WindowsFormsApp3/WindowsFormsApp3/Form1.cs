using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Boolean isMaxWidth = false;
        Boolean isMinWidth = true;
        int startWidth;
        public Form1()
        {
            InitializeComponent();
            startWidth = this.textBox1.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isMaxWidth && isMinWidth)
            {
                if (textBox1.Width >= this.Width - 100)
                {
                    this.Text = "Maximum width reached";
                    isMaxWidth = true;
                    isMinWidth = false;
                }
                else
                {
                    textBox1.Width += 10;
                }
            }
            else if (!isMinWidth && isMaxWidth)
            {
                if (textBox1.Width <= startWidth)
                {
                    this.Text = "Minimum width reached";
                    isMaxWidth = false;
                    isMinWidth = true;
                }
                else
                {
                    textBox1.Width -= 10;
                }
            }
        }
    }
}
