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


        // This method generates a consistent file path forInitialDirectory
        // to use. This method is called by BtnOpen and BtnSave.
        private string GetFilePath()
        {
            string filePathRel = @"..\..\Notes Folder\";
            string filePathFull = Path.GetFullPath(Path.Combine(Application.StartupPath, filePathRel));

            return filePathFull;
        }



        private void ReadNote(string readFilePath)
        {
            if (File.Exists(readFilePath))
            {
                using (StreamReader readFile = new StreamReader(readFilePath))
                {
                    RtbNoteMain.Text = File.ReadAllText(readFilePath);
                }
            }
        }



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



        private void WriteNote(string writeFilePath)
        {
            string rtbText = RtbNoteMain.Text;

            using (StreamWriter writeFile = new StreamWriter(writeFilePath))
            {
                writeFile.Write(rtbText, writeFilePath);
            }
        }



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



    }



}
