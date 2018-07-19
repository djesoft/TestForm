using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TheTextFileName = "Document1.txt";
            OriginalFileText = "";
            Text = string.Format("{0} - {1}", FormName, TheTextFileName);
            NewDocument = true;
        }


        private const string FormName = "A Simple Text Editor";
        private string TheTextFileName;
        private string OriginalFileText;
        private bool NewDocument;



        private void ExitMenu1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateFormCaption()
        {
            if (TextBox1.Modified)
            {
                Text = string.Format("{0} - {1} *", FormName, TheTextFileName);
            }
            else
            {
                Text = string.Format("{0} - {1}", FormName, TheTextFileName);
            }
        }

        private void OpenMenu1_Click(object sender, EventArgs e)
        {

            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    OriginalFileText= File.ReadAllText(OpenFileDialog1.FileName);
                    TextBox1.Text = OriginalFileText;
                    
                    TheTextFileName = OpenFileDialog1.FileName;
                    NewDocument = false;
                    //Text = string.Format("{0} - {1}", FormName, TheTextFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            NumberOfLines.Text = string.Format("{0} Lines", TextBox1.Lines.Length.ToString());
            NumberOfCharacters.Text = string.Format("{0} Characters",TextBox1.TextLength.ToString());
            TextBox1.Modified = (OriginalFileText != TextBox1.Text);
        }

        private void ToolbarMenu1_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
            ToolbarMenu1.Checked = toolStrip1.Visible;
        }

        private void SaveAsMenu1_Click(object sender, EventArgs e)
        {
            SaveFileDialog1.FileName = TheTextFileName;
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {


                try
                {
                    File.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text);
                    OriginalFileText = TextBox1.Text;
                    TextBox1.Modified = false;
                    UpdateFormCaption();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
                
            }
            
        }

        private void SaveMenu1_Click(object sender, EventArgs e)
        {
            if (NewDocument)
            {
                SaveAsMenu1.PerformClick();
            }
            else
            {
                try
                {
                    File.WriteAllText(TheTextFileName, TextBox1.Text);
                    OriginalFileText = TextBox1.Text;
                    TextBox1.Modified = false;

                    UpdateFormCaption();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
        }

        private void TextBox1_ModifiedChanged(object sender, EventArgs e)
        {
            UpdateFormCaption();
            SaveToolStripButton.Enabled = TextBox1.Modified;
        }
    }
}
