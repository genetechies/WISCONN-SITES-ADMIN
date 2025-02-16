using System.Data;
using DAL;
using Model;

namespace BLL;

public class linyuclass
{
	private readonly DAL.linyuclass dal = new DAL.linyuclass();

	public DataSet GetAll()
	{
		return dal.GetAll();
	}

	public bool Exists(string ClassName)
	{
		Model.linyuclass model = new Model.linyuclass();
		model.ClassName = ClassName;
		return dal.Exists(model);
	}

	public int Add(Model.linyuclass model)
	{
		return dal.Add(model);
	}

	public bool Update(Model.linyuclass model)
	{
		return dal.Update(model);
	}

	public int GetMaxSortKey(string strWhere)
	{
		return dal.GetMaxSortKey(strWhere);
	}

	public DataSet GetList(string strWhere)
	{
		return dal.GetList(strWhere);
	}

	public DataSet GetList_top(int num, string strWhere)
	{
		return dal.GetList_top(num, strWhere);
	}

	public Model.linyuclass GetModel(int NC_Id)
	{
		return dal.GetModel(NC_Id);
	}

	public Model.linyuclass GetModel_where(string where)
	{
		return dal.GetModel_where(where);
	}

	public bool Delete(int id)
	{
		return dal.Delete(id);
	}
}
