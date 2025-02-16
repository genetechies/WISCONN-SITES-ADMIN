using System;
using System.Data;
using System.IO;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for AspxToHtml
/// </summary>
public class AspxToHtml
{

    StreamReader sr;
    StreamWriter sw;
    string str = "";

    public void WriteFile(string htmlName)
    {
        string path = HttpContext.Current.Server.MapPath("../../newspages/");
        Encoding code = Encoding.GetEncoding("utf-8");
        //读取模版文件

        string temp = HttpContext.Current.Server.MapPath("../../adminaspx/Template/downotherTemplate.html");
        try
        {
            sr = new StreamReader(temp, code);
            str = sr.ReadToEnd();
            sr.Close();
        }
        catch (Exception)
        {
            sr.Close();
            throw;
        }

        Friendly_bll bll = new Friendly_bll();
        DataTable friendlytable = null;
        /*if (htmlName == "downindex.html")
            friendlytable = bll.GetList(" F_location in (1,3,4,6)").Tables[0];
        else if (htmlName == "downother.html")
            friendlytable = bll.GetList(" F_location IN (1,5,6,7)").Tables[0];
        else if (htmlName == "downlink.html")
            friendlytable = bll.GetList(" F_location in (1,2,4,7)").Tables[0];
        else
            friendlytable = bll.GetList("").Tables[0];*/

        if (htmlName == "downindex.html")
            friendlytable = bll.GetList(" F_location in (1,3,4,6)").Tables[0];
        else if (htmlName == "downother.html")
            friendlytable = bll.GetList(" F_location IN (1,5,6,7)").Tables[0];
        else if (htmlName == "downlink.html")
            friendlytable = bll.GetList(" F_location in (1,2,4,7)").Tables[0];
        else
            friendlytable = bll.GetList("").Tables[0];

        string FriendlyName = "<table style='border:0px;'><tr>";
        //替换内容
        if (friendlytable != null && friendlytable.Rows.Count > 0)
        {
            for (int i = 0; i < friendlytable.Rows.Count; i++)
            {
               // if (i != 0 && i % 7 == 0)
                //    FriendlyName += "</tr><tr><td style='border:0px;' align='center'><div class='icon1'><a href='http://" + friendlytable.Rows[i][2].ToString() + "' target='_blank' title='" + friendlytable.Rows[i][1].ToString() + "'><font style='font-family: 'Verdana', 'Helvetica san-serif''>" + friendlytable.Rows[i][1].ToString() + "</font></a></div></td> ";
               // else
                //    FriendlyName += "<td  style='border:0px;width:135px;' align='center'><div class='icon1'><a href='http://" + friendlytable.Rows[i][2].ToString() + "' target='_blank' title='" + friendlytable.Rows[i][1].ToString() + "'><font style='font-family: 'Verdana', 'Helvetica san-serif''>" + friendlytable.Rows[i][1].ToString() + "</font></a></div></td> ";
                if (i != 0 && i % 7 == 0)
                    FriendlyName += "</tr><tr><td style='border:0px;' align='center'><div class='icon1'><a href='http://" + friendlytable.Rows[i][2].ToString() + "' target='_blank' title='" + friendlytable.Rows[i][1].ToString() + "'><span class='fontstyle'>" + friendlytable.Rows[i][1].ToString() + "</span></a></div></td> ";
                else
                    FriendlyName += "<td  style='border:0px;width:135px;' align='center'><div class='icon1'><a href='http://" + friendlytable.Rows[i][2].ToString() + "' target='_blank' title='" + friendlytable.Rows[i][1].ToString() + "'><span class='fontstyle'>" + friendlytable.Rows[i][1].ToString() + "</span></a></div></td> ";
            
            }
        }
        if (friendlytable != null && friendlytable.Rows.Count < 7)
        {
            for (int i = 0; i < 7 - friendlytable.Rows.Count; i++)
            {
                FriendlyName += "<td  style='border:0px;width:135px;'></td>";
            }
        }
        FriendlyName += "</tr></table>";

        Partners_bll pbll = new Partners_bll();
        DataTable partnerstable = null;
        if (htmlName == "downindex.html")
            partnerstable = pbll.GetList(" F_location in (1,3,4,6)").Tables[0];
        else if (htmlName == "downother.html")
            partnerstable = pbll.GetList(" F_location in (1,5,6,7)").Tables[0];
        else if (htmlName == "downlink.html")
            partnerstable = pbll.GetList(" F_location in (1,2,4,7)").Tables[0];
        else
            partnerstable = pbll.GetList("").Tables[0];
        string PartnersName = "<table style='border:0px;'><tr>";
        if (partnerstable != null && partnerstable.Rows.Count > 0)
        {
            for (int i = 0; i < partnerstable.Rows.Count; i++)
            {
                if (i != 0 && i % 7 == 0)
                    PartnersName += "</tr><tr><td  style='border:0px;' align='center'><div class='icon1'><a href='http://" + partnerstable.Rows[i][2].ToString() + "' target='_blank' title='" + partnerstable.Rows[i][1].ToString() + "'><span class='fontstyle'>" + partnerstable.Rows[i][1].ToString() + "</span></a></div></td> ";
                else
                    PartnersName += "<td align='center' style='border:0px;width:135px;'><div class='icon1'><a href='http://" + partnerstable.Rows[i][2].ToString() + "' target='_blank' title='" + partnerstable.Rows[i][1].ToString() + "'><span class='fontstyle'>" + partnerstable.Rows[i][1].ToString() + "</span></a></div></td>";
            }
        }
        if (partnerstable != null && partnerstable.Rows.Count < 7)
        {
            for (int i = 0; i < 7 - partnerstable.Rows.Count; i++)
            {
                PartnersName += "<td  style='border:0px;width:135px;'></td>";
            }
        }
        PartnersName += "</tr></table>";
        str = str.Replace("$FriendlyName$", FriendlyName);
        str = str.Replace("$PartnersName$", PartnersName);

        try
        {
            sw = new StreamWriter(path + htmlName, false, code);
            sw.Write(str);
            sw.Flush();
            sw.Close();
        }
        catch (Exception)
        {
            sw.Close();
            throw;
        }
    }
}
