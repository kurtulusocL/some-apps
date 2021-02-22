using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeApps.Forms
{
    public partial class PcControlForm : Form
    {
        public PcControlForm()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void btnIP_Click(object sender, EventArgs e)
        {
            string bilgisayarAdi = Dns.GetHostName();
            string ipAdresi = Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString();
            txtIp.Text = ipAdresi;
        }

        private void btnPcName_Click(object sender, EventArgs e)
        {
            string bilgisayarAdi = Dns.GetHostName();
            txtPcName.Text = bilgisayarAdi;
        }

        private void btnMac_Click(object sender, EventArgs e)
        {
            string mac = Mac();

            if (String.IsNullOrEmpty(mac))
            {
                txtMac.Text = "Biglisayarınızda bir ağ bağdaştırıcısı bulunamadı.";
            }
            else
            {
                txtMac.Text = mac;
            }
        }
        static string Mac()
        {
            ManagementClass manager = new ManagementClass("Win32_NetworkAdapterConfiguration");
            foreach (ManagementObject obj in manager.GetInstances())
            {
                if ((bool)obj["IPEnabled"])
                {
                    return obj["MacAddress"].ToString();
                }
            }

            return String.Empty;
        }
    }
}
