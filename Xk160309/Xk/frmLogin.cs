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
    public partial class frmLogin : Form
    {
        DataSet ds = new DataSet();

        public frmLogin()
        {
            InitializeComponent();
            getPassList();
        }

        private void getPassList()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);

            //先把用户名和密码以及部门掩码取出来
            string sql = " SELECT UserName,CnName,Password,DepartmentMask FROM Sysuser S,Department D WHERE S.DepartmentNo = D.DepartmentNo ";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            cn.Open();
            da.Fill(ds, "PassList");
            cn.Close();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //取对话框中的用户名和密码与列表中的数据进行循环对比，验证用户身份
            int i;
            for (i = 0; i < ds.Tables["PassList"].Rows.Count; i++)
            {
                if (txtID.Text == ds.Tables["PassList"].Rows[i]["UserName"].ToString())
                {
                    if (txtPwd.Text == ds.Tables["PassList"].Rows[i]["Password"].ToString())
                    {
                        CPublic.isUser = true;
                        CPublic.UserName = ds.Tables["PassList"].Rows[i]["UserName"].ToString();
                        CPublic.CnName = ds.Tables["PassList"].Rows[i]["CnName"].ToString();
                        CPublic.DepartmentMask = Convert.ToInt32(ds.Tables["PassList"].Rows[i]["DepartmentMask"]);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("密码错误！", "登录", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }

            }
            if (i == ds.Tables["PassList"].Rows.Count)
                MessageBox.Show("用户名不存在！", "登录", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
 
}
