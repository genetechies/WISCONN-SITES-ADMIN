using System.Data;
using DAL;
using Model;

namespace BLL;

public class XunJia
{
	private readonly DAL.XunJia dal = new DAL.XunJia();

	public bool Exists(int G_Id)
	{
		return dal.Exists(G_Id);
	}

	public int Count()
	{
		return dal.Count();
	}

	public DataSet GetList(string strWhere)
	{
		return dal.GetList(strWhere);
	}

	public DataSet GetAllList()
	{
		return GetList("");
	}

	public void Add(Model.XunJia model)
	{
		dal.Add(model);
	}

	public void UpdateIsFinish(int G_Id, int isfinish)
	{
		dal.UpdateIsFinish(G_Id, isfinish);
	}

	public void Delete(int G_Id)
	{
		dal.Delete(G_Id);
	}

	public Model.XunJia GetModel(int G_Id)
	{
		return dal.GetModel(G_Id);
	}
}
