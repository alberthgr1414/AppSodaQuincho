using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSodaQuincho
{
    public partial class frmConfigurarTerminal : Form
    {
        public frmConfigurarTerminal()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmConfigurarTerminal_Load(object sender, EventArgs e)
        {
            lblMac.Text = GetMACAddress();
            PopulateInstalledPrintersCombo();

        }

        private void PopulateInstalledPrintersCombo()
        {
            // Add list of installed printers found to the combo box.
            // The pkInstalledPrinters string will be used to provide the display string.
            String pkInstalledPrinters;
            for (int i = 0; i < System.Drawing.Printing.PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = System.Drawing.Printing.PrinterSettings.InstalledPrinters[i];
                cboImpresoraPrimaria.Items.Add(pkInstalledPrinters);
                cboImpresoraSecundaria.Items.Add(pkInstalledPrinters);
            }
        }

        public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }


    }
}
