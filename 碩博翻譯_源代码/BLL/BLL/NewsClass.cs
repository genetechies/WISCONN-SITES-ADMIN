using System.Data;
using DAL;
using Model;

namespace BLL;

public class NewsClass
{
	private readonly DAL.NewsClass dal = new DAL.NewsClass();

	public bool Exists(string ClassName)
	{
		Model.NewsClass model = new Model.NewsClass();
		model.ClassName = ClassName;
		return dal.Exists(model);
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

	public Model.NewsClass GetModel(int P_ID)
	{
		return dal.GetModel(P_ID);
	}

	public bool AddSmall(Model.NewsClass model)
	{
		return dal.AddSmall(model);
	}

	public bool UpdateSmall(Model.NewsClass model)
	{
		return dal.UpdateSmall(model);
	}

	public bool Delete(int id)
	{
		return dal.Delete(id);
	}
}
