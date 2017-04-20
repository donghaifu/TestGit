using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace Xk
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            this.Invalidate(true);
        }


        private void frmMain_Load(object sender, EventArgs e)
        {

           LoginInfo.Text = "您好！" + CPublic.CnName + "，欢迎使用本系统！";

            //处理各个菜单的显示权限
           if ((Menus.GgCx & CPublic.DepartmentMask) > 0)
               装配查询ToolStripMenuItem.Enabled = true;
           else
               装配查询ToolStripMenuItem.Enabled = false;

           if ((Menus.YfZx & CPublic.DepartmentMask) > 0)
               研发中心ToolStripMenuItem.Enabled = true;
           else
               研发中心ToolStripMenuItem.Enabled = false;

           if ((Menus.JsB & CPublic.DepartmentMask) > 0)
               技术部ToolStripMenuItem.Enabled = true;
           else
               技术部ToolStripMenuItem.Enabled = false;

           if ((Menus.XxGl & CPublic.DepartmentMask) > 0)
               装配输入ToolStripMenuItem.Enabled = true;
           else
               装配输入ToolStripMenuItem.Enabled = false;

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:fudonghai@yeah.net");
        }

        private void 零件输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPartInput f = new frmPartInput();
            f.MdiParent = this;
            f.Show();
        }

        private void 组合件输入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssemblePartInput f = new frmAssemblePartInput();
            f.MdiParent = this;
            f.Show();
        }

        private void 装配组合ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssembleInput f = new frmAssembleInput();
            f.MdiParent = this;
            f.Show();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.MdiParent = this;
            f.Show();
        }

        private void 装配表查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOutput f = new frmOutput();
            f.MdiParent = this;
            f.Show();
        }

        private void 零部件删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDelete f = new frmDelete();
            f.MdiParent = this;
            f.Show();
        }

        private void 图纸查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //frmDrawing f = new frmDrawing();
            //f.MdiParent = this;
            if (CGlobal.isShow == false)
            {
                //f.Show();
                try
                {
                    System.Diagnostics.Process.Start("D:\\Harvest\\Drawing\\Drawing.exe");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "请拨打 3289#", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //CGlobal.isShow = true;
            }

        }

        /// <summary>
        /// 根据“精确进程名”结束进程
        /// </summary>
        /// <param name="strProcName">精确进程名</param>
        public void KillProc(string strProcName)
        {
            try
            {
                //精确进程名  用GetProcessesByName
                foreach (Process p in Process.GetProcessesByName(strProcName))
                {
                    if (!p.CloseMainWindow())
                    {
                        p.Kill();
                    }
                }
            }
            catch
            {
    
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            KillProc("Drawing");
        }

        private void menuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            //if (e.Item.Text.Length == 0 //隐藏子窗体图标 
            //    || e.Item.Text == "最小化(&N)"//隐藏最小化按钮 
            //    || e.Item.Text == "还原(&R)"//隐藏还原按钮 
            //    || e.Item.Text == "关闭(&C)")//隐藏最关闭按钮 
            //{ 
            //    e.Item.Visible = false; 
            //}
        }

        private void 图纸下载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDownload f = new frmDownload();
            f.MdiParent = this;
            f.Show();
        }

     }
}
