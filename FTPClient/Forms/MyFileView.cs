using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FTPClient.Forms
{
    public partial class MyFileView : UserControl
    {
        public MyFileView()
        {
            InitializeComponent();
        }

        private void MyFileView_Load(object sender, EventArgs e)
        {
           //获取逻辑驱动器
            string[] logicDrives = System.IO.Directory.GetLogicalDrives();
            TreeNode[] cRoot = new TreeNode[logicDrives.Length];
            for (int i = 0; i < logicDrives.Length; i++)
            {
                TreeNode drivesNode = new TreeNode(logicDrives[i]);
                treeViewPath.Nodes.Add(drivesNode);
                if (logicDrives[i] != "A:\\" && logicDrives[i] != "B:\\") ;
                
                
            }
        }
        private void getSubNode(TreeNode PathName, bool isEnd)
        {
            if (!isEnd)
                return; //exit this  
            TreeNode curNode;
            DirectoryInfo[] subDir;
            DirectoryInfo curDir = new DirectoryInfo(PathName.FullPath);
           // try
            //、{
               subDir = curDir.GetDirectories();
           // }
            //catch { }
            foreach (DirectoryInfo d in subDir)
            {
                curNode = new TreeNode(d.Name);
                PathName.Nodes.Add(curNode);
                getSubNode(curNode, false);
            }
        }

        private void treeViewPath_AfterExpand(object sender, TreeViewEventArgs e)
        {
            try
            {
                foreach (TreeNode tn in e.Node.Nodes)
                {
                    if (!tn.IsExpanded)
                        getSubNode(tn, true);
                }
            }
            catch { ;}  
        }  
    }
}
