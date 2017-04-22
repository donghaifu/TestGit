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
    public partial class frmPartInput : Form
    {
        DataSet ds = new DataSet();
        public frmPartInput(TextBox fc)
        {
            InitializeComponent();
            textBox1.Text = fc.Text;
            getDateList();
        }

        private void getDateList()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);

            //先把sheet取出来
            string sql = " SELECT SheetNo,SheetName FROM Sheet ";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            cn.Open();
            da.Fill(ds, "Sheet");
            cn.Close();
            comboBox1.DataSource = ds.Tables["Sheet"];
            comboBox1.DisplayMember = "SheetName";
            comboBox1.ValueMember = "SheetNo";

            sql = " SELECT TypeNo,TypeName FROM Type ";
            SqlDataAdapter da1 = new SqlDataAdapter(sql, cn);
            cn.Open();
            da1.Fill(ds, "Type");
            cn.Close();
            comboBox2.DataSource = ds.Tables["Type"];
            comboBox2.DisplayMember = "TypeName";
            comboBox2.ValueMember = "TypeNo";

            sql = " SELECT ImportantNo,ImportantName FROM Important ";
            SqlDataAdapter da2 = new SqlDataAdapter(sql, cn);
            cn.Open();
            da2.Fill(ds, "Important");
            cn.Close();
            comboBox3.DataSource = ds.Tables["Important"];
            comboBox3.DisplayMember = "ImportantName";
            comboBox3.ValueMember = "ImportantNo";

            sql = " SELECT UserNo,CnName FROM Sysuser WHERE DepartmentNo ='001' ";
            SqlDataAdapter da3 = new SqlDataAdapter(sql, cn);
            cn.Open();
            da3.Fill(ds, "UserNo");
            cn.Close();
            comboBox4.DataSource = ds.Tables["UserNo"];
            comboBox4.DisplayMember = "CnName";
            comboBox4.ValueMember = "UserNo";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            string sql3 = " INSERT INTO Part (PartNo,PartName,SheetNo,TypeNo,ImportantNo,UserNo,TechnologyEmailNo,Remark)";
            sql3 += " VALUES (@No1,@Name1,@SheetNo1,@TypeNo1,@ImportantNo1,@OwnerNo1,@TechnologyEmailNo1,@Remark1)";

            SqlCommand cmd3 = new SqlCommand(sql3, cn);
            cmd3.CommandText = sql3;
            cmd3.Parameters.Add("No1", SqlDbType.NVarChar, 20).Value = partNoTextBox.Text.ToString();
            cmd3.Parameters.Add("Name1", SqlDbType.NVarChar, 50).Value = partNameTextBox.Text.ToString();
            cmd3.Parameters.Add("SheetNo1", SqlDbType.NVarChar, 3).Value = comboBox1.SelectedValue.ToString();
            cmd3.Parameters.Add("TypeNo1", SqlDbType.NVarChar, 3).Value = comboBox2.SelectedValue.ToString(); ;
            cmd3.Parameters.Add("ImportantNo1", SqlDbType.NVarChar, 3).Value = comboBox3.SelectedValue.ToString(); ;
            cmd3.Parameters.Add("OwnerNo1", SqlDbType.NVarChar, 4).Value = comboBox4.SelectedValue.ToString(); ;
            cmd3.Parameters.Add("TechnologyEmailNo1", SqlDbType.NVarChar, 20).Value = textBox1.Text.ToUpper();
            cmd3.Parameters.Add("Remark1", SqlDbType.NVarChar, 60).Value = remarkTextBox.Text.ToString();


            cn.Open();
            cmd3.ExecuteNonQuery();
            cn.Close();
            partNoTextBox.Clear();
            partNameTextBox.Clear();
            remarkTextBox.Clear();
        }

        private void frmPartInput_Load(object sender, EventArgs e)
        {

            //输入法设置成半角
            partNoTextBox.ImeMode = ImeMode.OnHalf;
            partNameTextBox.ImeMode = ImeMode.OnHalf;
            remarkTextBox.ImeMode = ImeMode.OnHalf;
        }


    }
}
