using System;
using System.IO;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        private enum PasteModes { BeforeSelection, AfterSelection, OverSelection }



        public Form1()
        {
            InitializeComponent();
            NewDocumentNumber = 1;
            TheTextFileName = "Document1.txt";
            OriginalFileText = "";
            Text = string.Format("{0} - {1}", FormName, TheTextFileName);
            NewDocument = true;
            SavedOK = false;
            PasteMode = PasteModes.OverSelection;
        }

        // The main window caption
        private const string FormName = "A Simple Text Editor";
        // The path/filename of the currently displayed text file
        private string TheTextFileName;
        // The text displayed in the TextBox before any editing
        private string OriginalFileText;
        // Flag to show that the document is new so even clicking save will invoke SaveAs
        private bool NewDocument;
        // Integer starting from 1 to append to Document when clicking New
        private int NewDocumentNumber;
        // Flag to indicate that the document has been saved and thus the application can close
        private bool SavedOK;       
        private PasteModes  PasteMode;


        private void ExitMenu1_Click(object sender, EventArgs e)
        {               
            Close();
        }

        // Updates the caption of the window to display current filename with path
        // and optional * depending on if text has changed since last saved
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

        // Displays the file open dialogue window and allows user to select a text file to open
        // The file is the read in to the OriginalFileText string and copies that to the main text box
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
                    UpdateFormCaption();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        // Updates the display of the number of lines and characters in the status bar
        // plus compares the original contents of the text box with the changes to determine if it has been modified
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            NumberOfLines.Text = string.Format("{0} Lines", TextBox1.Lines.Length.ToString());
            NumberOfCharacters.Text = string.Format("{0} Characters",TextBox1.TextLength.ToString());
            TextBox1.Modified = !TextBox1.Text.Equals(OriginalFileText);
        }

        private void ToolbarMenu1_Click(object sender, EventArgs e)
        {
            toolStripContainer1.TopToolStripPanel.Visible = !ToolbarMenu1.Checked;
            ToolbarMenu1.Checked = !ToolbarMenu1.Checked;
        }

        /// <summary>
        /// Displays the file save dialogue window and allows the user to select where to save the text file
        /// Writes the text of the text box to the named text file, copies the contents of the text box to
        /// OriginalFileText, sets the Modified flag to false, no longer a new unknown document so sets
        /// NewDocument to flase, updates the window caption to show the filename
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    NewDocument = false;
                    TheTextFileName = SaveFileDialog1.FileName;
                    UpdateFormCaption();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }    
            }            
        }

        
        // Check if it is a new document and if it is pass the saving to the save as instead
        // If it is not the it writes the current text to the current filename, copies the
        // contents of the text box to OriginalFileText, sets the Modified flag to false
        // Updates the window caption to show the filename
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
            SaveMenu1.Enabled = TextBox1.Modified;
        }

        private void NewMenu1_Click(object sender, EventArgs e)
        {
            NewDocumentNumber++;
            TheTextFileName=string.Format("Document{0}.txt",NewDocumentNumber);
            OriginalFileText = "";
            TextBox1.Clear();
            NewDocument = true;
            TextBox1.Modified = false;
            UpdateFormCaption();
        }

        // Displays a warning if the current document text has been modified and trying to close the application
        // Gives option to save, close without saving or cancel the close
        // If user chooses Yes to save, the the save method is called and the SavedOK flag checked to see if the
        // save was successful
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TextBox1.Modified)
            {
                DialogResult MR;
                MR = MessageBox.Show("Current document is not saved. Save now?",
                                    "Warning",
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Warning);

                if (MR==DialogResult.Yes)
                {
                    SaveMenu1.PerformClick();
                    if (!SavedOK)
                    {
                        e.Cancel = true;
                    }    
                }
                else if (MR==DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Copy1_Click(object sender, EventArgs e)
        {
            if (TextBox1.SelectionLength > 0)
            {
                TextBox1.Copy();
            }
        }

        private void Cut1_Click(object sender, EventArgs e)
        {
            if (TextBox1.SelectionLength > 0)
            {
                TextBox1.Cut();
            }
        }

        private void Paste1_Click(object sender, EventArgs e)
        {
            // Determine if there is any text in the Clipboard to paste into the text box.
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                // Determine if any text is selected in the text box.
                if (TextBox1.SelectionLength > 0)
                {
                    // Save selection start point and selction length
                    int SelStart = TextBox1.SelectionStart;
                    int SelLength = TextBox1.SelectionLength;
                    switch (PasteMode)
                    {
                        case PasteModes.BeforeSelection:
                            // Turn off the selection, paste clipboard text then re-show selection
                            // in corrected position after adding the text
                            TextBox1.DeselectAll();
                            TextBox1.Paste();
                            TextBox1.SelectionStart = SelStart + Clipboard.GetText().Length;
                            TextBox1.SelectionLength = SelLength;
                            break;
                        case PasteModes.AfterSelection:
                            // Turn of the selection to prevent it getting overwritten, paste clipboard
                            // text, then set selection back to how it was
                            TextBox1.DeselectAll();
                            TextBox1.SelectionStart = SelStart + SelLength;
                            TextBox1.Paste();
                            TextBox1.SelectionStart = SelStart;
                            TextBox1.SelectionLength = SelLength;
                            break;
                        case PasteModes.OverSelection:
                            TextBox1.Paste();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    TextBox1.Paste();
                }
            }
        }

        private void PasteBeforeMenu1_Click(object sender, EventArgs e) => PasteMode = PasteModes.BeforeSelection;

        private void PasteAfterMenu1_Click(object sender, EventArgs e) => PasteMode = PasteModes.AfterSelection;

        private void PasteOverMenu1_Click(object sender, EventArgs e) => PasteMode = PasteModes.OverSelection;

        private void TextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            CopyToolStripButton.Enabled = CutToolStripButton.Enabled = (TextBox1.SelectionLength > 0);
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            CopyToolStripButton.Enabled = CutToolStripButton.Enabled = (TextBox1.SelectionLength > 0);
        }

        private void TextBox1_MouseEnter(object sender, EventArgs e)
        {
            PasteToolStripButton.Enabled = (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text));
        }

        private void toolStripContainer1_TopToolStripPanel_MouseEnter(object sender, EventArgs e)
        {
            PasteToolStripButton.Enabled = (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text));
        }

        private void Edit1_DropDownOpening(object sender, EventArgs e)
        {
            Paste1.Enabled = (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text));
            Cut1.Enabled = Copy1.Enabled = (TextBox1.SelectionLength > 0);
        }

        private void SelectAll1_Click(object sender, EventArgs e)
        {
            TextBox1.SelectAll();
            CopyToolStripButton.Enabled = CutToolStripButton.Enabled = (TextBox1.SelectionLength > 0);
        }

        private void PasteModesToolMenu1_DropDownOpening(object sender, EventArgs e)
        {
            PasteBeforeMenu1.Checked = (PasteMode == PasteModes.BeforeSelection);
            PasteAfterMenu1.Checked = (PasteMode == PasteModes.AfterSelection);
            PasteOverMenu1.Checked = (PasteMode == PasteModes.OverSelection);
        }

        private void Undo1_Click(object sender, EventArgs e)
        {
            if (TextBox1.CanUndo)
            {
                TextBox1.Undo();
            }
        }
    }
}
