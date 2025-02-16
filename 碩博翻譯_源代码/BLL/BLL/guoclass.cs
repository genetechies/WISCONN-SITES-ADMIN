using System.Data;
using DAL;
using Model;

namespace BLL;

public class guoclass
{
	private readonly DAL.guoclass dal = new DAL.guoclass();

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
}
