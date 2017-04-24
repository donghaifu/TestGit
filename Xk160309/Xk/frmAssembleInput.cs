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
            textBox1.Text = fc.Text;
        }

        private void frmAssembleInput_Load(object sender, EventArgs e)
        {
            dgvAssemble.AutoGenerateColumns = false;
            //只是生成一个表，表结构是组合表Assemble
            getAssemble();
        }

        private void getAssembleList()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            string sql = " SELECT Part.*,SheetName,TypeName,ImportantName,CnName FROM Part,Sheet,Type,Important,Sysuser";
            sql += " WHERE PartNo=@AssembleNo AND Part.SheetNo=Sheet.SheetNo AND Part.TypeNo=Type.TypeNo AND Part.ImportantNo=Important.ImportantNo AND Part.UserNo=Sysuser.UserNo ";
            //sql += " ORDER BY AssembleNo";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.SelectCommand.Parameters.Add("AssembleNo", SqlDbType.NVarChar, 20).Value = tbAssembleList.Text.ToString();


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

            string sql2 = " SELECT Part.PartNo AS No,Part.PartName AS Name,SheetName,TypeName,ImportantName,CnName FROM Part,Sheet,Type,Important,Sysuser";
            sql2 += " WHERE PartNo=@PartNo AND Part.SheetNo=Sheet.SheetNo AND Part.TypeNo=Type.TypeNo AND Part.ImportantNo=Important.ImportantNo AND Part.UserNo=Sysuser.UserNo";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, cn);
            da2.SelectCommand.Parameters.Add("PartNo", SqlDbType.NVarChar, 20).Value = tbNextLevel.Text.ToString();

            if (dgvNextLevel.CurrentRow == null)
            {
                cn.Open();
                da2.Fill(ds, "NextLevelList");
                cn.Close();
                dgvNextLevel.DataSource = ds.Tables["NextLevelList"];
            }
            else
            {
                ds.Tables["NextLevelList"].Clear();
                cn.Open();
                da2.Fill(ds, "NextLevelList");
                cn.Close();
                dgvNextLevel.DataSource = ds.Tables["NextLevelList"];
            }
        }

        //只是生成一个表，表结构是组合表Assemble
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


        //查询上级窗口
        private void btnQuery_Click(object sender, EventArgs e)
        {
            dgvAssembleList.AutoGenerateColumns = false;
            getAssembleList();
        }

        //查询下级窗口
        private void btnQueryNextLevel_Click(object sender, EventArgs e)
        {
            dgvNextLevel.AutoGenerateColumns = false;
            getNextLevel();
        }

        //生成按钮
        private void btnGenerate_Click(object sender, EventArgs e)
        {
                if (dgvAssembleList.CurrentRow != null)
                {
                    //取上级件号
                    string AssembleNo = dgvAssembleList.CurrentRow.Cells["AssembleNo1"].Value.ToString();
                    if (dgvNextLevel.CurrentRow != null)
                    {
                        DataRow dr = ds.Tables["Assemble"].NewRow();
                        //取下级件号
                        string NextLevelNo = dgvNextLevel.CurrentRow.Cells["AssembleNo2"].Value.ToString();
                        //if (Index == 18)
                        //    Index = 1;
                        //赋值
                        dr["No"] = Index++;
                        //dr["SalesNo"] = SalesNo;
                        dr["PartNo"] = AssembleNo;
                        dr["ChildNo"] = NextLevelNo;
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

        //点击一行的取消按钮
        private void dgvAssemble_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAssemble.Columns[e.ColumnIndex].Name == "Cancel")
            {
                CAssemble();
            }
        }

        private void CAssemble()
        {
            if (dgvAssemble.CurrentRow != null)
            {
                int RowIndex = dgvAssemble.CurrentRow.Index;
                string Column1 = dgvAssemble.CurrentRow.Cells["Column1"].Value.ToString();
                string NextLevel = dgvAssemble.CurrentRow.Cells["SelectNextLevel"].Value.ToString();

                DataRow[] adr;
                //adr = ds.Tables["Assemble"].Select("No='" + AssembleNo + "'");
                adr = ds.Tables["Assemble"].Select("No='" + Column1 + "' AND ChildNo='" + NextLevel + "'");
                ds.Tables["Assemble"].Rows.Remove(adr[0]);
            }
        }



        //提交按钮
        private void btnOver_Click(object sender, EventArgs e)
        {
            Index = 1;
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            for (int i = 0; i < dgvAssemble.Rows.Count; i++)
            {
                string sql = " INSERT Assemble (PartNo,ChildNo,Number,Groups,TechnologyEmailNo,Remark) VALUES(@AssembleNo,@NextLevel,@Number,@Level,@TechnologyEmailNo,@Remark)";
                SqlCommand cmd = new SqlCommand(sql, cn);
                //cmd.Parameters.Add("SalesNo", SqlDbType.NVarChar, 10).Value = dgvAssemble.Rows[i].Cells["SelectSalesNo"].Value;
                cmd.Parameters.Add("AssembleNo", SqlDbType.NVarChar, 20).Value = dgvAssemble.Rows[i].Cells["SelectAssembleNo"].Value;
                cmd.Parameters.Add("NextLevel", SqlDbType.NVarChar, 20).Value = dgvAssemble.Rows[i].Cells["SelectNextLevel"].Value;
                cmd.Parameters.Add("Number", SqlDbType.Decimal , 10).Value = dgvAssemble.Rows[i].Cells["SelectNumber"].Value;
                cmd.Parameters.Add("Level", SqlDbType.Int, 10).Value = dgvAssemble.Rows[i].Cells["SelectLevel"].Value;
                cmd.Parameters.Add("TechnologyEmailNo", SqlDbType.NVarChar, 20).Value = textBox1.Text.ToUpper();
                cmd.Parameters.Add("Remark", SqlDbType.NVarChar, 50).Value = dgvAssemble.Rows[i].Cells["SelectRemark"].Value;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            ds.Tables["Assemble"].Clear();
            
        }


    }
}
