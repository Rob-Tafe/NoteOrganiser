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



namespace NoteOrganiser
{


    public partial class NoteOrganiser : Form
    {


        public NoteOrganiser()
        {
            InitializeComponent();
        }


        // This method generates a consistent file path for InitialDirectory
        // to use. This method is called by BtnOpen and BtnSave.
        private string GetFilePath()
        {
            string filePathRel = @"..\..\Notes Folder\";
            string filePathFull = Path.GetFullPath(Path.Combine(Application.StartupPath, filePathRel));

            return filePathFull;
        }


        // This is the method that is responsible for reading a text file and
        // sending its contents to the RtbNote rich textbox.
        private void ReadNote(string readFilePath)
        {
            if (File.Exists(readFilePath))
            {
                using (StreamReader readFile = new StreamReader(readFilePath))
                {
                    RtbNote.Text = File.ReadAllText(readFilePath);
                }
            }
        }


        // This method allows a user to open a text file for reading and
        // modifying. It calls the ReadNote method.
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openTxtFile = new OpenFileDialog();
            openTxtFile.Title = "Open Text file";
            openTxtFile.Filter = "Text files|*.txt";
            openTxtFile.InitialDirectory = GetFilePath();

            if (openTxtFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ReadNote(openTxtFile.FileName);
                }
                catch
                {
                    MessageBox.Show("Error, unable to load file.", "Error (BtnOpen_Click Method)");
                    return;
                }
            }
        }


        // This method is responsible for writing the contents of the RtbNote
        // rich textbox to a text file.
        private void WriteNote(string writeFilePath)
        {
            string rtbText = RtbNote.Text;

            using (StreamWriter writeFile = new StreamWriter(writeFilePath))
            {
                writeFile.Write(rtbText, writeFilePath);
            }
        }


        // This method allows a user to save the contents of the RtbNote rich
        // textbox to a text file. It calls the WriteNote method.
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveTxtFile = new SaveFileDialog();
            saveTxtFile.Title = "Save Text file";
            saveTxtFile.Filter = "Text files|*.txt";
            saveTxtFile.InitialDirectory = GetFilePath();

            saveTxtFile.FileName = "Note.txt";

            if (saveTxtFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveTxtFile.FileName;
                try
                {
                    WriteNote(saveTxtFile.FileName);
                }
                catch
                {
                    MessageBox.Show("Error, unable to save file.", "Error (BtnSave_Click Method)");
                    return;
                }
            }
        }


        // AutoNewLine method. This method will automatically add line break when
        // the user has reached a specific length on a line, and only when the user
        // presses the spacebar.
        private void AutoNewLine(object sender, KeyEventArgs e)
        {
            int cursorIndex = RtbNote.SelectionStart;
            int cursorCurrLine = RtbNote.GetLineFromCharIndex(cursorIndex);
            int currLineStart = RtbNote.GetFirstCharIndexFromLine(cursorCurrLine);

            int currLineCursorIndex = cursorIndex - currLineStart;

            if ((currLineCursorIndex >= 90) && (e.KeyCode == Keys.Space))
            {
                MessageBox.Show("Here!");
            }
        }


    }


}
