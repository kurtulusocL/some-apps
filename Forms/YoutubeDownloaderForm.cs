using MediaToolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace SomeApps.Forms
{
    public partial class YoutubeDownloaderForm : Form
    {
        bool FormatState;
        public YoutubeDownloaderForm()
        {
            InitializeComponent();
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Please, select to folder for save..." })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    //GetTitle();
                    lblState.Text = "The download started";
                    lblState.ForeColor = Color.Red;
                    btnDownload.Visible = false;

                    var youtube = YouTube.Default;
                    var video = await youtube.GetVideoAsync(txtUrl.Text);
                    File.WriteAllBytes(fdb.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());

                    var inputFile = new MediaToolkit.Model.MediaFile
                    {
                        Filename = fdb.SelectedPath + @"\" + video.FullName
                    };
                    var outputFile = new MediaToolkit.Model.MediaFile
                    {
                        Filename = $"{fdb.SelectedPath + @"\" + video.FullName}.mp3"
                    };

                    using (var enging = new Engine())
                    {
                        enging.GetMetadata(inputFile);
                        enging.Convert(inputFile, outputFile);
                    }

                    if (FormatState == true)
                    {
                        File.Delete(fdb.SelectedPath + @"\" + video.FullName);
                    }
                    else
                    {
                        File.Delete($"{fdb.SelectedPath + @"\" + video.FullName}.mp3");
                    }

                    lblState.Text = "The dowload finished.";
                    lblState.ForeColor = Color.Green;
                    btnDownload.Visible = true;
                }
                else
                {
                    MessageBox.Show("Please Specify File Path", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        void GetTitle()
        {
            WebRequest request = HttpWebRequest.Create(txtUrl.Text);
            WebResponse response;
            response = request.GetResponse();
            StreamReader info = new StreamReader(response.GetResponseStream());
            string taken = info.ReadToEnd();
            int beginning = taken.IndexOf("<title>") + 7;
            int ending = taken.Substring(beginning).IndexOf("</>title>");
            string takenInfo = taken.Substring(beginning, ending);
            lblHeader.Text = (takenInfo);
        }

        private void radioMP3_CheckedChanged(object sender, EventArgs e)
        {
            FormatState = true;
        }

        private void radioMP4_CheckedChanged(object sender, EventArgs e)
        {
            FormatState = false;
        }
    }
}
