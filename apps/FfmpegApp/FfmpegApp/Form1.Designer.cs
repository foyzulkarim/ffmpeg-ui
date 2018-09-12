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
            this.convertButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.folderOpenButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnToAvi = new System.Windows.Forms.Button();
            this.btnToMp4 = new System.Windows.Forms.Button();
            this.btnToMPEG = new System.Windows.Forms.Button();
            this.btnToWmv = new System.Windows.Forms.Button();
            this.btnToFlv = new System.Windows.Forms.Button();
            this.btnToMp3 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(180, 424);
            this.convertButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(112, 35);
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
            this.openFileButton.Location = new System.Drawing.Point(995, 224);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(42, 35);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "...";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input file";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(180, 233);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(804, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Location = new System.Drawing.Point(180, 300);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(804, 26);
            this.textBox2.TabIndex = 4;
            // 
            // folderOpenButton
            // 
            this.folderOpenButton.Location = new System.Drawing.Point(995, 291);
            this.folderOpenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.folderOpenButton.Name = "folderOpenButton";
            this.folderOpenButton.Size = new System.Drawing.Size(42, 35);
            this.folderOpenButton.TabIndex = 5;
            this.folderOpenButton.Text = "...";
            this.folderOpenButton.UseVisualStyleBackColor = true;
            this.folderOpenButton.Click += new System.EventHandler(this.folderOpenButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 364);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output Filename";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(180, 361);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(804, 26);
            this.textBox3.TabIndex = 7;
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
            // 
            // btnToAvi
            // 
            this.btnToAvi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToAvi.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
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
            // 
            // btnToMp4
            // 
            this.btnToMp4.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToMp4.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
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
            // 
            // btnToMPEG
            // 
            this.btnToMPEG.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToMPEG.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
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
            // 
            // btnToWmv
            // 
            this.btnToWmv.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToWmv.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
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
            // 
            // btnToFlv
            // 
            this.btnToFlv.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToFlv.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.folderOpenButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.convertButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button folderOpenButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
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
    }
}

