using System.Data;
using DAL;
using Model;

namespace BLL;

public class linyuxinxi
{
	private readonly DAL.linyuxinxi dal = new DAL.linyuxinxi();

	public int CountByClass(string where)
	{
		return dal.CountByClass(where);
	}

	public bool UpdateState(int P_Id, int state)
	{
		return dal.UpdateState(P_Id, state);
	}

	public int GetMaxSortKey(string strWhere)
	{
		return dal.GetMaxSortKey(strWhere);
	}

	public DataSet GetAll()
	{
		return dal.GetAll();
	}

	public bool Exists(string ClassName)
	{
		Model.linyuxinxi model = new Model.linyuxinxi();
		model.title = ClassName;
		return dal.Exists(model);
	}

	public bool Add(Model.linyuxinxi model)
	{
		return dal.Add(model);
	}

	public bool Update(Model.linyuxinxi model)
	{
		return dal.Update(model);
	}

	public Model.linyuxinxi GetModel(int NC_Id)
	{
		return dal.GetModel(NC_Id);
	}

	public bool Delete(int id)
	{
		return dal.Delete(id);
	}

	public DataSet GetList(string strWhere)
	{
		return dal.GetList(strWhere);
	}

	public DataSet GetList_top(int num, string strWhere)
	{
		return dal.GetList_top(num, strWhere);
	}

	public DataSet GetoutList()
	{
		return dal.GetoutList();
	}

	public int Count(string where)
	{
		return dal.Count(where);
	}
}
