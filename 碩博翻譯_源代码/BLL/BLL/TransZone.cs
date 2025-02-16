using System.Data;
using DAL;
using Model;

namespace BLL;

public class TransZone
{
	private readonly DAL.TransZone dal = new DAL.TransZone();

	public bool Exists(string ClassName)
	{
		Model.guoclass model = new Model.guoclass();
		model.ClassName = ClassName;
		return dal.Exists(model);
	}

	public int Add(Model.guoclass model)
	{
		return dal.Add(model);
	}

	public bool Update(Model.guoclass model)
	{
		return dal.Update(model);
	}

	public bool Delete(int id)
	{
		return dal.Delete(id);
	}

	public DataSet GetAll()
	{
		return dal.GetAll();
	}

	public int GetMaxSortKey(string strWhere)
	{
		return dal.GetMaxSortKey(strWhere);
	}

	public DataSet GetList(string strWhere)
	{
		return dal.GetList(strWhere);
	}

	public Model.guoclass GetModel(int NC_Id)
	{
		return dal.GetModel(NC_Id);
	}

	public Model.guoclass GetModel_where(string where)
	{
		return dal.GetModel_where(where);
	}

	public int CountNew(string where)
	{
		return dal.CountNew(where);
	}

	public DataSet GetListByClassNew(string strWhere, string orderBy)
	{
		return dal.GetListByClassNew(strWhere, orderBy);
	}

	public DataSet GetListNew(string strWhere)
	{
		return dal.GetListNew(strWhere);
	}

	public DataSet GetList_topNew(int num, string strWhere)
	{
		return dal.GetList_topNew(num, strWhere);
	}

	public void UpdateStateNew(int P_Id, int state)
	{
		dal.UpdateStateNew(P_Id, state);
	}

	public Model.newsdata GetModelNew(int P_ID)
	{
		return dal.GetModelNew(P_ID);
	}

	public void UpdateSortKeyNew(int P_Id, int sortkey)
	{
		dal.UpdaetSortKeyNew(P_Id, sortkey);
	}

	public int CountByClassNew(string where)
	{
		return dal.CountByClassNew(where);
	}

	public bool AddNew(Model.newsdata model)
	{
		return dal.AddNew(model);
	}

	public void UpdateNew(Model.newsdata model)
	{
		dal.UpdateNew(model);
	}

	public void Update_clickNew(int P_Id)
	{
		dal.Update_clickNew(P_Id);
	}

	public bool DeleteNew(int id)
	{
		return dal.DeleteNew(id);
	}

	public DataTable GetTop5CloseNews(string keys, string title)
	{
		return dal.GetTop5CloseNews(keys, title);
	}
}
