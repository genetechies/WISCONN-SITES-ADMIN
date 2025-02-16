using System;
using System.Data;
using System.IO;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for AspxToHtml
/// </summary>
public class AspxToHtml : System.Web.UI.Page
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

        if (htmlName == "downindex.html")
            friendlytable = CreateTable(" F_location in (1,3,4,6)");
        else if (htmlName == "downother.html")
            friendlytable = CreateTable(" F_location IN (1,5,6,7)");
        else if (htmlName == "downlink.html")
            friendlytable = CreateTable(" F_location in (1,2,4,7)");
        else
            friendlytable = CreateTable("");

        string FriendlyName = "";
        //替换内容
        if (friendlytable != null && friendlytable.Rows.Count >= 7)
        {
            for (int i = 0; i < friendlytable.Rows.Count; i++)
            {
                if (i % 7 == 0)
                    FriendlyName += "<tr><td style='text-align:left;border:0px;width:135px;height:24px;'><a href='http://" + friendlytable.Rows[i]["F_Url"].ToString() + "' target='_blank' title='" + friendlytable.Rows[i]["F_Name"].ToString() + "'>" + friendlytable.Rows[i]["F_Name"].ToString() + "</a></td>";
                else if((i+1)%7==0)
                    FriendlyName += "<td style='text-align:left;border:0px;width:135px;height:24px;'><a href='http://" + friendlytable.Rows[i]["F_Url"].ToString() + "' target='_blank' title='" + friendlytable.Rows[i]["F_Name"].ToString() + "'>" + friendlytable.Rows[i]["F_Name"].ToString() + "</a></td></tr>";
                else
                    FriendlyName += "<td style='text-align:left;border:0px;width:135px;height:24px;'><a href='http://" + friendlytable.Rows[i]["F_Url"].ToString() + "' target='_blank' title='" + friendlytable.Rows[i]["F_Name"].ToString() + "'>" + friendlytable.Rows[i]["F_Name"].ToString() + "</a></td>";
            }
        }
        if (friendlytable != null && friendlytable.Rows.Count < 7)
        {
            FriendlyName = "<tr>";
            for (int i = 0; i < 7 - friendlytable.Rows.Count; i++)
            {
                FriendlyName += "<td style='text-align:left;border:0px;width:135px;height:24px;'><a href='http://" + friendlytable.Rows[i]["F_Url"].ToString() + "' target='_blank' title='" + friendlytable.Rows[i]["F_Name"].ToString() + "'>" + friendlytable.Rows[i]["F_Name"].ToString() + "</a></td>";
            }
            FriendlyName += "</tr>";
        }
        FriendlyName += "";

        str = str.Replace("$FriendlyName$", FriendlyName);
        //str = str.Replace("$PartnersName$", PartnersName);

        try
        {
            sw = new StreamWriter(path + htmlName, false, code);
            sw.Write(str);
            sw.Flush();
            sw.Close();
        }
        catch (Exception)
        {
            //sw = new StreamWriter(path + htmlName);
            //sw.Close();
            //throw;
        }
    }

    /// <summary>
    /// 綁定數據
    /// </summary>
    /// <param name="where"></param>
    /// <returns></returns>
    public DataTable CreateTable(string where)
    {
        DataTable dt = new DataTable();

        //------------------創建數據源--------------------------
        //創建表頭
        dt.Columns.Add("F_Id", Type.GetType("System.Int32"));
        dt.Columns.Add("F_Location", Type.GetType("System.String"));
        dt.Columns.Add("F_Name", Type.GetType("System.String"));
        dt.Columns.Add("F_Url", Type.GetType("System.String"));
        dt.Columns.Add("F_Author", Type.GetType("System.String"));
        dt.Columns.Add("F_SortKey", Type.GetType("System.Int32"));
        dt.Columns.Add("F_OptionTime", Type.GetType("System.String"));
        //創建行
        DataRow dr = null;

        if (where != "")
        {
            where = " where " + where;
        }
        //DataSet ds = new Friendly_bll().GetList(where, new CbxSubwebSingle().GetWebModel());
        DataSet ds = DBUtility.DbHelperSQL.Query(string.Format("select top 35 * from Friendly {0}  order by F_SortKey asc,F_Id desc", where));
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            dr = dt.NewRow();
            dr["F_Id"] = Convert.ToInt32(ds.Tables[0].Rows[i]["F_Id"].ToString());
            dr["F_Location"] = ds.Tables[0].Rows[i]["F_Location"].ToString();
            dr["F_Name"] = ds.Tables[0].Rows[i]["F_Name"].ToString();
            dr["F_Url"] = ds.Tables[0].Rows[i]["F_Url"].ToString();
            dr["F_Author"] = ds.Tables[0].Rows[i]["F_Author"].ToString();
            dr["F_SortKey"] = ds.Tables[0].Rows[i]["F_SortKey"].ToString();
            dr["F_OptionTime"] = ds.Tables[0].Rows[i]["F_OptionTime"].ToString();
            dt.Rows.Add(dr);
        }

        DataSet ds2 = DBUtility.DbHelperSQL.Query(string.Format("select top 35 * from Partners {0}  order by F_SortKey asc,F_Id desc", where));
        for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
        {
            dr = dt.NewRow();
            dr["F_Id"] = Convert.ToInt32(ds2.Tables[0].Rows[i]["F_Id"].ToString());
            dr["F_Location"] = ds2.Tables[0].Rows[i]["F_Location"].ToString();
            dr["F_Name"] = ds2.Tables[0].Rows[i]["F_Name"].ToString();
            dr["F_Url"] = ds2.Tables[0].Rows[i]["F_Url"].ToString();
            dr["F_Author"] = ds2.Tables[0].Rows[i]["F_Author"].ToString();
            dr["F_SortKey"] = ds2.Tables[0].Rows[i]["F_SortKey"].ToString();
            dr["F_OptionTime"] = ds2.Tables[0].Rows[i]["F_OptionTime"].ToString();
            dt.Rows.Add(dr);
        }

        return dt;
    }

    public DataTable CreateTable2(string where)
    {
        DataTable dt = new DataTable();

        //------------------創建數據源--------------------------
        //創建表頭
        dt.Columns.Add("F_Id", Type.GetType("System.Int32"));
        dt.Columns.Add("F_Location", Type.GetType("System.String"));
        dt.Columns.Add("F_Name", Type.GetType("System.String"));
        dt.Columns.Add("F_Url", Type.GetType("System.String"));
        dt.Columns.Add("F_Author", Type.GetType("System.String"));
        dt.Columns.Add("F_SortKey", Type.GetType("System.Int32"));
        dt.Columns.Add("F_OptionTime", Type.GetType("System.String"));
        //創建行
        DataRow dr = null;
        if (where != "")
        {
            where = " where " + where;
        }


        DataSet ds = DBUtility.DbHelperSQL.Query(string.Format("select top 35 * from Partners {0}  order by F_SortKey asc", where));
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            dr = dt.NewRow();
            dr["F_Id"] = Convert.ToInt32(ds.Tables[0].Rows[i]["F_Id"].ToString());
            dr["F_Location"] = ds.Tables[0].Rows[i]["F_Location"].ToString();
            dr["F_Name"] = ds.Tables[0].Rows[i]["F_Name"].ToString();
            dr["F_Url"] = ds.Tables[0].Rows[i]["F_Url"].ToString();
            dr["F_Author"] = ds.Tables[0].Rows[i]["F_Author"].ToString();
            dr["F_SortKey"] = ds.Tables[0].Rows[i]["F_SortKey"].ToString();
            dr["F_OptionTime"] = ds.Tables[0].Rows[i]["F_OptionTime"].ToString();
            dt.Rows.Add(dr);
        }

        return dt;
    }
}
