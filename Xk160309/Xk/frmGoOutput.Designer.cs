namespace Xk
{
    partial class frmGoOutput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoOutput));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSalesList = new System.Windows.Forms.DataGridView();
            this.SalesNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQueryNextLevel = new System.Windows.Forms.Button();
            this.tbAssemble = new System.Windows.Forms.TextBox();
            this.dgvNextLevel = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.AssembleNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.件型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssembleName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SheetNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportantNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleNumber2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "已有销售号列表：";
            // 
            // dgvSalesList
            // 
            this.dgvSalesList.AllowUserToAddRows = false;
            this.dgvSalesList.AllowUserToDeleteRows = false;
            this.dgvSalesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesNo,
            this.SalesName});
            this.dgvSalesList.Location = new System.Drawing.Point(44, 55);
            this.dgvSalesList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvSalesList.Name = "dgvSalesList";
            this.dgvSalesList.ReadOnly = true;
            this.dgvSalesList.RowTemplate.Height = 23;
            this.dgvSalesList.Size = new System.Drawing.Size(342, 578);
            this.dgvSalesList.TabIndex = 19;
            // 
            // SalesNo
            // 
            this.SalesNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SalesNo.DataPropertyName = "AssembleNo";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SalesNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.SalesNo.HeaderText = "销售号";
            this.SalesNo.Name = "SalesNo";
            this.SalesNo.ReadOnly = true;
            this.SalesNo.Width = 90;
            // 
            // SalesName
            // 
            this.SalesName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SalesName.DataPropertyName = "AssembleName";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SalesName.DefaultCellStyle = dataGridViewCellStyle2;
            this.SalesName.HeaderText = "销售名称";
            this.SalesName.Name = "SalesName";
            this.SalesName.ReadOnly = true;
            this.SalesName.Width = 109;
            // 
            // btnQueryNextLevel
            // 
            this.btnQueryNextLevel.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQueryNextLevel.Location = new System.Drawing.Point(846, 14);
            this.btnQueryNextLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQueryNextLevel.Name = "btnQueryNextLevel";
            this.btnQueryNextLevel.Size = new System.Drawing.Size(100, 27);
            this.btnQueryNextLevel.TabIndex = 24;
            this.btnQueryNextLevel.Text = "查询";
            this.btnQueryNextLevel.UseVisualStyleBackColor = true;
            this.btnQueryNextLevel.Click += new System.EventHandler(this.btnQueryNextLevel_Click);
            // 
            // tbAssemble
            // 
            this.tbAssemble.Location = new System.Drawing.Point(592, 14);
            this.tbAssemble.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbAssemble.Name = "tbAssemble";
            this.tbAssemble.Size = new System.Drawing.Size(195, 27);
            this.tbAssemble.TabIndex = 22;
            // 
            // dgvNextLevel
            // 
            this.dgvNextLevel.AllowUserToAddRows = false;
            this.dgvNextLevel.AllowUserToDeleteRows = false;
            this.dgvNextLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNextLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNextLevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssembleNo2,
            this.Column1,
            this.件型,
            this.AssembleName2,
            this.SheetNo2,
            this.TypeNo2,
            this.ImportantNo2,
            this.SaleNumber2});
            this.dgvNextLevel.Location = new System.Drawing.Point(465, 55);
            this.dgvNextLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvNextLevel.Name = "dgvNextLevel";
            this.dgvNextLevel.ReadOnly = true;
            this.dgvNextLevel.RowTemplate.Height = 23;
            this.dgvNextLevel.Size = new System.Drawing.Size(767, 578);
            this.dgvNextLevel.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(461, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "件号输入：";
            // 
            // AssembleNo2
            // 
            this.AssembleNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AssembleNo2.DataPropertyName = "NextLevel";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AssembleNo2.DefaultCellStyle = dataGridViewCellStyle3;
            this.AssembleNo2.HeaderText = "件号";
            this.AssembleNo2.Name = "AssembleNo2";
            this.AssembleNo2.ReadOnly = true;
            this.AssembleNo2.Width = 71;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "名称";
            this.Column1.HeaderText = "名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 71;
            // 
            // 件型
            // 
            this.件型.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.件型.DataPropertyName = "件型";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.件型.DefaultCellStyle = dataGridViewCellStyle4;
            this.件型.HeaderText = "件型";
            this.件型.Name = "件型";
            this.件型.ReadOnly = true;
            this.件型.Width = 71;
            // 
            // AssembleName2
            // 
            this.AssembleName2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AssembleName2.DataPropertyName = "AssembleNo";
            this.AssembleName2.HeaderText = "上级件号";
            this.AssembleName2.Name = "AssembleName2";
            this.AssembleName2.ReadOnly = true;
            this.AssembleName2.Width = 109;
            // 
            // SheetNo2
            // 
            this.SheetNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SheetNo2.DataPropertyName = "Level";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SheetNo2.DefaultCellStyle = dataGridViewCellStyle5;
            this.SheetNo2.HeaderText = "分组";
            this.SheetNo2.Name = "SheetNo2";
            this.SheetNo2.ReadOnly = true;
            this.SheetNo2.Width = 71;
            // 
            // TypeNo2
            // 
            this.TypeNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TypeNo2.DataPropertyName = "TopLevel";
            this.TypeNo2.HeaderText = "顶级件号";
            this.TypeNo2.Name = "TypeNo2";
            this.TypeNo2.ReadOnly = true;
            this.TypeNo2.Width = 109;
            // 
            // ImportantNo2
            // 
            this.ImportantNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ImportantNo2.DataPropertyName = "数量";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ImportantNo2.DefaultCellStyle = dataGridViewCellStyle6;
            this.ImportantNo2.HeaderText = "数量";
            this.ImportantNo2.Name = "ImportantNo2";
            this.ImportantNo2.ReadOnly = true;
            this.ImportantNo2.Width = 71;
            // 
            // SaleNumber2
            // 
            this.SaleNumber2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SaleNumber2.DataPropertyName = "SalesNo";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SaleNumber2.DefaultCellStyle = dataGridViewCellStyle7;
            this.SaleNumber2.HeaderText = "销售号";
            this.SaleNumber2.Name = "SaleNumber2";
            this.SaleNumber2.ReadOnly = true;
            this.SaleNumber2.Width = 90;
            // 
            // frmGoOutput
            // 
            this.AcceptButton = this.btnQueryNextLevel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 684);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQueryNextLevel);
            this.Controls.Add(this.tbAssemble);
            this.Controls.Add(this.dgvNextLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSalesList);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmGoOutput";
            this.ShowInTaskbar = false;
            this.Text = "去向查询";
            this.Load += new System.EventHandler(this.frmGoOutput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSalesList;
        private System.Windows.Forms.Button btnQueryNextLevel;
        private System.Windows.Forms.TextBox tbAssemble;
        private System.Windows.Forms.DataGridView dgvNextLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssembleNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 件型;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssembleName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SheetNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportantNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleNumber2;
    }
}