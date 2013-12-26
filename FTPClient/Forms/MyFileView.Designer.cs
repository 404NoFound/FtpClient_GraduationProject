namespace FTPClient.Forms
{
    partial class MyFileView
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewFile = new System.Windows.Forms.ListView();
            this.treeViewPath = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // listViewFile
            // 
            this.listViewFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFile.Location = new System.Drawing.Point(0, 0);
            this.listViewFile.Name = "listViewFile";
            this.listViewFile.Size = new System.Drawing.Size(467, 309);
            this.listViewFile.TabIndex = 0;
            this.listViewFile.UseCompatibleStateImageBehavior = false;
            // 
            // treeViewPath
            // 
            this.treeViewPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewPath.Location = new System.Drawing.Point(0, 0);
            this.treeViewPath.Name = "treeViewPath";
            this.treeViewPath.Size = new System.Drawing.Size(128, 309);
            this.treeViewPath.TabIndex = 1;
            this.treeViewPath.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPath_AfterExpand);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(128, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 309);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // MyFileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeViewPath);
            this.Controls.Add(this.listViewFile);
            this.Name = "MyFileView";
            this.Size = new System.Drawing.Size(467, 309);
            this.Load += new System.EventHandler(this.MyFileView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewFile;
        private System.Windows.Forms.TreeView treeViewPath;
        private System.Windows.Forms.Splitter splitter1;
    }
}
