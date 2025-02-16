using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
///CbxSubweb 的摘要说明
/// </summary>
public class CbxSubwebSingle : System.Web.UI.Page
{
    public CbxSubwebSingle()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    public DataTable CbxTable()
    {
        DataTable dt = new DataTable();

        //------------------創建數據源--------------------------
        //創建表頭
        dt.Columns.Add("SWID", Type.GetType("System.Int32"));
        dt.Columns.Add("SWName", Type.GetType("System.String"));
        //創建行
        DataRow dr = null;
        //int j = 0;
        //dr = dt.NewRow();
        //dr["SWName"] = "全站";
        //dr["SWID"] = j;
        //dt.Rows.Add(dr);

        List<Model.SubWeb> web = new BLL.SubWeb().GetModelList("SWName='母站'");
        for (int i = 0; i < web.Count; i++)
        {
            dr = dt.NewRow();
            dr["SWName"] = web[i].SWName;
            dr["SWID"] = web[i].SWID;
            dt.Rows.Add(dr);
        }
        return dt;
    }
    /// <summary>
    /// 權限限制
    /// </summary>
    /// <returns></returns>
    public DataTable CbxTableAuthority()
    {
        return CbxTable();
        //if (Session["Admin"].ToString().ToLower() == "admin")
        //{
        //    return CbxTable();
        //}
        //else
        //{
        //    DataTable dt = new DataTable();
        //    string UserName = Session["Admin"].ToString();

        //    //------------------創建數據源--------------------------
        //    //創建表頭
        //    dt.Columns.Add("SWID", Type.GetType("System.Int32"));
        //    dt.Columns.Add("SWName", Type.GetType("System.String"));
        //    //創建行
        //    DataRow dr = null;
        //    //int j = 0;
        //    //dr = dt.NewRow();
        //    //dr["SWName"] = "全站";
        //    //dr["SWID"] = j;
        //    //dt.Rows.Add(dr);
        //    DataSet ds = new BLL.Right().GetList("UserName='" + UserName + "' and Rights=0");

        //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //    {
        //        Model.SubWeb web = new BLL.SubWeb().GetModel(Convert.ToInt32(ds.Tables[0].Rows[i]["PageName"].ToString()));
        //        if (web != null)
        //        {
        //            dr = dt.NewRow();
        //            dr["SWName"] = web.SWName;
        //            dr["SWID"] = web.SWID;
        //            dt.Rows.Add(dr);
        //        }
        //    }
        //    return dt;
        //}
    
    }

    public Model.SubWeb GetWebModel()
    {
        List<Model.SubWeb> web = new BLL.SubWeb().GetModelList("SWName='母站'");

        return web[0];
    }
}