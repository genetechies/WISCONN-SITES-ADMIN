using System.Data;
using DAL;
using Model;

namespace BLL;

public class PageClass
{
	private readonly DAL.PageClass dal = new DAL.PageClass();

	public int Count(string where)
	{
		return dal.Count(where);
	}

	public bool Exists(string ClassName)
	{
		Model.PageClass model = new Model.PageClass();
		model.ClassName = ClassName;
		return dal.Exists(model);
	}

	public DataSet GetAll()
	{
		return dal.GetAll();
	}

	public int GetMaxSortKey(string strWhere)
	{
		return dal.GetMaxSortKey(strWhere);
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

	public void Update_click(int P_Id)
	{
		dal.Update_click(P_Id);
	}

	public Model.PageClass GetModel(int P_ID)
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

	public void Add(Model.PageClass model)
	{
		dal.Add(model);
	}

	public bool AddSmall(Model.PageClass model)
	{
		return dal.AddSmall(model);
	}

	public bool UpdateSmall(Model.PageClass model)
	{
		return dal.UpdateSmall(model);
	}

	public void Update(Model.PageClass model)
	{
		dal.Update(model);
	}

	public bool Delete(int id)
	{
		return dal.Delete(id);
	}
}
