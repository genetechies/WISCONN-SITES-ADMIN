using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Xml;
using System.Net;
using System.Text.RegularExpressions;

/// <summary>
/// Summary description for GetIpaddress
/// </summary>
public class IpAddress
{
    public static string GetstringIpAddress(string strIP)//strIP为IP
        {


            string sURL = "http://www.youdao.com/smartresult-xml/search.s?type=ip&q="+strIP+"";//youdao的URL
            string stringIpAddress = "";
            using (XmlReader read = XmlReader.Create(sURL))//获取youdao返回的xml格式文件内容
            {
                while (read.Read())
                {
                    switch (read.NodeType)
                    {
                        case XmlNodeType.Text://取xml格式文件当中的文本内容
                            if (string.Format("{0}", read.Value).ToString().Trim() != strIP)//youdao返回的xml格式文件内容一个是IP，另一个是IP地址，如果不是IP
                            {
                                string ssss = read.Value;
                                if (ssss.Split(new Char[] { ' ' }).Length > 0)
                                {
                                    ssss = ssss.Split(new Char[] { ' ' })[0];
                                }
                                stringIpAddress = string.Format("{0}", ssss).ToString().Trim(); //赋值
                            }
                            break;
                        //other
                    }
                }
            }
            return stringIpAddress.Length > 3 ? stringIpAddress.Substring(0, 3) : stringIpAddress;
    }


    public static string getIPAddress()
    {
        string result = String.Empty;

        result = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

        // 如果使用代理，获取真实IP 
        if (result != null && result.IndexOf(".") == -1)    //没有“.”肯定是非IPv4格式 
            result = null;
        else if (result != null)
        {
            if (result.IndexOf(",") != -1)
            {
                //有“,”，估计多个代理。取第一个不是内网的IP。 
                result = result.Replace(" ", "").Replace("'", "");
                string[] temparyip = result.Split(",;".ToCharArray());
                for (int i = 0; i < temparyip.Length; i++)
                {
                    if (IsIPAddress(temparyip[i])
                        && temparyip[i].Substring(0, 3) != "10."
                        && temparyip[i].Substring(0, 7) != "192.168"
                        && temparyip[i].Substring(0, 7) != "172.16.")
                    {
                        return temparyip[i];    //找到不是内网的地址 
                    }
                }
            }
            else if (IsIPAddress(result)) //代理即是IP格式 
                return result;
            else
                result = null;    //代理中的内容 非IP，取IP 
        }
        if (null == result || result == String.Empty)
            result = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];

        if (result == null || result == String.Empty)
            result = System.Web.HttpContext.Current.Request.UserHostAddress;

        return result;
    }
    private static bool IsIPAddress(string str1)
    {
        if (str1 == null || str1 == string.Empty || str1.Length < 7 || str1.Length > 15) return false;

        string regformat = @"^\d{1,3}[\.]\d{1,3}[\.]\d{1,3}[\.]\d{1,3}$";

        Regex regex = new Regex(regformat, RegexOptions.IgnoreCase);
        return regex.IsMatch(str1);
    }

    public static string getIpAddr(String ip)
    {
        if (ip.StartsWith("http://"))
            ip = ip.Replace("http://", "");
        String IP = "http://www.ip138.com/ips1388.asp?ip=";
        IP += ip;
        IP += "&action=2";
        String ipAddr = "";

        //获取网页源码  
        System.Net.WebClient webClient = new System.Net.WebClient();
        String strSource = "";
        try
        {
            strSource = webClient.DownloadString(IP);
            //this.txbAddr.Text = strSource;  
        }
        catch (System.Net.WebException e)
        {
            return ipAddr = e.ToString();
        }

        //提取地址  
        String regex = @"<li>.+<li>";
        ipAddr = System.Text.RegularExpressions.Regex.Match(strSource, regex).ToString();
        ipAddr = ipAddr.Replace("<li>本站主数据：", "");
        ipAddr = ipAddr.Replace("</li><li>", "");
        if (ipAddr.Contains(" "))
        {
            ipAddr = ipAddr.Split(new char[] { ' ' })[0];
        }
        return ipAddr;
    }

}


