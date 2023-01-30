using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class notePad : Form
    {
        public notePad()
        {
            InitializeComponent();
        }

        private string file = "";

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = printDialog.ShowDialog();
            if (dr == DialogResult.OK) 
            { 

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textArea_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "Character count: " + textArea.Text.Length;

            string[] words = textArea.Text.Split(' ');
            label5.Text = "Word count: " + words.Length;

            textArea.WordWrap = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();
            openFileDialog.Filter = "txt|*.mytxt";
            if(dr == DialogResult.OK)
            {
                StreamReader read = new StreamReader(openFileDialog.FileName);
                read.Close();
                file = openFileDialog.FileName;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog.ShowDialog();
            saveFileDialog.Filter = "txt|*.mytxt";
            if (dr == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(saveFileDialog.FileName);
                write.Write(textArea.Text);
                write.Close();
                file = openFileDialog.FileName;
            }

            else 
            {
                try
                {
                    StreamWriter write = new StreamWriter(saveFileDialog.FileName);
                    write.Write(textArea.Text);
                    write.Close();
                    file = openFileDialog.FileName;
                }
                catch
                { 
                
                }
            }
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notePad n = new notePad();
            n.Show();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textArea.CanUndo == true)
            {
                textArea.Undo();
            
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textArea.CanRedo == true)
            {
                textArea.Redo();

            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textArea.SelectedText != "") ;
            {
                textArea.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textArea.SelectionLength > 0 ) ;
            {
                textArea.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)==true) ;
            {
                textArea.Paste();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.SelectedText = "";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textArea.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textArea.Font = fontDialog1.Font;
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {

        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.WordWrap = true;
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textArea.WordWrap = false;
        }

        private void onToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            textArea.BackColor = Color.FromArgb(34, 36, 49);
            textArea.ForeColor = Color.White;
        }

        private void offToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textArea.BackColor = Color.White;
            textArea.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calTool_Click(object sender, EventArgs e)
        {
            Calculator log = new Calculator();
            log.Show();
        }
    }
}
