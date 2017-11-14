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
    public partial class MathsOutput : Form
    {
        public MathsOutput()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void showMe(float result)
        {
            this.textBox1.Text = result.ToString();
            this.Show();
        }
    }
}
