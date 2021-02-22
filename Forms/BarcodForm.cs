using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace SomeApps.Forms
{
    public partial class BarcodForm : Form
    {
        public BarcodForm()
        {
            InitializeComponent();
        }

        private void btnBarcod_Click(object sender, EventArgs e)
        {
            Code128BarcodeDraw barcode = BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(txtBarcod.Text, 50);
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(txtQR.Text, 50);
        }
    }
}
