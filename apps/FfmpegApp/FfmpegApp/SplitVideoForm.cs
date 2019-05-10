using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FfmpegApp.Models;
using MediaToolkit;

namespace FfmpegApp
{
    public partial class SplitVideoForm : Form
    {
        public SplitVideoForm()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtInputFile.Text = openFileDialog1.FileName;
            }
        }

        private void SplitButton_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt16(startTextBox.Text);
            int end = Convert.ToInt16(endTextBox.Text);
            string outputFilename = $@"{txtOutputFolder.Text}\{outputFileNameTextBox.Text}{extensionComboBox.Text}";
            string command = $"-i \"{txtInputFile.Text}\" -ss {start} -t {end} \"{outputFilename}\"";

            FfmpegHandler.ExecuteFFMpeg(command);

            Process.Start("explorer.exe", "/select, \"" + txtOutputFolder.Text + "\"");

            Application.Exit();
        }

    
        private void FolderOpenButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Environment.CurrentDirectory;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOutputFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
