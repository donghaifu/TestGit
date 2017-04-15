using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
//using System.Net;

namespace Xk
{
    class CGlobal 
    {
        public static bool isShow = false; 
    
    }

    class CPublic
    {
        //public static DataRow LoginInfo;
        public static bool isManager;
        public static bool isUser;

        //public static IPHostEntry ipe = Dns.GetHostEntry(Dns.GetHostName());
        //public static IPAddress ipa = ipe.AddressList[3];
        //CPublic.ipa.ToString()

        public static void CheckUsers(string UserID, string Pwd)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.HarvestConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users WHERE UserName=@UserName AND Pwd=@Pwd", cn);
            da.SelectCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 10).Value = UserID;
            da.SelectCommand.Parameters.Add("@Pwd", SqlDbType.NVarChar, 8).Value = Pwd;
            DataSet ds = new DataSet();
            cn.Open();
            da.Fill(ds);
            cn.Close();
            
            if (ds.Tables[0].Rows.Count > 0)
            {
                isUser = true;
                isManager = true;
            }
            else
            {
                isUser = false;
                isManager = false;
            }
        }

        public static void CheckIp()
        {
            isManager = false;
            isUser = true;
        }

    }
}
