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
            string ServerIP = textboxFtpIP.Text;
            string UserName = textboxUserName.Text;
            string PassWord = textboxUserPassWord.Text;
            int ServerPort = Convert.ToInt32(textboxFtpIP.Text);
             


        }

        private void strSeverIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void strSeverIP_Leave(object sender, EventArgs e)
        {
            string con = textboxFtpIP.Text.ToString().Trim();//获得输入的字符串
            /*
           if (con.Contains("."))
           {
               string[] lines = new string[4];
               string s = ".";
               lines = textboxFtpIP.Text.Split(s.ToCharArray(), 4);//检查字符串中"."的个数
               if (lines.Count().Equals(4))
               {
                   for (int i = 0; i < 4; i++)
                   {
                       System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(@"^\d+$");//检查字符串中的每个字符是否是0-9之间的数字
                       if (rex.IsMatch(lines[i]))
                       {
                           if (Convert.ToInt32(lines[i]) >= 255)//检查是否大于255
                           {
                               MessageBox.Show("Error");
                               textboxFtpIP.Focus();
                           }
                           else
                           {
                               labelIPError.Text = "合法";
                           }
                       }
                       else
                       {
                           MessageBox.Show("Error");
                           textboxFtpIP.Focus();
                       }
                   }
               }
               else
               {
                   MessageBox.Show("Error");
                   textboxFtpIP.Focus();
               }
           }
           else
           {
               MessageBox.Show("Error");
               textboxFtpIP.Focus();
           } */
        }
            
    }
}
