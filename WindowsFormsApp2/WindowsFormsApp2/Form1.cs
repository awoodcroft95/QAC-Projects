using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            int a, b, c;
            a = Int32.Parse(textBox1.Text);
            b = Int32.Parse(textBox2.Text);
            c = a + b;
            textBox3.Text = c.ToString();
        }
    }
}
