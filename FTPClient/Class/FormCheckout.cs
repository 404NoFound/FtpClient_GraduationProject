using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;


namespace FTPClient.Class
{
   static class FormCheckout
    {
        public  static void IpAddressCheck(string ServerIP){
             string con =ServerIP;//获得输入的字符串
            if (con.Contains("."))
            {
                string[] lines = new string[4];
                string s = ".";
                lines = strSeverIP.Text.Split(s.ToCharArray(), 4);//检查字符串中"."的个数
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
                                return false;
                            }
                            else
                            {
                                labelIPError.Text = "合法";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error");
                            strSeverIP.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                    strSeverIP.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error");
                strSeverIP.Focus();
            }
        }
    }
      
        }
    }
}
