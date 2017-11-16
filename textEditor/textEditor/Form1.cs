using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textEditor
{
    public partial class textEditorForm : Form
    {
        private bool hasBeenLoaded = false;
        private string fileName;
        private bool hasBeenChanged = false;

        public textEditorForm()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            richTB.Height = this.Height - 80;
            richTB.Width = this.Width - 40;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                richTB.LoadFile(openFileDialog.FileName);
                hasBeenLoaded = true;
                fileName = openFileDialog.FileName;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hasBeenChanged)
            {
                if (messageBoxOnExit())
                {
                    hasBeenLoaded = false;
                    hasBeenChanged = false;
                    richTB.Text = "";
                    fileName = "";
                }
                else
                {
                    //do nothing
                }
            }
            else
            {
                richTB.Text = "";
            }
        }

        private void richTB_TextChanged(object sender, EventArgs e)
        {
            hasBeenChanged = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (messageBoxOnExit())
            {
                Application.Exit();
            }
        }

        public void saveAs()
        {
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                richTB.SaveFile(saveFileDialog.FileName);
            }
        }

        public void save()
        {
            if (hasBeenLoaded)
            {
                richTB.SaveFile(fileName);
            }
            else
            {
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    richTB.SaveFile(saveFileDialog.FileName);
                }
            }
        }

        private bool messageBoxOnExit()
        {
            DialogResult messageBoxResult;
            if (fileName != "")
            {
                messageBoxResult = MessageBox.Show("Do you want to save changes made to" + fileName + "?", "Save File?", MessageBoxButtons.YesNoCancel);
            }
            else
            {
                messageBoxResult = MessageBox.Show("Do you want to save your file?", "Save File?", MessageBoxButtons.YesNoCancel);
            }
            if (messageBoxResult == DialogResult.Yes)
            {
                save();
                return true;
            }
            else if (messageBoxResult == DialogResult.No)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            richTB.SelectionColor = colorDialog.Color;
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowDialog();
            richTB.SelectionFont = fontDialog1.Font;
            richTB.SelectionColor = fontDialog1.Color;
        }
    }
}
