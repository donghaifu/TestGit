namespace Xk
{
    partial class frmAssemblePartInput
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
            System.Windows.Forms.Label assembleNoLabel;
            System.Windows.Forms.Label assembleNameLabel;
            System.Windows.Forms.Label sheetNoLabel;
            System.Windows.Forms.Label typeNoLabel;
            System.Windows.Forms.Label levelHighLabel;
            System.Windows.Forms.Label importantNoLabel;
            System.Windows.Forms.Label ownerNoLabel;
            System.Windows.Forms.Label validDateLabel;
            System.Windows.Forms.Label remarkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssemblePartInput));
            this.dataSet1 = new Xk.DataSet1();
            this.assembleListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assembleListTableAdapter = new Xk.DataSet1TableAdapters.AssembleListTableAdapter();
            this.tableAdapterManager = new Xk.DataSet1TableAdapters.TableAdapterManager();
            this.assembleListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.assembleListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.assembleNoTextBox = new System.Windows.Forms.TextBox();
            this.assembleNameTextBox = new System.Windows.Forms.TextBox();
            this.validDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sheetListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.typeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.importantListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.ownerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.sheetListTableAdapter = new Xk.DataSet1TableAdapters.SheetListTableAdapter();
            this.typeListTableAdapter = new Xk.DataSet1TableAdapters.TypeListTableAdapter();
            this.importantListTableAdapter = new Xk.DataSet1TableAdapters.ImportantListTableAdapter();
            this.ownerListTableAdapter = new Xk.DataSet1TableAdapters.OwnerListTableAdapter();
            assembleNoLabel = new System.Windows.Forms.Label();
            assembleNameLabel = new System.Windows.Forms.Label();
            sheetNoLabel = new System.Windows.Forms.Label();
            typeNoLabel = new System.Windows.Forms.Label();
            levelHighLabel = new System.Windows.Forms.Label();
            importantNoLabel = new System.Windows.Forms.Label();
            ownerNoLabel = new System.Windows.Forms.Label();
            validDateLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assembleListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assembleListBindingNavigator)).BeginInit();
            this.assembleListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheetListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importantListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // assembleNoLabel
            // 
            assembleNoLabel.AutoSize = true;
            assembleNoLabel.Location = new System.Drawing.Point(37, 65);
            assembleNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            assembleNoLabel.Name = "assembleNoLabel";
            assembleNoLabel.Size = new System.Drawing.Size(75, 18);
            assembleNoLabel.TabIndex = 11;
            assembleNoLabel.Text = "装配号:";
            // 
            // assembleNameLabel
            // 
            assembleNameLabel.AutoSize = true;
            assembleNameLabel.Location = new System.Drawing.Point(37, 97);
            assembleNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            assembleNameLabel.Name = "assembleNameLabel";
            assembleNameLabel.Size = new System.Drawing.Size(94, 18);
            assembleNameLabel.TabIndex = 12;
            assembleNameLabel.Text = "装配名称:";
            // 
            // sheetNoLabel
            // 
            sheetNoLabel.AutoSize = true;
            sheetNoLabel.Location = new System.Drawing.Point(37, 128);
            sheetNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sheetNoLabel.Name = "sheetNoLabel";
            sheetNoLabel.Size = new System.Drawing.Size(56, 18);
            sheetNoLabel.TabIndex = 13;
            sheetNoLabel.Text = "图幅:";
            // 
            // typeNoLabel
            // 
            typeNoLabel.AutoSize = true;
            typeNoLabel.Location = new System.Drawing.Point(37, 160);
            typeNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            typeNoLabel.Name = "typeNoLabel";
            typeNoLabel.Size = new System.Drawing.Size(56, 18);
            typeNoLabel.TabIndex = 14;
            typeNoLabel.Text = "件型:";
            // 
            // levelHighLabel
            // 
            levelHighLabel.AutoSize = true;
            levelHighLabel.Location = new System.Drawing.Point(37, 191);
            levelHighLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            levelHighLabel.Name = "levelHighLabel";
            levelHighLabel.Size = new System.Drawing.Size(94, 18);
            levelHighLabel.TabIndex = 15;
            levelHighLabel.Text = "最高装配:";
            // 
            // importantNoLabel
            // 
            importantNoLabel.AutoSize = true;
            importantNoLabel.Location = new System.Drawing.Point(37, 223);
            importantNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            importantNoLabel.Name = "importantNoLabel";
            importantNoLabel.Size = new System.Drawing.Size(75, 18);
            importantNoLabel.TabIndex = 16;
            importantNoLabel.Text = "重要度:";
            // 
            // ownerNoLabel
            // 
            ownerNoLabel.AutoSize = true;
            ownerNoLabel.Location = new System.Drawing.Point(37, 254);
            ownerNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ownerNoLabel.Name = "ownerNoLabel";
            ownerNoLabel.Size = new System.Drawing.Size(56, 18);
            ownerNoLabel.TabIndex = 17;
            ownerNoLabel.Text = "设计:";
            // 
            // validDateLabel
            // 
            validDateLabel.AutoSize = true;
            validDateLabel.Location = new System.Drawing.Point(37, 287);
            validDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            validDateLabel.Name = "validDateLabel";
            validDateLabel.Size = new System.Drawing.Size(94, 18);
            validDateLabel.TabIndex = 18;
            validDateLabel.Text = "生效日期:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(37, 317);
            remarkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(56, 18);
            remarkLabel.TabIndex = 19;
            remarkLabel.Text = "备注:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assembleListBindingSource
            // 
            this.assembleListBindingSource.DataMember = "AssembleList";
            this.assembleListBindingSource.DataSource = this.dataSet1;
            // 
            // assembleListTableAdapter
            // 
            this.assembleListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssembleListTableAdapter = this.assembleListTableAdapter;
            this.tableAdapterManager.AssembleTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ImportantListTableAdapter = null;
            this.tableAdapterManager.OwnerListTableAdapter = null;
            this.tableAdapterManager.PartListTableAdapter = null;
            this.tableAdapterManager.SalesListTableAdapter = null;
            this.tableAdapterManager.SheetListTableAdapter = null;
            this.tableAdapterManager.TypeListTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Xk.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // assembleListBindingNavigator
            // 
            this.assembleListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.assembleListBindingNavigator.BindingSource = this.assembleListBindingSource;
            this.assembleListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.assembleListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.assembleListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.assembleListBindingNavigatorSaveItem});
            this.assembleListBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.assembleListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.assembleListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.assembleListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.assembleListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.assembleListBindingNavigator.Name = "assembleListBindingNavigator";
            this.assembleListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.assembleListBindingNavigator.Size = new System.Drawing.Size(453, 25);
            this.assembleListBindingNavigator.TabIndex = 0;
            this.assembleListBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // assembleListBindingNavigatorSaveItem
            // 
            this.assembleListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.assembleListBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("assembleListBindingNavigatorSaveItem.Image")));
            this.assembleListBindingNavigatorSaveItem.Name = "assembleListBindingNavigatorSaveItem";
            this.assembleListBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.assembleListBindingNavigatorSaveItem.Text = "保存数据";
            this.assembleListBindingNavigatorSaveItem.Click += new System.EventHandler(this.assembleListBindingNavigatorSaveItem_Click);
            // 
            // assembleNoTextBox
            // 
            this.assembleNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assembleListBindingSource, "AssembleNo", true));
            this.assembleNoTextBox.Location = new System.Drawing.Point(132, 61);
            this.assembleNoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.assembleNoTextBox.Name = "assembleNoTextBox";
            this.assembleNoTextBox.Size = new System.Drawing.Size(265, 27);
            this.assembleNoTextBox.TabIndex = 1;
            // 
            // assembleNameTextBox
            // 
            this.assembleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assembleListBindingSource, "AssembleName", true));
            this.assembleNameTextBox.Location = new System.Drawing.Point(132, 92);
            this.assembleNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.assembleNameTextBox.Name = "assembleNameTextBox";
            this.assembleNameTextBox.Size = new System.Drawing.Size(265, 27);
            this.assembleNameTextBox.TabIndex = 2;
            // 
            // validDateDateTimePicker
            // 
            this.validDateDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.validDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.validDateDateTimePicker.Location = new System.Drawing.Point(132, 281);
            this.validDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.validDateDateTimePicker.Name = "validDateDateTimePicker";
            this.validDateDateTimePicker.Size = new System.Drawing.Size(265, 27);
            this.validDateDateTimePicker.TabIndex = 8;
            this.validDateDateTimePicker.Visible = false;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assembleListBindingSource, "Remark", true));
            this.remarkTextBox.Enabled = false;
            this.remarkTextBox.Location = new System.Drawing.Point(132, 313);
            this.remarkTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(265, 27);
            this.remarkTextBox.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.assembleListBindingSource, "SheetNo", true));
            this.comboBox1.DataSource = this.sheetListBindingSource;
            this.comboBox1.DisplayMember = "SheetName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 125);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 25);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "SheetNo";
            // 
            // sheetListBindingSource
            // 
            this.sheetListBindingSource.DataMember = "SheetList";
            this.sheetListBindingSource.DataSource = this.dataSet1;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.assembleListBindingSource, "TypeNo", true));
            this.comboBox2.DataSource = this.typeListBindingSource;
            this.comboBox2.DisplayMember = "TypeName";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(132, 156);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(265, 25);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "TypeNo";
            // 
            // typeListBindingSource
            // 
            this.typeListBindingSource.DataMember = "TypeList";
            this.typeListBindingSource.DataSource = this.dataSet1;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.assembleListBindingSource, "ImportantNo", true));
            this.comboBox3.DataSource = this.importantListBindingSource;
            this.comboBox3.DisplayMember = "ImportantName";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(132, 218);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(265, 25);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.ValueMember = "ImportantNo";
            // 
            // importantListBindingSource
            // 
            this.importantListBindingSource.DataMember = "ImportantList";
            this.importantListBindingSource.DataSource = this.dataSet1;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.assembleListBindingSource, "OwnerNo", true));
            this.comboBox4.DataSource = this.ownerListBindingSource;
            this.comboBox4.DisplayMember = "OwnerName";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(132, 250);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(265, 25);
            this.comboBox4.TabIndex = 7;
            this.comboBox4.ValueMember = "OwnerNo";
            // 
            // ownerListBindingSource
            // 
            this.ownerListBindingSource.DataMember = "OwnerList";
            this.ownerListBindingSource.DataSource = this.dataSet1;
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.assembleListBindingSource, "LevelHigh", true));
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "是",
            "否"});
            this.comboBox5.Location = new System.Drawing.Point(132, 187);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(265, 25);
            this.comboBox5.TabIndex = 5;
            // 
            // sheetListTableAdapter
            // 
            this.sheetListTableAdapter.ClearBeforeFill = true;
            // 
            // typeListTableAdapter
            // 
            this.typeListTableAdapter.ClearBeforeFill = true;
            // 
            // importantListTableAdapter
            // 
            this.importantListTableAdapter.ClearBeforeFill = true;
            // 
            // ownerListTableAdapter
            // 
            this.ownerListTableAdapter.ClearBeforeFill = true;
            // 
            // frmAssemblePartInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 393);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(assembleNoLabel);
            this.Controls.Add(this.assembleNoTextBox);
            this.Controls.Add(assembleNameLabel);
            this.Controls.Add(this.assembleNameTextBox);
            this.Controls.Add(sheetNoLabel);
            this.Controls.Add(typeNoLabel);
            this.Controls.Add(levelHighLabel);
            this.Controls.Add(importantNoLabel);
            this.Controls.Add(ownerNoLabel);
            this.Controls.Add(validDateLabel);
            this.Controls.Add(this.validDateDateTimePicker);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkTextBox);
            this.Controls.Add(this.assembleListBindingNavigator);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAssemblePartInput";
            this.Text = "组合件输入";
            this.Load += new System.EventHandler(this.frmAssemblePartInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assembleListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assembleListBindingNavigator)).EndInit();
            this.assembleListBindingNavigator.ResumeLayout(false);
            this.assembleListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheetListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importantListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource assembleListBindingSource;
        private DataSet1TableAdapters.AssembleListTableAdapter assembleListTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator assembleListBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton assembleListBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox assembleNoTextBox;
        private System.Windows.Forms.TextBox assembleNameTextBox;
        private System.Windows.Forms.DateTimePicker validDateDateTimePicker;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.BindingSource sheetListBindingSource;
        private DataSet1TableAdapters.SheetListTableAdapter sheetListTableAdapter;
        private System.Windows.Forms.BindingSource typeListBindingSource;
        private DataSet1TableAdapters.TypeListTableAdapter typeListTableAdapter;
        private System.Windows.Forms.BindingSource importantListBindingSource;
        private DataSet1TableAdapters.ImportantListTableAdapter importantListTableAdapter;
        private System.Windows.Forms.BindingSource ownerListBindingSource;
        private DataSet1TableAdapters.OwnerListTableAdapter ownerListTableAdapter;
    }
}