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
            this.TopmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopmenuStrip
            // 
            this.TopmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
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
            this.AddToSiteExplorertoolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.ShortcutKeyDisplayString = "S";
            this.文件ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.文件ToolStripMenuItem.Text = "文件 &s";
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

    }
}

