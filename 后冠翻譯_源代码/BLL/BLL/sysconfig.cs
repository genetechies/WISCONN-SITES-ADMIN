using DAL;
using Model;

namespace BLL;

public class sysconfig
{
	private readonly DAL.sysconfig dal = new DAL.sysconfig();

	public void Update(Model.sysconfig model)
	{
		dal.Update(model);
	}

	public Model.sysconfig GetModel(int id)
	{
		return dal.GetModel(id);
	}
}
