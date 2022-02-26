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
            ytdlCheck();
        }

        static void ytdlCheck()
        {
            if (!File.Exists("youtube-dl.exe"))
            {
                DialogResult dr = MessageBox.Show("youtube-dl.exe was not found, download it?", "youtube-dl.exe was not found", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes) Application.Run(new ytdlDownload());
                else Application.Exit();
            } else Application.Run(new mainUI());
        }
    }
}
