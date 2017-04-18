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
            getSaleList();
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
            treeView1.CollapseAll();//全部收起
            PrintTreeViewNode(treeView1.Nodes);

            //特性查询
            getNextLevel1();

            //装配表查询
            getNextLeve2();

            //去向查询
            getNextLevel3();
        }

        private void getSaleList()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);

            //先把销售号取出来
            string sql = " SELECT PartNo,PartName,Remark FROM ViewSalesNo ORDER BY PartNo ";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            cn.Open();
            da.Fill(ds, "SalesList");
            cn.Close();

            for (int i = 0; i < ds.Tables["SalesList"].Rows.Count; i++)
            {
                string sql1 = " SELECT No,AssembleNo,NextLevel,NextLevelName,Remark FROM TempTable WHERE SalesNo=@SalesName";

                SqlDataAdapter da1 = new SqlDataAdapter(sql1, cn);
                da1.SelectCommand.Parameters.Add("SalesName", SqlDbType.NVarChar, 20).Value = ds.Tables["SalesList"].Rows[i]["PartNo"].ToString();
                cn.Open();
                da1.Fill(ds, "NameList");
                cn.Close();

                //以10001为例来展示结构
                TreeNode tn = new TreeNode();
                tn.Name = ds.Tables["SalesList"].Rows[i]["PartNo"].ToString();
                //tn.Text = "4YZ-6型玉米籽粒收获机";
                tn.Text = ds.Tables["SalesList"].Rows[i]["PartNo"].ToString() + ' '+ ds.Tables["SalesList"].Rows[i]["PartName"].ToString();
                tn.ToolTipText = ds.Tables["SalesList"].Rows[i]["Remark"].ToString();
                treeView1.Nodes.Add(tn);//将该节点加入到TreeView中
                BindTreeView(ds.Tables["NameList"], tn, "NextLevel", "AssembleNo", "NextLevelName", "Remark");
                //打开悬停鼠标时提示
                treeView1.ShowNodeToolTips = true;
                this.Controls.Add(treeView1);
                ds.Tables["NameList"].Clear();
            }
        }

        /// <summary>
        /// 绑定TreeView（利用TreeNode）
        /// </summary>
        /// <param name="p_Node">TreeNode（TreeView的一个节点）</param>
        /// <param name="id">数据库 id 字段名</param>
        /// <param name="pid">数据库 父id 字段名</param>
        /// <param name="text">数据库 文本 字段值</param>
        /// 本算法没有使用递归，节省了递归算法层级嵌套耗费的时间，效率非常高。
        /// 本算法强烈依赖于product表生成时使用的递归算法。
        /// product表的一个特点是层级从小到大一直是连续变化的，且一个装配的相关数据都在一起；但层级从大到小有可能产生跳跃
        /// 不能对其进行按组排序（ORDER BY Level），排序后所有组号相同的零件放在一起，打破了装配关系
        protected void BindTreeView(DataTable dt, TreeNode p_Node, string id, string pid, string text, string Remark)
        {
            TreeNode tn;//建立TreeView的节点（TreeNode），以便将取出的数据添加到节点中
            int TempLevel = 0;//当前行的层级数
            int FutureLevel = 0;//下一行的层级数

            //得到DataTable中数据的行数，利用循环每次处理一行数据
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tn = new TreeNode();//建立一个新节点（学名叫：一个实例）
                tn.Name = dt.Rows[i]["NextLevel"].ToString();//结点名称
                tn.Text = dt.Rows[i]["NextLevel"].ToString() + dt.Rows[i]["NextLevelName"].ToString();//结点显示内容
                tn.ToolTipText = dt.Rows[i]["Remark"].ToString();//结点在鼠标悬停时显示的内容，就是Remark列的内容
                p_Node.Nodes.Add(tn);//添加节点

                //从下面一直到结束这些代码用来明确在下一个循环开始的父节点p_Node的位置
                TempLevel = (int)dt.Rows[i]["No"];//字段No的值就是当前行的层级数
                if (i != dt.Rows.Count - 1)//如果没有达到表的最后一行，直接取i+1给FutureLevel赋值就行
                {
                    FutureLevel = (int)dt.Rows[i + 1]["No"];
                }
                else
                {
                    FutureLevel = 0;//到达表的最后一行，i+1就会出问题，需要仔细考虑边界问题
                }

                //用本行和下一行的层级关系来决定结点的移动
                if (TempLevel < FutureLevel)//下一行结点是本行结点的子节点
                {
                    p_Node = tn;
                }
                else if (TempLevel == FutureLevel)
                {
                    //下一行结点是本行结点的兄弟结点
                }
                else//等价(TempLevel > FutureLevel)，下一行结点是本行结点的父兄结点，但是有可能从6级一下回到2级
                {
                    int Distance = TempLevel - FutureLevel;//计算层级差距
                    for (int j = 1; j <= Distance; j++)//无论差几级会一直回溯到正确的父结点
                    {
                        p_Node = p_Node.Parent;
                    }
                }

            }

        }

        //迭代查找
        public void PrintTreeViewNode(TreeNodeCollection node)
        {
            foreach (TreeNode n in node)
            {
                if (n.Name == tbAssemble.Text.ToUpper())
                {
                    //n.Expand(); 自我展开没有必要
                    n.BackColor = Color.LightBlue;//匹配的背景色为蓝色
                    ExpandParentNodes(n.Parent.Nodes);//迭代展开父节点
                }
                else
                {
                    n.BackColor = Color.White;//不匹配的背景色为白色
                }
                PrintTreeViewNode(n.Nodes);//迭代
            }
        }

        //迭代展开父节点
        private void ExpandParentNodes(TreeNodeCollection tnodes)
        {
            TreeNode parentNode;
            foreach (TreeNode node in tnodes)
            {
                parentNode = node;
                if (parentNode.Parent != null)
                {
                    parentNode.Parent.Expand();
                    if (parentNode.Parent.Parent != null)//判断父节点的父节点是否为空，如果已经达到根节点就是null
                    {
                        ExpandParentNodes(parentNode.Parent.Parent.Nodes);
                    }
                    else
                        break;//已经达到根节点，退出
                }
            }
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
            //如果不处理，生成对话框时，如果取消再生成会出现两次重复数据
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
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
            else
            { 
                //取消后动作，可以不处理
            }
        }

        //双击treeview的某一个节点后进行查询
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {   
            //取得双击的节点
            TreeNode currentNode = e.Node;
            //更新输入文本框
            tbAssemble.Text = currentNode.Name.ToString();
            //模拟查询动作
            button1_Click(sender,e);
        }

    }
}
