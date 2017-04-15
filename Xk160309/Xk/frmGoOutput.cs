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
    public partial class frmGoOutput : Form
    {
        DataSet ds = new DataSet();
        public frmGoOutput()
        {
            InitializeComponent();
        }


        //取得左侧销售列表
        private void getSaleList()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            string sql = " SELECT * FROM AssembleList where  AssembleNo LIKE '__0__' AND LevelHigh = '是' ORDER BY AssembleNo ";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);

            cn.Open();
            da.Fill(ds, "SalesList");
            cn.Close();
            dgvSalesList.DataSource = ds.Tables["SalesList"];
        }

        //页面加载的时候运行
        private void frmGoOutput_Load(object sender, EventArgs e)
        {
            dgvSalesList.AutoGenerateColumns = false;
            getSaleList();
            //dgvSalesList.Columns[1].DefaultCellStyle.Font = new Font("宋体", 12, FontStyle.Bold);
            //dgvSalesList.Columns[0].DefaultCellStyle.Font = new Font("宋体", 12, FontStyle.Bold);
            //dgvSalesList.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 12, FontStyle.Bold);
        }

        //按钮按下后取得
        private void btnQueryNextLevel_Click(object sender, EventArgs e)
        {
            dgvNextLevel.AutoGenerateColumns = false;
            getNextLevel();
        }


        private void getNextLevel()
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
            SalesNo.Value = dgvSalesList.CurrentRow.Cells["SalesNo"].Value.ToString();

            //查找去向的类型为4
            SqlParameter Type = SqlComm.Parameters.Add(new SqlParameter("@Type", SqlDbType.Int, 10));
            SalesNo.Direction = ParameterDirection.Input;
            Type.Value = 4;

            SqlDataAdapter da = new SqlDataAdapter(SqlComm);

            if (dgvNextLevel.CurrentRow == null)
            {
                cn.Open();
                da.Fill(ds, "GetGo");
                cn.Close();
                dgvNextLevel.DataSource = ds.Tables["GetGo"];
            }
            else
            {
                ds.Tables["GetGo"].Clear();
                cn.Open();
                da.Fill(ds, "GetGo");
                cn.Close();
                dgvNextLevel.DataSource = ds.Tables["GetGo"];
            }



            //string UpLevel1 = Convert.ToString(SqlComm.Parameters["@UpLevel"].Value);
            //MessageBox.Show(UpLevel1);
            //string Count1 = Convert.ToString(SqlComm.Parameters["@Count"].Value);
            //MessageBox.Show(Count1);
            //string TopLevel1 = Convert.ToString(SqlComm.Parameters["@TopLevel"].Value);
            //MessageBox.Show(TopLevel1);
        }

    }
}
