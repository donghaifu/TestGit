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
    public partial class frmAssembleInput : Form
    {
        DataSet ds = new DataSet();
        int Index = 1;

        public frmAssembleInput(TextBox fc)
        {
            InitializeComponent();
        }



        private void getAssembleList()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            string sql = " SELECT AssembleList.*,SheetName,TypeName,ImportantName,OwnerName FROM AssembleList,SheetList,TypeList,ImportantList,OwnerList";
            sql += " WHERE AssembleNo=@AssembleNo AND AssembleList.SheetNo=SheetList.SheetNo AND AssembleList.TypeNo=TypeList.TypeNo AND AssembleList.ImportantNo=ImportantList.ImportantNo AND AssembleList.OwnerNo=OwnerList.OwnerNo";
            sql += " ORDER BY AssembleNo";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.SelectCommand.Parameters.Add("AssembleNo", SqlDbType.NVarChar, 30).Value = tbAssembleList.Text.ToString();


            if (dgvAssembleList.CurrentRow == null)
            {
                cn.Open();
                da.Fill(ds, "AssembleList");
                cn.Close();
                dgvAssembleList.DataSource = ds.Tables["AssembleList"];
            }
            else
            {
                ds.Tables["AssembleList"].Clear();
                cn.Open();
                da.Fill(ds, "AssembleList");
                cn.Close();
                dgvAssembleList.DataSource = ds.Tables["AssembleList"];
            }
        }

        private void getNextLevel()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            string sql1 = " SELECT AssembleList.AssembleNo AS No,AssembleList.AssembleName AS Name,SheetName,TypeName,ImportantName,OwnerName FROM AssembleList,SheetList,TypeList,ImportantList,OwnerList";
            sql1 += " WHERE AssembleNo=@AssembleNo AND AssembleList.SheetNo=SheetList.SheetNo AND AssembleList.TypeNo=TypeList.TypeNo AND AssembleList.ImportantNo=ImportantList.ImportantNo AND AssembleList.OwnerNo=OwnerList.OwnerNo";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, cn);
            da1.SelectCommand.Parameters.Add("AssembleNo", SqlDbType.NVarChar, 50).Value = tbNextLevel.Text.ToString();

            string sql2 = " SELECT PartList.PartNo AS No,PartList.PartName AS Name,SheetName,TypeName,ImportantName,OwnerName FROM PartList,SheetList,TypeList,ImportantList,OwnerList";
            sql2 += " WHERE PartNo=@PartNo AND PartList.SheetNo=SheetList.SheetNo AND PartList.TypeNo=TypeList.TypeNo AND PartList.ImportantNo=ImportantList.ImportantNo AND PartList.OwnerNo=OwnerList.OwnerNo";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, cn);
            da2.SelectCommand.Parameters.Add("PartNo", SqlDbType.NVarChar, 50).Value = tbNextLevel.Text.ToString();

            if (dgvNextLevel.CurrentRow == null)
            {
                if (cbAssemble.Checked)//组合件
                {
                    cn.Open();
                    da1.Fill(ds, "NextLevelList");
                    cn.Close();
                }
                else
                {
                    cn.Open();
                    da2.Fill(ds, "NextLevelList");
                    cn.Close();
                }
                dgvNextLevel.DataSource = ds.Tables["NextLevelList"];
            }
            else
            {
                ds.Tables["NextLevelList"].Clear();
                if (cbAssemble.Checked)//组合件
                {
                    cn.Open();
                    da1.Fill(ds, "NextLevelList");
                    cn.Close();
                }
                else
                {
                    cn.Open();
                    da2.Fill(ds, "NextLevelList");
                    cn.Close();
                }
                dgvNextLevel.DataSource = ds.Tables["NextLevelList"];
            }


        }

        private void getAssemble()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            string sql = " SELECT * FROM Assemble WHERE No=0";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            cn.Open();
            da.Fill(ds,"Assemble");
            cn.Close();
            dgvAssemble.DataSource = ds.Tables["Assemble"];
        }

        private void frmAssembleInput_Load(object sender, EventArgs e)
        {
            dgvAssemble.AutoGenerateColumns = false;
            getAssemble();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dgvAssembleList.AutoGenerateColumns = false;
            getAssembleList();
        }

        private void btnQueryNextLevel_Click(object sender, EventArgs e)
        {
            dgvNextLevel.AutoGenerateColumns = false;
            getNextLevel();
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
                if (dgvAssembleList.CurrentRow != null)
                {
                    string AssembleNo = dgvAssembleList.CurrentRow.Cells["AssembleNo1"].Value.ToString();
                    if (dgvNextLevel.CurrentRow != null)
                    {
                        DataRow dr = ds.Tables["Assemble"].NewRow();
                        string NextLevelNo = dgvNextLevel.CurrentRow.Cells["AssembleNo2"].Value.ToString();
                        //if (Index == 18)
                        //    Index = 1;
                        dr["No"] = Index++;
                        //dr["SalesNo"] = SalesNo;
                        dr["AssembleNo"] = AssembleNo;
                        dr["NextLevel"] = NextLevelNo;
                        ds.Tables["Assemble"].Rows.Add(dr);
                    }
                    else
                    {
                        MessageBox.Show("没有选择下级件号！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("没有选择装配件号！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (Index > 17)
                    dgvAssemble.FirstDisplayedScrollingRowIndex = dgvAssemble.Rows[16].Index;
                if (Index > 34)
                    dgvAssemble.FirstDisplayedScrollingRowIndex = dgvAssemble.Rows[33].Index;
                if (Index > 51)
                    dgvAssemble.FirstDisplayedScrollingRowIndex = dgvAssemble.Rows[50].Index;
                if (Index > 68)
                    dgvAssemble.FirstDisplayedScrollingRowIndex = dgvAssemble.Rows[67].Index;
        }

        private void CAssemble()
        {
            if(dgvAssemble.CurrentRow != null)
            {
                int RowIndex = dgvAssemble.CurrentRow.Index;
                string AssembleNo = dgvAssemble.CurrentRow.Cells["Column1"].Value.ToString();
                string NextLevel = dgvAssemble.CurrentRow.Cells["SelectNextLevel"].Value.ToString();
                
                DataRow[] adr;
                //adr = ds.Tables["Assemble"].Select("No='" + AssembleNo + "'");
                adr = ds.Tables["Assemble"].Select("No='" + AssembleNo + "' AND NextLevel='" + NextLevel + "'");
                ds.Tables["Assemble"].Rows.Remove(adr[0]);
             }
        }



        private void dgvAssemble_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAssemble.Columns[e.ColumnIndex].Name == "Cancel")
            {
                CAssemble();
            }

        }


        private void btnOver_Click(object sender, EventArgs e)
        {
            Index = 1;
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            for (int i = 0; i < dgvAssemble.Rows.Count; i++)
            {
                string sql = " INSERT Assemble (AssembleNo,NextLevel,Number,Level,Remark) VALUES(@AssembleNo,@NextLevel,@Number,@Level,@Remark)";
                SqlCommand cmd = new SqlCommand(sql, cn);
                //cmd.Parameters.Add("SalesNo", SqlDbType.NVarChar, 10).Value = dgvAssemble.Rows[i].Cells["SelectSalesNo"].Value;
                cmd.Parameters.Add("AssembleNo", SqlDbType.NVarChar, 20).Value = dgvAssemble.Rows[i].Cells["SelectAssembleNo"].Value;
                cmd.Parameters.Add("NextLevel", SqlDbType.NVarChar, 50).Value = dgvAssemble.Rows[i].Cells["SelectNextLevel"].Value;
                cmd.Parameters.Add("Number", SqlDbType.Int, 10).Value = dgvAssemble.Rows[i].Cells["SelectNumber"].Value;
                cmd.Parameters.Add("Level", SqlDbType.Int, 10).Value = dgvAssemble.Rows[i].Cells["SelectLevel"].Value;
                cmd.Parameters.Add("Remark", SqlDbType.NVarChar, 50).Value = dgvAssemble.Rows[i].Cells["SelectRemark"].Value;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            ds.Tables["Assemble"].Clear();
            
        }


    }
}
