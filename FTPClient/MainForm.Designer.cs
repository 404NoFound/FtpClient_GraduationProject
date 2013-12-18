namespace FTPClient
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TopmenuStrip = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SiteExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToSiteExplorertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.服务器SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新链接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.断开连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSeverIP = new System.Windows.Forms.Label();
            this.textboxFtpIP = new System.Windows.Forms.TextBox();
            this.labelSeverPort = new System.Windows.Forms.Label();
            this.textboxSeverPort = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textboxUserPassWord = new System.Windows.Forms.TextBox();
            this.textboxUserName = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelFtpPath = new System.Windows.Forms.Label();
            this.textBoxFtpPath = new System.Windows.Forms.TextBox();
            this.labelIPError = new System.Windows.Forms.Label();
            this.TopmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopmenuStrip
            // 
            this.TopmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.服务器SToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.TopmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TopmenuStrip.Name = "TopmenuStrip";
            this.TopmenuStrip.Size = new System.Drawing.Size(944, 25);
            this.TopmenuStrip.TabIndex = 0;
            this.TopmenuStrip.Text = "TopmenuStrip";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SiteExplorerToolStripMenuItem,
            this.AddToSiteExplorertoolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.ShortcutKeyDisplayString = "F";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.文件ToolStripMenuItem.Text = "文件 &F";
            // 
            // SiteExplorerToolStripMenuItem
            // 
            this.SiteExplorerToolStripMenuItem.Name = "SiteExplorerToolStripMenuItem";
            this.SiteExplorerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SiteExplorerToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.SiteExplorerToolStripMenuItem.Text = "站点管理器&s";
            this.SiteExplorerToolStripMenuItem.Click += new System.EventHandler(this.SiteExplorerToolStripMenuItem_Click);
            // 
            // AddToSiteExplorertoolStripMenuItem
            // 
            this.AddToSiteExplorertoolStripMenuItem.Name = "AddToSiteExplorertoolStripMenuItem";
            this.AddToSiteExplorertoolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.AddToSiteExplorertoolStripMenuItem.Text = "添加当前链接到站点管理器";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.EditToolStripMenuItem.Text = "编辑 &E";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.SettingsToolStripMenuItem.Text = "设置 ";
            // 
            // 服务器SToolStripMenuItem
            // 
            this.服务器SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新链接ToolStripMenuItem,
            this.断开连接ToolStripMenuItem});
            this.服务器SToolStripMenuItem.Name = "服务器SToolStripMenuItem";
            this.服务器SToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.服务器SToolStripMenuItem.Text = "服务器 &S";
            // 
            // 重新链接ToolStripMenuItem
            // 
            this.重新链接ToolStripMenuItem.Name = "重新链接ToolStripMenuItem";
            this.重新链接ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.重新链接ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.重新链接ToolStripMenuItem.Text = "重新连接 &R";
            // 
            // 断开连接ToolStripMenuItem
            // 
            this.断开连接ToolStripMenuItem.Name = "断开连接ToolStripMenuItem";
            this.断开连接ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.断开连接ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.断开连接ToolStripMenuItem.Text = "断开连接 &D";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.帮助HToolStripMenuItem.Text = "帮助 &H";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.关于ToolStripMenuItem.Text = "关于 &A";
            // 
            // labelSeverIP
            // 
            this.labelSeverIP.AutoSize = true;
            this.labelSeverIP.Location = new System.Drawing.Point(13, 29);
            this.labelSeverIP.Name = "labelSeverIP";
            this.labelSeverIP.Size = new System.Drawing.Size(65, 12);
            this.labelSeverIP.TabIndex = 1;
            this.labelSeverIP.Text = "服务器地址";
            // 
            // textboxFtpIP
            // 
            this.textboxFtpIP.AllowDrop = true;
            this.textboxFtpIP.Location = new System.Drawing.Point(84, 26);
            this.textboxFtpIP.Name = "textboxFtpIP";
            this.textboxFtpIP.Size = new System.Drawing.Size(126, 21);
            this.textboxFtpIP.TabIndex = 2;
            this.textboxFtpIP.WordWrap = false;
            this.textboxFtpIP.TextChanged += new System.EventHandler(this.strSeverIP_TextChanged);
            this.textboxFtpIP.Leave += new System.EventHandler(this.strSeverIP_Leave);
            // 
            // labelSeverPort
            // 
            this.labelSeverPort.AutoSize = true;
            this.labelSeverPort.Location = new System.Drawing.Point(216, 29);
            this.labelSeverPort.Name = "labelSeverPort";
            this.labelSeverPort.Size = new System.Drawing.Size(65, 12);
            this.labelSeverPort.TabIndex = 3;
            this.labelSeverPort.Text = "服务器端口";
            // 
            // textboxSeverPort
            // 
            this.textboxSeverPort.Location = new System.Drawing.Point(287, 26);
            this.textboxSeverPort.Name = "textboxSeverPort";
            this.textboxSeverPort.Size = new System.Drawing.Size(51, 21);
            this.textboxSeverPort.TabIndex = 4;
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Location = new System.Drawing.Point(507, 29);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(29, 12);
            this.labelUserPassword.TabIndex = 5;
            this.labelUserPassword.Text = "密码";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(354, 29);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(41, 12);
            this.labelUserName.TabIndex = 6;
            this.labelUserName.Text = "用户名";
            // 
            // textboxUserPassWord
            // 
            this.textboxUserPassWord.Location = new System.Drawing.Point(542, 26);
            this.textboxUserPassWord.Name = "textboxUserPassWord";
            this.textboxUserPassWord.Size = new System.Drawing.Size(100, 21);
            this.textboxUserPassWord.TabIndex = 7;
            // 
            // textboxUserName
            // 
            this.textboxUserName.Location = new System.Drawing.Point(401, 26);
            this.textboxUserName.Name = "textboxUserName";
            this.textboxUserName.Size = new System.Drawing.Size(100, 21);
            this.textboxUserName.TabIndex = 8;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(814, 22);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 9;
            this.buttonConnect.Text = "连接";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelFtpPath
            // 
            this.labelFtpPath.AutoSize = true;
            this.labelFtpPath.Location = new System.Drawing.Point(649, 29);
            this.labelFtpPath.Name = "labelFtpPath";
            this.labelFtpPath.Size = new System.Drawing.Size(53, 12);
            this.labelFtpPath.TabIndex = 10;
            this.labelFtpPath.Text = "远程路径";
            // 
            // textBoxFtpPath
            // 
            this.textBoxFtpPath.Location = new System.Drawing.Point(708, 24);
            this.textBoxFtpPath.Name = "textBoxFtpPath";
            this.textBoxFtpPath.Size = new System.Drawing.Size(100, 21);
            this.textBoxFtpPath.TabIndex = 11;
            // 
            // labelIPError
            // 
            this.labelIPError.AutoSize = true;
            this.labelIPError.Location = new System.Drawing.Point(84, 54);
            this.labelIPError.Name = "labelIPError";
            this.labelIPError.Size = new System.Drawing.Size(41, 12);
            this.labelIPError.TabIndex = 12;
            this.labelIPError.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 602);
            this.Controls.Add(this.labelIPError);
            this.Controls.Add(this.textBoxFtpPath);
            this.Controls.Add(this.labelFtpPath);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textboxUserName);
            this.Controls.Add(this.textboxUserPassWord);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.textboxSeverPort);
            this.Controls.Add(this.labelSeverPort);
            this.Controls.Add(this.textboxFtpIP);
            this.Controls.Add(this.labelSeverIP);
            this.Controls.Add(this.TopmenuStrip);
            this.Name = "MainForm";
            this.Text = "FtpClint--by ZYX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopmenuStrip.ResumeLayout(false);
            this.TopmenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SiteExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToSiteExplorertoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 服务器SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新链接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 断开连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Label labelSeverIP;
        private System.Windows.Forms.TextBox textboxFtpIP;
        private System.Windows.Forms.Label labelSeverPort;
        private System.Windows.Forms.TextBox textboxSeverPort;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textboxUserPassWord;
        private System.Windows.Forms.TextBox textboxUserName;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelFtpPath;
        private System.Windows.Forms.TextBox textBoxFtpPath;
        private System.Windows.Forms.Label labelIPError;

    }
}

