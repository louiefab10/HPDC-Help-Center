using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace HPDC_Help_Center
{
    public partial class Form1: MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            GetPCDetails();
        }

        public void GetPCDetails()
        {
           labelIPAdd.Text = Dns.GetHostEntry(Dns.GetHostName())
                    .AddressList
                    .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork)?
                    .ToString();
            labelPCName.Text = Environment.MachineName;
            labelOSVersion.Text = OSVersion();
        }

        public static string OSVersion()
        {
            string osVer = "";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion"))
            {
                if(key != null)
                {
                    string prodName = key.GetValue("ProductName") as string;
                    string releaseNo = key.GetValue("ReleaseId") as string;
                    string buildNo = key.GetValue("CurrentBuild") as string;
                    osVer = $"{prodName} (Build Number: {buildNo}, Release No: {releaseNo})";
                }
            }
            return osVer;
        }
    }
}
