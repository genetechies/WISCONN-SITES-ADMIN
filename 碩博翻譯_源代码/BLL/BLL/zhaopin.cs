using System.Data;
using DAL;
using Model;

namespace BLL;

public class zhaopin
{
	private readonly DAL.zhaopin dal = new DAL.zhaopin();

	public int CountByClass(string where)
	{
		return dal.CountByClass(where);
	}

	public DataSet GetList(string strWhere)
	{
		return dal.GetList(strWhere);
	}

	public DataSet GetListByClass(string strWhere, string orderBy)
	{
		return dal.GetListByClass(strWhere, orderBy);
	}

	public bool Delete(int id)
	{
		return dal.Delete(id);
	}

	public Model.zhaopin GetModel(int P_ID)
	{
		return dal.GetModel(P_ID);
	}

	public void UpdateSortKey(int P_Id, int sortkey)
	{
		dal.UpdaetSortKey(P_Id, sortkey);
	}

	public void Add(Model.zhaopin model)
	{
		dal.Add(model);
	}

	public bool Update(Model.zhaopin model)
	{
		return dal.Update(model);
	}
}
