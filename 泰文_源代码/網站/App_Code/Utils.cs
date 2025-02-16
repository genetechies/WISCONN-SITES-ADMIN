using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Utils 的摘要说明
/// </summary>
public class Utils
{
    public Utils() { }

    public static bool IsRight(string username, string pagename, RightStatus status)
    {

        BLL.Right right = new BLL.Right();
        if (username.ToLower() == "admin")
        {
            return true;
        }
        Model.Right model = right.GetModel(username, pagename);
        if (model == null)
        {
            return false;
        }
        else
        {
            int rights = model.Rights;
            if ((rights & (int)status) == (int)status)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }

    public static string SubString(object strObj, int length, string pad)
    {
        var str = Convert.ToString(strObj);

        if (string.IsNullOrEmpty(str) || str.Length <= length)
        {
            return str;
        }

        else
        {
            if (string.IsNullOrEmpty(pad))
            {
                return str.Substring(0, length);
            }
            else
            {
                return str.Substring(0, length - pad.Length) + pad;
            }
        }

    }
}
public enum RightStatus
{
    Empty = 0,
    Insert = 1,
    Delete = 1 << 1,
    Update = 1 << 2,
    Select = 1 << 3
}
public enum BookItems
{
    State1 = 1,//Seo網站專用空間
    State2 = 1 << 1,//Seo專業網頁設計
    State3 = 1 << 2,//全球搜尋引擎登錄
    State4 = 1 << 3,//網站排名
    State5 = 1 << 4, //社群行銷
    State6 = 1 << 5,//論壇行銷
    State7 = 1 << 6, //部落格行銷
    State8 = 1 << 7,//專業行銷分析系統
}
