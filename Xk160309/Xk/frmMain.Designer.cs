namespace Xk
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LoginInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.装配查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.装配表查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图纸查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.研发中心ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图纸下载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设计库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.技术部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一步要做ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.装配输入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通知单输入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.装配查询ToolStripMenuItem,
            this.研发中心ToolStripMenuItem,
            this.技术部ToolStripMenuItem,
            this.装配输入ToolStripMenuItem,
            this.系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1914, 62);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemAdded += new System.Windows.Forms.ToolStripItemEventHandler(this.menuStrip1_ItemAdded);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LoginInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1017);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 31, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1914, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.LinkColor = System.Drawing.SystemColors.Highlight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(302, 25);
            this.toolStripStatusLabel1.Text = "项目设计：付东海，分机号：3289#";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // LoginInfo
            // 
            this.LoginInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoginInfo.LinkColor = System.Drawing.SystemColors.Highlight;
            this.LoginInfo.Name = "LoginInfo";
            this.LoginInfo.Size = new System.Drawing.Size(1578, 25);
            this.LoginInfo.Spring = true;
            this.LoginInfo.Text = "以后将显示登录信息";
            this.LoginInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 装配查询ToolStripMenuItem
            // 
            this.装配查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.装配表查询ToolStripMenuItem,
            this.图纸查看ToolStripMenuItem});
            this.装配查询ToolStripMenuItem.Image = global::Xk.Properties.Resources.Search;
            this.装配查询ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.装配查询ToolStripMenuItem.Name = "装配查询ToolStripMenuItem";
            this.装配查询ToolStripMenuItem.Size = new System.Drawing.Size(153, 52);
            this.装配查询ToolStripMenuItem.Text = "公共查询";
            // 
            // 装配表查询ToolStripMenuItem
            // 
            this.装配表查询ToolStripMenuItem.Image = global::Xk.Properties.Resources.SearchAss;
            this.装配表查询ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.装配表查询ToolStripMenuItem.Name = "装配表查询ToolStripMenuItem";
            this.装配表查询ToolStripMenuItem.Size = new System.Drawing.Size(194, 54);
            this.装配表查询ToolStripMenuItem.Text = "装配查询";
            this.装配表查询ToolStripMenuItem.Click += new System.EventHandler(this.装配表查询ToolStripMenuItem_Click);
            // 
            // 图纸查看ToolStripMenuItem
            // 
            this.图纸查看ToolStripMenuItem.Image = global::Xk.Properties.Resources.SearchDrawing;
            this.图纸查看ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.图纸查看ToolStripMenuItem.Name = "图纸查看ToolStripMenuItem";
            this.图纸查看ToolStripMenuItem.Size = new System.Drawing.Size(194, 54);
            this.图纸查看ToolStripMenuItem.Text = "图纸查看";
            this.图纸查看ToolStripMenuItem.Click += new System.EventHandler(this.图纸查看ToolStripMenuItem_Click);
            // 
            // 研发中心ToolStripMenuItem
            // 
            this.研发中心ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图纸下载ToolStripMenuItem,
            this.设计库ToolStripMenuItem});
            this.研发中心ToolStripMenuItem.Image = global::Xk.Properties.Resources.YanFan;
            this.研发中心ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.研发中心ToolStripMenuItem.Name = "研发中心ToolStripMenuItem";
            this.研发中心ToolStripMenuItem.Size = new System.Drawing.Size(153, 52);
            this.研发中心ToolStripMenuItem.Text = "研发中心";
            // 
            // 图纸下载ToolStripMenuItem
            // 
            this.图纸下载ToolStripMenuItem.Image = global::Xk.Properties.Resources.Downloads;
            this.图纸下载ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.图纸下载ToolStripMenuItem.Name = "图纸下载ToolStripMenuItem";
            this.图纸下载ToolStripMenuItem.Size = new System.Drawing.Size(194, 54);
            this.图纸下载ToolStripMenuItem.Text = "图纸下载";
            this.图纸下载ToolStripMenuItem.Click += new System.EventHandler(this.图纸下载ToolStripMenuItem_Click);
            // 
            // 设计库ToolStripMenuItem
            // 
            this.设计库ToolStripMenuItem.Image = global::Xk.Properties.Resources.Lib;
            this.设计库ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.设计库ToolStripMenuItem.Name = "设计库ToolStripMenuItem";
            this.设计库ToolStripMenuItem.Size = new System.Drawing.Size(194, 54);
            this.设计库ToolStripMenuItem.Text = "设计库";
            // 
            // 技术部ToolStripMenuItem
            // 
            this.技术部ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.下一步要做ToolStripMenuItem});
            this.技术部ToolStripMenuItem.Image = global::Xk.Properties.Resources.JiShu;
            this.技术部ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.技术部ToolStripMenuItem.Name = "技术部ToolStripMenuItem";
            this.技术部ToolStripMenuItem.Size = new System.Drawing.Size(132, 52);
            this.技术部ToolStripMenuItem.Text = "技术部";
            // 
            // 下一步要做ToolStripMenuItem
            // 
            this.下一步要做ToolStripMenuItem.Name = "下一步要做ToolStripMenuItem";
            this.下一步要做ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.下一步要做ToolStripMenuItem.Text = "下一步要做";
            // 
            // 装配输入ToolStripMenuItem
            // 
            this.装配输入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.通知单输入ToolStripMenuItem});
            this.装配输入ToolStripMenuItem.Image = global::Xk.Properties.Resources.Manager;
            this.装配输入ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.装配输入ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.装配输入ToolStripMenuItem.Name = "装配输入ToolStripMenuItem";
            this.装配输入ToolStripMenuItem.Size = new System.Drawing.Size(153, 52);
            this.装配输入ToolStripMenuItem.Text = "信息管理";
            // 
            // 通知单输入ToolStripMenuItem
            // 
            this.通知单输入ToolStripMenuItem.Image = global::Xk.Properties.Resources.Mail;
            this.通知单输入ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.通知单输入ToolStripMenuItem.Name = "通知单输入ToolStripMenuItem";
            this.通知单输入ToolStripMenuItem.Size = new System.Drawing.Size(215, 54);
            this.通知单输入ToolStripMenuItem.Text = "通知单输入";
            this.通知单输入ToolStripMenuItem.Click += new System.EventHandler(this.通知单输入ToolStripMenuItem_Click);
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.系统ToolStripMenuItem.Image = global::Xk.Properties.Resources.System;
            this.系统ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(111, 52);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Image = global::Xk.Properties.Resources.Personal;
            this.关于ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 54);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = global::Xk.Properties.Resources.Quit;
            this.退出ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 54);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1914, 1047);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "装配图纸查询系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 装配查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 装配输入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LoginInfo;
        private System.Windows.Forms.ToolStripMenuItem 装配表查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图纸查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 研发中心ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 技术部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图纸下载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一步要做ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通知单输入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设计库ToolStripMenuItem;
    }
}

