namespace FfmpegApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.convertButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.folderOpenButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnToMp3 = new System.Windows.Forms.Button();
            this.btnToFlv = new System.Windows.Forms.Button();
            this.btnToWmv = new System.Windows.Forms.Button();
            this.btnToMPEG = new System.Windows.Forms.Button();
            this.btnToMp4 = new System.Windows.Forms.Button();
            this.btnToAvi = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbFileConversion = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTimePassed = new System.Windows.Forms.Label();
            this.vcTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(1023, 185);
            this.convertButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(112, 34);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(1023, 37);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(112, 34);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "Browse...";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input File Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInputFile
            // 
            this.txtInputFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInputFile.Location = new System.Drawing.Point(316, 38);
            this.txtInputFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.ReadOnly = true;
            this.txtInputFile.Size = new System.Drawing.Size(689, 26);
            this.txtInputFile.TabIndex = 3;
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOutputFolder.Location = new System.Drawing.Point(316, 127);
            this.txtOutputFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.ReadOnly = true;
            this.txtOutputFolder.Size = new System.Drawing.Size(689, 26);
            this.txtOutputFolder.TabIndex = 4;
            // 
            // folderOpenButton
            // 
            this.folderOpenButton.Location = new System.Drawing.Point(1023, 126);
            this.folderOpenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.folderOpenButton.Name = "folderOpenButton";
            this.folderOpenButton.Size = new System.Drawing.Size(112, 34);
            this.folderOpenButton.TabIndex = 5;
            this.folderOpenButton.Text = "Browse...";
            this.folderOpenButton.UseVisualStyleBackColor = true;
            this.folderOpenButton.Click += new System.EventHandler(this.folderOpenButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 10);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 52);
            this.panel2.TabIndex = 10;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Crimson;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1083, -3);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(55, 53);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1140, -3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 53);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "Video Converter";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.btnToMp3);
            this.panel3.Controls.Add(this.btnToFlv);
            this.panel3.Controls.Add(this.btnToWmv);
            this.panel3.Controls.Add(this.btnToMPEG);
            this.panel3.Controls.Add(this.btnToMp4);
            this.panel3.Controls.Add(this.btnToAvi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 95);
            this.panel3.TabIndex = 11;
            // 
            // btnToMp3
            // 
            this.btnToMp3.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToMp3.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnToMp3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnToMp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToMp3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToMp3.ForeColor = System.Drawing.Color.White;
            this.btnToMp3.Location = new System.Drawing.Point(525, 0);
            this.btnToMp3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToMp3.Name = "btnToMp3";
            this.btnToMp3.Size = new System.Drawing.Size(105, 95);
            this.btnToMp3.TabIndex = 17;
            this.btnToMp3.Text = "To MP3";
            this.btnToMp3.UseVisualStyleBackColor = true;
            this.btnToMp3.Click += new System.EventHandler(this.btnToMp3_Click);
            // 
            // btnToFlv
            // 
            this.btnToFlv.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToFlv.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnToFlv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnToFlv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToFlv.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToFlv.ForeColor = System.Drawing.Color.White;
            this.btnToFlv.Location = new System.Drawing.Point(420, 0);
            this.btnToFlv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToFlv.Name = "btnToFlv";
            this.btnToFlv.Size = new System.Drawing.Size(105, 95);
            this.btnToFlv.TabIndex = 16;
            this.btnToFlv.Text = "To FLV";
            this.btnToFlv.UseVisualStyleBackColor = true;
            this.btnToFlv.Click += new System.EventHandler(this.btnToFlv_Click);
            // 
            // btnToWmv
            // 
            this.btnToWmv.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToWmv.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnToWmv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnToWmv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToWmv.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToWmv.ForeColor = System.Drawing.Color.White;
            this.btnToWmv.Location = new System.Drawing.Point(315, 0);
            this.btnToWmv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToWmv.Name = "btnToWmv";
            this.btnToWmv.Size = new System.Drawing.Size(105, 95);
            this.btnToWmv.TabIndex = 15;
            this.btnToWmv.Text = "To WMV";
            this.btnToWmv.UseVisualStyleBackColor = true;
            this.btnToWmv.Click += new System.EventHandler(this.btnToWmv_Click);
            // 
            // btnToMPEG
            // 
            this.btnToMPEG.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToMPEG.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnToMPEG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnToMPEG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToMPEG.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToMPEG.ForeColor = System.Drawing.Color.White;
            this.btnToMPEG.Location = new System.Drawing.Point(210, 0);
            this.btnToMPEG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToMPEG.Name = "btnToMPEG";
            this.btnToMPEG.Size = new System.Drawing.Size(105, 95);
            this.btnToMPEG.TabIndex = 14;
            this.btnToMPEG.Text = "To MPEG";
            this.btnToMPEG.UseVisualStyleBackColor = true;
            this.btnToMPEG.Click += new System.EventHandler(this.btnToMPEG_Click);
            // 
            // btnToMp4
            // 
            this.btnToMp4.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToMp4.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnToMp4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnToMp4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToMp4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToMp4.ForeColor = System.Drawing.Color.White;
            this.btnToMp4.Location = new System.Drawing.Point(105, 0);
            this.btnToMp4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToMp4.Name = "btnToMp4";
            this.btnToMp4.Size = new System.Drawing.Size(105, 95);
            this.btnToMp4.TabIndex = 13;
            this.btnToMp4.Text = "To Mp4";
            this.btnToMp4.UseVisualStyleBackColor = true;
            this.btnToMp4.Click += new System.EventHandler(this.btnToMp4_Click);
            // 
            // btnToAvi
            // 
            this.btnToAvi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToAvi.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnToAvi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnToAvi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToAvi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToAvi.ForeColor = System.Drawing.Color.White;
            this.btnToAvi.Location = new System.Drawing.Point(0, 0);
            this.btnToAvi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToAvi.Name = "btnToAvi";
            this.btnToAvi.Size = new System.Drawing.Size(105, 95);
            this.btnToAvi.TabIndex = 12;
            this.btnToAvi.Text = "To Avi";
            this.btnToAvi.UseVisualStyleBackColor = true;
            this.btnToAvi.Click += new System.EventHandler(this.btnToAvi_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pbFileConversion);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtInputFile);
            this.panel4.Controls.Add(this.txtOutputFolder);
            this.panel4.Controls.Add(this.openFileButton);
            this.panel4.Controls.Add(this.convertButton);
            this.panel4.Controls.Add(this.folderOpenButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1200, 248);
            this.panel4.TabIndex = 12;
            // 
            // pbFileConversion
            // 
            this.pbFileConversion.Location = new System.Drawing.Point(316, 185);
            this.pbFileConversion.Name = "pbFileConversion";
            this.pbFileConversion.Size = new System.Drawing.Size(689, 34);
            this.pbFileConversion.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Progress :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Output Folder Name :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblTimePassed);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 406);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1200, 11);
            this.panel5.TabIndex = 13;
            // 
            // lblTimePassed
            // 
            this.lblTimePassed.AutoSize = true;
            this.lblTimePassed.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTimePassed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePassed.Location = new System.Drawing.Point(1196, 0);
            this.lblTimePassed.Name = "lblTimePassed";
            this.lblTimePassed.Size = new System.Drawing.Size(0, 21);
            this.lblTimePassed.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 417);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Button folderOpenButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnToAvi;
        private System.Windows.Forms.Button btnToMp3;
        private System.Windows.Forms.Button btnToFlv;
        private System.Windows.Forms.Button btnToWmv;
        private System.Windows.Forms.Button btnToMPEG;
        private System.Windows.Forms.Button btnToMp4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ProgressBar pbFileConversion;
        private System.Windows.Forms.Label lblTimePassed;
        private System.Windows.Forms.Timer vcTimer;
    }
}

