using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Xk
{
    public partial class frmOutput : Form
    {
        DataSet ds = new DataSet();

        public frmOutput()
        {
            InitializeComponent();
        }


        private void frmOutput_Load(object sender, EventArgs e)
        {
            dgvNextLevel1.AutoGenerateColumns = false;
            dgvNextLevel2.AutoGenerateColumns = false;
            dgvNextLevel3.AutoGenerateColumns = false;
        }

        //查询按钮按下，分组进行排序
        private void button1_Click(object sender, EventArgs e)
        {
            //特性查询
            getNextLevel1();

            //装配表查询
            getNextLeve2();

            //去向查询
            getNextLevel3();
        }

        private void getNextLevel1()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);

            string sql1 = " SELECT Part.PartNo AS No,Part.PartName AS Name,SheetName,TypeName,ImportantName,CnName,ValidDate,Remark FROM Part,Sheet,Type,Important,Sysuser";
            sql1 += " WHERE PartNo=@PartNo AND Part.SheetNo=Sheet.SheetNo AND Part.TypeNo=Type.TypeNo AND Part.ImportantNo=Important.ImportantNo AND Part.UserNo=Sysuser.UserNo";
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, cn);
            da1.SelectCommand.Parameters.Add("PartNo", SqlDbType.NVarChar, 50).Value = tbAssemble.Text.ToString();

            if (dgvNextLevel1.CurrentRow == null)
            {
                cn.Open();
                da1.Fill(ds, "NextLevelList1");
                cn.Close();
   
                dgvNextLevel1.DataSource = ds.Tables["NextLevelList1"];
            }
            else
            {
                ds.Tables["NextLevelList1"].Clear();

                cn.Open();
                da1.Fill(ds, "NextLevelList1");
                cn.Close();

                dgvNextLevel1.DataSource = ds.Tables["NextLevelList1"];
            }


        }


        private void getNextLeve2()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            string sql1 = " SELECT Part.PartNo AS No,Part.PartName AS Name,SheetName,TypeName,Assemble.Number,Assemble.Groups,ImportantName,CnName,Assemble.ValidDate,Assemble.Remark FROM Part,Assemble,Sheet,Type,Important,Sysuser";
            sql1 += " WHERE  Assemble.PartNo=@AssembleNo AND Part.PartNo=Assemble.ChildNo AND Part.SheetNo=Sheet.SheetNo AND Part.TypeNo=Type.TypeNo AND Part.ImportantNo=Important.ImportantNo AND Part.UserNo=Sysuser.UserNo";
            sql1 += " ORDER BY Assemble.Groups";

            SqlDataAdapter da1 = new SqlDataAdapter(sql1, cn);
            da1.SelectCommand.Parameters.Add("AssembleNo", SqlDbType.NVarChar, 20).Value = tbAssemble.Text.ToString();
            //da1.SelectCommand.Parameters.Add("SalesNo", SqlDbType.NVarChar, 10).Value = dgvSalesList.CurrentRow.Cells["SalesNo"].Value.ToString();

            if (dgvNextLevel2.CurrentRow == null)
            {
                cn.Open();
                da1.Fill(ds, "NextLevelList2");
                cn.Close();
                dgvNextLevel2.DataSource = ds.Tables["NextLevelList2"];
            }
            else
            {
                ds.Tables["NextLevelList2"].Clear();
                cn.Open();
                da1.Fill(ds, "NextLevelList2");
                cn.Close();
                dgvNextLevel2.DataSource = ds.Tables["NextLevelList2"];
            }

        }

        private void getNextLevel3()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            SqlCommand SqlComm = cn.CreateCommand();
            SqlComm.CommandText = "GetNextLevelShell";
            SqlComm.CommandType = CommandType.StoredProcedure;

            SqlParameter No = SqlComm.Parameters.Add(new SqlParameter("@No", SqlDbType.NVarChar, 20));
            No.Direction = ParameterDirection.Input;
            No.Value = tbAssemble.Text.ToString();

            SqlParameter SalesNo = SqlComm.Parameters.Add(new SqlParameter("@SalesNo", SqlDbType.NVarChar, 10));
            SalesNo.Direction = ParameterDirection.Input;
            SalesNo.Value = "保留";

            //查找去向的类型为4
            SqlParameter Type = SqlComm.Parameters.Add(new SqlParameter("@Type", SqlDbType.Int, 10));
            SalesNo.Direction = ParameterDirection.Input;
            Type.Value = 4;

            SqlDataAdapter da = new SqlDataAdapter(SqlComm);

            if (dgvNextLevel3.CurrentRow == null)
            {
                cn.Open();
                da.Fill(ds, "GetGo");
                cn.Close();
                dgvNextLevel3.DataSource = ds.Tables["GetGo"];
            }
            else
            {
                ds.Tables["GetGo"].Clear();
                cn.Open();
                da.Fill(ds, "GetGo");
                cn.Close();
                dgvNextLevel3.DataSource = ds.Tables["GetGo"];
            }
        }

        //生成装配表按钮按下
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            SqlCommand SqlComm = cn.CreateCommand();
            SqlComm.CommandText = "GetNextLevelShell";
            SqlComm.CommandType = CommandType.StoredProcedure;

            //查询装配号
            SqlParameter No = SqlComm.Parameters.Add(new SqlParameter("@No", SqlDbType.NVarChar, 20));
            No.Direction = ParameterDirection.Input;
            No.Value = tbAssemble.Text.ToString();

            //目前没有使用
            SqlParameter SalesNo = SqlComm.Parameters.Add(new SqlParameter("@SalesNo", SqlDbType.NVarChar, 10));
            SalesNo.Direction = ParameterDirection.Input;
            SalesNo.Value = "1";

            //生成装配表的类型为1
            SqlParameter Type = SqlComm.Parameters.Add(new SqlParameter("@Type", SqlDbType.Int, 10));
            SalesNo.Direction = ParameterDirection.Input;
            Type.Value = 1;

            SqlDataAdapter da = new SqlDataAdapter(SqlComm);

            cn.Open();
            da.Fill(ds, "GetAssemble");
            cn.Close();

            SaveAs(ds.Tables["GetAssemble"]);
            ds.Tables["GetAssemble"].Clear();

            //dataTableToCsv(ds.Tables["GetGo"], @"c:\1.xls");
            //System.Diagnostics.Process.Start(@"c:\1.xls");
        }

        //生成生产用表按钮按下
        private void btnProduction_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            SqlCommand SqlComm = cn.CreateCommand();
            SqlComm.CommandText = "GetNextLevelShell";
            SqlComm.CommandType = CommandType.StoredProcedure;

            SqlParameter No = SqlComm.Parameters.Add(new SqlParameter("@No", SqlDbType.NVarChar, 20));
            No.Direction = ParameterDirection.Input;
            No.Value = tbAssemble.Text.ToString();

            SqlParameter SalesNo = SqlComm.Parameters.Add(new SqlParameter("@SalesNo", SqlDbType.NVarChar, 10));
            SalesNo.Direction = ParameterDirection.Input;
            SalesNo.Value = "2";

            //生产用表的类型为2
            SqlParameter Type = SqlComm.Parameters.Add(new SqlParameter("@Type", SqlDbType.Int, 10));
            SalesNo.Direction = ParameterDirection.Input;
            Type.Value = 2;

            SqlDataAdapter da = new SqlDataAdapter(SqlComm);

            cn.Open();
            da.Fill(ds, "GetProduction");
            cn.Close();

            SaveAs(ds.Tables["GetProduction"]);
            ds.Tables["GetProduction"].Clear();
        }

        //生成采购用表
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            SqlCommand SqlComm = cn.CreateCommand();
            SqlComm.CommandText = "GetNextLevelShell";
            SqlComm.CommandType = CommandType.StoredProcedure;

            SqlParameter No = SqlComm.Parameters.Add(new SqlParameter("@No", SqlDbType.NVarChar, 20));
            No.Direction = ParameterDirection.Input;
            No.Value = tbAssemble.Text.ToString();

            SqlParameter SalesNo = SqlComm.Parameters.Add(new SqlParameter("@SalesNo", SqlDbType.NVarChar, 10));
            SalesNo.Direction = ParameterDirection.Input;
            SalesNo.Value = "3";

            //采购用表的类型为3
            SqlParameter Type = SqlComm.Parameters.Add(new SqlParameter("@Type", SqlDbType.Int, 10));
            SalesNo.Direction = ParameterDirection.Input;
            Type.Value = 3;

            SqlDataAdapter da = new SqlDataAdapter(SqlComm);

            cn.Open();
            da.Fill(ds, "GetPurchase");
            cn.Close();

            SaveAs(ds.Tables["GetPurchase"]);
            ds.Tables["GetPurchase"].Clear();
        }

        private void btnDrawing_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            SqlCommand SqlComm = cn.CreateCommand();
            SqlComm.CommandText = "GetNextLevelShell";
            SqlComm.CommandType = CommandType.StoredProcedure;

            SqlParameter No = SqlComm.Parameters.Add(new SqlParameter("@No", SqlDbType.NVarChar, 20));
            No.Direction = ParameterDirection.Input;
            No.Value = tbAssemble.Text.ToString();

            SqlParameter SalesNo = SqlComm.Parameters.Add(new SqlParameter("@SalesNo", SqlDbType.NVarChar, 10));
            SalesNo.Direction = ParameterDirection.Input;
            SalesNo.Value = "5";

            //生成图纸清单的类型为5
            SqlParameter Type = SqlComm.Parameters.Add(new SqlParameter("@Type", SqlDbType.Int, 10));
            SalesNo.Direction = ParameterDirection.Input;
            Type.Value = 5;

            SqlDataAdapter da = new SqlDataAdapter(SqlComm);

            cn.Open();
            da.Fill(ds, "Drawing");
            cn.Close();

            SaveAs(ds.Tables["Drawing"]);
            ds.Tables["Drawing"].Clear();

        }


        private void SaveAs(DataTable table) //另存新档按钮   导出成Excel
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Export Excel File To";
            saveFileDialog.ShowDialog();
            Stream myStream;
            myStream = saveFileDialog.OpenFile();
            StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding("gb2312"));
            //StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));
            //string str = "";
            string title = "";
            try
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {

                    title += table.Columns[i].ColumnName + "\t"; //栏位：自动跳到下一单元格

                }

                title = title.Substring(0, title.Length - 1) + "\n";

                sw.Write(title);

                foreach (DataRow row in table.Rows)
                {

                    string line = "";

                    for (int i = 0; i < table.Columns.Count; i++)
                    {

                        line += row[i].ToString().Trim() + "\t"; //内容：自动跳到下一单元格

                    }

                    line = line.Substring(0, line.Length - 1) + "\n";

                    sw.Write(line);

                }

                sw.Close();

                myStream.Close();


                ////写标题
                //for (int i = 0; i < dgvNextLevel.ColumnCount; i++)
                //{
                //    if (i > 0)
                //    {
                //        str += "\t";
                //    }
                //    str += dgvNextLevel.Columns[i].HeaderText;
                //}
                //sw.WriteLine(str);
                ////写内容
                //for (int j = 0; j < dgvNextLevel.Rows.Count; j++)
                //{
                //    string tempStr = "";
                //    for (int k = 0; k < dgvNextLevel.Columns.Count; k++)
                //    {
                //        if (k > 0)
                //        {
                //            tempStr += "\t";
                //        }
                //        tempStr += dgvNextLevel.Rows[j].Cells[k].Value.ToString();
                //    }

                //    sw.WriteLine(tempStr);
                //}
                //sw.Close();
                //myStream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                sw.Close();
                myStream.Close();
            }
        }







        //private void dataTableToCsv(DataTable table, string file)
        //{

        //    string title = "";

        //    FileStream fs = new FileStream(file, FileMode.OpenOrCreate);

        //    //FileStream fs1 = File.Open(file, FileMode.Open, FileAccess.Read);

        //    StreamWriter sw = new StreamWriter(new BufferedStream(fs), System.Text.Encoding.Default);

        //    for (int i = 0; i < table.Columns.Count; i++)
        //    {

        //        title += table.Columns[i].ColumnName + "\t"; //栏位：自动跳到下一单元格

        //    }

        //    title = title.Substring(0, title.Length - 1) + "\n";

        //    sw.Write(title);

        //    foreach (DataRow row in table.Rows)
        //    {

        //        string line = "";

        //        for (int i = 0; i < table.Columns.Count; i++)
        //        {

        //            line += row[i].ToString().Trim() + "\t"; //内容：自动跳到下一单元格

        //        }

        //        line = line.Substring(0, line.Length - 1) + "\n";

        //        sw.Write(line);

        //    }

        //    sw.Close();

        //    fs.Close();

        //}


        //private void SaveAs() //另存新档按钮   导出成Excel
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
        //    saveFileDialog.FilterIndex = 0;
        //    saveFileDialog.RestoreDirectory = true;
        //    saveFileDialog.CreatePrompt = true;
        //    saveFileDialog.Title = "Export Excel File To";
        //    saveFileDialog.ShowDialog();
        //    Stream myStream;
        //    myStream = saveFileDialog.OpenFile();
        //    StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding("gb2312"));
        //    //StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));
        //    string str = "";
        //    try
        //    {
        //        //写标题
        //        for (int i = 0; i < dgvNextLevel.ColumnCount; i++)
        //        {
        //            if (i > 0)
        //            {
        //                str += "\t";
        //            }
        //            str += dgvNextLevel.Columns[i].HeaderText;
        //        }
        //        sw.WriteLine(str);
        //        //写内容
        //        for (int j = 0; j < dgvNextLevel.Rows.Count; j++)
        //        {
        //            string tempStr = "";
        //            for (int k = 0; k < dgvNextLevel.Columns.Count; k++)
        //            {
        //                if (k > 0)
        //                {
        //                    tempStr += "\t";
        //                }
        //                tempStr += dgvNextLevel.Rows[j].Cells[k].Value.ToString();
        //            }

        //            sw.WriteLine(tempStr);
        //        }
        //        sw.Close();
        //        myStream.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.ToString());
        //    }
        //    finally
        //    {
        //        sw.Close();
        //        myStream.Close();
        //    }
        //}

    }
}
