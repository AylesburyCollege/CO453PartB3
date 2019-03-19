using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453PartB3
{
    public partial class MyWordForm : Form
    {
        public MyWordForm()
        {
            InitializeComponent();
        }

        private void CutText(object sender, EventArgs e)
        {
            mainRichTextBox.Cut();
        }

        private void PasteText(object sender, EventArgs e)
        {
            mainRichTextBox.Paste();
        }

        private void CopyText(object sender, EventArgs e)
        {
            mainRichTextBox.Copy();
        }

        private void UndoOperation(object sender, EventArgs e)
        {
            mainRichTextBox.Undo();
        }

        private void SelectBackColor(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            mainRichTextBox.BackColor = colorDialog1.Color;
        }

        private void SelectFont(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            mainRichTextBox.SelectionFont = fontDialog1.Font;
        }

        private void OpenFile(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            mainRichTextBox.LoadFile(openFileDialog1.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Rich Text Format (*.rtf)";
            saveFileDialog1.FileName = "Document1";
            saveFileDialog1.ShowDialog();
            mainRichTextBox.SaveFile(saveFileDialog1.FileName);
        }
    }
}
