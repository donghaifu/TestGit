namespace Xk
{
    partial class frmSaleOutput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleOutput));
            this.dgvNextLevel1 = new System.Windows.Forms.DataGridView();
            this.AssembleNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssembleName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SheetNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportantNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQueryNextLevel = new System.Windows.Forms.Button();
            this.cbAssemble1 = new System.Windows.Forms.CheckBox();
            this.tbNextLevel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextLevel1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNextLevel1
            // 
            this.dgvNextLevel1.AllowUserToAddRows = false;
            this.dgvNextLevel1.AllowUserToDeleteRows = false;
            this.dgvNextLevel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNextLevel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNextLevel1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssembleNo2,
            this.AssembleName2,
            this.SheetNo2,
            this.TypeNo2,
            this.ImportantNo2,
            this.OwnerNo2,
            this.ValidDate2,
            this.Remark2});
            this.dgvNextLevel1.Location = new System.Drawing.Point(38, 66);
            this.dgvNextLevel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvNextLevel1.Name = "dgvNextLevel1";
            this.dgvNextLevel1.ReadOnly = true;
            this.dgvNextLevel1.RowTemplate.Height = 23;
            this.dgvNextLevel1.Size = new System.Drawing.Size(940, 81);
            this.dgvNextLevel1.TabIndex = 21;
            // 
            // AssembleNo2
            // 
            this.AssembleNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AssembleNo2.DataPropertyName = "No";
            this.AssembleNo2.HeaderText = "件号";
            this.AssembleNo2.Name = "AssembleNo2";
            this.AssembleNo2.ReadOnly = true;
            this.AssembleNo2.Width = 71;
            // 
            // AssembleName2
            // 
            this.AssembleName2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AssembleName2.DataPropertyName = "Name";
            this.AssembleName2.HeaderText = "名称";
            this.AssembleName2.Name = "AssembleName2";
            this.AssembleName2.ReadOnly = true;
            this.AssembleName2.Width = 71;
            // 
            // SheetNo2
            // 
            this.SheetNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SheetNo2.DataPropertyName = "SheetName";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SheetNo2.DefaultCellStyle = dataGridViewCellStyle1;
            this.SheetNo2.HeaderText = "图幅";
            this.SheetNo2.Name = "SheetNo2";
            this.SheetNo2.ReadOnly = true;
            this.SheetNo2.Width = 71;
            // 
            // TypeNo2
            // 
            this.TypeNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TypeNo2.DataPropertyName = "TypeName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TypeNo2.DefaultCellStyle = dataGridViewCellStyle2;
            this.TypeNo2.HeaderText = "件型";
            this.TypeNo2.Name = "TypeNo2";
            this.TypeNo2.ReadOnly = true;
            this.TypeNo2.Width = 71;
            // 
            // ImportantNo2
            // 
            this.ImportantNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ImportantNo2.DataPropertyName = "ImportantName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ImportantNo2.DefaultCellStyle = dataGridViewCellStyle3;
            this.ImportantNo2.HeaderText = "重要度";
            this.ImportantNo2.Name = "ImportantNo2";
            this.ImportantNo2.ReadOnly = true;
            this.ImportantNo2.Width = 90;
            // 
            // OwnerNo2
            // 
            this.OwnerNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OwnerNo2.DataPropertyName = "OwnerName";
            this.OwnerNo2.HeaderText = "设计";
            this.OwnerNo2.Name = "OwnerNo2";
            this.OwnerNo2.ReadOnly = true;
            this.OwnerNo2.Width = 71;
            // 
            // ValidDate2
            // 
            this.ValidDate2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ValidDate2.DataPropertyName = "ValidDate";
            this.ValidDate2.HeaderText = "生效日期";
            this.ValidDate2.Name = "ValidDate2";
            this.ValidDate2.ReadOnly = true;
            this.ValidDate2.Width = 109;
            // 
            // Remark2
            // 
            this.Remark2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Remark2.DataPropertyName = "Remark";
            this.Remark2.HeaderText = "备注";
            this.Remark2.Name = "Remark2";
            this.Remark2.ReadOnly = true;
            this.Remark2.Width = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(34, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "请输入件号：";
            // 
            // btnQueryNextLevel
            // 
            this.btnQueryNextLevel.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQueryNextLevel.Location = new System.Drawing.Point(503, 15);
            this.btnQueryNextLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQueryNextLevel.Name = "btnQueryNextLevel";
            this.btnQueryNextLevel.Size = new System.Drawing.Size(100, 27);
            this.btnQueryNextLevel.TabIndex = 19;
            this.btnQueryNextLevel.Text = "查询";
            this.btnQueryNextLevel.UseVisualStyleBackColor = true;
            this.btnQueryNextLevel.Click += new System.EventHandler(this.btnQueryNextLevel_Click_1);
            // 
            // cbAssemble1
            // 
            this.cbAssemble1.AutoSize = true;
            this.cbAssemble1.Location = new System.Drawing.Point(390, 20);
            this.cbAssemble1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbAssemble1.Name = "cbAssemble1";
            this.cbAssemble1.Size = new System.Drawing.Size(87, 22);
            this.cbAssemble1.TabIndex = 18;
            this.cbAssemble1.Text = "组合件";
            this.cbAssemble1.UseVisualStyleBackColor = true;
            // 
            // tbNextLevel
            // 
            this.tbNextLevel.Location = new System.Drawing.Point(168, 15);
            this.tbNextLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNextLevel.Name = "tbNextLevel";
            this.tbNextLevel.Size = new System.Drawing.Size(195, 27);
            this.tbNextLevel.TabIndex = 17;
            // 
            // frmSaleOutput
            // 
            this.AcceptButton = this.btnQueryNextLevel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 182);
            this.Controls.Add(this.dgvNextLevel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnQueryNextLevel);
            this.Controls.Add(this.cbAssemble1);
            this.Controls.Add(this.tbNextLevel);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSaleOutput";
            this.Text = "零件特性查询";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextLevel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNextLevel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQueryNextLevel;
        private System.Windows.Forms.CheckBox cbAssemble1;
        private System.Windows.Forms.TextBox tbNextLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssembleNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssembleName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SheetNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportantNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidDate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark2;
    }
}