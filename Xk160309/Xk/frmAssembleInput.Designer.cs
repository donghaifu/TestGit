namespace Xk
{
    partial class frmAssembleInput
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssembleInput));
            this.dgvAssemble = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectAssembleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectNextLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAssembleList = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQueryAssembleList = new System.Windows.Forms.Button();
            this.dgvAssembleList = new System.Windows.Forms.DataGridView();
            this.AssembleNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssembleName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SheetNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelHigh1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportantNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvNextLevel = new System.Windows.Forms.DataGridView();
            this.AssembleNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssembleName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SheetNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportantNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNextLevel = new System.Windows.Forms.TextBox();
            this.cbAssemble = new System.Windows.Forms.CheckBox();
            this.btnQueryNextLevel = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnOver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssemble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssembleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAssemble
            // 
            this.dgvAssemble.AllowUserToAddRows = false;
            this.dgvAssemble.AllowUserToDeleteRows = false;
            this.dgvAssemble.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAssemble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssemble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.SelectAssembleNo,
            this.SelectNextLevel,
            this.SelectNumber,
            this.SelectLevel,
            this.SelectRemark,
            this.Cancel});
            this.dgvAssemble.Location = new System.Drawing.Point(717, 60);
            this.dgvAssemble.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvAssemble.Name = "dgvAssemble";
            this.dgvAssemble.RowTemplate.Height = 23;
            this.dgvAssemble.Size = new System.Drawing.Size(609, 715);
            this.dgvAssemble.TabIndex = 2;
            this.dgvAssemble.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssemble_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "No";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 71;
            // 
            // SelectAssembleNo
            // 
            this.SelectAssembleNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SelectAssembleNo.DataPropertyName = "AssembleNo";
            this.SelectAssembleNo.HeaderText = "装配号";
            this.SelectAssembleNo.Name = "SelectAssembleNo";
            this.SelectAssembleNo.ReadOnly = true;
            this.SelectAssembleNo.Width = 90;
            // 
            // SelectNextLevel
            // 
            this.SelectNextLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SelectNextLevel.DataPropertyName = "NextLevel";
            this.SelectNextLevel.HeaderText = "下级件号";
            this.SelectNextLevel.Name = "SelectNextLevel";
            this.SelectNextLevel.ReadOnly = true;
            this.SelectNextLevel.Width = 109;
            // 
            // SelectNumber
            // 
            this.SelectNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SelectNumber.DataPropertyName = "Number";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SelectNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.SelectNumber.HeaderText = "数量";
            this.SelectNumber.Name = "SelectNumber";
            this.SelectNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SelectNumber.Width = 52;
            // 
            // SelectLevel
            // 
            this.SelectLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SelectLevel.DataPropertyName = "Level";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SelectLevel.DefaultCellStyle = dataGridViewCellStyle3;
            this.SelectLevel.HeaderText = "分组";
            this.SelectLevel.Name = "SelectLevel";
            this.SelectLevel.Width = 71;
            // 
            // SelectRemark
            // 
            this.SelectRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SelectRemark.DataPropertyName = "Remark";
            this.SelectRemark.HeaderText = "备注";
            this.SelectRemark.Name = "SelectRemark";
            this.SelectRemark.Width = 71;
            // 
            // Cancel
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Cancel.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cancel.HeaderText = "取消";
            this.Cancel.Name = "Cancel";
            this.Cancel.Text = "取消";
            this.Cancel.UseColumnTextForButtonValue = true;
            this.Cancel.Width = 80;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(714, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "3,装配组合：";
            // 
            // tbAssembleList
            // 
            this.tbAssembleList.Location = new System.Drawing.Point(22, 53);
            this.tbAssembleList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbAssembleList.Name = "tbAssembleList";
            this.tbAssembleList.Size = new System.Drawing.Size(195, 27);
            this.tbAssembleList.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(22, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "1,装配号选择：";
            // 
            // btnQueryAssembleList
            // 
            this.btnQueryAssembleList.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQueryAssembleList.Location = new System.Drawing.Point(269, 53);
            this.btnQueryAssembleList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQueryAssembleList.Name = "btnQueryAssembleList";
            this.btnQueryAssembleList.Size = new System.Drawing.Size(100, 27);
            this.btnQueryAssembleList.TabIndex = 6;
            this.btnQueryAssembleList.Text = "查询";
            this.btnQueryAssembleList.UseVisualStyleBackColor = true;
            this.btnQueryAssembleList.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgvAssembleList
            // 
            this.dgvAssembleList.AllowUserToAddRows = false;
            this.dgvAssembleList.AllowUserToDeleteRows = false;
            this.dgvAssembleList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAssembleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssembleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssembleNo1,
            this.AssembleName1,
            this.SheetNo1,
            this.TypeNo1,
            this.LevelHigh1,
            this.ImportantNo1,
            this.OwnerNo1});
            this.dgvAssembleList.Location = new System.Drawing.Point(22, 100);
            this.dgvAssembleList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvAssembleList.Name = "dgvAssembleList";
            this.dgvAssembleList.ReadOnly = true;
            this.dgvAssembleList.RowTemplate.Height = 23;
            this.dgvAssembleList.Size = new System.Drawing.Size(672, 100);
            this.dgvAssembleList.TabIndex = 7;
            // 
            // AssembleNo1
            // 
            this.AssembleNo1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AssembleNo1.DataPropertyName = "AssembleNo";
            this.AssembleNo1.HeaderText = "装配号";
            this.AssembleNo1.Name = "AssembleNo1";
            this.AssembleNo1.ReadOnly = true;
            this.AssembleNo1.Width = 90;
            // 
            // AssembleName1
            // 
            this.AssembleName1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AssembleName1.DataPropertyName = "AssembleName";
            this.AssembleName1.HeaderText = "装配名称";
            this.AssembleName1.Name = "AssembleName1";
            this.AssembleName1.ReadOnly = true;
            this.AssembleName1.Width = 109;
            // 
            // SheetNo1
            // 
            this.SheetNo1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SheetNo1.DataPropertyName = "SheetName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SheetNo1.DefaultCellStyle = dataGridViewCellStyle5;
            this.SheetNo1.HeaderText = "图幅";
            this.SheetNo1.Name = "SheetNo1";
            this.SheetNo1.ReadOnly = true;
            this.SheetNo1.Width = 71;
            // 
            // TypeNo1
            // 
            this.TypeNo1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TypeNo1.DataPropertyName = "TypeName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TypeNo1.DefaultCellStyle = dataGridViewCellStyle6;
            this.TypeNo1.HeaderText = "件型";
            this.TypeNo1.Name = "TypeNo1";
            this.TypeNo1.ReadOnly = true;
            this.TypeNo1.Width = 71;
            // 
            // LevelHigh1
            // 
            this.LevelHigh1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LevelHigh1.DataPropertyName = "LevelHigh";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LevelHigh1.DefaultCellStyle = dataGridViewCellStyle7;
            this.LevelHigh1.HeaderText = "最高装配";
            this.LevelHigh1.Name = "LevelHigh1";
            this.LevelHigh1.ReadOnly = true;
            this.LevelHigh1.Width = 109;
            // 
            // ImportantNo1
            // 
            this.ImportantNo1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ImportantNo1.DataPropertyName = "ImportantName";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ImportantNo1.DefaultCellStyle = dataGridViewCellStyle8;
            this.ImportantNo1.HeaderText = "重要度";
            this.ImportantNo1.Name = "ImportantNo1";
            this.ImportantNo1.ReadOnly = true;
            this.ImportantNo1.Width = 90;
            // 
            // OwnerNo1
            // 
            this.OwnerNo1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OwnerNo1.DataPropertyName = "OwnerName";
            this.OwnerNo1.HeaderText = "设计";
            this.OwnerNo1.Name = "OwnerNo1";
            this.OwnerNo1.ReadOnly = true;
            this.OwnerNo1.Width = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(22, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "2,下级件号选择：";
            // 
            // dgvNextLevel
            // 
            this.dgvNextLevel.AllowUserToAddRows = false;
            this.dgvNextLevel.AllowUserToDeleteRows = false;
            this.dgvNextLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNextLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNextLevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssembleNo2,
            this.AssembleName2,
            this.SheetNo2,
            this.TypeNo2,
            this.ImportantNo2,
            this.OwnerNo2});
            this.dgvNextLevel.Location = new System.Drawing.Point(22, 343);
            this.dgvNextLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvNextLevel.Name = "dgvNextLevel";
            this.dgvNextLevel.ReadOnly = true;
            this.dgvNextLevel.RowTemplate.Height = 23;
            this.dgvNextLevel.Size = new System.Drawing.Size(672, 100);
            this.dgvNextLevel.TabIndex = 9;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SheetNo2.DefaultCellStyle = dataGridViewCellStyle9;
            this.SheetNo2.HeaderText = "图幅";
            this.SheetNo2.Name = "SheetNo2";
            this.SheetNo2.ReadOnly = true;
            this.SheetNo2.Width = 71;
            // 
            // TypeNo2
            // 
            this.TypeNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TypeNo2.DataPropertyName = "TypeName";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TypeNo2.DefaultCellStyle = dataGridViewCellStyle10;
            this.TypeNo2.HeaderText = "件型";
            this.TypeNo2.Name = "TypeNo2";
            this.TypeNo2.ReadOnly = true;
            this.TypeNo2.Width = 71;
            // 
            // ImportantNo2
            // 
            this.ImportantNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ImportantNo2.DataPropertyName = "ImportantName";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ImportantNo2.DefaultCellStyle = dataGridViewCellStyle11;
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
            // tbNextLevel
            // 
            this.tbNextLevel.Location = new System.Drawing.Point(22, 300);
            this.tbNextLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNextLevel.Name = "tbNextLevel";
            this.tbNextLevel.Size = new System.Drawing.Size(195, 27);
            this.tbNextLevel.TabIndex = 10;
            // 
            // cbAssemble
            // 
            this.cbAssemble.AutoSize = true;
            this.cbAssemble.Location = new System.Drawing.Point(257, 305);
            this.cbAssemble.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbAssemble.Name = "cbAssemble";
            this.cbAssemble.Size = new System.Drawing.Size(87, 22);
            this.cbAssemble.TabIndex = 11;
            this.cbAssemble.Text = "组合件";
            this.cbAssemble.UseVisualStyleBackColor = true;
            // 
            // btnQueryNextLevel
            // 
            this.btnQueryNextLevel.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQueryNextLevel.Location = new System.Drawing.Point(360, 300);
            this.btnQueryNextLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQueryNextLevel.Name = "btnQueryNextLevel";
            this.btnQueryNextLevel.Size = new System.Drawing.Size(100, 27);
            this.btnQueryNextLevel.TabIndex = 12;
            this.btnQueryNextLevel.Text = "查询";
            this.btnQueryNextLevel.UseVisualStyleBackColor = true;
            this.btnQueryNextLevel.Click += new System.EventHandler(this.btnQueryNextLevel_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGenerate.Location = new System.Drawing.Point(244, 485);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(248, 73);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnOver
            // 
            this.btnOver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOver.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOver.Location = new System.Drawing.Point(946, 16);
            this.btnOver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOver.Name = "btnOver";
            this.btnOver.Size = new System.Drawing.Size(100, 27);
            this.btnOver.TabIndex = 14;
            this.btnOver.Text = "提交";
            this.btnOver.UseVisualStyleBackColor = true;
            this.btnOver.Click += new System.EventHandler(this.btnOver_Click);
            // 
            // frmAssembleInput
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 792);
            this.Controls.Add(this.btnOver);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnQueryNextLevel);
            this.Controls.Add(this.cbAssemble);
            this.Controls.Add(this.tbNextLevel);
            this.Controls.Add(this.dgvNextLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvAssembleList);
            this.Controls.Add(this.btnQueryAssembleList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAssembleList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAssemble);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAssembleInput";
            this.Text = "装配组合：";
            this.Load += new System.EventHandler(this.frmAssembleInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssemble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssembleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAssemble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAssembleList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQueryAssembleList;
        private System.Windows.Forms.DataGridView dgvAssembleList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvNextLevel;
        private System.Windows.Forms.TextBox tbNextLevel;
        private System.Windows.Forms.CheckBox cbAssemble;
        private System.Windows.Forms.Button btnQueryNextLevel;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnOver;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssembleNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssembleName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SheetNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelHigh1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportantNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssembleNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssembleName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SheetNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportantNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectAssembleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectNextLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectRemark;
        private System.Windows.Forms.DataGridViewButtonColumn Cancel;

    }
}