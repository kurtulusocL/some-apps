using SomeApps.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBarcod_Click(object sender, EventArgs e)
        {
            BarcodForm barcodForm = new BarcodForm();
            barcodForm.Show();
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            YoutubeDownloaderForm yDownloader = new YoutubeDownloaderForm();
            yDownloader.Show();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            PcControlForm pcControl = new PcControlForm();
            pcControl.Show();
        }

        private void btnNetwork_Click(object sender, EventArgs e)
        {
            PcNetworkForm pcNetwork = new PcNetworkForm();
            pcNetwork.Show();
        }

        private void btnCurrency_Click(object sender, EventArgs e)
        {
            ForeignCurrencyForm foreignCurrency = new ForeignCurrencyForm();
            foreignCurrency.Show();
        }

        private void btnIpAddress_Click(object sender, EventArgs e)
        {
            IpAddressForm ipAddress = new IpAddressForm();
            ipAddress.Show();
        }

        private void btnQRRead_Click(object sender, EventArgs e)
        {
            ReadQRCodeForm readQRCode = new ReadQRCodeForm();
            readQRCode.Show();
        }

        private void btnSendEMail_Click(object sender, EventArgs e)
        {
            SendEMailForm sendMail = new SendEMailForm();
            sendMail.Show();
        }
    }
}
