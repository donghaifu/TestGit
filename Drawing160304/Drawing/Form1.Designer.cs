namespace Drawing
{
    partial class frmDrawing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrawing));
            this.tbAssemble = new System.Windows.Forms.TextBox();
            this.btnSee = new System.Windows.Forms.Button();
            this.axDwgViewX1 = new AxDWGVIEWXLib.AxDwgViewX();
            this.dgvNextLevel = new System.Windows.Forms.DataGridView();
            this.件号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.axDwgViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAssemble
            // 
            this.tbAssemble.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAssemble.Location = new System.Drawing.Point(20, 20);
            this.tbAssemble.Name = "tbAssemble";
            this.tbAssemble.Size = new System.Drawing.Size(145, 30);
            this.tbAssemble.TabIndex = 0;
            // 
            // btnSee
            // 
            this.btnSee.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSee.Location = new System.Drawing.Point(196, 22);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(106, 30);
            this.btnSee.TabIndex = 1;
            this.btnSee.Text = "查看";
            this.btnSee.UseVisualStyleBackColor = true;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // axDwgViewX1
            // 
            this.axDwgViewX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axDwgViewX1.Enabled = true;
            this.axDwgViewX1.Location = new System.Drawing.Point(347, 20);
            this.axDwgViewX1.Name = "axDwgViewX1";
            this.axDwgViewX1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDwgViewX1.OcxState")));
            this.axDwgViewX1.Size = new System.Drawing.Size(898, 701);
            this.axDwgViewX1.TabIndex = 2;
            // 
            // dgvNextLevel
            // 
            this.dgvNextLevel.AllowUserToAddRows = false;
            this.dgvNextLevel.AllowUserToDeleteRows = false;
            this.dgvNextLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvNextLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNextLevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.件号,
            this.名称,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvNextLevel.Location = new System.Drawing.Point(20, 65);
            this.dgvNextLevel.Name = "dgvNextLevel";
            this.dgvNextLevel.ReadOnly = true;
            this.dgvNextLevel.RowTemplate.Height = 27;
            this.dgvNextLevel.Size = new System.Drawing.Size(295, 656);
            this.dgvNextLevel.TabIndex = 3;
            this.dgvNextLevel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNextLevel_CellDoubleClick);
            // 
            // 件号
            // 
            this.件号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.件号.DataPropertyName = "No";
            this.件号.HeaderText = "件号";
            this.件号.Name = "件号";
            this.件号.ReadOnly = true;
            this.件号.Width = 62;
            // 
            // 名称
            // 
            this.名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.名称.DataPropertyName = "Name";
            this.名称.HeaderText = "名称";
            this.名称.Name = "名称";
            this.名称.ReadOnly = true;
            this.名称.Width = 62;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "Number";
            this.Column1.HeaderText = "数量";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 62;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "Level";
            this.Column2.HeaderText = "分组";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 62;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Remark";
            this.Column3.HeaderText = "备注";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 62;
            // 
            // frmDrawing
            // 
            this.AcceptButton = this.btnSee;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 733);
            this.Controls.Add(this.dgvNextLevel);
            this.Controls.Add(this.axDwgViewX1);
            this.Controls.Add(this.btnSee);
            this.Controls.Add(this.tbAssemble);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDrawing";
            this.Text = "图纸查看器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDrawing_FormClosing);
            this.Load += new System.EventHandler(this.frmDrawing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axDwgViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAssemble;
        private System.Windows.Forms.Button btnSee;
        private AxDWGVIEWXLib.AxDwgViewX axDwgViewX1;
        private System.Windows.Forms.DataGridView dgvNextLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn 件号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

