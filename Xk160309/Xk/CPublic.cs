using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
//using System.Net;


/*
部门权限配置
1100000000000001研发
1010000000000001技术
1000000000000001其他
1000000000000011数据
1110000000000001经营
*/


namespace Xk
{
    static class Menus //推荐定义常量方式  
    {
        public const ushort GgCx = 0x8000;//1000000000000000
        public const ushort YfZx = 0x4000;//0100000000000000
        public const ushort JsB = 0x2000; //0010000000000000
        public const ushort XxGl = 0x0002;//0000000000000010
        public const ushort Xt = 0x0001;  //0000000000000001
    }

    class CGlobal 
    {
        public static bool isShow = false; 
    }

    class CPublic
    {
        public static bool isUser = false;
        public static string UserName;
        public static string CnName;
        public static int DepartmentMask;
        //public static IPHostEntry ipe = Dns.GetHostEntry(Dns.GetHostName());
        //public static IPAddress ipa = ipe.AddressList[3];
        //CPublic.ipa.ToString()
    }
}
