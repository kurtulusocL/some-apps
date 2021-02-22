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
using System.Xml;

namespace SomeApps.Forms
{
    public partial class ForeignCurrencyForm : Form
    {
        XmlDocument xmlDocument = new XmlDocument();
        public ForeignCurrencyForm()
        {
            InitializeComponent();
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            string url = "https://www.tcmb.gov.tr/kurlar/today.xml"; //turkey central rezerv bak

            WebClient client = new WebClient();

            client.Encoding = Encoding.UTF8;

            string xmlData = client.DownloadString(url);

            xmlDocument.LoadXml(xmlData);

            XmlNodeList kur = xmlDocument.DocumentElement.ChildNodes;

            foreach (XmlNode veri in kur)
            {
                string currencies = veri.ChildNodes[2].InnerText;
                listBox1.Items.Add(currencies);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {

                XmlNode selectedCurrency = xmlDocument.DocumentElement.SelectSingleNode(string.Format("Currency[CurrencyName='{0}']", listBox1.SelectedItem));

                if (selectedCurrency == null)
                {
                    return;
                }
                lblCurrency.Text = selectedCurrency.SelectSingleNode("Isim").InnerText;
                lblPurchase.Text = selectedCurrency.SelectSingleNode("BanknoteBuying").InnerText;
                lblSale.Text = selectedCurrency.SelectSingleNode("BanknoteSelling").InnerText;
            }
        }

        private void btnForeignToLocal_Click(object sender, EventArgs e)
        {
            decimal result;

            decimal value1 = Convert.ToDecimal(txtCurrency.Text.ToString());
            decimal value2 = Convert.ToDecimal(txtCurrencyPrice.Text.ToString());

            result = (value1 * value2);
            lblResult.Text = result.ToString();
        }

        private void btnLocalToForeign_Click(object sender, EventArgs e)
        {
            decimal result;
            decimal value1 = Convert.ToDecimal(txtCurrency.Text.ToString());
            decimal value2 = Convert.ToDecimal(txtCurrencyPrice.Text.ToString());

            result = (value1 / value2);
            lblResult.Text = result.ToString();
        }
    }
}
