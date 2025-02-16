using DAL;
using Model;

namespace BLL;

public class Right
{
	private readonly DAL.Right dal = new DAL.Right();

	public bool Exists(string username, string pagename)
	{
		return dal.Exists(username, pagename);
	}

	public void Add(Model.Right model)
	{
		dal.Add(model);
	}

	public void Update(Model.Right model)
	{
		dal.Update(model);
	}

	public void Delete(int RightID)
	{
		dal.Delete(RightID);
	}

	public Model.Right GetModel(int RightID)
	{
		return dal.GetModel(RightID);
	}

	public Model.Right GetModel(string username, string pagename)
	{
		return dal.GetModel(username, pagename);
	}
}
