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
            string ServerIP = strSeverIP.Text;
            string UserName = strUserName.Text;
            string PassWord = strUserPassWord.Text;
            int ServerPort = Convert.ToInt32(strSeverIP.Text);
             


        }
    }
}
