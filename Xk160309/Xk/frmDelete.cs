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
    public partial class frmDelete : Form
    {
        DataSet ds = new DataSet();
        public frmDelete(TextBox fc)
        {
            InitializeComponent();
            textBox1.Text = fc.Text;
        }

        //载入数据
        private void frmDelete_Load(object sender, EventArgs e)
        {

            //注意fillby函数是自定义的
            this.sysuserTableAdapter1.FillBy(this.dataSet11.Sysuser);
            // TODO: 这行代码将数据加载到表“dataSet11.ImportantList”中。您可以根据需要移动或删除它。
            this.importantTableAdapter1.Fill(this.dataSet11.Important);
            // TODO: 这行代码将数据加载到表“dataSet11.SheetList”中。您可以根据需要移动或删除它。
            this.sheetTableAdapter1.Fill(this.dataSet11.Sheet);
            // TODO: 这行代码将数据加载到表“dataSet11.TypeList”中。您可以根据需要移动或删除它。
            this.typeTableAdapter1.Fill(this.dataSet11.Type);

        }

        private void getNextLevel1()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            //string sql1 = " SELECT AssembleList.AssembleNo AS No,AssembleList.AssembleName AS Name,SheetName,TypeName,ImportantName,OwnerName,ValidDate,Remark FROM AssembleList,SheetList,TypeList,ImportantList,OwnerList";
            //sql1 += " WHERE AssembleNo=@AssembleNo AND AssembleList.SheetNo=SheetList.SheetNo AND AssembleList.TypeNo=TypeList.TypeNo AND AssembleList.ImportantNo=ImportantList.ImportantNo AND AssembleList.OwnerNo=OwnerList.OwnerNo";
            //SqlDataAdapter da1 = new SqlDataAdapter(sql1, cn);
            //da1.SelectCommand.Parameters.Add("AssembleNo", SqlDbType.NVarChar, 50).Value = tbNextLevel.Text.ToString();

            //string sql1 = " SELECT AssembleList.AssembleNo AS No,AssembleList.AssembleName AS Name,SheetNo,TypeNo,ImportantNo,OwnerNo,ValidDate FROM AssembleList";
            //sql1 += " WHERE AssembleNo=@AssembleNo ";
            //SqlDataAdapter da1 = new SqlDataAdapter(sql1, cn);
            //da1.SelectCommand.Parameters.Add("AssembleNo", SqlDbType.NVarChar, 50).Value = tbNextLevel.Text.ToString();


            string sql2 = " SELECT Part.PartNo AS No,Part.PartName AS Name,SheetNo,TypeNo,ImportantNo,UserNo,Remark FROM Part";
            sql2 += " WHERE PartNo=@PartNo ";
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, cn);
            da2.SelectCommand.Parameters.Add("PartNo", SqlDbType.NVarChar, 20).Value = tbNextLevel.Text.ToString();

            if (dgvNextLevel1.CurrentRow == null)
            {
                cn.Open();
                da2.Fill(ds, "NextLevelList1");
                cn.Close();
                dgvNextLevel1.DataSource = ds.Tables["NextLevelList1"];
            }
            else
            {
                ds.Tables["NextLevelList1"].Clear();
                cn.Open();
                da2.Fill(ds, "NextLevelList1");
                cn.Close();
                dgvNextLevel1.DataSource = ds.Tables["NextLevelList1"];
            }

            if (dgvNextLevel1.CurrentRow != null)
            {
                string sql3 = " INSERT INTO ChangeList (No,Name,SheetNo,TypeNo,ImportantNo,OwnerNo,ChangeId,ChangeType)";
                sql3 += " VALUES (@No1,@Name1,@SheetNo1,@TypeNo1,@ImportantNo1,@OwnerNo1,@ChangeId1,@ChangeType1)";

                SqlCommand cmd3 = new SqlCommand(sql3, cn);
                cmd3.CommandText = sql3;
                cmd3.Parameters.Add("No1", SqlDbType.NVarChar, 50).Value = dgvNextLevel1.CurrentRow.Cells["AssembleNo2"].Value.ToString();
                cmd3.Parameters.Add("Name1", SqlDbType.NVarChar, 50).Value = dgvNextLevel1.CurrentRow.Cells["AssembleName2"].Value.ToString();
                cmd3.Parameters.Add("SheetNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["SheetNo2"].Value.ToString();
                cmd3.Parameters.Add("TypeNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["TypeNo2"].Value.ToString();
                cmd3.Parameters.Add("ImportantNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["ImportantNo2"].Value.ToString();
                cmd3.Parameters.Add("OwnerNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["OwnerNo2"].Value.ToString();
                cmd3.Parameters.Add("ChangeId1", SqlDbType.NVarChar, 20).Value = textBox1.Text.ToUpper();
                cmd3.Parameters.Add("ChangeType1", SqlDbType.NVarChar, 10).Value = "QUERY";


                cn.Open();
                cmd3.ExecuteNonQuery();
                cn.Close();
            }

        }

        //查询
        private void btnQueryNextLevel_Click(object sender, EventArgs e)
        {
            dgvNextLevel1.AutoGenerateColumns = false;
            getNextLevel1();
        }

        //更改按钮
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            //组合件
            //string sql1 = " UPDATE AssembleList";
            //sql1 += " SET AssembleName=@AssembleName1,SheetNo=@SheetNo1,TypeNo=@TypeNo1,ImportantNo=@ImportantNo1,OwnerNo=@OwnerNo1";
            //sql1 += " WHERE AssembleNo=@AssembleNo1 ";
            //SqlCommand cmd1 = new SqlCommand(sql1, cn);
            //cmd1.CommandText = sql1;
            //cmd1.Parameters.Add("AssembleNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["AssembleNo2"].Value.ToString();
            //cmd1.Parameters.Add("AssembleName1", SqlDbType.NVarChar, 50).Value = dgvNextLevel1.CurrentRow.Cells["AssembleName2"].Value.ToString();
            //cmd1.Parameters.Add("SheetNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["SheetNo2"].Value.ToString();
            //cmd1.Parameters.Add("TypeNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["TypeNo2"].Value.ToString();
            //cmd1.Parameters.Add("ImportantNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["ImportantNo2"].Value.ToString();
            //cmd1.Parameters.Add("OwnerNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["OwnerNo2"].Value.ToString();
            
            

            //零件
            string sql2 = " UPDATE Part";
            sql2 += " SET PartName=@AssembleName1,SheetNo=@SheetNo1,TypeNo=@TypeNo1,ImportantNo=@ImportantNo1,UserNo=@OwnerNo1,TechnologyEmailNo=@TechnologyEmailNo1,Remark=@Remark1";
            sql2 += " WHERE PartNo=@PartNo1 ";
            SqlCommand cmd2 = new SqlCommand(sql2, cn);
            cmd2.CommandText = sql2;
            cmd2.Parameters.Add("PartNo1", SqlDbType.NVarChar, 20).Value = dgvNextLevel1.CurrentRow.Cells["AssembleNo2"].Value.ToString();
            cmd2.Parameters.Add("AssembleName1", SqlDbType.NVarChar, 50).Value = dgvNextLevel1.CurrentRow.Cells["AssembleName2"].Value.ToString();
            cmd2.Parameters.Add("SheetNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["SheetNo2"].Value.ToString();
            cmd2.Parameters.Add("TypeNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["TypeNo2"].Value.ToString();
            cmd2.Parameters.Add("ImportantNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["ImportantNo2"].Value.ToString();
            cmd2.Parameters.Add("OwnerNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["OwnerNo2"].Value.ToString();
            cmd2.Parameters.Add("Remark1", SqlDbType.NVarChar, 60).Value = dgvNextLevel1.CurrentRow.Cells["Remark2"].Value.ToString();
            cmd2.Parameters.Add("TechnologyEmailNo1", SqlDbType.NVarChar, 20).Value = textBox1.Text.ToUpper();


            if (dgvNextLevel1.CurrentRow == null)
            {
                MessageBox.Show("没有查询件号！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //ds.Tables["NextLevelList1"].Clear();

                cn.Open();
                cmd2.ExecuteNonQuery();
                cn.Close();

                string sql3 = " INSERT INTO ChangeList (No,Name,SheetNo,TypeNo,ImportantNo,OwnerNo,ChangeId,ChangeType)";
                sql3 += " VALUES (@No1,@Name1,@SheetNo1,@TypeNo1,@ImportantNo1,@OwnerNo1,@ChangeId1,@ChangeType1)";

                SqlCommand cmd3 = new SqlCommand(sql3, cn);
                cmd3.CommandText = sql3;
                cmd3.Parameters.Add("No1", SqlDbType.NVarChar, 50).Value = dgvNextLevel1.CurrentRow.Cells["AssembleNo2"].Value.ToString();
                cmd3.Parameters.Add("Name1", SqlDbType.NVarChar, 50).Value = dgvNextLevel1.CurrentRow.Cells["AssembleName2"].Value.ToString();
                cmd3.Parameters.Add("SheetNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["SheetNo2"].Value.ToString();
                cmd3.Parameters.Add("TypeNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["TypeNo2"].Value.ToString();
                cmd3.Parameters.Add("ImportantNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["ImportantNo2"].Value.ToString();
                cmd3.Parameters.Add("OwnerNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["OwnerNo2"].Value.ToString();
                cmd3.Parameters.Add("ChangeId1", SqlDbType.NVarChar, 20).Value = textBox1.Text.ToUpper();
                cmd3.Parameters.Add("ChangeType1", SqlDbType.NVarChar, 10).Value = "UPDATE";


                cn.Open();
                cmd3.ExecuteNonQuery();
                cn.Close();

                ds.Tables["NextLevelList1"].Clear();
            }
        }


        //DELETE from Assemble WHERE AssembleNo = 'ayt05080' AND NextLevel = 'AYT05183'
        //删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            //组合件
            //string sql1 = " DELETE FROM AssembleList";
            //sql1 += " WHERE AssembleNo=@AssembleNo1 ";
            //SqlCommand cmd1 = new SqlCommand(sql1, cn);
            //cmd1.CommandText = sql1;
            //cmd1.Parameters.Add("AssembleNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["AssembleNo2"].Value.ToString();
 

            //零件
            string sql2 = " DELETE FROM Part";
            sql2 += " WHERE PartNo=@PartNo1 ";
            SqlCommand cmd2 = new SqlCommand(sql2, cn);
            cmd2.CommandText = sql2;
            cmd2.Parameters.Add("PartNo1", SqlDbType.NVarChar, 20).Value = dgvNextLevel1.CurrentRow.Cells["AssembleNo2"].Value.ToString();
       


            if (dgvNextLevel1.CurrentRow == null)
            {
                MessageBox.Show("没有查询件号！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //ds.Tables["NextLevelList1"].Clear();
                cn.Open();
                cmd2.ExecuteNonQuery();
                cn.Close();

                string sql3 = " INSERT INTO ChangeList (No,Name,SheetNo,TypeNo,ImportantNo,OwnerNo,ChangeId,ChangeType)";
                sql3 += " VALUES (@No1,@Name1,@SheetNo1,@TypeNo1,@ImportantNo1,@OwnerNo1,@ChangeId1,@ChangeType1)";

                SqlCommand cmd3 = new SqlCommand(sql3, cn);
                cmd3.CommandText = sql3;
                cmd3.Parameters.Add("No1", SqlDbType.NVarChar, 50).Value = dgvNextLevel1.CurrentRow.Cells["AssembleNo2"].Value.ToString();
                cmd3.Parameters.Add("Name1", SqlDbType.NVarChar, 50).Value = dgvNextLevel1.CurrentRow.Cells["AssembleName2"].Value.ToString();
                cmd3.Parameters.Add("SheetNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["SheetNo2"].Value.ToString();
                cmd3.Parameters.Add("TypeNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["TypeNo2"].Value.ToString();
                cmd3.Parameters.Add("ImportantNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["ImportantNo2"].Value.ToString();
                cmd3.Parameters.Add("OwnerNo1", SqlDbType.NVarChar, 10).Value = dgvNextLevel1.CurrentRow.Cells["OwnerNo2"].Value.ToString();
                cmd3.Parameters.Add("ChangeId1", SqlDbType.NVarChar, 20).Value = textBox1.Text.ToUpper();
                cmd3.Parameters.Add("ChangeType1", SqlDbType.NVarChar, 10).Value = "DELETE";


                cn.Open();
                cmd3.ExecuteNonQuery();
                cn.Close();

                ds.Tables["NextLevelList1"].Clear();
            }
        }


        //组合调整-----------------------------------------------------------------------------------------------------------------------
        //查询
        private void btnAssemble_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);

            string sql1 = " SELECT No,PartNo,ChildNo,Number,Groups,Remark FROM Assemble";
            sql1 += " WHERE PartNo=@AssembleNo1 AND ChildNo=@NextLevel1 AND Groups=@Level1";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, cn);
            da1.SelectCommand.Parameters.Add("AssembleNo1", SqlDbType.NVarChar, 20).Value = tbAssembleNo.Text.ToString();
            da1.SelectCommand.Parameters.Add("NextLevel1", SqlDbType.NVarChar, 20).Value = tbNextNo.Text.ToString();
            da1.SelectCommand.Parameters.Add("Level1", SqlDbType.Int, 10).Value = tbGroup.Text.ToString();

            if (dgvAssemble.CurrentRow == null)
            {

                 cn.Open();
                 da1.Fill(ds, "dgvAssemble");
                 cn.Close();
                 dgvAssemble.DataSource = ds.Tables["dgvAssemble"];
            }
            else
            {
                ds.Tables["dgvAssemble"].Clear();
                cn.Open();
                da1.Fill(ds, "dgvAssemble");
                cn.Close();
                dgvAssemble.DataSource = ds.Tables["dgvAssemble"];
            }

            if (dgvAssemble.CurrentRow != null)
            {
                string sql3 = " INSERT INTO ChangeList (No,Name,SheetNo,TypeNo,ImportantNo,OwnerNo,ChangeId,ChangeType,Remark,Number,Level)";
                sql3 += " VALUES (@No1,@Name1,@SheetNo1,@TypeNo1,@ImportantNo1,@OwnerNo1,@ChangeId1,@ChangeType1,@Remark1,@Number1,@Level1)";

                SqlCommand cmd3 = new SqlCommand(sql3, cn);
                cmd3.CommandText = sql3;
                cmd3.Parameters.Add("No1", SqlDbType.NVarChar, 50).Value = dgvAssemble.CurrentRow.Cells["CoAssembleNo"].Value.ToString();
                cmd3.Parameters.Add("Name1", SqlDbType.NVarChar, 50).Value = dgvAssemble.CurrentRow.Cells["CoNextLevel"].Value.ToString();
                cmd3.Parameters.Add("SheetNo1", SqlDbType.NVarChar, 10).Value = "001";
                cmd3.Parameters.Add("TypeNo1", SqlDbType.NVarChar, 10).Value = "001";
                cmd3.Parameters.Add("ImportantNo1", SqlDbType.NVarChar, 10).Value = "001";
                cmd3.Parameters.Add("OwnerNo1", SqlDbType.NVarChar, 10).Value = "001";
                cmd3.Parameters.Add("ChangeId1", SqlDbType.NVarChar, 20).Value = textBox1.Text.ToUpper();
                cmd3.Parameters.Add("ChangeType1", SqlDbType.NVarChar, 10).Value = "QUERY";
                cmd3.Parameters.Add("Remark1", SqlDbType.NVarChar, 50).Value = dgvAssemble.CurrentRow.Cells["CoRemark"].Value.ToString();
                cmd3.Parameters.Add("Number1", SqlDbType.Decimal, 10).Value = dgvAssemble.CurrentRow.Cells["CoNumber"].Value.ToString();
                cmd3.Parameters.Add("Level1", SqlDbType.Int, 10).Value = dgvAssemble.CurrentRow.Cells["CoLevel"].Value.ToString();

                cn.Open();
                cmd3.ExecuteNonQuery();
                cn.Close();
            }
        }

        //更改
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            string sql1 = " UPDATE Assemble";
            sql1 += " SET Number=@Number1,Groups=@Level1,TechnologyEmailNo=@TechnologyEmailNo1,Remark=@Remark1 ";
            sql1 += " WHERE No=@No1 ";
            SqlCommand cmd1 = new SqlCommand(sql1, cn);
            cmd1.CommandText = sql1;
            cmd1.Parameters.Add("No1", SqlDbType.Int, 10).Value = dgvAssemble.CurrentRow.Cells["CoNo"].Value.ToString();
            cmd1.Parameters.Add("Number1", SqlDbType.Decimal, 10).Value = dgvAssemble.CurrentRow.Cells["CoNumber"].Value.ToString();
            cmd1.Parameters.Add("Level1", SqlDbType.Int, 10).Value = dgvAssemble.CurrentRow.Cells["CoLevel"].Value.ToString();
            cmd1.Parameters.Add("Remark1", SqlDbType.NVarChar, 50).Value = dgvAssemble.CurrentRow.Cells["CoRemark"].Value.ToString();
            cmd1.Parameters.Add("TechnologyEmailNo1", SqlDbType.NVarChar, 20).Value = textBox1.Text.ToUpper();

            if (dgvAssemble.CurrentRow == null)
            {
                MessageBox.Show("没有查询件号！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                cn.Open();
                cmd1.ExecuteNonQuery();
                cn.Close();


                string sql3 = " INSERT INTO ChangeList (No,Name,SheetNo,TypeNo,ImportantNo,OwnerNo,ChangeId,ChangeType,Remark,Number,Level)";
                sql3 += " VALUES (@No1,@Name1,@SheetNo1,@TypeNo1,@ImportantNo1,@OwnerNo1,@ChangeId1,@ChangeType1,@Remark1,@Number1,@Level1)";

                SqlCommand cmd3 = new SqlCommand(sql3, cn);
                cmd3.CommandText = sql3;
                cmd3.Parameters.Add("No1", SqlDbType.NVarChar, 50).Value = dgvAssemble.CurrentRow.Cells["CoAssembleNo"].Value.ToString();
                cmd3.Parameters.Add("Name1", SqlDbType.NVarChar, 50).Value = dgvAssemble.CurrentRow.Cells["CoNextLevel"].Value.ToString();
                cmd3.Parameters.Add("SheetNo1", SqlDbType.NVarChar, 10).Value = "001";
                cmd3.Parameters.Add("TypeNo1", SqlDbType.NVarChar, 10).Value = "001";
                cmd3.Parameters.Add("ImportantNo1", SqlDbType.NVarChar, 10).Value = "001";
                cmd3.Parameters.Add("OwnerNo1", SqlDbType.NVarChar, 10).Value = "001";
                cmd3.Parameters.Add("ChangeId1", SqlDbType.NVarChar, 20).Value = textBox1.Text.ToUpper();
                cmd3.Parameters.Add("ChangeType1", SqlDbType.NVarChar, 10).Value = "UPDATE";
                cmd3.Parameters.Add("Remark1", SqlDbType.NVarChar, 50).Value = dgvAssemble.CurrentRow.Cells["CoRemark"].Value.ToString();
                cmd3.Parameters.Add("Number1", SqlDbType.Decimal, 10).Value = dgvAssemble.CurrentRow.Cells["CoNumber"].Value.ToString();
                cmd3.Parameters.Add("Level1", SqlDbType.Int, 10).Value = dgvAssemble.CurrentRow.Cells["CoLevel"].Value.ToString();

                cn.Open();
                cmd3.ExecuteNonQuery();
                cn.Close();

                ds.Tables["dgvAssemble"].Clear();
            }

        }

        //删除
        private void btnDeleteAssemble_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
   
            string sql1 = " DELETE FROM Assemble";
            sql1 += " WHERE No=@No1 ";
            SqlCommand cmd1 = new SqlCommand(sql1, cn);
            cmd1.CommandText = sql1;
            cmd1.Parameters.Add("No1", SqlDbType.Int, 10).Value = dgvAssemble.CurrentRow.Cells["CoNo"].Value.ToString();


            if (dgvAssemble.CurrentRow == null)
            {
                MessageBox.Show("没有查询件号！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                cn.Open();
                cmd1.ExecuteNonQuery();
                cn.Close();


                string sql3 = " INSERT INTO ChangeList (No,Name,SheetNo,TypeNo,ImportantNo,OwnerNo,ChangeId,ChangeType,Remark,Number,Level)";
                sql3 += " VALUES (@No1,@Name1,@SheetNo1,@TypeNo1,@ImportantNo1,@OwnerNo1,@ChangeId1,@ChangeType1,@Remark1,@Number1,@Level1)";

                SqlCommand cmd3 = new SqlCommand(sql3, cn);
                cmd3.CommandText = sql3;
                cmd3.Parameters.Add("No1", SqlDbType.NVarChar, 50).Value = dgvAssemble.CurrentRow.Cells["CoAssembleNo"].Value.ToString();
                cmd3.Parameters.Add("Name1", SqlDbType.NVarChar, 50).Value = dgvAssemble.CurrentRow.Cells["CoNextLevel"].Value.ToString();
                cmd3.Parameters.Add("SheetNo1", SqlDbType.NVarChar, 10).Value = "001";
                cmd3.Parameters.Add("TypeNo1", SqlDbType.NVarChar, 10).Value = "001";
                cmd3.Parameters.Add("ImportantNo1", SqlDbType.NVarChar, 10).Value = "001";
                cmd3.Parameters.Add("OwnerNo1", SqlDbType.NVarChar, 10).Value = "001";
                cmd3.Parameters.Add("ChangeId1", SqlDbType.NVarChar, 20).Value = textBox1.Text.ToUpper();
                cmd3.Parameters.Add("ChangeType1", SqlDbType.NVarChar, 10).Value = "DELETE";
                cmd3.Parameters.Add("Remark1", SqlDbType.NVarChar, 50).Value = dgvAssemble.CurrentRow.Cells["CoRemark"].Value.ToString();
                cmd3.Parameters.Add("Number1", SqlDbType.Decimal, 10).Value = dgvAssemble.CurrentRow.Cells["CoNumber"].Value.ToString();
                cmd3.Parameters.Add("Level1", SqlDbType.Int, 10).Value = dgvAssemble.CurrentRow.Cells["CoLevel"].Value.ToString();

                cn.Open();
                cmd3.ExecuteNonQuery();
                cn.Close();

                ds.Tables["dgvAssemble"].Clear();
            }
        }

        private void dgvNextLevel1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvAssemble_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }



    }
}
