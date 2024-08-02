using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeDownload;
using System.IO;
using System.Threading;
using YoutubeExtractor;

namespace YoutubeDownload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboResolution.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(txtURL.Text);
            VideoInfo video = videos.First(p => p.VideoType = VideoType.Mp4 && p.Resolution == Convert.ToInt32(cboResolution.Text));
            if (video.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(video);
            VideoDownloader Downloader = new VideoDownloader(video, Path.Combine(txtPath.Text+ "\\", video.Title+video.VideoExtension));
            Downloader.DownloadProgressChanged+=Downloader_DownloadProgressChanged;
            Thread thread = new Thread(() => { Downloader.Execute(); }) { IsBackground = true };
            thread.Start();
        }

        private void Downloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Value = (int)e.ProgressPercentage;
                lblProgress.Text = string.Format("{0:0.##}", e.ProgressPercentage) + " %";
                progressBar1.Update();
            }
            ));
        }

      
    }
}
