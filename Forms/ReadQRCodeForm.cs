using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace SomeApps.Forms
{
    public partial class ReadQRCodeForm : Form
    {
        FilterInfoCollection webcam;
        VideoCaptureDevice camera;
        public ReadQRCodeForm()
        {
            InitializeComponent();
        }

        private void ReadQRCodeForm_Load(object sender, EventArgs e)
        {
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo dev in webcam)
            {
                cmbCamera.Items.Add(dev.Name);
            }
            cmbCamera.SelectedIndex = 0;
        }

        private void btnOpenCam_Click(object sender, EventArgs e)
        {
            camera = new VideoCaptureDevice(webcam[cmbCamera.SelectedIndex].MonikerString);
            camera.NewFrame += new NewFrameEventHandler(CamNewCam);
            camera.Start();
            timer1.Start();
        }
        private void CamNewCam(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnScanCode_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader barcod = new BarcodeReader();
            if (pictureBox1.Image != null)
            {
                Result result = barcod.Decode((Bitmap)pictureBox1.Image);
                try
                {
                    string decloader = result.ToString().Trim();
                    if (decloader != "")
                    {
                        timer1.Stop();
                        txtCode.Text = decloader;
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("An error occurred while processing your transaction.");
                }
            }
        }

        private void ReadQRCodeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camera != null)
                if (camera.IsRunning)
                {
                    camera.Stop();
                }
        }
    }
}
