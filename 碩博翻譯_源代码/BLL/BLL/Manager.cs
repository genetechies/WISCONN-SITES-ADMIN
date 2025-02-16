using System.Data;
using DAL;
using Model;

namespace BLL;

public class Manager
{
	private readonly DAL.Manager dal = new DAL.Manager();

	public void Add(Model.Manager model)
	{
		dal.Add(model);
	}

	public bool Exists(string adminame, string password)
	{
		Model.Manager model = new Model.Manager();
		model.AdminName = adminame;
		model.Password = password;
		return dal.Exists(model.AdminName, model.Password);
	}

	public bool Exists(string adminname)
	{
		Model.Manager m = new Model.Manager();
		m.AdminName = adminname;
		return dal.Exists(m);
	}

	public Model.Manager GetModel(int m_id)
	{
		return dal.GetModel(m_id);
	}

	public DataSet GetAll()
	{
		return dal.GetAll();
	}

	public bool CountIsOne()
	{
		return dal.CountIsOne();
	}

	public bool Delete(int M_ID)
	{
		return dal.Delete(M_ID);
	}

	public bool Update(Model.Manager model)
	{
		return dal.Update(model);
	}
}
