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

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            string filePathRel = @"..\..\Notes Folder\";
            string filePathFull = Path.GetFullPath(Path.Combine(Application.StartupPath, filePathRel));
            

            OpenFileDialog openTxtFile = new OpenFileDialog();
            openTxtFile.Title = "Open Text file";
            openTxtFile.Filter = "Text files|*.txt";
            openTxtFile.InitialDirectory = filePathFull;

            if (openTxtFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ReadNote(openTxtFile.FileName);
                }
                catch
                {
                    MessageBox.Show("Error, unable to load file.", "Error");
                    return;
                }
            }
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

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void WriteNote(string writeFilePath)
        {
            string rtbText = RtbNoteMain.Text;

            //using (StreamWriter writeFile = new StreamWriter(writeFilePath)
            //{
                
            //    writeFile.Write(rtbText);
            //}
        }
    }
}
