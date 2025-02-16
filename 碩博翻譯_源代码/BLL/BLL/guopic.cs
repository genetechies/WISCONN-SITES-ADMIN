using System.Data;
using DAL;
using Model;

namespace BLL;

public class guopic
{
	private readonly DAL.guopic dal = new DAL.guopic();

	public int Count(string where)
	{
		return dal.Count(where);
	}

	public DataSet GetoutList()
	{
		return dal.GetoutList();
	}

	public DataSet GetListByClass(string strWhere, string orderBy)
	{
		return dal.GetListByClass(strWhere, orderBy);
	}

	public DataSet GetAll()
	{
		return dal.GetAll();
	}

	public int GetMaxSortKey(string strWhere)
	{
		return dal.GetMaxSortKey(strWhere);
	}

	public bool Exists(string ClassName)
	{
		Model.guopic model = new Model.guopic();
		model.title = ClassName;
		return dal.Exists(model);
	}

	public bool Add(Model.guopic model)
	{
		return dal.Add(model);
	}

	public bool Update(Model.guopic model)
	{
		return dal.Update(model);
	}

	public DataSet GetList(string strWhere)
	{
		return dal.GetList(strWhere);
	}

	public Model.guopic GetModel(int NC_Id)
	{
		return dal.GetModel(NC_Id);
	}

	public bool Delete(int id)
	{
		return dal.Delete(id);
	}
}
