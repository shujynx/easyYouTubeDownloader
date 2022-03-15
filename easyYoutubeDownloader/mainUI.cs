using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

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

        private string CreateArgumentsToYyDlp()
        {
            string args = "yt-dlp -f";

            if (checkBox1.Checked && checkBox2.Checked)
            {
                args += string.Format(" bestvideo+bestaudio/best {0}", videoURL.Text.Trim());
            }
            else if (checkBox1.Checked)
            {
                args += string.Format(" bestvideo {0}", videoURL.Text.Trim());
            }
            else
            {
                args += string.Format(" bestaudio {0}", videoURL.Text.Trim());
            }

            if (!string.IsNullOrWhiteSpace(downloadLocation.Text))
            {
                if (!Directory.Exists(downloadLocation.Text))
                {
                    MessageBox.Show("The directory provided does not exist. The default directory will be used.", "", MessageBoxButtons.OK);
                }
                else
                {
                    args += string.Format(@" --output {0}\%(title)s-%(id)s.%(ext)s", downloadLocation.Text);
                }
            }

            return args;
        }

        private void DownlodVideo(string argsToYyDlp)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            consoleOutput.Text = string.Empty;
            cmd.StandardInput.WriteLine("@echo off");
            cmd.StandardInput.WriteLine(argsToYyDlp);
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

        private void downloadButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(videoURL.Text))
            {
                MessageBox.Show("You need to provide a URL", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("You need at least 1 of the download checkboxes ticked", "Error", MessageBoxButtons.OK);
                return;
            }
           
            string argsToYyDlp = CreateArgumentsToYyDlp();
            DownlodVideo(argsToYyDlp);
        }

        private void ytdlGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/yt-dlp/yt-dlp");
        }

        private void chooseDownloadLocationButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    downloadLocation.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
