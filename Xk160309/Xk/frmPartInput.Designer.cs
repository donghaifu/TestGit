namespace Xk
{
    partial class frmPartInput
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
            System.Windows.Forms.Label partNoLabel;
            System.Windows.Forms.Label partNameLabel;
            System.Windows.Forms.Label sheetNoLabel;
            System.Windows.Forms.Label typeNoLabel;
            System.Windows.Forms.Label standardPartLabel;
            System.Windows.Forms.Label importantNoLabel;
            System.Windows.Forms.Label ownerNoLabel;
            System.Windows.Forms.Label validDateLabel;
            System.Windows.Forms.Label remarkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartInput));
            this.dataSet1 = new Xk.DataSet1();
            this.partListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partListTableAdapter = new Xk.DataSet1TableAdapters.PartListTableAdapter();
            this.tableAdapterManager = new Xk.DataSet1TableAdapters.TableAdapterManager();
            this.importantListTableAdapter = new Xk.DataSet1TableAdapters.ImportantListTableAdapter();
            this.ownerListTableAdapter = new Xk.DataSet1TableAdapters.OwnerListTableAdapter();
            this.sheetListTableAdapter = new Xk.DataSet1TableAdapters.SheetListTableAdapter();
            this.typeListTableAdapter = new Xk.DataSet1TableAdapters.TypeListTableAdapter();
            this.partListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.partListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.partNoTextBox = new System.Windows.Forms.TextBox();
            this.partNameTextBox = new System.Windows.Forms.TextBox();
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
            partNoLabel = new System.Windows.Forms.Label();
            partNameLabel = new System.Windows.Forms.Label();
            sheetNoLabel = new System.Windows.Forms.Label();
            typeNoLabel = new System.Windows.Forms.Label();
            standardPartLabel = new System.Windows.Forms.Label();
            importantNoLabel = new System.Windows.Forms.Label();
            ownerNoLabel = new System.Windows.Forms.Label();
            validDateLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partListBindingNavigator)).BeginInit();
            this.partListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheetListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importantListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // partNoLabel
            // 
            partNoLabel.AutoSize = true;
            partNoLabel.Location = new System.Drawing.Point(38, 61);
            partNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            partNoLabel.Name = "partNoLabel";
            partNoLabel.Size = new System.Drawing.Size(75, 18);
            partNoLabel.TabIndex = 11;
            partNoLabel.Text = "零件号:";
            // 
            // partNameLabel
            // 
            partNameLabel.AutoSize = true;
            partNameLabel.Location = new System.Drawing.Point(38, 92);
            partNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            partNameLabel.Name = "partNameLabel";
            partNameLabel.Size = new System.Drawing.Size(94, 18);
            partNameLabel.TabIndex = 12;
            partNameLabel.Text = "零件名称:";
            // 
            // sheetNoLabel
            // 
            sheetNoLabel.AutoSize = true;
            sheetNoLabel.Location = new System.Drawing.Point(38, 124);
            sheetNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sheetNoLabel.Name = "sheetNoLabel";
            sheetNoLabel.Size = new System.Drawing.Size(56, 18);
            sheetNoLabel.TabIndex = 13;
            sheetNoLabel.Text = "图幅:";
            // 
            // typeNoLabel
            // 
            typeNoLabel.AutoSize = true;
            typeNoLabel.Location = new System.Drawing.Point(38, 155);
            typeNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            typeNoLabel.Name = "typeNoLabel";
            typeNoLabel.Size = new System.Drawing.Size(56, 18);
            typeNoLabel.TabIndex = 14;
            typeNoLabel.Text = "件型:";
            // 
            // standardPartLabel
            // 
            standardPartLabel.AutoSize = true;
            standardPartLabel.Location = new System.Drawing.Point(38, 187);
            standardPartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            standardPartLabel.Name = "standardPartLabel";
            standardPartLabel.Size = new System.Drawing.Size(75, 18);
            standardPartLabel.TabIndex = 15;
            standardPartLabel.Text = "标准件:";
            // 
            // importantNoLabel
            // 
            importantNoLabel.AutoSize = true;
            importantNoLabel.Location = new System.Drawing.Point(38, 218);
            importantNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            importantNoLabel.Name = "importantNoLabel";
            importantNoLabel.Size = new System.Drawing.Size(75, 18);
            importantNoLabel.TabIndex = 16;
            importantNoLabel.Text = "重要度:";
            // 
            // ownerNoLabel
            // 
            ownerNoLabel.AutoSize = true;
            ownerNoLabel.Location = new System.Drawing.Point(38, 250);
            ownerNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ownerNoLabel.Name = "ownerNoLabel";
            ownerNoLabel.Size = new System.Drawing.Size(56, 18);
            ownerNoLabel.TabIndex = 17;
            ownerNoLabel.Text = "设计:";
            // 
            // validDateLabel
            // 
            validDateLabel.AutoSize = true;
            validDateLabel.Location = new System.Drawing.Point(38, 282);
            validDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            validDateLabel.Name = "validDateLabel";
            validDateLabel.Size = new System.Drawing.Size(94, 18);
            validDateLabel.TabIndex = 18;
            validDateLabel.Text = "生效时间:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(38, 313);
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
            // partListBindingSource
            // 
            this.partListBindingSource.DataMember = "PartList";
            this.partListBindingSource.DataSource = this.dataSet1;
            // 
            // partListTableAdapter
            // 
            this.partListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssembleListTableAdapter = null;
            this.tableAdapterManager.AssembleTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ImportantListTableAdapter = this.importantListTableAdapter;
            this.tableAdapterManager.OwnerListTableAdapter = this.ownerListTableAdapter;
            this.tableAdapterManager.PartListTableAdapter = this.partListTableAdapter;
            this.tableAdapterManager.SalesListTableAdapter = null;
            this.tableAdapterManager.SheetListTableAdapter = this.sheetListTableAdapter;
            this.tableAdapterManager.TypeListTableAdapter = this.typeListTableAdapter;
            this.tableAdapterManager.UpdateOrder = Xk.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // importantListTableAdapter
            // 
            this.importantListTableAdapter.ClearBeforeFill = true;
            // 
            // ownerListTableAdapter
            // 
            this.ownerListTableAdapter.ClearBeforeFill = true;
            // 
            // sheetListTableAdapter
            // 
            this.sheetListTableAdapter.ClearBeforeFill = true;
            // 
            // typeListTableAdapter
            // 
            this.typeListTableAdapter.ClearBeforeFill = true;
            // 
            // partListBindingNavigator
            // 
            this.partListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.partListBindingNavigator.BindingSource = this.partListBindingSource;
            this.partListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.partListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.partListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.partListBindingNavigatorSaveItem});
            this.partListBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.partListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.partListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.partListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.partListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.partListBindingNavigator.Name = "partListBindingNavigator";
            this.partListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.partListBindingNavigator.Size = new System.Drawing.Size(439, 25);
            this.partListBindingNavigator.TabIndex = 0;
            this.partListBindingNavigator.Text = "bindingNavigator1";
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
            // partListBindingNavigatorSaveItem
            // 
            this.partListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.partListBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("partListBindingNavigatorSaveItem.Image")));
            this.partListBindingNavigatorSaveItem.Name = "partListBindingNavigatorSaveItem";
            this.partListBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.partListBindingNavigatorSaveItem.Text = "保存数据";
            this.partListBindingNavigatorSaveItem.Click += new System.EventHandler(this.partListBindingNavigatorSaveItem_Click);
            // 
            // partNoTextBox
            // 
            this.partNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partListBindingSource, "PartNo", true));
            this.partNoTextBox.Location = new System.Drawing.Point(129, 56);
            this.partNoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.partNoTextBox.Name = "partNoTextBox";
            this.partNoTextBox.Size = new System.Drawing.Size(265, 27);
            this.partNoTextBox.TabIndex = 1;
            // 
            // partNameTextBox
            // 
            this.partNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partListBindingSource, "PartName", true));
            this.partNameTextBox.Location = new System.Drawing.Point(129, 86);
            this.partNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.partNameTextBox.Name = "partNameTextBox";
            this.partNameTextBox.Size = new System.Drawing.Size(265, 27);
            this.partNameTextBox.TabIndex = 2;
            // 
            // validDateDateTimePicker
            // 
            this.validDateDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.validDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.validDateDateTimePicker.Location = new System.Drawing.Point(129, 275);
            this.validDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.validDateDateTimePicker.Name = "validDateDateTimePicker";
            this.validDateDateTimePicker.Size = new System.Drawing.Size(265, 27);
            this.validDateDateTimePicker.TabIndex = 8;
            this.validDateDateTimePicker.Visible = false;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partListBindingSource, "Remark", true));
            this.remarkTextBox.Enabled = false;
            this.remarkTextBox.Location = new System.Drawing.Point(129, 307);
            this.remarkTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(265, 27);
            this.remarkTextBox.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partListBindingSource, "SheetNo", true));
            this.comboBox1.DataSource = this.sheetListBindingSource;
            this.comboBox1.DisplayMember = "SheetName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 119);
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
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partListBindingSource, "TypeNo", true));
            this.comboBox2.DataSource = this.typeListBindingSource;
            this.comboBox2.DisplayMember = "TypeName";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(129, 150);
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
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partListBindingSource, "ImportantNo", true));
            this.comboBox3.DataSource = this.importantListBindingSource;
            this.comboBox3.DisplayMember = "ImportantName";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(129, 213);
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
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partListBindingSource, "OwnerNo", true));
            this.comboBox4.DataSource = this.ownerListBindingSource;
            this.comboBox4.DisplayMember = "OwnerName";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(129, 245);
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
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.partListBindingSource, "StandardPart", true));
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "是",
            "否"});
            this.comboBox5.Location = new System.Drawing.Point(129, 183);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(265, 25);
            this.comboBox5.TabIndex = 5;
            // 
            // frmPartInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 376);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(partNoLabel);
            this.Controls.Add(this.partNoTextBox);
            this.Controls.Add(partNameLabel);
            this.Controls.Add(this.partNameTextBox);
            this.Controls.Add(sheetNoLabel);
            this.Controls.Add(typeNoLabel);
            this.Controls.Add(standardPartLabel);
            this.Controls.Add(importantNoLabel);
            this.Controls.Add(ownerNoLabel);
            this.Controls.Add(validDateLabel);
            this.Controls.Add(this.validDateDateTimePicker);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkTextBox);
            this.Controls.Add(this.partListBindingNavigator);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPartInput";
            this.Text = "零件输入";
            this.Load += new System.EventHandler(this.frmPartInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partListBindingNavigator)).EndInit();
            this.partListBindingNavigator.ResumeLayout(false);
            this.partListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sheetListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importantListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource partListBindingSource;
        private DataSet1TableAdapters.PartListTableAdapter partListTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator partListBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton partListBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox partNoTextBox;
        private System.Windows.Forms.TextBox partNameTextBox;
        private System.Windows.Forms.DateTimePicker validDateDateTimePicker;
        private System.Windows.Forms.TextBox remarkTextBox;
        private DataSet1TableAdapters.SheetListTableAdapter sheetListTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource sheetListBindingSource;
        private DataSet1TableAdapters.TypeListTableAdapter typeListTableAdapter;
        private System.Windows.Forms.BindingSource typeListBindingSource;
        private DataSet1TableAdapters.ImportantListTableAdapter importantListTableAdapter;
        private System.Windows.Forms.BindingSource importantListBindingSource;
        private DataSet1TableAdapters.OwnerListTableAdapter ownerListTableAdapter;
        private System.Windows.Forms.BindingSource ownerListBindingSource;
        private System.Windows.Forms.ComboBox comboBox5;
    }
}