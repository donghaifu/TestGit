using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xk
{
    public partial class frmPartInput : Form
    {
        public frmPartInput()
        {
            InitializeComponent();
        }

        private void partListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmPartInput_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet1.OwnerList”中。您可以根据需要移动或删除它。
            this.ownerListTableAdapter.Fill(this.dataSet1.OwnerList);
            // TODO: 这行代码将数据加载到表“dataSet1.ImportantList”中。您可以根据需要移动或删除它。
            this.importantListTableAdapter.Fill(this.dataSet1.ImportantList);
            // TODO: 这行代码将数据加载到表“dataSet1.TypeList”中。您可以根据需要移动或删除它。
            this.typeListTableAdapter.Fill(this.dataSet1.TypeList);
            // TODO: 这行代码将数据加载到表“dataSet1.SheetList”中。您可以根据需要移动或删除它。
            this.sheetListTableAdapter.Fill(this.dataSet1.SheetList);
            // TODO: 这行代码将数据加载到表“dataSet1.PartList”中。您可以根据需要移动或删除它。
            this.partListTableAdapter.Fill(this.dataSet1.PartList);

        }
    }
}
