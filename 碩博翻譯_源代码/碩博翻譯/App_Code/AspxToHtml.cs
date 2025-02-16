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
    private StreamReader sr;
    private StreamWriter sw;
    private string str = "";

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
        if (htmlName == "downindex.html")
            friendlytable = bll.GetList(" F_location in (1,3,4,6)").Tables[0];
        else if (htmlName == "downother.html")
            friendlytable = bll.GetList(" F_location IN (1,5,6,7)").Tables[0];
        else if (htmlName == "downlink.html")
            friendlytable = bll.GetList(" F_location in (1,2,4,7)").Tables[0];
        else
            friendlytable = bll.GetList("").Tables[0];

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < friendlytable.Rows.Count; i++)
        {
            if (i % 4 == 0)
            {
                sb.Append("<ul  class=\"slides\">");

            }

            sb.Append("<li  class=\"gdlr-core-item-mglr\" " + (i % 4 == 0 ? "" : (i % 4 == 3 ? "style=\"text-align: right;\"" : "style=\"text-align: center;\"")) + " >");
            sb.Append("<a href='http://" + friendlytable.Rows[i][2].ToString() + "' target='_blank' title='" + friendlytable.Rows[i][1].ToString() + "'>" + friendlytable.Rows[i][1].ToString() + "</a>");
            sb.Append("</li>");
            if (i % 4 == 3 || i == friendlytable.Rows.Count - 1)
            {
                sb.Append("</ul>");
            }
        }

        str = str.Replace("$FriendlyName$", sb.ToString());

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
