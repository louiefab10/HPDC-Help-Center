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
using System.DirectoryServices.AccountManagement;

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
            labelGreeting.Text = $"Hi, {GetUsername()}";
        }

        public static string OSVersion()
        {
            string osVer = "";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion"))
            {
                if(key != null)
                {
                    string prodName = key.GetValue("ProductName") as string;
                    string releaseNo = key.GetValue("DisplayVersion") as string;
                    string currentBuild = key.GetValue("CurrentBuild") as string;
                    string edition = key.GetValue("EditionID") as string;
                    if(int.TryParse(currentBuild, out int buildNo))
                    {
                        prodName = buildNo >= 22000 ? "Windows 11" : prodName;
                    }
                    prodName = $"{prodName} {edition}";
                    osVer = $"{prodName} (Release No: {releaseNo})";
                }
            }
            return osVer;
        }

        public static string GetUsername()
        {
            string userName = "";
            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
                {
                    UserPrincipal user = UserPrincipal.Current;
                    userName = user.DisplayName;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return userName;

        }
    }
}
