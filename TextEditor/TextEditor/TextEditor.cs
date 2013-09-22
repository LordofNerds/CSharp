using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text; 
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }
        #region Editor & General
        #endregion

        #region MainMenu
        #endregion

        #region ToolBar
        #endregion

        #region ContextMenu
        #endregion

        #region Methods
        #endregion

        #region file

        // The Code for a new document. File>New
        void New()
        {
            Document.Clear();
        }

        // The Code for opening a new document. Done as plaintext. File>Open
        void Open()
        {
            if (openWork.ShowDialog() == DialogResult.OK)
            {
                HtmlDocument.LoadFile(openWork.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        //The code for saving the file. Done as plaintext. File>Save
        void Save()
        {
            if (saveWork.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document.SaveFile(saveWork.FileName, RichTextBoxStreamType.PlainText);

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //The code for exiting the program
        void Exit()
        {
            Application.Exit();
        }

        #endregion

        #region edit

        void Undo()
        {
            Document.Undo();
        }

        void Redo()
        {
            Document.Redo();
        }

        void Cut()
        {
            Document.Cut();
        }


        void Copy()
        {
            Document.Copy();
        }

        void Paste()
        {
            Document.Paste();
        }

        void SelectAll()
        {
            Document.SelectAll();
        }

        void ClearAll()
        {
            Document.Clear();
        }


        #endregion

        #region tools

        // Brings up a colour Dialog which allows the user to change the background of mainMenu, Status & Tools.
        void customise()
        {
            ColorDialog myDialog = new ColorDialog();

            if(myDialog.ShowDialog() == DialogResult.OK)
            {
                mainMenu.BackColor = myDialog.Color;
                Status.BackColor = myDialog.Color;
                Tools.BackColor = myDialog.Color;
            }
        }




        #endregion


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void saveWork_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void file_New_Click(object sender, EventArgs e)
        {
            New();
        }

        private void file_Open_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void file_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void edit_Undo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void edit_Redo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void edit_Cut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void edit_Copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void edit_Paste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void tools_Customisation_Click(object sender, EventArgs e)
        {
            customise();
        }

        private void rcMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void tb_New_Click(object sender, EventArgs e)
        {
            New();
        }

        private void tb_Open_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void tb_Save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void tb_Cut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void tb_Copy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void tb_Paste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void tb_ZoomIn_Click(object sender, EventArgs e)
        {
            if (Doument.ZoomFactor == 63)
            {
                return;
            }
            else
            {
                Document.ZoomFactor = Document.ZoomFactor + 1;
            }
        }

        private void tb_ZoomOut_Click(object sender, EventArgs e)
        {
            if (Doument.ZoomFactor == 1)
            {
                return;
            }
            else
            {
                Document.ZoomFactor = Document.ZoomFactor - 1;
            }
        }

        private void tb_Bold_Click(object sender, EventArgs e)
        {
            Font bfont = new Font(Document.Font, FontStyle.Bold);
            Font rfont = new Font(Document.Font, FontStyle.Regular);


            //If no text is selected
            if (Document.SelectedText.Length == 0)
            {
                return;
            }
            if (Document.SelectionFont.Bold)
            {
                Document.SelectionFont = rfont;
            }
            else
            {
                Document.SelectionFont = bfont;
            }
        }

        private void tb_Italics_Click(object sender, EventArgs e)
        {
            Font Ifont = new Font(Document.Font, FontStyle.Italic);
            Font rfont = new Font(Document.Font, FontStyle.Regular);
            if (Document.SelectedText.Length == 0)
            {
                    return;
            }
            if (Document.SelectionFont.Italic)
            {
                    Document.SelectionFont = rfont;
            }
            else
            {
                Document.SelectionFont = Ifont;
            }
        }

        

       
    }
}
