using System;
using System.IO;
using System.Windows.Forms;

namespace easyYoutubeDownloader
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ytdlpCheck();
        }

        static void ytdlpCheck()
        {
            if (!File.Exists("yt-dlp.exe"))
            {
                DialogResult dr = MessageBox.Show("yt-dlp.exe was not found, download it?", "yt-dlp.exe was not found", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes) Application.Run(new ytdlDownload());
                else Application.Exit();
            } else Application.Run(new mainUI());
        }
    }
}
