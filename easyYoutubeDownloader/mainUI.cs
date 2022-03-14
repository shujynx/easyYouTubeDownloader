using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace easyYoutubeDownloader
{
    public partial class mainUI : Form
    {
        public mainUI()
        {
            InitializeComponent();
        }

        private void donateLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://ko-fi.com/shujynx");
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            if (videoURL.Text == "")
            {
                MessageBox.Show("You need to provide a URL", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("You need at least 1 of the download checkboxes ticked", "Error", MessageBoxButtons.OK);
                return;
            }
            string cmdStr = "yt-dlp -f ";
            if (checkBox1.Checked && checkBox2.Checked)
            {
                cmdStr = cmdStr + "bestvideo+bestaudio/best " + videoURL.Text;
            } else if(checkBox1.Checked)
            {
                cmdStr = cmdStr + "bestvideo " + videoURL.Text;
            } else cmdStr = cmdStr + "bestaudio " + videoURL.Text;
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            consoleOutput.Text = "";
            cmd.StandardInput.WriteLine("@echo off");
            cmd.StandardInput.WriteLine(cmdStr);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            while (!cmd.StandardOutput.EndOfStream)
            {
                consoleOutput.AppendText(cmd.StandardOutput.ReadLine().ToString() + "\n");
                consoleOutput.ScrollToCaret();
            }
            cmd.WaitForExit();
            cmd.Close();
            MessageBox.Show("Download Completed.", "", MessageBoxButtons.OK);
        }

        private void ytdlGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/yt-dlp/yt-dlp");
        }
    }
}
