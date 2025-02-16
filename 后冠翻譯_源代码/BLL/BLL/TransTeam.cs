using System.Data;
using DAL;
using Model;

namespace BLL;

public class TransTeam
{
	private readonly DAL.TransTeam dal = new DAL.TransTeam();

	public bool ExistsTeamType(string ClassName)
	{
		Model.guoclass model = new Model.guoclass();
		model.ClassName = ClassName;
		return dal.ExistsTeamType(model);
	}

	public int AddTeamType(Model.guoclass model)
	{
		return dal.AddTeamType(model);
	}

	public bool UpdateTeamType(Model.guoclass model)
	{
		return dal.UpdateTeamType(model);
	}

	public bool DeleteTeamType(int id)
	{
		return dal.DeleteTeamType(id);
	}

	public DataSet GetAllTeamType()
	{
		return dal.GetAllTeamType();
	}

	public int GetMaxSortKeyTeamType(string strWhere)
	{
		return dal.GetMaxSortKeyTeamType(strWhere);
	}

	public DataSet GetListTeamType(string strWhere)
	{
		return dal.GetListTeamType(strWhere);
	}

	public Model.guoclass GetModelTeamType(int NC_Id)
	{
		return dal.GetModelTeamType(NC_Id);
	}

	public Model.guoclass GetModel_whereTeamType(string where)
	{
		return dal.GetModel_whereTeamType(where);
	}

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
		Model.TransTeam model = new Model.TransTeam();
		model.tname = ClassName;
		return dal.Exists(model);
	}

	public bool Add(Model.TransTeam model)
	{
		return dal.Add(model);
	}

	public bool Update(Model.TransTeam model)
	{
		return dal.Update(model);
	}

	public DataSet GetList(string strWhere)
	{
		return dal.GetList(strWhere);
	}

	public Model.TransTeam GetModel(int NC_Id)
	{
		return dal.GetModel(NC_Id);
	}

	public bool Delete(int id)
	{
		return dal.Delete(id);
	}

	public void UpdaetSortKey(int P_Id, int sortkey)
	{
		dal.UpdaetSortKey(P_Id, sortkey);
	}
}
