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
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于ToolStripMenuItem.Text = "关于 &A";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 602);
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

    }
}

