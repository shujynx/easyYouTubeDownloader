﻿using System;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;

namespace easyYoutubeDownloader
{
    public partial class ytdlDownload : Form
    {
        public ytdlDownload()
        {
            InitializeComponent();
            download();
        }

        static void download()
        {
            WebClient wc = new WebClient();
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            wc.DownloadFileAsync(new Uri("https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp.exe"), "yt-dlp.exe");
        }

        static void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("yt-dlp.exe was downloaded, re-open the program", "", MessageBoxButtons.OK);
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/yt-dlp/yt-dlp");
        }
    }
}
