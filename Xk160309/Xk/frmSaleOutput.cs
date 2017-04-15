using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Xk
{
    public partial class frmSaleOutput : Form
    {
        DataSet ds = new DataSet();

        public frmSaleOutput()
        {
            InitializeComponent();
        }


        private void getNextLevel1()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            string sql1 = " SELECT AssembleList.AssembleNo AS No,AssembleList.AssembleName AS Name,SheetName,TypeName,ImportantName,OwnerName,ValidDate,Remark FROM AssembleList,SheetList,TypeList,ImportantList,OwnerList";
            sql1 += " WHERE AssembleNo=@AssembleNo AND AssembleList.SheetNo=SheetList.SheetNo AND AssembleList.TypeNo=TypeList.TypeNo AND AssembleList.ImportantNo=ImportantList.ImportantNo AND AssembleList.OwnerNo=OwnerList.OwnerNo";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, cn);
            da1.SelectCommand.Parameters.Add("AssembleNo", SqlDbType.NVarChar, 50).Value = tbNextLevel.Text.ToString();

            string sql2 = " SELECT PartList.PartNo AS No,PartList.PartName AS Name,SheetName,TypeName,ImportantName,OwnerName,ValidDate,Remark FROM PartList,SheetList,TypeList,ImportantList,OwnerList";
            sql2 += " WHERE PartNo=@PartNo AND PartList.SheetNo=SheetList.SheetNo AND PartList.TypeNo=TypeList.TypeNo AND PartList.ImportantNo=ImportantList.ImportantNo AND PartList.OwnerNo=OwnerList.OwnerNo";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, cn);
            da2.SelectCommand.Parameters.Add("PartNo", SqlDbType.NVarChar, 50).Value = tbNextLevel.Text.ToString();

            if (dgvNextLevel1.CurrentRow == null)
            {
                if (cbAssemble1.Checked)//组合件
                {
                    cn.Open();
                    da1.Fill(ds, "NextLevelList1");
                    cn.Close();
                }
                else
                {
                    cn.Open();
                    da2.Fill(ds, "NextLevelList1");
                    cn.Close();
                }
                dgvNextLevel1.DataSource = ds.Tables["NextLevelList1"];
            }
            else
            {
                ds.Tables["NextLevelList1"].Clear();
                if (cbAssemble1.Checked)//组合件
                {
                    cn.Open();
                    da1.Fill(ds, "NextLevelList1");
                    cn.Close();
                }
                else
                {
                    cn.Open();
                    da2.Fill(ds, "NextLevelList1");
                    cn.Close();
                }
                dgvNextLevel1.DataSource = ds.Tables["NextLevelList1"];
            }


        }

        private void btnQueryNextLevel_Click_1(object sender, EventArgs e)
        {
            dgvNextLevel1.AutoGenerateColumns = false;
            getNextLevel1();
        }



    }
}
