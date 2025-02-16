using System.Data;
using DAL;
using Model;

namespace BLL;

public class newsdata
{
	private readonly DAL.newsdata dal = new DAL.newsdata();

	public int Count(string where)
	{
		return dal.Count(where);
	}

	public DataSet GetListByClass(string strWhere, string orderBy)
	{
		return dal.GetListByClass(strWhere, orderBy);
	}

	public DataSet GetList(string strWhere)
	{
		return dal.GetList(strWhere);
	}

	public DataSet GetList_top(int num, string strWhere)
	{
		return dal.GetList_top(num, strWhere);
	}

	public void UpdateState(int P_Id, int state)
	{
		dal.UpdateState(P_Id, state);
	}

	public DataTable GetTop5CloseNews(string keys, string title)
	{
		return dal.GetTop5CloseNews(keys, title);
	}

	public Model.newsdata GetModel(int P_ID)
	{
		return dal.GetModel(P_ID);
	}

	public void UpdateSortKey(int P_Id, int sortkey)
	{
		dal.UpdaetSortKey(P_Id, sortkey);
	}

	public int CountByClass(string where)
	{
		return dal.CountByClass(where);
	}

	public bool Add(Model.newsdata model)
	{
		return dal.Add(model);
	}

	public void Update(Model.newsdata model)
	{
		dal.Update(model);
	}

	public void Update_click(int P_Id)
	{
		dal.Update_click(P_Id);
	}

	public bool Delete(int id)
	{
		return dal.Delete(id);
	}
}
