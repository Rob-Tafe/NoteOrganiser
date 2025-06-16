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
using System.Runtime.Remoting.Messaging;



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
        } // End of GetFilePath method.


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
        } // End of ReadNote method.


        // This method allows a user to open a text file for reading and
        // modifying. It calls the ReadNote method.
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openTextFile = new OpenFileDialog();
            openTextFile.Title = "Open Text file";
            openTextFile.Filter = "Text files|*.txt";
            openTextFile.InitialDirectory = GetFilePath();

            if (openTextFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ReadNote(openTextFile.FileName);
                }
                catch
                {
                    MessageBox.Show("Error, unable to load file.", "Error (BtnOpen_Click Method)");
                    return;
                }
            }
        } // End of BtnOpen method.


        // This method is responsible for writing the contents of the RtbNote
        // rich textbox to a text file.
        private void WriteNote(string writeFilePath)
        {
            string rtbText = RtbNote.Text;

            using (StreamWriter writeFile = new StreamWriter(writeFilePath))
            {
                writeFile.Write(rtbText, writeFilePath);
            }
        } // End of WriteNote method.


        // This method allows a user to save the contents of the RtbNote rich
        // textbox to a text file. It calls the WriteNote method.
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveTextFile = new SaveFileDialog();
            saveTextFile.Title = "Save Text file";
            saveTextFile.Filter = "Text files|*.txt";
            saveTextFile.InitialDirectory = GetFilePath();

            if (saveTextFile.ShowDialog() == DialogResult.OK)
            {
                
                try
                {
                    WriteNote(saveTextFile.FileName);
                }
                catch
                {
                    MessageBox.Show("Error, unable to save file.", "Error (BtnSave_Click Method)");
                    return;
                }
            }
        } // End of BtnSave method.


        // AutoNewLine method. This method will automatically add line break when
        // the user has reached a specific length on a line, and only when the user
        // presses the spacebar.
        private void AutoNewLine(object sender, KeyPressEventArgs e)
        {
            int cursorIndex = RtbNote.SelectionStart;
            int cursorCurrLine = RtbNote.GetLineFromCharIndex(cursorIndex);
            int currLineStart = RtbNote.GetFirstCharIndexFromLine(cursorCurrLine);

            int currLineCursorIndex = cursorIndex - currLineStart;

            if ((currLineCursorIndex >= 89) && (e.KeyChar == ' '))
            {
                SendKeys.Send("{BackSpace}");
                SendKeys.Send("{Enter}");
            }
        } // End of AutoNewLine method.


        // Save shortcut method. This method should save the current file when the hotkey combo
        // 'Ctrl' + 'S' is pressed.
        private void HotkeySave(object sender, KeyEventArgs e)
        {
            string fileNameForHkSave = "Default HK Save.txt";

            if ((e.Control) && (e.KeyCode == Keys.S)) {
                MessageBox.Show("Key combo working!");
            }
        }


    }


}
