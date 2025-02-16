using System.Data;
using DAL;
using Model;

namespace BLL;

public class yingpin
{
	private readonly DAL.yingpin dal = new DAL.yingpin();

	public Model.yingpin GetModel(int G_Id)
	{
		return dal.GetModel(G_Id);
	}

	public void UpdateIsFinish(int G_Id, int isfinish)
	{
		dal.UpdateIsFinish(G_Id, isfinish);
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

	public DataSet GetoutList()
	{
		return dal.GetoutList("");
	}

	public void Delete(int G_Id)
	{
		dal.Delete(G_Id);
	}
}
