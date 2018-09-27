using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace NetUI
{
    public partial class Form_Ip_Options : Form
    {
        public Form_Ip_Options()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Trace_add_Click(object sender, EventArgs e)
        {

            int Num;
            string str = tb_trace_ip.Text;
            str = str.Replace(".", "");
            bool isNum = int.TryParse(str, out Num);

            if (isNum)
            {
                FileStream FileCheck = new FileStream("TraceIP.txt", FileMode.OpenOrCreate);
                FileCheck.Close();

                int fileEmpty = 0;
                int LineExist = 0;

                string[] strok = File.ReadAllLines("TraceIP.txt");
                if (strok.Length == 0)
                {
                    fileEmpty = 1;
                }

                FileStream srFile = new FileStream("TraceIP.txt", FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(srFile);
                string line;
                if (fileEmpty == 0)
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();

                        if (line == tb_trace_ip.Text)
                        {
                            LineExist = 1;
                        }
                    }
                    sr.Close();

                    if (LineExist == 0)
                    {
                        FileStream aFile = new FileStream("TraceIP.txt", FileMode.OpenOrCreate);
                        StreamWriter sw = new StreamWriter(aFile);
                        aFile.Seek(0, SeekOrigin.End);
                        sw.WriteLine(tb_trace_ip.Text);
                        sw.Close();
                        MessageBox.Show("IP added successfuly");

                        Form_Ip_Options_Load(sender, e);

                        return;
                    }
                    else
                    {
                        MessageBox.Show("This IP is already in list");
                        return;
                    }
                }
                else
                {
                    //FileStream aFile = new FileStream("TraceIP.txt", FileMode.OpenOrCreate);
                    StreamWriter sw = new StreamWriter(srFile);
                    srFile.Seek(0, SeekOrigin.End);
                    sw.WriteLine(tb_trace_ip.Text);
                    sw.Close();
                    MessageBox.Show("IP added successfuly");

                    Form_Ip_Options_Load(sender, e);

                    return;
                }
            }
            else MessageBox.Show("Enter IP Prpperly \nExample: 192.168.0.104");
        }

        private void trace_Click(object sender, EventArgs e)
        {
            
        }

        private void Form_Ip_Options_Load(object sender, EventArgs e)
        {
            UsedIPList.Items.Clear();

            FileStream srFile = new FileStream("TraceIP.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(srFile);
            string line;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                UsedIPList.Items.Add(line);
            }
            sr.Close();
        }
    }
}
