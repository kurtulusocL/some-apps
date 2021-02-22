using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeApps.Forms
{
    public partial class IpAddressForm : Form
    {
        public IpAddressForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtPc.Text = Dns.GetHostName();
            foreach (IPAddress adres in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                txtIP.Text = adres.ToString();
            }
        }

        private void btnSiteShow_Click(object sender, EventArgs e)
        {
            try
            {
                IPHostEntry siteAdi = Dns.GetHostEntry(txtLink.Text);
                IPAddress[] ip = siteAdi.AddressList;
                txtSiteIP.Text = ip[0].ToString();
                ListViewItem list = new ListViewItem();
                list.Text = txtLink.Text.ToString();
                list.SubItems.Add(txtSiteIP.Text.ToString());

                lstSite.Items.Add(list);
                txtLink.Clear();
                txtSiteIP.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("There is no website with this domain name...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
