using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace NetUI
{
    public partial class Form_Net_List : Form
    {
        public Form_Net_List()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Get_Sys_Info();
        }

        private void Get_Sys_Info()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM Win32_NetworkAdapterConfiguration");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                listBox1.Items.Add("--------- Network Adapter --------------");
                listBox1.Items.Add("Caption: " + queryObj["Caption"].ToString());

                if (queryObj["DefaultIPGateway"] == null)
                    listBox1.Items.Add("DefaultIPGateway: " + queryObj["DefaultIPGateway"]);
                else
                {
                    String[] arrDefaultIPGateway = (String[])(queryObj["DefaultIPGateway"]);
                    foreach (String arrValue in arrDefaultIPGateway)
                    {
                        listBox1.Items.Add("DefaultIPGateway: " + arrValue);
                    }
                }

                if (queryObj["DNSServerSearchOrder"] == null)
                    listBox1.Items.Add("DNSServerSearchOrder: " + queryObj["DNSServerSearchOrder"]);
                else
                {
                    String[] arrDNSServerSearchOrder = (String[])(queryObj["DNSServerSearchOrder"]);
                    foreach (String arrValue in arrDNSServerSearchOrder)
                    {
                        listBox1.Items.Add("DNSServerSearchOrder: " + arrValue);
                    }
                }

                if (queryObj["IPAddress"] == null)
                    listBox1.Items.Add("IPAddress: " + queryObj["IPAddress"]);
                else
                {
                    String[] arrIPAddress = (String[])(queryObj["IPAddress"]);
                    foreach (String arrValue in arrIPAddress)
                    {
                        listBox1.Items.Add("IPAddress: "+ arrValue);
                    }
                }

                if (queryObj["IPSubnet"] == null)
                    listBox1.Items.Add("IPSubnet: "+ queryObj["IPSubnet"]);
                else
                {
                    String[] arrIPSubnet = (String[])(queryObj["IPSubnet"]);
                    foreach (String arrValue in arrIPSubnet)
                    {
                        listBox1.Items.Add("IPSubnet: "+ arrValue);
                    }
                }
                listBox1.Items.Add("MACAddress: "+ queryObj["MACAddress"]);
                listBox1.Items.Add("ServiceName: "+ queryObj["ServiceName"]);
                listBox1.Items.Add("\t");
                listBox1.Items.Add("\t");
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Get_Sys_Info();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
