using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;

namespace UpdateWebService
{
    /// <summary>
    /// Service1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class LiveUpdate : System.Web.Services.WebService
    {

        [WebMethod]
        public decimal GetVersion()
        {
            string version= System.Configuration.ConfigurationManager.AppSettings["version"];
            decimal decver = decimal.Parse(version);
            return decver;
        }
         [WebMethod]
        public byte[] GetExeFile()
        {
            string filename = Server.MapPath("updateFile");
            string path = filename + "\\RFDeviceAPP.exe";
            FileStream fs= File.Open(path, FileMode.Open, FileAccess.Read);
            byte[] buf=new byte[fs.Length];

            fs.Read(buf, 0, buf.Length);
            fs.Close();
            return buf;

        }
    }
}
