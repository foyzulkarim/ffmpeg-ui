using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FfmpegApp.Models;
using MediaToolkit;
using MediaToolkit.Model;

namespace FfmpegApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private string OutputType { get; set; }
        private Button lastClickedButton = null;

        private async void convertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OutputType))
            {
                MessageBox.Show("Please select output format");
            }
            else
            {
                
                var inputFilePath = txtInputFile.Text;
                var fileName = Path.GetFileNameWithoutExtension(inputFilePath);
                string outputFilePath = txtOutputFolder.Text + $"\\{fileName}-{DateTime.Now.Ticks}." + OutputType;

                var conversionFileDetails = new ConvertFileDetails
                {
                    InputFilePath = inputFilePath,
                    OutputFilePath = outputFilePath
                };

                Task<string> conversionTask = new Task<string>(() => FfmpegHandler.ConvertFile(conversionFileDetails, ConvertProgressEvent,ConversionCompleteEvent));
                conversionTask.Start();
                DisableActionButtons();


                MessageBox.Show("Conversion in progress please wait...");
                var result = await conversionTask;
                MessageBox.Show("File conversion completed.");
                EnableActionButtons();

                //LaunchCommandLineApp(txtInputFile.Text, output);

            }
            
        }

        private void ConvertProgressEvent(object sender, MediaToolkit.ConvertProgressEventArgs e)
        {
            pbFileConversion.Invoke(new Action(() =>
            {
                pbFileConversion.Value = (int)(e.ProcessedDuration.TotalMilliseconds / e.TotalDuration.TotalMilliseconds * 100);
            }));

        }

        private void ConversionCompleteEvent(object sender, ConversionCompleteEventArgs e)
        {
            pbFileConversion.Invoke(new Action(() =>
            {
                pbFileConversion.Value = 0;
            }));
        }


        private void DisableActionButtons()
        {
            convertButton.Enabled = folderOpenButton.Enabled = openFileButton.Enabled = false;
        }

        private void EnableActionButtons()
        {
            convertButton.Enabled = folderOpenButton.Enabled = openFileButton.Enabled = true;
        }

        private void LaunchCommandLineApp(string input, string outputFile)
        {
            FfmpegHandler.ExecuteFFMpeg($"-i \"{input}\" \"{outputFile}\"");
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtInputFile.Text = openFileDialog1.FileName;
            }
        }

        private void folderOpenButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Environment.CurrentDirectory;
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                txtOutputFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SetOutputType(string outputType, Button btnSelectedType)
        {
            this.OutputType = outputType;

            btnSelectedType.BackColor = Color.Crimson;

            // Revert the background color of the previously-colored button, if any
            if (lastClickedButton != null)
                lastClickedButton.BackColor = Color.DimGray;

            // Update the previously-colored button
            lastClickedButton = btnSelectedType;
        }

        private void btnToAvi_Click(object sender, EventArgs e)
        {
            SetOutputType("avi", (Button)sender);            
        }

        private void btnToMp4_Click(object sender, EventArgs e)
        {
            SetOutputType("mp4", (Button)sender);
        }

        private void btnToMPEG_Click(object sender, EventArgs e)
        {
            SetOutputType("mpeg", (Button)sender);
        }

        private void btnToWmv_Click(object sender, EventArgs e)
        {
            SetOutputType("wmv", (Button)sender);
        }

        private void btnToFlv_Click(object sender, EventArgs e)
        {
            SetOutputType("flv", (Button)sender);
        }

        private void btnToMp3_Click(object sender, EventArgs e)
        {
            SetOutputType("mp3", (Button)sender);
        }  

       

        
    }
}
