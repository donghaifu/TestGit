using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Net;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Globalization;  //要支持汉字路径，应该包含这个

using System.Data.SqlClient;


namespace Drawing
{
    public partial class frmDrawing : Form
    {
        private string ftpServerIP = "192.168.5.77";
        private string ftpUserName = "shjxtzk";
        private string ftpPwd = "yto1008610";
        //本地路径
        private string filePath = "C:\\Windows\\windrawing\\";
        DataSet ds = new DataSet();

        public frmDrawing()
        {
            InitializeComponent();
            try
            {
                Directory.Delete(filePath, true);

            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message, "请拨打 3289#", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //设定按字体来缩放控件  
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //设定字体大小为12px       
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));

            Directory.CreateDirectory(filePath);
            axDwgViewX1.AddFontPath("D:\\Harvest\\fonts\\");

        }

        private bool Download(string filePath, string ImageSrc, string ImageName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {

            //using (FileStream OutputStream = new FileStream(filePath + "/" + ImageName, FileMode.Create))
            try
            {

                FtpWebRequest ReqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + ImageSrc));
                ReqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                ReqFTP.UseBinary = true;
                ReqFTP.Credentials = new NetworkCredential(ftpUserName, ftpPwd);

                try
                {
                    FtpWebResponse response = (FtpWebResponse)ReqFTP.GetResponse();
                    FileStream OutputStream = new FileStream(filePath + "/" + ImageName, FileMode.Create);
                    using (Stream FtpStream = response.GetResponseStream())
                    {
                        long Cl = response.ContentLength;
                        int bufferSize = 2048;
                        int readCount;
                        byte[] buffer = new byte[bufferSize];
                        readCount = FtpStream.Read(buffer, 0, bufferSize);
                        while (readCount > 0)
                        {
                            OutputStream.Write(buffer, 0, readCount);
                            readCount = FtpStream.Read(buffer, 0, bufferSize);
                        }
                        FtpStream.Close();
                    }
                    response.Close();
                    OutputStream.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "如果件号确认无误，请拨打 3289#", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
                //MessageBox.Show(ex.Message, "请拨打 3289#", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }

        private void dgvNextLevel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ImageSrc 最终要给出的是 FTP文件的全路径和文件名
            string ImageSrc = "图纸汇总/";
            ImageSrc += dgvNextLevel[0, dgvNextLevel.CurrentRow.Index].Value.ToString();
            ImageSrc += ".dwg";

            //ImageName只要给出本地文件名即可，路径在类开始处声明的 filePath 中
            string ImageName = dgvNextLevel[0, dgvNextLevel.CurrentRow.Index].Value.ToString();
            ImageName += ".dwg";
            string src = filePath + ImageName;

            //加入查询语句返回结果
            FtpDownloadAndSee(ImageSrc, ImageName, src);
            axDwgViewX1.DrawingFile = src;


            //MessageBox.Show(name, "软件异常", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }



        private void btnSee_Click(object sender, EventArgs e)
        {
            //ImageSrc 最终要给出的是 FTP文件的全路径和文件名
            string ImageSrc = "图纸汇总/";
            ImageSrc += tbAssemble.Text.ToString();
            ImageSrc += ".dwg";

            //ImageName只要给出本地文件名即可，路径在类开始处声明的 filePath 中
            string ImageName = tbAssemble.Text.ToString();
            ImageName += ".dwg";
            string src = filePath + ImageName;

            getNextLevel();
            //加入查询语句返回结果
            FtpDownloadAndSee(ImageSrc, ImageName, src);
            axDwgViewX1.DrawingFile = src;
        }

        private void FtpDownloadAndSee(string ImageSrc, string ImageName, string src)
        {
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
                if (Download(filePath, ImageSrc, ImageName, ftpServerIP, ftpUserName, ftpPwd))
                {
                    //MessageBox.Show("创建目录下载完后显示", "请拨打 3289#", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (File.Exists(src))
                {
                    //MessageBox.Show("有文件直接看", "请拨打 3289#", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (Download(filePath, ImageSrc, ImageName, ftpServerIP, ftpUserName, ftpPwd))
                    {
                        //MessageBox.Show("有目录，无文件，下载完后显示", "请拨打 3289#", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }


        private void getNextLevel()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            string sql1 = " SELECT AssembleList.AssembleNo AS No,AssembleList.AssembleName AS Name,Assemble.Number,Assemble.Level,Assemble.Remark FROM AssembleList,Assemble";
            sql1 += " WHERE Assemble.AssembleNo=@AssembleNo AND AssembleList.AssembleNo=Assemble.NextLevel AND AssembleList.SheetNo!='006'";
            sql1 += " UNION ALL";
            sql1 += " SELECT PartList.PartNo AS No,PartList.PartName AS Name,Assemble.Number,Assemble.Level,Assemble.Remark FROM PartList,Assemble";
            sql1 += " WHERE  Assemble.AssembleNo=@AssembleNo AND PartList.PartNo=Assemble.NextLevel AND PartList.SheetNo!='006'";
            sql1 += " ORDER BY Assemble.Level";

            SqlDataAdapter da1 = new SqlDataAdapter(sql1, cn);
            da1.SelectCommand.Parameters.Add("AssembleNo", SqlDbType.NVarChar, 20).Value = tbAssemble.Text.ToString();
            //da1.SelectCommand.Parameters.Add("SalesNo", SqlDbType.NVarChar, 10).Value = dgvSalesList.CurrentRow.Cells["SalesNo"].Value.ToString();

            if (dgvNextLevel.CurrentRow == null)
            {
                cn.Open();
                da1.Fill(ds, "NextLevelList");
                cn.Close();
                dgvNextLevel.DataSource = ds.Tables["NextLevelList"];
            }
            else
            {
                ds.Tables["NextLevelList"].Clear();
                cn.Open();
                da1.Fill(ds, "NextLevelList");
                cn.Close();
                dgvNextLevel.DataSource = ds.Tables["NextLevelList"];
            }

        }




        private void frmDrawing_Load(object sender, EventArgs e)
        {
            //窗体加载时改变标志位
           // CGlobal.isShow = true;
            dgvNextLevel.AutoGenerateColumns = false;
        }

        private void frmDrawing_FormClosing(object sender, FormClosingEventArgs e)
        {
            //窗体关闭时改变标志位
            //CGlobal.isShow = false;
            //Form关闭时删除目录
            try
            {
                Directory.Delete(filePath, true);
            }
            catch (Exception)
            {
                MessageBox.Show("软件异常，请拨打 3289#", "软件异常", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



    }
}
