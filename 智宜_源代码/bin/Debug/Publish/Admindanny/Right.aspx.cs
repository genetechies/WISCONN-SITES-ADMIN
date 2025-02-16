using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Diagnostics;

namespace ZeroStudio.Web.Admin
{
    public partial class Right : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DataAccess.IsAdmin();
            if (Session["Admin"] != null)
                Label1.Text = Session["Admin"].ToString();
            else Label1.Visible = false;

            ComName.Text = Server.MachineName;
            IP.Text = Request.ServerVariables["Local_addr"];

            Web.Text = Request.ServerVariables["server_name"].ToString();

            Dk.Text = Request.ServerVariables["server_port"].ToString();

            Iis.Text = Request.ServerVariables["server_software"].ToString();

            Path.Text = Request.PhysicalApplicationPath;

            Os.Text = Environment.OSVersion.ToString();

            TimeOut.Text = (Server.ScriptTimeout / 1000).ToString() + "秒";
            Framework.Text = string.Concat(new object[] { Environment.Version.Major, ".", Environment.Version.Minor, ".", Environment.Version.Build, ".", Environment.Version.Revision });

            Time.Text = DateTime.Now.ToString("yyyy-MM-dd");

            StartTime.Text = (((Environment.TickCount / 0x3e8) / 60) / 60).ToString() + "\n小时";
            string[] achDrives = Directory.GetLogicalDrives();

            for (int i = 0; i < Directory.GetLogicalDrives().Length; i++)
            {
                IDE.Text = IDE.Text + achDrives[i].ToString();
            }
            w3w.Text = ((Double)Process.GetCurrentProcess().WorkingSet64 / 1048576).ToString("N2") + "M";
            CpuNum.Text = Environment.GetEnvironmentVariable("NUMBER_OF_PROCESSORS").ToString();

            CpuType.Text = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER").ToString();

            SessionNum.Text = Session.Contents.Count.ToString();
        }
    }
}
