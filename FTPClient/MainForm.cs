using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FTPClient.Forms;
using FTPClient.Class;


namespace FTPClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SiteExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiteExplorerForm siteExplorer = new SiteExplorerForm();
            siteExplorer.Show();
          //  siteExplorer.ShowDialog();

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (FormCheckout.IpAddressCheck(textboxServerIP.Text.ToString().Trim()))
            {
                textboxServerIP.Focus();
            }

            string ServerIP = textboxServerIP.Text;
            string UserName = textboxUserName.Text;
            string PassWord = textboxUserPassWord.Text;
            int ServerPort = Convert.ToInt32(textboxServerIP.Text);
            

        }

        private void strSeverIP_TextChanged(object sender, EventArgs e)
        {

        }

       

            
    }
}
