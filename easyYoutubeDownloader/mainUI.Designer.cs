namespace easyYoutubeDownloader
{
    partial class mainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainUI));
            this.label1 = new System.Windows.Forms.Label();
            this.videoURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.donateLink = new System.Windows.Forms.LinkLabel();
            this.downloadButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.consoleOutput = new System.Windows.Forms.RichTextBox();
            this.ytdlGithub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "YouTube Video URL";
            // 
            // videoURL
            // 
            this.videoURL.Location = new System.Drawing.Point(124, 10);
            this.videoURL.Name = "videoURL";
            this.videoURL.Size = new System.Drawing.Size(389, 20);
            this.videoURL.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Download";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(124, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Video";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(183, 38);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(53, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Audio";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // donateLink
            // 
            this.donateLink.AutoSize = true;
            this.donateLink.Location = new System.Drawing.Point(468, 362);
            this.donateLink.Name = "donateLink";
            this.donateLink.Size = new System.Drawing.Size(45, 13);
            this.donateLink.TabIndex = 5;
            this.donateLink.TabStop = true;
            this.donateLink.Text = "Donate!";
            this.donateLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.donateLink_LinkClicked);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(380, 39);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(133, 23);
            this.downloadButton.TabIndex = 8;
            this.downloadButton.Text = " Start Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Console Output";
            // 
            // consoleOutput
            // 
            this.consoleOutput.DetectUrls = false;
            this.consoleOutput.Location = new System.Drawing.Point(12, 76);
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.ReadOnly = true;
            this.consoleOutput.Size = new System.Drawing.Size(512, 283);
            this.consoleOutput.TabIndex = 11;
            this.consoleOutput.Text = "";
            // 
            // ytdlGithub
            // 
            this.ytdlGithub.AutoSize = true;
            this.ytdlGithub.Location = new System.Drawing.Point(12, 362);
            this.ytdlGithub.Name = "ytdlGithub";
            this.ytdlGithub.Size = new System.Drawing.Size(66, 13);
            this.ytdlGithub.TabIndex = 12;
            this.ytdlGithub.TabStop = true;
            this.ytdlGithub.Text = "yt-dlp Github";
            this.ytdlGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ytdlGithub_LinkClicked);
            // 
            // mainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 382);
            this.Controls.Add(this.ytdlGithub);
            this.Controls.Add(this.consoleOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.donateLink);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.videoURL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainUI";
            this.Text = "easyYouTubeDownloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox videoURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.LinkLabel donateLink;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox consoleOutput;
        private System.Windows.Forms.LinkLabel ytdlGithub;
    }
}