namespace Xk
{
    partial class frmDelete
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelete));
            this.dgvNextLevel1 = new System.Windows.Forms.DataGridView();
            this.AssembleNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssembleName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SheetNo2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sheetListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new Xk.DataSet1();
            this.TypeNo2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ImportantNo2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.importantListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OwnerNo2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ownerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnQueryNextLevel = new System.Windows.Forms.Button();
            this.cbAssemble1 = new System.Windows.Forms.CheckBox();
            this.tbNextLevel = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAssembleNo = new System.Windows.Forms.TextBox();
            this.tbNextNo = new System.Windows.Forms.TextBox();
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.btnDeleteAssemble = new System.Windows.Forms.Button();
            this.btnAssemble = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAssemble = new System.Windows.Forms.DataGridView();
            this.CoNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoAssembleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoNextLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.typeListTableAdapter = new Xk.DataSet1TableAdapters.TypeListTableAdapter();
            this.sheetListTableAdapter = new Xk.DataSet1TableAdapters.SheetListTableAdapter();
            this.importantListTableAdapter = new Xk.DataSet1TableAdapters.ImportantListTableAdapter();
            this.ownerListTableAdapter = new Xk.DataSet1TableAdapters.OwnerListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importantListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerListBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssemble)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNextLevel1
            // 
            this.dgvNextLevel1.AllowUserToAddRows = false;
            this.dgvNextLevel1.AllowUserToDeleteRows = false;
            this.dgvNextLevel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNextLevel1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssembleNo2,
            this.AssembleName2,
            this.SheetNo2,
            this.TypeNo2,
            this.ImportantNo2,
            this.OwnerNo2});
            this.dgvNextLevel1.Location = new System.Drawing.Point(14, 149);
            this.dgvNextLevel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dgvNextLevel1.Name = "dgvNextLevel1";
            this.dgvNextLevel1.RowTemplate.Height = 23;
            this.dgvNextLevel1.Size = new System.Drawing.Size(850, 115);
            this.dgvNextLevel1.TabIndex = 26;
            // 
            // AssembleNo2
            // 
            this.AssembleNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AssembleNo2.DataPropertyName = "No";
            this.AssembleNo2.HeaderText = "件号";
            this.AssembleNo2.Name = "AssembleNo2";
            this.AssembleNo2.ReadOnly = true;
            this.AssembleNo2.Width = 76;
            // 
            // AssembleName2
            // 
            this.AssembleName2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AssembleName2.DataPropertyName = "Name";
            this.AssembleName2.HeaderText = "名称";
            this.AssembleName2.Name = "AssembleName2";
            this.AssembleName2.Width = 76;
            // 
            // SheetNo2
            // 
            this.SheetNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SheetNo2.DataPropertyName = "SheetNo";
            this.SheetNo2.DataSource = this.sheetListBindingSource;
            this.SheetNo2.DisplayMember = "SheetName";
            this.SheetNo2.HeaderText = "图幅";
            this.SheetNo2.Name = "SheetNo2";
            this.SheetNo2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SheetNo2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SheetNo2.ValueMember = "SheetNo";
            this.SheetNo2.Width = 76;
            // 
            // sheetListBindingSource
            // 
            this.sheetListBindingSource.DataMember = "SheetList";
            this.sheetListBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TypeNo2
            // 
            this.TypeNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TypeNo2.DataPropertyName = "TypeNo";
            this.TypeNo2.DataSource = this.typeListBindingSource;
            this.TypeNo2.DisplayMember = "TypeName";
            this.TypeNo2.HeaderText = "件型";
            this.TypeNo2.Name = "TypeNo2";
            this.TypeNo2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeNo2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TypeNo2.ValueMember = "TypeNo";
            this.TypeNo2.Width = 76;
            // 
            // typeListBindingSource
            // 
            this.typeListBindingSource.DataMember = "TypeList";
            this.typeListBindingSource.DataSource = this.dataSet11;
            // 
            // ImportantNo2
            // 
            this.ImportantNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ImportantNo2.DataPropertyName = "ImportantNo";
            this.ImportantNo2.DataSource = this.importantListBindingSource;
            this.ImportantNo2.DisplayMember = "ImportantName";
            this.ImportantNo2.HeaderText = "重要度";
            this.ImportantNo2.Name = "ImportantNo2";
            this.ImportantNo2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImportantNo2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ImportantNo2.ValueMember = "ImportantNo";
            this.ImportantNo2.Width = 97;
            // 
            // importantListBindingSource
            // 
            this.importantListBindingSource.DataMember = "ImportantList";
            this.importantListBindingSource.DataSource = this.dataSet11;
            // 
            // OwnerNo2
            // 
            this.OwnerNo2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OwnerNo2.DataPropertyName = "OwnerNo";
            this.OwnerNo2.DataSource = this.ownerListBindingSource;
            this.OwnerNo2.DisplayMember = "OwnerName";
            this.OwnerNo2.HeaderText = "设计";
            this.OwnerNo2.Name = "OwnerNo2";
            this.OwnerNo2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OwnerNo2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OwnerNo2.ValueMember = "OwnerNo";
            this.OwnerNo2.Width = 76;
            // 
            // ownerListBindingSource
            // 
            this.ownerListBindingSource.DataMember = "OwnerList";
            this.ownerListBindingSource.DataSource = this.dataSet11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(14, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "请输入件号：";
            // 
            // btnQueryNextLevel
            // 
            this.btnQueryNextLevel.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQueryNextLevel.Location = new System.Drawing.Point(353, 84);
            this.btnQueryNextLevel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnQueryNextLevel.Name = "btnQueryNextLevel";
            this.btnQueryNextLevel.Size = new System.Drawing.Size(100, 31);
            this.btnQueryNextLevel.TabIndex = 24;
            this.btnQueryNextLevel.Text = "查询";
            this.btnQueryNextLevel.UseVisualStyleBackColor = true;
            this.btnQueryNextLevel.Click += new System.EventHandler(this.btnQueryNextLevel_Click);
            // 
            // cbAssemble1
            // 
            this.cbAssemble1.AutoSize = true;
            this.cbAssemble1.Location = new System.Drawing.Point(195, 97);
            this.cbAssemble1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbAssemble1.Name = "cbAssemble1";
            this.cbAssemble1.Size = new System.Drawing.Size(94, 24);
            this.cbAssemble1.TabIndex = 23;
            this.cbAssemble1.Text = "组合件";
            this.cbAssemble1.UseVisualStyleBackColor = true;
            // 
            // tbNextLevel
            // 
            this.tbNextLevel.Location = new System.Drawing.Point(14, 90);
            this.tbNextLevel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbNextLevel.Name = "tbNextLevel";
            this.tbNextLevel.Size = new System.Drawing.Size(143, 30);
            this.tbNextLevel.TabIndex = 22;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(761, 84);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 31);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChange.Location = new System.Drawing.Point(557, 84);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 31);
            this.btnChange.TabIndex = 32;
            this.btnChange.Text = "更改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.tbNextLevel);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.cbAssemble1);
            this.groupBox1.Controls.Add(this.dgvNextLevel1);
            this.groupBox1.Controls.Add(this.btnQueryNextLevel);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(47, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 330);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "零部件调整";
            // 
            // tbAssembleNo
            // 
            this.tbAssembleNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAssembleNo.Location = new System.Drawing.Point(14, 109);
            this.tbAssembleNo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbAssembleNo.Name = "tbAssembleNo";
            this.tbAssembleNo.Size = new System.Drawing.Size(143, 30);
            this.tbAssembleNo.TabIndex = 33;
            // 
            // tbNextNo
            // 
            this.tbNextNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNextNo.Location = new System.Drawing.Point(188, 109);
            this.tbNextNo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbNextNo.Name = "tbNextNo";
            this.tbNextNo.Size = new System.Drawing.Size(143, 30);
            this.tbNextNo.TabIndex = 34;
            // 
            // tbGroup
            // 
            this.tbGroup.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbGroup.Location = new System.Drawing.Point(362, 109);
            this.tbGroup.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(143, 30);
            this.tbGroup.TabIndex = 35;
            // 
            // btnDeleteAssemble
            // 
            this.btnDeleteAssemble.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleteAssemble.Location = new System.Drawing.Point(764, 104);
            this.btnDeleteAssemble.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnDeleteAssemble.Name = "btnDeleteAssemble";
            this.btnDeleteAssemble.Size = new System.Drawing.Size(100, 31);
            this.btnDeleteAssemble.TabIndex = 34;
            this.btnDeleteAssemble.Text = "删除";
            this.btnDeleteAssemble.UseVisualStyleBackColor = true;
            this.btnDeleteAssemble.Click += new System.EventHandler(this.btnDeleteAssemble_Click);
            // 
            // btnAssemble
            // 
            this.btnAssemble.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAssemble.Location = new System.Drawing.Point(536, 104);
            this.btnAssemble.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAssemble.Name = "btnAssemble";
            this.btnAssemble.Size = new System.Drawing.Size(100, 31);
            this.btnAssemble.TabIndex = 33;
            this.btnAssemble.Text = "查询";
            this.btnAssemble.UseVisualStyleBackColor = true;
            this.btnAssemble.Click += new System.EventHandler(this.btnAssemble_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "请输入组合号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(185, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "请输入下级件号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(359, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "请输入分组号：";
            // 
            // dgvAssemble
            // 
            this.dgvAssemble.AllowUserToAddRows = false;
            this.dgvAssemble.AllowUserToDeleteRows = false;
            this.dgvAssemble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssemble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoNo,
            this.CoAssembleNo,
            this.CoNextLevel,
            this.CoNumber,
            this.CoLevel,
            this.CoRemark});
            this.dgvAssemble.Location = new System.Drawing.Point(14, 171);
            this.dgvAssemble.Name = "dgvAssemble";
            this.dgvAssemble.RowTemplate.Height = 23;
            this.dgvAssemble.Size = new System.Drawing.Size(850, 150);
            this.dgvAssemble.TabIndex = 38;
            // 
            // CoNo
            // 
            this.CoNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CoNo.DataPropertyName = "No";
            this.CoNo.HeaderText = "序号";
            this.CoNo.Name = "CoNo";
            this.CoNo.ReadOnly = true;
            this.CoNo.Width = 76;
            // 
            // CoAssembleNo
            // 
            this.CoAssembleNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CoAssembleNo.DataPropertyName = "AssembleNo";
            this.CoAssembleNo.HeaderText = "组合号";
            this.CoAssembleNo.Name = "CoAssembleNo";
            this.CoAssembleNo.ReadOnly = true;
            this.CoAssembleNo.Width = 97;
            // 
            // CoNextLevel
            // 
            this.CoNextLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CoNextLevel.DataPropertyName = "NextLevel";
            this.CoNextLevel.HeaderText = "下级件号";
            this.CoNextLevel.Name = "CoNextLevel";
            this.CoNextLevel.ReadOnly = true;
            this.CoNextLevel.Width = 118;
            // 
            // CoNumber
            // 
            this.CoNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CoNumber.DataPropertyName = "Number";
            this.CoNumber.HeaderText = "数量";
            this.CoNumber.Name = "CoNumber";
            this.CoNumber.Width = 76;
            // 
            // CoLevel
            // 
            this.CoLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CoLevel.DataPropertyName = "Level";
            this.CoLevel.HeaderText = "分组";
            this.CoLevel.Name = "CoLevel";
            this.CoLevel.Width = 76;
            // 
            // CoRemark
            // 
            this.CoRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CoRemark.DataPropertyName = "Remark";
            this.CoRemark.HeaderText = "备注";
            this.CoRemark.Name = "CoRemark";
            this.CoRemark.Width = 76;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgvAssemble);
            this.groupBox2.Controls.Add(this.tbAssembleNo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbNextNo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbGroup);
            this.groupBox2.Controls.Add(this.btnAssemble);
            this.groupBox2.Controls.Add(this.btnDeleteAssemble);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(47, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(901, 364);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "装配调整";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(649, 103);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 33;
            this.button1.Text = "更改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // typeListTableAdapter
            // 
            this.typeListTableAdapter.ClearBeforeFill = true;
            // 
            // sheetListTableAdapter
            // 
            this.sheetListTableAdapter.ClearBeforeFill = true;
            // 
            // importantListTableAdapter
            // 
            this.importantListTableAdapter.ClearBeforeFill = true;
            // 
            // ownerListTableAdapter
            // 
            this.ownerListTableAdapter.ClearBeforeFill = true;
            // 
            // frmDelete
            // 
            this.AcceptButton = this.btnQueryNextLevel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 826);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDelete";
            this.Text = "零部件及装配调整";
            this.Load += new System.EventHandler(this.frmDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importantListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerListBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssemble)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNextLevel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQueryNextLevel;
        private System.Windows.Forms.CheckBox cbAssemble1;
        private System.Windows.Forms.TextBox tbNextLevel;
        private System.Windows.Forms.Button btnDelete;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.TypeListTableAdapter typeListTableAdapter;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.BindingSource sheetListBindingSource;
        private DataSet1TableAdapters.SheetListTableAdapter sheetListTableAdapter;
        private System.Windows.Forms.BindingSource importantListBindingSource;
        private DataSet1TableAdapters.ImportantListTableAdapter importantListTableAdapter;
        private System.Windows.Forms.BindingSource ownerListBindingSource;
        private DataSet1TableAdapters.OwnerListTableAdapter ownerListTableAdapter;
        private System.Windows.Forms.BindingSource typeListBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAssembleNo;
        private System.Windows.Forms.TextBox tbNextNo;
        private System.Windows.Forms.TextBox tbGroup;
        private System.Windows.Forms.Button btnDeleteAssemble;
        private System.Windows.Forms.Button btnAssemble;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAssemble;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssembleNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssembleName2;
        private System.Windows.Forms.DataGridViewComboBoxColumn SheetNo2;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypeNo2;
        private System.Windows.Forms.DataGridViewComboBoxColumn ImportantNo2;
        private System.Windows.Forms.DataGridViewComboBoxColumn OwnerNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoAssembleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoNextLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoRemark;
    }
}