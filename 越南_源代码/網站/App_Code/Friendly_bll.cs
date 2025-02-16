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

/// <summary>
/// Summary description for Friendly_bll
/// </summary>
public class Friendly_bll
{
    private readonly Friendly_dal dal = new Friendly_dal();
	public Friendly_bll()
	{
		//
		// TODO: Add constructor logic here
		//
    }

    #region 成员方法
     /// <summary>
    /// 增加一条数据
    /// </summary>
    public void Add(Friendly_model model,Model.SubWeb sw)
    {
        dal.Add(model,sw);
    }

    /// <summary>
    /// 返回留言条数
    /// </summary>
    /// <returns></returns>
    public int Count()
    {
        return dal.Count();
    }

    /// <summary>
    /// 获得数据列表
    /// </summary>
    public DataSet GetList(string StrWhere,Model.SubWeb sw)
    {
        return dal.GetList(StrWhere,sw);
    }

    /// <summary>
    /// 刪除一条数据
    /// </summary>
    /// <param name="strWhere"></param>
    /// <returns></returns>
    public void Delete(string strWhere,Model.SubWeb sw)
    {
        dal.Delete(strWhere,sw);
    }

    /// <summary>
    /// 更新一条数据
    /// </summary>
    public void Update(Friendly_model model,Model.SubWeb sw)
    {
        dal.Update(model,sw);
    }

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public Friendly_model GetModel(int F_Id,Model.SubWeb sw)
    {
        return dal.GetModel(F_Id,sw);
    }

    /// <summary>
    /// 更新排序號
    /// </summary>
    /// <param name="F_Id"></param>
    /// <param name="sort"></param>
    public void UpdateSortKey(int F_Id, int sort)
    {
        dal.UpdateSortKey(F_Id, sort);
    }
    #endregion
}
